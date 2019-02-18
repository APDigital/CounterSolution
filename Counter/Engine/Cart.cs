using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Cart<T> : ICountable
    {
        private int cartCount;
        private ArrayList cart = new ArrayList();
        
        public ArrayList ItemCart { get; private set; }

        public Cart()
        {
            ItemCart = cart;
        }

        public void AddBoxes(ArrayList list)
        {
            foreach (var item in list)
            {
                cart.Add(item);
            }
        }

        public int Count()
        {
            foreach (var item in ItemCart)
            {
                cartCount = cartCount + 1;
            }
            return cartCount;
        }

    }
}
