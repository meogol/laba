using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Car
    {
        protected string typeCar { get; set; } = "машина";
        /// <summary>
        /// тип машины
        /// </summary>
        private float vdvig { get; set; }
        /// <summary>
        /// объем двигателя
        /// </summary>
        private int kpos { get; set; }
        /// <summary>
        /// кол-во посадочных мест
        /// </summary>
        public Car()
        {
            vdvig = 14;
            kpos = 6;
        }

        public Car(float vdvig, int kpos, string typeCar)
        {
            this.typeCar = typeCar;
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public virtual void Serialize(SqlDataReader reader)
        {
            typeCar = (string)reader.GetValue(9);
            vdvig = (float)(double)reader.GetValue(1);
            kpos = (int)reader.GetValue(2);
        }

        public virtual string str()
        {
            string ss = $"тип машины {typeCar} объем двигателя {vdvig} кол-во посадочных мест {kpos}"; 
            return ss;
        }
    }
}
