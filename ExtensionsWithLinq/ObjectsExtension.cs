using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsWithLinq
{
    public static class ObjectsExtension
    {
        public static T WhereFirstOrDefault<T>(this List<T> list, Func<T, bool> predicate)
        {
            return list.Where(predicate).FirstOrDefault();
        }
        public static T WhereLastOrDefault<T>(this List<T> list, Func<T, bool> predicate)
        {
            return list.Where(predicate).LastOrDefault();
        }
        public static int IndexOf<T>(this IList<T> source, Func<T, bool> predicate)
        {
            return source.IndexOf(source.Where(predicate).FirstOrDefault());
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return string.IsNullOrEmpty(value?.ToString().Trim());
        }
        
        public static void Clear(this object[] source)
        {
            if (source != null)
                Array.Clear(source, 0, source.Length);
        }

        public static string ToJson(this object source, bool ignore = false)
        {
            if (ignore)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                return JsonConvert.SerializeObject(source, settings);
            }
            return JsonConvert.SerializeObject(source);
        }
        public static T FromJson<T>(this string source, bool ignore = false)
        {
            if (ignore)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                return JsonConvert.DeserializeObject<T>(source, settings);
            }
            return JsonConvert.DeserializeObject<T>(source);
        }
    }


}
