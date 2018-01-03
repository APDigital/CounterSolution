using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Counter<T> where T :ICountable
    {
        public int count;
        public void Add(T Item)
        {
            count = Item.Count();
        }

        public void Add(IEnumerable<T> items)
        {
            count = items.Count();
        }
        public void Add(IEnumerable<T> items, Func<IEnumerable<T>, int> del)
        {
            count = del(items);
        }
    }
}
