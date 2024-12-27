using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametreli_metot_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            isimsoyisim("rıdvan", "kılıç"); 
            topla(15, 12);
            çarp(15, 12, 12);
            Console.ReadLine();
        }
        static void topla(int x, int y)
        {
            Console.WriteLine("Toplam:"+(x+y));

        }
        static void çarp(int x, int y, int z)
        {
            Console.WriteLine("çarpım:"+(x*y*z));

        }
        static void isimsoyisim(string isim,string soyisim)
        {
            Console.WriteLine("isim soyisminiz"+isim+soyisim);

        }
    }
}
