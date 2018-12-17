using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBtype : CachedRepositary<Types>
    {        
        //protected override Types Serialize(SqlDataReader reader, Type t)
        //{
        //    typeCar sqlRead = (typeCar)reader["type_car"];
        //    int id=(int)reader["ID"];

        //    return base.Serialize(re);
        //}
    }
}
