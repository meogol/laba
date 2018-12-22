using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cars = new List<Car>();

            var Str = new List<Types>();

            BaseRepository<Types> t = new BaseRepository<Types>();

            Str = t.Load("SELECT * FROM dbo_s");
            foreach (Types n in Str)
            {
                Console.WriteLine(n.str());
            }

            Console.WriteLine(); Console.WriteLine();

            DBcars c = new DBcars();

            char i;
            while (true)
            {
                Console.WriteLine("1-Load   2-LoadID    3-LoadIDLinq    4-Clear");
                i = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (i)
                {
                    case '1':
                        {
                            Cars = c.Load("SELECT * FROM car");
                            foreach (Car n in Cars)
                            {
                                Console.WriteLine(n.str());
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Введите ID искомого эллемента");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if (c.LoadById(id) != null)
                                Console.WriteLine(c.LoadById(id).str());
                            else
                                Console.WriteLine("указанного значения не существует");
                            break;
                        }
                    case '3':
                        {
                            string s;
                            Console.WriteLine("Введите строку");
                            s=Console.ReadLine();
                            
                            foreach (Car car in c.LoadFromCacheByLinq(Pcar => Pcar.str().Contains(s)))
                            {
                                Console.WriteLine(car.str());
                            }
                            
                            break;
                        }
                    case '4':
                        {
                            Console.Clear();
                            break;
                        }
                }
            }
            
            Console.ReadKey();
        }
    }   
}
