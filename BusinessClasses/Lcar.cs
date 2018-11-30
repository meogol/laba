using System;

namespace ConsoleApp1
{
    
    class Lcar : Car
    {
        /// <summary>
        /// расход
        /// </summary>
        public float ras { get; set; }
        /// <summary>
        /// макс скорость
        /// </summary>
        public int Mspeed { get; set; }      

        public Lcar() : base()
        {}
        public Lcar(object ras, object Mspeed, object id, object vdvig, object kpos ) : base(id,vdvig, kpos)
        {
            typeCar = typeCar.lcar;
            this.ras = (float)(double)ras;
            this.Mspeed = (int)Mspeed;
        }

        public void SetParam(float ras, int Mspeed)
        {
            typeCar = typeCar.lcar;
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
