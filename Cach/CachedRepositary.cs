using System.Collections.Generic;

namespace ConsoleApp1
{
    class CachedRepositary<T>:BaseRepository<T> where T:IIntegerKey
    {
        int idCache = 0;
        protected Dictionary<int, T> cache = new Dictionary<int, T>();
        
        public T LoadById(int id)
        {
            foreach(T i in cache.Values)
            {
                if (i.ID == id)
                {
                    return i;
                }
            }
            List<T> list = Load($"SELECT * FROM car WHERE ID={id}");
            cache.Add(idCache++, list[0]);
            return list[0];
        }
        
        public override List<T> Load(string s)
        {
            List<T> list= base.Load(s);

            foreach (T tList in list)
            {
                if (!cache.ContainsValue(tList))//проверяем, есть ли элемент в кэше
                {
                    cache.Add(idCache, tList);
                    idCache++;
                }
            }
            return list;
        }
    }
}
