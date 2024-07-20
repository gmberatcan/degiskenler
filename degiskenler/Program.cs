using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Beratcan";
            string soyad = "Yazar";
            string Tamad=ad+" "+ soyad;
            Console.WriteLine(Tamad);

            bool b1 = true;
            Console.WriteLine(b1);
            b1=false;
            Console.WriteLine(b1);

            object sayı = 1;
            object karakter= 'c';
            object metin = "merhaba";
            object sayıondalık = 2.4;
            string tamamı=sayı.ToString()+" "+ karakter +" "+metin+" "+ sayıondalık.ToString() ;
            Console.WriteLine(tamamı);
            string d1= DateTime.Now.ToString("dd.mm.yyyy");
            string d2= DateTime.Now.ToString("HH:mm");
            Console.WriteLine(d1 +"\n"+ d2);
            Console.ReadKey();
        }
    }
}
