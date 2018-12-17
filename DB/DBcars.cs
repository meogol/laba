using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp1
{
    class DBcars : CachedRepositary<Car>
    {
        public DBcars() {}

        protected override Car Serialize(SqlDataReader reader, Type t)
        {
            typeCar strok = (typeCar)reader["typeCar"];
            if (strok == typeCar.car)
            {
                t=typeof(Car);
            }
            else if(strok == typeCar.lcar)
            {
                t=typeof(Lcar);
            }
            else if (strok == typeCar.fcar)
            {
                t=typeof(Fcar);
            }
            else if (strok == typeCar.tyag)
            {
                t=typeof(Tyag);
            }    
            return base.Serialize(reader, t);
        }
    }
}
