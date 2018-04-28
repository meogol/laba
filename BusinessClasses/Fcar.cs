using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fcar : Car
    {
        int mas { get; set; }
        /// <summary>
        /// масса авто
        /// </summary>
        int cc { get; set; }
        /// <summary>
        /// грузоподъемность
        /// </summary>

        public Fcar() : base()
        {
            mas = 2000;
            cc = 800;
        }

        public Fcar(int mas, int cc, float vdvig, int kpos) : base(vdvig, kpos)
        {
            this.mas = mas;
            this.cc = cc;
        }

        public override string str()
        {
            string ss = $"{base.str()} масса авто {mas} грузоподъемность {cc}";
            return ss;
        }
    }
}
