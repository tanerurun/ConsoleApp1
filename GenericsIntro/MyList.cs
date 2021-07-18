using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
   class MyList<T> //4.video
    {
        T[] items;
        //consturctor
        public MyList()//otamatik kendisi çalışır class ile aynı isimde 
        {
            //constructor aslında bir metotur.classı newlerse mylist otomatik çalışır.
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//ucmasın diye referans numarasını bu arkadaşa tuturuyoruz.
            items = new T[items.Length + 1];

            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
 
        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
