using System.Data.SqlClient;

namespace ConsoleApp1
{
    enum typeCar { машина = 0, легковая, грузовик, тягач };
    class DBtype : ClassDB<typeCar>
    {

        protected override typeCar Serialize(SqlDataReader reader)
        {
            string sqlRead = reader["type_car"].ToString();

            if(sqlRead== typeCar.машина.ToString())
                return typeCar.машина;
            else if (sqlRead == typeCar.легковая.ToString())
                return typeCar.легковая;
            else if (sqlRead == typeCar.грузовик.ToString())
                return typeCar.грузовик;
            else if (sqlRead == typeCar.тягач.ToString())
                return typeCar.тягач;

            return typeCar.машина;
        }
    }
}
