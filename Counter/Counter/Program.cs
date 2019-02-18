using System;
using System.Collections.Generic;
using System.Collections;
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

            //Array List
            ArrayList listOfBoxes = new ArrayList();

            //Boxes
            Box<Apple> boxOfApples = new Box<Apple>(MyApples);
            listOfBoxes.Add(boxOfApples);
            Box<Apple> anotherBoxOfApples = new Box<Apple>(ListOfRedApples);
            listOfBoxes.Add(anotherBoxOfApples);

            Box<Orange> boxOfOranges = new Box<Orange>(ListOfLargeOranges);
            listOfBoxes.Add(boxOfOranges);
            listOfBoxes.Add(boxOfApples);

            //Cart
            Cart<dynamic> cart = new Cart<dynamic>();
            cart.AddBoxes(listOfBoxes);

            //Output
            Console.WriteLine("Apple Count : {0}", appleCounter.count);
            Console.WriteLine("Orange Count : {0}", orangeCounter.count);
            Console.WriteLine("Red Apple Count : {0}", redAppleCounter.count);
            Console.WriteLine("Large Orange Count : {0}", largeOrangeCounter.count);

            foreach (var box in cart.ItemCart)
            {
                if (box is Box<Apple>)
                {
                    Box<Apple> newbox = box as Box<Apple>;
                    Console.WriteLine("Number of Items in Apple Box: {0}", newbox.Count());
                }
                else
                {
                    Box<Orange> newBox = box as Box<Orange>;
                    Console.WriteLine("Number of Items in Orange Box: {0}", newBox.Count());
                }
            }

            Console.WriteLine("Sum of boxes in the cart : {0}", cart.Count().ToString());

            Console.ReadLine();

        }
    }
}
