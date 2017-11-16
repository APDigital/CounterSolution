using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Apple> apples = new List<Apple>();
            Apple apple = new Apple();
            apples.Add(apple);
            Apple apple2 = new Apple();
            apples.Add(apple2);

            Box<Apple> boxOfApples = new Box<Apple>(apples);
            Cart<Apple> cart = new Cart<Apple>(boxOfApples);

            Console.WriteLine("Apple Count :");
            Console.WriteLine(apple.Count().ToString());
            Console.WriteLine("Number of things in the box :");
            Console.WriteLine(boxOfApples.Count().ToString());
            Console.WriteLine("Sum of items in the cart : ");
            Console.WriteLine(cart.Count().ToString());

            Console.ReadLine();

        }
    }
}
