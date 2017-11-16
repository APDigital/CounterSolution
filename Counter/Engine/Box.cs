using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Box<T> : ICountable
    {
        List<T> boxes;
        public Box(IEnumerable<T> Item)
        {
            boxes = new List<T>(Item);
        }
        public int Count()
        {
            int count = boxes.Count;
            return count;
        }
    }
}
