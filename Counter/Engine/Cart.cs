
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Cart<T> : ICountable
    {
        private int cartCount;
        public Cart(Box<T> box)
        {
            cartCount = box.Count();
        }

        public int Count()
        {
            return cartCount;
        }
    }
}
