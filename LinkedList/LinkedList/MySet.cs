using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class MySet<T>  : IEnumerable    
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public MySet() { }

        public MySet(T item)
        {
            items.Add(item);
        }

        public void Add(T item)
        {
            if (items.Contains(item))
            {
                return;
            }
            items.Add(item);
        }

        public MySet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public MySet<T> Union(MySet<T> set)
        {
            return new MySet<T>(items.Union(set.items));
        }

        public MySet<T> Intersection(MySet<T> set)
        {
            return new MySet<T>(items.Intersect(set.items));
        }
        public MySet<T> Difference(MySet<T> set)
        {
            return new MySet<T>(items.Except(set.items));
            var result = new MySet<T>(items);
            foreach (var item in set.items)
            {
                result.Remove(item);
            }
            return result;
        }
        public bool Subset(MySet<T> set)
        {
            return set.items.All(i => items.Contains(i));
        }
        public MySet<T> SymDif(MySet<T> set)
        {
            return new MySet<T>(items.Except(set.items).Union(set.items.Except(items)));
            var result = new MySet<T>(items);

            foreach (var item1 in set.items)
            {
                var equals = false;

                foreach (var item2 in items)
                {
                    if (item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }
                if (!equals)
                {
                    result.Add(item1);
                }
            }
            foreach (var item1 in items)
            {
                var equals = false;

                foreach (var item2 in set.items)
                {
                    if (item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }
                if (!equals)
                {
                    result.Add(item1);
                }
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
