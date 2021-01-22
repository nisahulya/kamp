using System;

namespace refout2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Topla1(10,20);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

        public int Topla1(int sayi3, int sayi4)
        {
            int sayi3 = 30;
            int sonuc = sayi3 + sayi4;
            return sonuc;
        }
    }
}
