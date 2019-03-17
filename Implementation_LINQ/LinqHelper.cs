using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_LINQ
{
    public static class LinqHelper
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return new WhereHelperEnumerable<T>(source, predicate);
        }

        public static IEnumerable<TResult> Select<T>(this IEnumerable<T> source, Func<T, TResult> selector)
        {
            return new SelectHelperEnumerable<T>(source, selector);
        }
    }
}
