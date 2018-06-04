using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBtype : ClassDB<Types>
    {        
        protected override Types Serialize(SqlDataReader reader)
        {
            string sqlRead = reader["type_car"].ToString();
            int sqlID = (int)reader["id"];

            return new Types(sqlID, sqlRead);
        }
    }
}
