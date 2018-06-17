namespace ConsoleApp1
{
    class Types
    {
        typeCar tc { get; set; }

        public Types(typeCar str)
        {
            tc = str;
        }

        public string str()
        {
            string ss = $"тип машины {tc}";//итог?
            return ss;
        }

    }
}
