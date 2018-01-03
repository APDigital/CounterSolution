
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Cart<T> : ICountable
    {
        private int cartCount;
       
        public Cart(IEnumerable<Box<T>> boxes)
        {
            cartCount =  boxes.Sum(x => x.Count());
        }

        public int Count()
        {
            return cartCount;
        }
    }
}
