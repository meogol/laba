using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
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

        public Car(float vdvig, int kpos)
        {
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public virtual string str()
        {
            string ss = $"объем двигателя {vdvig} кол-во посадочных мест {kpos}"; 
            return ss;
        }
    }
}
