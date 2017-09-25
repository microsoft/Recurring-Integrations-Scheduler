/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System.Collections;
using System.Linq.Dynamic;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    public static class Extensions
    {
        /// <summary>
        /// Sort extension
        /// </summary>
        /// <param name="collection">IEnumerable collection.</param>
        /// <param name="sortBy">SortBy keyword</param>
        /// <param name="reverse">order</param>
        /// <returns></returns>
        public static IEnumerable Sort(this IEnumerable collection, string sortBy, bool reverse = false)
        {
            return collection.OrderBy(sortBy + (reverse ? " descending" : ""));
        }
    }
}