using System;
using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Counter<T> where T :ICountable
    {
        public int count;
        public void Add(T Item)
        {
            count = Item.Count();
        }

        public void Add(List<T> items)
        {
            count = items.Count();
        }
        public void Add(List<T> items, Func<List<T>, int> del)
        {
            count = del(items);
        }
    }
}
