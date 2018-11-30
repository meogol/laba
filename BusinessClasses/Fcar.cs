using System;

namespace ConsoleApp1
{
    
    class Fcar : Car
    {
        /// <summary>
        /// масса авто
        /// </summary>
        public int mas { get; set; }
        /// <summary>
        /// грузоподъемность
        /// </summary>
        public int cc { get; set; }     

        public Fcar() : base()
        {}

        public Fcar(object mas, object cc, object id, object vdvig, object kpos) : base(id,vdvig, kpos)
        {
            typeCar = typeCar.fcar;
            this.mas = (int)mas;
            this.cc = (int)cc;
        }

        public void SetParam(int mas, int cc)
        {
            typeCar = typeCar.fcar;
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
