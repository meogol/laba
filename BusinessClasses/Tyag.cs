using System;

namespace ConsoleApp1
{
    
    class Tyag : Fcar
    {
        /// <summary>
        /// кол-во прицепов
        /// </summary>
        public int kPr { get; set; }
        /// <summary>
        /// тип двигателя
        /// </summary>
        public string typeDv { get; set; }     

        public Tyag() : base()
        {}

        public Tyag(object kPr, object typeDv, object mas, object cc, object id, object vdvig, object kpos) : base(mas, cc, id, vdvig, kpos)
        {
            base.typeCar = typeCar.tyag;
            this.kPr = (int)kPr;
            this.typeDv = typeDv.ToString();
        }

        public void SetParam(int kPr, string typeDv)
        {
            base.typeCar = typeCar.tyag;
            this.kPr = kPr;
            this.typeDv = typeDv;
        }

        public override string str()
        {
            string ss = $"{base.str()} кол-во прицепов {kPr} тип двигателя {typeDv}";
            return ss;
        }
    }
}
