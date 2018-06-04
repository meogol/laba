using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Types
    {
        int id { get; set; }
        enum typeCar { машина = 0, легковая, грузовик, тягач };
        typeCar tc { get; set; }

        public Types(int id, string str)
        {
            this.id = id;

            if (str == typeCar.машина.ToString())
                tc = typeCar.машина;
            else if (str == typeCar.легковая.ToString())
                tc = typeCar.легковая;
            else if (str == typeCar.грузовик.ToString())
                tc = typeCar.грузовик;
            else if (str == typeCar.тягач.ToString())
                tc = typeCar.тягач;
        }

        public string str()
        {
            string ss = $"id {id} тип машины {tc}";
            return ss;
        }

    }
}
