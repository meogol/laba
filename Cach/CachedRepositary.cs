using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class CachedRepositary<T>:BaseRepository<T> where T:IIntegerKey
    {

        protected Dictionary<int, T> cache = new Dictionary<int, T>();
        
        public T LoadById(int id)
        {
            if (cache.ContainsKey(id))
            {
                return cache[id];
            }

            List<T> list = Load($"SELECT * FROM car WHERE ID={id}");
            if (list.Count > 0)
            {
                return list[0];
            }
            else return default(T);
        }
        
        public override List<T> Load(string s)
        {
            List<T> list= base.Load(s);

            foreach (T tList in list)
            {
                if (!cache.ContainsKey(tList.ID))//проверяем, есть ли элемент в кэше
                {
                    cache.Add(tList.ID, tList);
                }
            }
            return list;
        }

        public List<T> LoadFromCacheByLinq(Predicate<T> predicate)
        {
            List<T> list = new List<T>();

            foreach (T t in cache.Values)
            {
                if(predicate(t))
                    list.Add(t);
            }

            return list;
        }
    }
}
