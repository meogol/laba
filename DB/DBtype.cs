using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBtype : CachedRepositary<Types>
    {        
        protected override Types Serialize(SqlDataReader reader)
        {
            typeCar sqlRead = (typeCar)reader["type_car"];
            int id=(int)reader["ID"];

            return new Types(id,sqlRead);
        }
    }
}
