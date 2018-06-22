using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Str = new List<Types>();
            var Cars = new List<Car>();

            DBtype t = new DBtype();
            DBcars c = new DBcars();

            Str = t.Load("SELECT * FROM dbo_s");
            Cars = c.Load("SELECT * FROM car");

            foreach (Car n in Cars)
            {
                Console.WriteLine(n.str());
            }
            Console.WriteLine(); Console.WriteLine();
            foreach (Types n in Str)
            {
                Console.WriteLine(n.str());
            }
            Console.ReadKey();
        }
    }   
}
