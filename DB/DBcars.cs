using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp1
{
    class DBcars : CachedRepositary<Car>
    {
        public DBcars() {}

        protected override Car Serialize(SqlDataReader reader)
        {
            typeCar strok = (typeCar)reader["typeCar"];
            if (strok == typeCar.car)
            {
                return AddList(reader, typeof(Car));
            }
            else if(strok == typeCar.lcar)
            {
                return AddList(reader, typeof(Lcar));
            }
            else if (strok == typeCar.fcar)
            {
                return AddList(reader, typeof(Fcar));
            }
            else if (strok == typeCar.tyag)
            {
                return AddList(reader, typeof(Tyag));
            }    
            return null;
        }
    }
}
