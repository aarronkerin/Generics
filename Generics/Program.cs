using Generics.Countable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Apple> myApples = new List<Apple>()
            {
                new Apple { colour = "Orange" },
                new Apple { colour = "Red" },
                new Apple { colour = "Red" },
                new Apple { colour = "Red" },
                new Apple { colour = "Red" },
                new Apple { colour = "Red" },
                new Apple { colour = "Red" },
                new Apple { colour = "Green" },
                new Apple { colour = "Green" },
                new Apple { colour = "Green" },
                new Apple { colour = "Green" },
                new Apple { colour = "Green" }
            };

            Counter<Apple> appleCounter = new Counter<Apple>();
            appleCounter.Add(myApples);

            Counter<Apple> redAppleCounter = new Counter<Apple>();
            Func<IEnumerable<Apple>, int> NumberOfRedApples = i => i.Where(a => a.colour == "Red").Count();
            redAppleCounter.Add(myApples, NumberOfRedApples);

            Console.WriteLine($"There are {appleCounter.count} apples in the list");
            Console.WriteLine($"There are {redAppleCounter.count} red apples in the list");

            Console.ReadLine();
        }
    }
}