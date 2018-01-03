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
            List<Apple> MyApples = new List<Apple>()
            {
                new Apple { colour = "Red" },
                new Apple { colour = "Red" },
                new Apple { colour = "Red" },
                new Apple {colour = "Green" },
                new Apple {colour = "Yellow" }
            };
            Counter<Apple> appleCounter = new Counter<Apple>();
            appleCounter.Add(MyApples);

            Counter<Apple> redAppleCounter = new Counter<Apple>();
            Func<IEnumerable<Apple>, int> NumRedApples = i => i.Where(a => a.colour == "Red").Count();
            redAppleCounter.Add(MyApples, NumRedApples);

            Box<Apple> boxOfApples = new Box<Apple>(MyApples);
            List<Box<Apple>> listBox = new List<Box<Apple>>();
            listBox.Add(boxOfApples);

            Cart<Apple> cart = new Cart<Apple>(listBox);

            Console.WriteLine("Apple Count :");
            Console.WriteLine(appleCounter.count);
            Console.WriteLine("Red Apple Count :");
            Console.WriteLine(redAppleCounter.count);
            Console.WriteLine("Number of things in the box :");
            Console.WriteLine(boxOfApples.Count().ToString());
            Console.WriteLine("Sum of items in the cart : ");
            Console.WriteLine(cart.Count().ToString());

            Console.ReadLine();

        }
    }
}
