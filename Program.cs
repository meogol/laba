using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Str = new List<string>();
            var Cars = new List<Car>();

            DBtype t = new DBtype();
            DBcars c = new DBcars();

            Str = t.Load("dbo_s");
            Cars = c.Load("car");

            foreach (Car n in Cars)
            {
                Console.WriteLine(n.str());
            }
            Console.WriteLine(); Console.WriteLine();
            foreach (string n in Str)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }   
}
