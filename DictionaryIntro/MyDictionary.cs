using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryIntro
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] itemsx;
        Tvalue[] itemsy;
        public MyDictionary()
        {
            itemsx = new Tkey[0];
            itemsy = new Tvalue[0];
        }

        public void Add(Tkey itemx, Tvalue itemy)
        {
            Tkey[] tempxArray = itemsx;
            itemsx = new Tkey[itemsx.Length + 1];
            for (int i = 0; i < tempxArray.Length; i++)
            {
                itemsx[i] = tempxArray[i];
            }

            itemsx[itemsx.Length - 1] = itemx;


            Tvalue[] tempyArray = itemsy;
            itemsy = new Tvalue[itemsy.Length + 1];
            for (int i = 0; i < tempyArray.Length; i++)
            {
                itemsy[i] = tempyArray[i];
            }

            itemsy[itemsy.Length - 1] = itemy;
        }

        public Tvalue Find(Tkey key) 
        {
            int index = Array.IndexOf(itemsx, key);
            Tvalue value = itemsy[index];
            return value;
        }
        

    }
}
