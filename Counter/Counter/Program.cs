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
            //Data
            List<Apple> MyApples = new List<Apple>()
            {
                new Apple { Colour = "Red" },
                new Apple { Colour = "Red" },
                new Apple { Colour = "Red" },
                new Apple { Colour = "Green" },
                new Apple { Colour = "Yellow" }
            };
            List<Orange> MyOranges = new List<Orange>()
            {
                new Orange { Size = "Small" },
                new Orange { Size = "Small" },
                new Orange { Size = "Small" },
                new Orange { Size = "Small" },
                new Orange { Size = "Medium" },
                new Orange { Size = "Medium" },
                new Orange { Size = "Medium" },
                new Orange { Size = "Medium" },
                new Orange { Size = "Medium" },
                new Orange { Size = "Medium" },
                new Orange { Size = "Large"},
                new Orange { Size = "Large"},
                new Orange { Size = "Large"},
                new Orange { Size = "Large"}
            };

            //Counters
            Counter<Apple> appleCounter = new Counter<Apple>();
            appleCounter.Add(MyApples);

            Counter<Apple> redAppleCounter = new Counter<Apple>();
            Func<List<Apple>, int> NumRedApples = i => i.Where(a => a.Colour == "Red").Count();
            redAppleCounter.Add(MyApples, NumRedApples);
            List<Apple> ListOfRedApples = MyApples.Where(a => a.Colour == "Red").ToList();

            Counter<Orange> orangeCounter = new Counter<Orange>();
            orangeCounter.Add(MyOranges);

            Counter<Orange> largeOrangeCounter = new Counter<Orange>();
            Func<List<Orange>, int> NumLargeOranges = i => i.Where(o => o.Size == "Large").Count();
            largeOrangeCounter.Add(MyOranges, NumLargeOranges);
            List<Orange> ListOfLargeOranges = MyOranges.Where(o => o.Size == "Large").ToList();

            Box<Apple> boxOfApples = new Box<Apple>(MyApples);
            List<Box<Apple>> listBoxesOfApples = new List<Box<Apple>>();
            listBoxesOfApples.Add(boxOfApples);

            Box<Apple> anotherBoxOfApples = new Box<Apple>(ListOfRedApples);
            listBoxesOfApples.Add(anotherBoxOfApples);

            Box<Orange> boxOfOranges = new Box<Orange>(ListOfLargeOranges);
            List<Box<Orange>> listBoxesOfOranges = new List<Box<Orange>>();
            listBoxesOfOranges.Add(boxOfOranges);

            Cart<dynamic> cart = new Cart<dynamic>();
            cart.AddBoxes(listBoxesOfApples);
            cart.AddBoxes(listBoxesOfOranges);
           

            Console.WriteLine("Apple Count : {0}", appleCounter.count);
            Console.WriteLine("Orange Count : {0}", orangeCounter.count);
            Console.WriteLine("Red Apple Count : {0}", redAppleCounter.count);
            Console.WriteLine("Large Orange Count : {0}", largeOrangeCounter.count);
            foreach (Box<Apple> box in cart.CartApple)
            {
                Console.WriteLine("Number of things in the apple box : {0}", box.Count().ToString());
            }
            foreach (Box<Orange> box in cart.CartOrange)
            {
                Console.WriteLine("Number of things in the orange box : {0}", box.Count().ToString());
            }

            Console.WriteLine("Sum of items in the cart : {0}", cart.Count().ToString());

            Console.ReadLine();

        }
    }
}
