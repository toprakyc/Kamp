using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //istenilen herşey yazılabilir int, double, class adı vs|generics olmasaydı nasıl yazardık diye yazdık bunları
    {
        T[] items;
        public MyList() //constructor. MyList classını newlersek otomatik çalışır
        {
            items = new T[0];
        }
        public void Add(T item) //bu metodu ekledik değişken tipi T
        {
            T[] tempArray = items;  //referansı kaybetmemek için tempte tuttuk
            items = new T[items.Length + 1];  //boyutu 1 arttırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Lenght
        {
            get { return items.Length; }
        }

        public T[] Items 
        {
            get { return items; }
        }
    }
}
