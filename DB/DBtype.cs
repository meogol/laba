using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBtype : ClassDB<Types>
    {        
        protected override Types Serialize(SqlDataReader reader)
        {
            typeCar sqlRead = (typeCar)reader["type_car"];

            return new Types(sqlRead);
        }
    }
}
