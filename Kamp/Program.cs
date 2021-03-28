using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ternary operatorü; kısa bir if-else kullanım şeklidir
            int num = 5;
            string str = (num < 4) ? "true" : "false";
            Console.WriteLine(str);

            //switch-case operatörü: if-else yapısının basit bir halidir..
            double euro = 9;
            switch (euro)
            {
                case 1:
                    Console.WriteLine("answer 1");
                    break;
                case 2:
                    Console.WriteLine("answer 2");
                    break;
                case 9:
                    Console.WriteLine("answer 9");
                    break;
                default:
                    Console.WriteLine("unknown value!");
                    break;
            }

            //while yapısı kullanılırken önce bir değer ataması yapılır.
            //Sonra while içine bir şart yazılır. değişken değeri while
            //içerisinde arttırılabilir. Her döngüde şartın sağlanıp
            //sağlanmadığı kontrol edilir. 
            int temp = 5;
            while (temp > 0)
            {
                Console.WriteLine("sa");
                temp -= 1;
            }
        }
    }
}
