using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SerTyag : SerFcar
    {
        protected int kPr;
        protected string typeDv;
        public override void ser(SqlDataReader reader)
        {
            base.ser(reader);
            kPr = (int)reader["kPr"];
            typeDv = (string)reader["typeDv"];
        }

        public Tyag NewTyag()
        {
            return new Tyag(kPr, typeDv, mas, cc, vdvig, kpos);
        }
    }
}
