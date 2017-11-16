using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Cart<TBox> : ICountable
    {
        private List<TBox> boxes;
        public Cart(IEnumerable<TBox> boxes)
        {
            boxes = new List<TBox>(boxes);
        }
        public int Count()
        {
            return boxes.Count();
        }
    }
}
