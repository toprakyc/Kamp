using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Sozluk = new Dictionary<int, string>();
            Sozluk.Add(34, "İstanbul");
            Sozluk.Add(35, "İzmir");
            Sozluk.Add(31, "Hatay");
            //bool varmi = Sozluk.ContainsKey(32);
            //Console.WriteLine(varmi);
            Console.WriteLine(Sozluk.Count);

            DictionaryMine<int, string> Plakalar = new DictionaryMine<int, string>();
            Plakalar.Add(34, "İstanbul");
            Plakalar.Add(42, "Konya");
            Plakalar.Add(81, "Düzce");
            Console.WriteLine(Plakalar.Count);

        }
    }

    class DictionaryMine<TKey, TValue>
    {
        TKey[] _key;
        TValue[] _value;
        public DictionaryMine()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempkey = _key;
            TValue[] tempvalue = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                _key[i] = tempkey[i];
                _value[i] = tempvalue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
        public int Count
        {
            get { return _key.Length; }
        }
    }
}
