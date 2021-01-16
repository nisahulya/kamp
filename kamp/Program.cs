using System;

namespace kamp
{
    class Program
    {
        static void Main(string[] args)

        {   //değer tutucu,allias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
