using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgretmenSorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayi1, a;
            string[] il = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
            string[] isim = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };
            bool[] D = new bool[7];
            bool[] D1 = new bool[7];

            for (a = 0; a <= 6; a++)

            {
                Console.WriteLine("Bool D dizisinin  " + a + ". elemanı= " + D[a]);
                Console.WriteLine("Bool D1 dizisinin " + a + ". elemanı= " + D1[a]);
            }
            Random rastgele = new Random();


            for (a = 0; a <= 6; a++)
            {



                do
                { //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engelleniyor.
                    sayi = rastgele.Next(0, 7);//sıfır dahil, 7 dahil değil.

                } while (D[sayi] == true);
                D[sayi] = true;

                do
                { //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engelleniyor.

                    sayi1 = rastgele.Next(0, 7);

                } while (D1[sayi1] == true);
                D1[sayi1] = true;



                Console.WriteLine(isim[sayi1] + "\t= " + il[sayi]);

            }
            for (a = 0; a <= 6; a++)
            {
                Console.WriteLine("Bool D dizisinin  " + a + ". elemanı= " + D[a]);
                Console.WriteLine("Bool D1 dizisinin " + a + ". elemanı= " + D1[a]);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
