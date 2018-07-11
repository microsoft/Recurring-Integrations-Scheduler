/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using Quartz.Impl.Triggers;
using RecurringIntegrationsScheduler.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecurringIntegrationsScheduler
{
    /// <summary>
    /// Instantiated as singleton
    /// </summary>
    public sealed class Scheduler
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static volatile Scheduler _instance;
        /// <summary>
        /// The scheduler
        /// </summary>
        private IScheduler _scheduler;
        /// <summary>
        /// The scheduler factory
        /// </summary>
        private ISchedulerFactory _schedulerFactory;        
        /// <summary>
        /// Synchro object
        /// </summary>
        private static readonly object SyncRoot = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="Scheduler"/> class from being created.
        /// </summary>
        private Scheduler()
        {
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; private set; }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Scheduler Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new Scheduler();
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Connects the specified server.
        /// </summary>
        /// <param name="server">The server.</param>
        /// <param name="port">The port.</param>
        /// <param name="scheduler">The scheduler.</param>
        public void Connect(string server, int port, string scheduler)
        {
            try
            {
                Address = $"tcp://{server}:{port}/{scheduler}";
                _schedulerFactory = new StdSchedulerFactory(GetProperties(Address));
                if (_scheduler == null || !_schedulerFactory.GetAllSchedulers().Result.Contains(_scheduler))
                    _scheduler = _schedulerFactory.GetScheduler(Address).Result ?? _schedulerFactory.GetScheduler().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Connection_error);
            }
        }

        /// <summary>
        /// Connects this instance.
        /// </summary>
        public void Connect()
        {
            try
            {
                _schedulerFactory = new StdSchedulerFactory();
                _scheduler = _schedulerFactory.GetScheduler().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Connection_error);
            }
        }        

        /// <summary>
        /// Gets the scheduler.
        /// </summary>
        /// <returns></returns>
        public IScheduler GetScheduler()
        {
            return _scheduler;
        }

        /// <summary>
        /// Gets the jobs.
        /// </summary>
        /// <returns></returns>
        public DataTable GetJobs()
        {
            DataTable table;
            try
            {
                table = new DataTable();
                table.Columns.Add("JobName");
                table.Columns.Add("JobGroup");
                table.Columns.Add("JobDescription");
                table.Columns.Add("JobType");
                table.Columns.Add("JobStatus");
                table.Columns.Add("NextFireTime");
                table.Columns.Add("PreviousFireTime");
                table.Columns.Add("Instance");

                var jobGroups = GetScheduler().GetJobGroupNames().Result;
                foreach (var group in jobGroups)
                {
                    var groupMatcher = GroupMatcher<JobKey>.GroupContains(group);
                    var jobKeys = GetScheduler().GetJobKeys(groupMatcher).Result;
                    foreach (var jobKey in jobKeys)
                    {
                        var detail = GetScheduler().GetJobDetail(jobKey).Result;
                        var row = table.NewRow();
                        row["JobGroup"] = group;
                        row["JobName"] = jobKey.Name;
                        row["JobDescription"] = detail.Description;
                        row["JobType"] = detail.JobType.Name;
                        row["Instance"] = detail.JobDataMap["AosUri"];

                        var triggers = GetScheduler().GetTriggersOfJob(jobKey).Result;
                        if (triggers.Count > 0)
                        {
                            var nextFireTime = triggers.First().GetNextFireTimeUtc();
                            if (nextFireTime.HasValue)
                                row["NextFireTime"] = TimeZone.CurrentTimeZone.ToLocalTime(nextFireTime.Value.DateTime);

                            var previousFireTime = triggers.First().GetPreviousFireTimeUtc();
                            if (previousFireTime.HasValue)
                                row["PreviousFireTime"] =
                                    TimeZone.CurrentTimeZone.ToLocalTime(previousFireTime.Value.DateTime);
                            row["JobStatus"] = GetScheduler().GetTriggerState(triggers.First().Key).Result.ToString();
                        }
                        table.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
                table = null;
            }
            return table;
        }

        /// <summary>
        /// Backups to file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void BackupToFile(FileInfo file)
        {
            try
            {
                var scheduler = GetScheduler();
                if (scheduler == null)
                {
                    throw new ArgumentException("Scheduler is missing.");
                }
                var jobGroupNames = scheduler.GetJobGroupNames().Result;
                var jobDetails = new List<IJobDetail>();

                var triggerGroupNames = scheduler.GetTriggerGroupNames().Result;
                var triggerDetails = new List<ITrigger>();

                foreach (var jobGroup in jobGroupNames)
                {
                    var groupMatcher = GroupMatcher<JobKey>.GroupContains(jobGroup);
                    var jobKeys = scheduler.GetJobKeys(groupMatcher).Result;
                    jobDetails.AddRange(jobKeys.Select(jobKey => scheduler.GetJobDetail(jobKey).Result));
                }

                foreach (var triggerGroup in triggerGroupNames)
                {
                    var groupMatcher = GroupMatcher<TriggerKey>.GroupContains(triggerGroup);
                    var keys = scheduler.GetTriggerKeys(groupMatcher).Result;
                    triggerDetails.AddRange(keys.Select(triggerKey => scheduler.GetTrigger(triggerKey).Result));
                }

                WriteToFile(file, jobDetails, triggerDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        private static NameValueCollection GetProperties(string address)
        {
            var properties = new NameValueCollection
            {
                ["quartz.scheduler.instanceName"] = "RemoteClient",
                ["quartz.scheduler.proxy"] = "true",
                ["quartz.threadPool.threadCount"] = "0",
                ["quartz.scheduler.proxy.address"] = address
            };
            return properties;
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="jobDetails">The job details.</param>
        /// <param name="triggerDetails">The trigger details.</param>
        private static void WriteToFile(FileInfo file, List<IJobDetail> jobDetails, List<ITrigger> triggerDetails)
        {
            using (var writer = file.CreateText())
            {
                XNamespace ns = "http://quartznet.sourceforge.net/JobSchedulingData";
                var doc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes")
                    , new XElement(ns + "job-scheduling-data"
                        , new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance")
                        , new XAttribute("version", "2.0")
                    ));
                doc.Root?.Add(new XElement(ns + "processing-directives"
                        , new XElement(ns + "overwrite-existing-data", true))
                );
                var schedule = new XElement(ns + "schedule");
                foreach (var detail in jobDetails)
                    schedule.Add(
                        new XElement(ns + "job"
                            , new XElement(ns + "name", detail.Key.Name)
                            , new XElement(ns + "group", detail.Key.Group)
                            , new XElement(ns + "description", detail.Description)
                            ,
                            new XElement(ns + "job-type",
                                detail.JobType.FullName + "," + detail.JobType.Assembly.FullName)
                            , new XElement(ns + "durable", detail.Durable)
                            , new XElement(ns + "recover", detail.RequestsRecovery)
                            , GetJobDataMap(ns, detail.JobDataMap)
                        )
                    );
                foreach (var trigger in triggerDetails)
                {
                    if (trigger is SimpleTriggerImpl simple)
                        schedule.Add(GetSimpleTrigger(ns, simple));
                    if (trigger is CronTriggerImpl cron)
                        schedule.Add(GetCronTrigger(ns, cron));
                    if (trigger is CalendarIntervalTriggerImpl calendar)
                        schedule.Add(GetCalendarIntervalTrigger(ns, calendar));
                }
                doc.Root?.Add(schedule);
                doc.Save(writer);
            }
        }

        /// <summary>
        /// Gets the job data map.
        /// </summary>
        /// <param name="ns">The ns.</param>
        /// <param name="jobDataMap">The job data map.</param>
        /// <returns></returns>
        private static XElement GetJobDataMap(XNamespace ns, JobDataMap jobDataMap)
        {
            var map = new XElement(ns + "job-data-map");
            foreach (var key in jobDataMap.GetKeys())
                map.Add(new XElement(ns + "entry"
                        , new XElement(ns + "key", key)
                        , new XElement(ns + "value", jobDataMap[key])
                    )
                );

            return map;
        }

        /// <summary>
        /// Gets the cron trigger.
        /// </summary>
        /// <param name="ns">The ns.</param>
        /// <param name="trigger">The trigger.</param>
        /// <returns></returns>
        private static XElement GetCronTrigger(XNamespace ns, CronTriggerImpl trigger)
        {
            var cronTrigger = new XElement(ns + "trigger");
            var cron = new XElement(ns + "cron");
            cronTrigger.Add(cron);
            AddCommonTriggerData(ns, cron, trigger);
            cron.Add(
                new XElement(ns + "cron-expression", trigger.CronExpressionString),
                new XElement(ns + "time-zone", trigger.TimeZone.StandardName)
            );
            return cronTrigger;
        }

        /// <summary>
        /// Gets the calendar interval trigger.
        /// </summary>
        /// <param name="ns">The ns.</param>
        /// <param name="trigger">The trigger.</param>
        /// <returns></returns>
        private static XElement GetCalendarIntervalTrigger(XNamespace ns, CalendarIntervalTriggerImpl trigger)
        {
            var calendarTrigger = new XElement(ns + "trigger");
            var calendar = new XElement(ns + "calendar-interval");
            calendarTrigger.Add(calendar);
            AddCommonTriggerData(ns, calendar, trigger);
            calendar.Add(
                new XElement(ns + "repeat-interval", trigger.RepeatInterval),
                new XElement(ns + "repeat-interval-unit", trigger.RepeatIntervalUnit)
            );
            return calendarTrigger;
        }

        /// <summary>
        /// Adds the common trigger data.
        /// </summary>
        /// <param name="ns">The ns.</param>
        /// <param name="rootTriggerElement">The root trigger element.</param>
        /// <param name="trigger">The trigger.</param>
        private static void AddCommonTriggerData(XNamespace ns, XElement rootTriggerElement, AbstractTrigger trigger)
        {
            rootTriggerElement.Add(
                new XElement(ns + "name", trigger.Key.Name)
                , new XElement(ns + "group", trigger.Key.Group)
                , new XElement(ns + "description", trigger.Description)
                , new XElement(ns + "job-name", trigger.JobName)
                , new XElement(ns + "job-group", trigger.JobGroup)
                , new XElement(ns + "misfire-instruction", GetMisfireInstructionText(trigger))
            );
        }

        /// <summary>
        /// Gets the misfire instruction text.
        /// </summary>
        /// <param name="trigger">The trigger.</param>
        /// <returns></returns>
        private static string GetMisfireInstructionText(AbstractTrigger trigger)
        {
            if (trigger is CronTriggerImpl)
                return GetCronTriggerMisfireInstructionText(trigger.MisfireInstruction);
            return GetSimpleTriggerMisfireInstructionText(trigger.MisfireInstruction);
        }

        /// <summary>
        /// Gets the simple trigger misfire instruction text.
        /// </summary>
        /// <param name="misfireInstruction">The misfire instruction.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        private static string GetSimpleTriggerMisfireInstructionText(int misfireInstruction)
        {
            switch (misfireInstruction)
            {
                case 0:
                    return "SmartPolicy";
                case 1:
                    return "FireNow";
                case 2:
                    return "RescheduleNowWithExistingRepeatCount";
                case 3:
                    return "RescheduleNowWithRemainingRepeatCount";
                case 4:
                    return "RescheduleNextWithRemainingCount";
                case 5:
                    return "RescheduleNextWithExistingCount";
                default:
                    throw new ArgumentOutOfRangeException(
                        $"{misfireInstruction} is not a supported misfire instruction for SimpleTrigger See Quartz.MisfireInstruction for more details.");
            }
        }

        /// <summary>
        /// Gets the cron trigger misfire instruction text.
        /// </summary>
        /// <param name="misfireInstruction">The misfire instruction.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        private static string GetCronTriggerMisfireInstructionText(int misfireInstruction)
        {
            switch (misfireInstruction)
            {
                case 0:
                    return "SmartPolicy";
                case 1:
                    return "FireOnceNow";
                case 2:
                    return "DoNothing";
                default:
                    throw new ArgumentOutOfRangeException(
                        $"{misfireInstruction} is not a supported misfire instruction for CronTrigger See Quartz.MisfireInstruction for more details.");
            }
        }

        /// <summary>
        /// Gets the simple trigger.
        /// </summary>
        /// <param name="ns">The ns.</param>
        /// <param name="trigger">The trigger.</param>
        /// <returns></returns>
        private static XElement GetSimpleTrigger(XNamespace ns, SimpleTriggerImpl trigger)
        {
            var simpleTrigger = new XElement(ns + "trigger");
            var simple = new XElement(ns + "simple");
            simpleTrigger.Add(simple);
            AddCommonTriggerData(ns, simple, trigger);
            simple.Add(
                new XElement(ns + "repeat-count", trigger.RepeatCount),
                new XElement(ns + "repeat-interval", trigger.RepeatInterval.TotalMilliseconds)
            );
            return simpleTrigger;
        }
    }
}