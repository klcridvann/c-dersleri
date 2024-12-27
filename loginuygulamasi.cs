using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGİN_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            while(true)
            {
                Console.WriteLine("kullanıcı adınızı giriniz:");
                string kullaniciadi = Console.ReadLine();
                Console.WriteLine("şifrenizi girin:");
                string sifre = Console.ReadLine();
                if (sifre == "123" && kullaniciadi == "rıdvan")
                {
                    Console.WriteLine("giriş başarılı");
                    break;
                }
                if (hak > 0) 
                    
                    {
                    hak -= 1;

                        Console.WriteLine("bilgilerinizi kontrol edip tekrar girin");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("hakkınız kalmadı");
                        Console.ReadLine();

                    }

                Console.ReadLine();

               


            }

        }
    }
}
