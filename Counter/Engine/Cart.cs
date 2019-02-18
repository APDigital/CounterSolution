using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Cart<T> : ICountable/*, IEnumerable*/
    {
        private int cartCount;
        private readonly List<Box<Apple>> cartApple = new List<Box<Apple>>();
        private readonly List<Box<Orange>> cartOrange = new List<Box<Orange>>();

        public IReadOnlyList<Box<Apple>> CartApple { get; private set; }
        public IReadOnlyList<Box<Orange>> CartOrange { get; private set; }

        public Cart()
        {
            CartApple = cartApple.AsReadOnly();
            CartOrange = cartOrange.AsReadOnly();
        }

        public void AddBoxes(List<Box<Apple>> list)
        {
            foreach (Box<Apple> item in list)
            {
                cartApple.Add(item);
            }
        }

        public void AddBoxes(List<Box<Orange>> list)
        {
            foreach (var item in list)
            {
                cartOrange.Add(item);
            }
        }

        public int Count()
        {
            cartCount = (cartApple.Sum(x => x.Count())) + (cartOrange.Sum(x => x.Count()));
            return cartCount;
        }

    }
}
