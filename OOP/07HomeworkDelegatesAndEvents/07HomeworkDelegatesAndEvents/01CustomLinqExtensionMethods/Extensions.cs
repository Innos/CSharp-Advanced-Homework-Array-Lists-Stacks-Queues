using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CustomLinqExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var list = new List<T>();
            foreach (var element in collection)
            {
                if (!condition(element))
                {
                    list.Add(element);
                }
            }
            return list;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> funciton)
            where TSelector : IComparable<TSelector>
        {
            if (collection.Count() == 0)
            {
                throw new NullReferenceException("Collection has no elements.");
            }
            TSelector max = funciton(collection.First());
            foreach (var element in collection)
            {
                TSelector currentSelectedElement = funciton(element);
                if (max.CompareTo(currentSelectedElement) == -1)
                {
                    max = currentSelectedElement;
                }
            }
            return max;
        }
    }
}
