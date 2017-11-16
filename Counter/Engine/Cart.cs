
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
        private int cartCount;
        public Cart(IEnumerable<TBox> boxes)
        {
            boxes = new List<TBox>(boxes);
            cartCount = boxes.Count();
        }

        public int Count()
        {
            return cartCount;
        }
    }
}
