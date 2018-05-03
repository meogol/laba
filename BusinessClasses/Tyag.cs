using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tyag : Fcar
    {
        int kPr { get; set; }
        /// <summary>
        /// кол-во прицепов
        /// </summary>
        string typeDv { get; set; }
        /// <summary>
        /// тип двигателя
        /// </summary>

        public Tyag() : base()
        {
            kPr = 1;
            typeDv = "дизель";
        }
        public Tyag(int kPr, string typeDv, int mas, int cc, float vdvig, int kpo) : base(mas, cc, vdvig, kpo)
        {
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
