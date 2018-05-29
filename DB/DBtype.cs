using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBtype : ClassDB<string>
    {
        protected override string Serialize(SqlDataReader reader)
        {
            string sqlRead = reader["type_car"].ToString();
            return sqlRead;
        }
    }
}
