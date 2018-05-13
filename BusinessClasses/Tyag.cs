using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    [Serializable]
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
            base.typeCar = "тягач";
            kPr = 1;
            typeDv = "дизель";
        }
        public Tyag(int kPr, string typeDv, int mas, int cc, float vdvig, int kpo, string typeCar) : base(mas, cc, vdvig, kpo, typeCar)
        {
            this.kPr = kPr;
            this.typeDv = typeDv;
        }

        public override void Serialize(SqlDataReader reader)
        {
            base.Serialize(reader);
            kPr = (int)reader.GetValue(7);
            typeDv = (string)reader.GetValue(8);
        }

        public override string str()
        {
            string ss = $"{base.str()} кол-во прицепов {kPr} тип двигателя {typeDv}";
            return ss;
        }
    }
}
