using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> customers1 = new List<int>();
            customers1.Add(2);
            customers1.Add(5);
            Console.WriteLine(customers1.Count);

            MyList<int> customers2 = new MyList<int>();
            customers2.Add(3);
            Console.WriteLine(customers2.Count);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] tempArray;
        public MyList()
        {
            _array = new T[0];
        }   
        public void Add(T item)
        {
            tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count  //public int yapısı bir property propfull dan geliyorr.
        {
            get { return _array.Length; }
        }
    }
}
