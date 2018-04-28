using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListCar = new List<Car>() {
                new Car(),
                new Fcar(),
                new Tyag(1,"2",3,4,5,6),
                new Lcar(1,45,12,35)
            };

            foreach (Car n in ListCar)
            {
                string ss = n.str();
                Console.WriteLine(ss);
            }
            Console.ReadKey();
        }
    }
}
