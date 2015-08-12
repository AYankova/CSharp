namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T sum = (dynamic)0;

            foreach (T item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            T product = (dynamic)1;

            foreach (T item in collection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T:IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty!");
            }

            T min=collection.First();
            foreach (T item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty!");
            }

            T max = collection.First();
            foreach (T item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection) 
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty!");
            }

            return (dynamic)collection.Sum<T>()/ collection.Count<T>();
        }
    }
}
