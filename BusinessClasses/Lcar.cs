using System;
using System.Collections.Generic;
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
            ras = 20;
            Mspeed = 120;
        }
        public Lcar(float ras, int Mspeed, float vdvig, int kpo) : base(vdvig, kpo)
        {
            this.ras = ras;
            this.Mspeed = Mspeed;
        }

        public override string str()
        {
            string ss = $"{base.str()} расход {ras} макс скорость {Mspeed}";
            return ss;
        }
    }
}
