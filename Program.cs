using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        enum typeCar { машина = 0, легковая, грузовик, тягач };
        static void Main(string[] args)
        {
            var Str = new List<typeCar>();
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
            foreach (typeCar n in Str)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }   
}
