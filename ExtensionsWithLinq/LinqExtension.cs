using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsWithLinq
{
    public static class LinqExtension
    {
        public static T WhereFirstOrDefault<T>(this List<T> list, Func<T, bool> predicate)
        {
            return list.Where(predicate).FirstOrDefault();
        }
        public static T WhereLastOrDefault<T>(this List<T> list, Func<T, bool> predicate)
        {
            return list.Where(predicate).LastOrDefault();
        }
        public static int IndexOf<T>(this List<T> list, Func<T, bool> predicate)
        {
            return list.IndexOf(list.WhereFirstOrDefault(predicate));
        }
    }
}
