using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Car
    {
        //типы машин
        protected enum typeCar { машина=0, легковая, грузовик, тягач };
        /// <summary>
        /// объем двигателя
        /// </summary>
        private float vdvig { get; set; }
        /// <summary>
        /// кол-во посадочных мест
        /// </summary>
        private int kpos { get; set; }
        /// <summary>
        /// тип машины
        /// </summary>
        protected typeCar tc { get; set; }

        public Car()
        {
            tc = typeCar.машина;
            vdvig = 14;
            kpos = 6;
        }

        public Car(float vdvig, int kpos)
        {
            tc = typeCar.машина;
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public virtual void Serialize(SqlDataReader reader)
        {
            vdvig = (float)(double)reader["объем_дв"];
            kpos = (int)reader["кво_мест"];
        }

        public virtual string str()
        {
            string ss = $"тип машины {tc} объем двигателя {vdvig} кол-во посадочных мест {kpos}"; 
            return ss;
        }
    }
}
