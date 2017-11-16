using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Counter<T> : ICountable
    {
        private List<T> MyList;
        public void Add(T Item)
        {
            MyList.Add(Item);
        }

        public int Count()
        {
            int count = MyList.Count;
            return count;
        }
    }
}
