using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    [Serializable]
    class Tyag : Fcar
    {
        /// <summary>
        /// кол-во прицепов
        /// </summary>
        int kPr { get; set; }
        /// <summary>
        /// тип двигателя
        /// </summary>
        string typeDv { get; set; }     

        public Tyag() : base()
        {
            tc = typeCar.tyag;
            kPr = 1;
            typeDv = "дизель";
        }
        public Tyag(int kPr, string typeDv, int mas, int cc, float vdvig, int kpo) : base(mas, cc, vdvig, kpo)
        {
            base.tc = typeCar.tyag;
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
