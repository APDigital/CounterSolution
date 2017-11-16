using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Box<T> : ICountable
    {
        int count;
        public Box(IEnumerable<T> Item)
        {
           count = Item.Count();

        }
        public int Count()
        {
            return count;
        }
    }
}
