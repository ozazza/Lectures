using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_LINQ_Extension
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T>
            collection, Func<T, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (!predicate(item))   // x => x % 2 == 0, return true or false
                {
                    yield return item; // yield - return items one by one
                }
            }
        }


    }
}
