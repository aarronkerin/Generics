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
            var TeaBagOne = new Teabags();
            var TeaBagTwo = new Teabags();
            var TeaBagThree = new Teabags();
            var TyresFour = new Tyres();
            var DoughnutOne = new Doughnuts();
            var DoughnutTwo = new Doughnuts();
            var AppleOne = new Apple();
            var AppleTwo = new Apple();

            var BoxOne = new Box<Teabags>();
            BoxOne.items = new List<Teabags>() { TeaBagOne, TeaBagTwo, TeaBagThree };

            var BoxTwo = new Box<Doughnuts>();
            BoxTwo.items = new List<Doughnuts>() { DoughnutOne, DoughnutTwo };

            var BoxThree = new Box<Apple>();
            BoxThree.items = new List<Apple>() { AppleOne, AppleTwo };

            var CartOne = new Cart();
            CartOne.boxes = new List<Box>() { BoxOne, BoxTwo };

            var BoxCounter = new Counter<Box>();
            var CartCounter = new Counter<Cart>();
            var ItemCounter = new Counter<Tyres>();
          

            CartCounter.Add(CartOne);
            BoxCounter.Add(BoxThree);
            ItemCounter.Add(TyresFour);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("There are currently " + CartCounter.count + " Items in this cart containing Teabags and Doughnuts. Mmmmmmmmm ");
            Console.WriteLine("There are also " + BoxCounter.count + " Apples in this box");
            Console.WriteLine("There are also " + ItemCounter.count +" Spare Tyres for your car");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();


        }
    }
}
