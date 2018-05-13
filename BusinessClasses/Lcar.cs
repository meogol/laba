using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lcar : Car
    {
        float ras { get; set; }
        /// <summary>
        /// расход
        /// </summary>
        int Mspeed { get; set; }
        /// <summary>
        /// макс скорость
        /// </summary>

        public Lcar() : base()
        {
            base.typeCar = "легковая";
            ras = 20;
            Mspeed = 120;
        }
        public Lcar(float ras, int Mspeed, float vdvig, int kpo, string typeCar) : base(vdvig, kpo, typeCar)
        {
            this.ras = ras;
            this.Mspeed = Mspeed;
        }

        public override void Serialize (SqlDataReader reader)
        {
            base.Serialize(reader);
            ras = (float)(double)reader.GetValue(5);
            Mspeed = (int)reader.GetValue(6);
        }

        public override string str()
        {
            string ss = $"{base.str()} расход {ras} макс скорость {Mspeed}";
            return ss;
        }
    }
}
