using Quartz;
using RecurringIntegrationsScheduler.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler
{
    internal class FormsHelper
    {
        public static int DropDownWidth(ComboBox myCombo)
        {
            int minWidth = 1;
            foreach (var item in myCombo.Items)
            {
                int temp = TextRenderer.MeasureText(item.ToString(), myCombo.Font).Width;
                if (temp > minWidth)
                {
                    minWidth = temp;
                }
            }
            return minWidth;
        }

        public static DateTimeOffset? GetScheduleForCron(string cronexpression, DateTimeOffset date)
        {
            try
            {
                var cron = new CronExpression(cronexpression);
                return cron.GetNextValidTimeAfter(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Cron_expression_is_invalid);
                return DateTimeOffset.MinValue;
            }
        }

        public static void SetDropDownsWidth(Control parentCtrl)
        {
            parentCtrl.Controls
                .OfType<ComboBox>()
                .ToList()
                .ForEach(t => t.DropDownWidth = DropDownWidth(t));

            foreach (Control c in parentCtrl.Controls)
            {
                SetDropDownsWidth(c);
            }
        }

        public static void TrimTextBoxes(Control parentCtrl)
        {
            parentCtrl.Controls //Trim all textboxes
                .OfType<TextBox>()
                .ToList()
                .ForEach(t => t.Text = t.Text.Trim());

            foreach (Control c in parentCtrl.Controls)
            {
                TrimTextBoxes(c);
            }
        }
    }
}