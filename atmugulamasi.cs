using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace atm_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 10000;
            Console.WriteLine("lütfen seçim yapınız:");
            Console.WriteLine("1-bakiye sorgulama");
            Console.WriteLine("2- para yatırma");
            Console.WriteLine("3-para çekme");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("bakiyeniz:" +bakiye);

            }
            else if(secim==2)
            {
                Console.WriteLine("yatırılan tutarı girin:");
                int yatırılan = int.Parse(Console.ReadLine());

                int  yenibakiye = 10000 + yatırılan;
                Console.WriteLine("yeni bakiyeniz:" + yenibakiye);
            }
            else if(secim==3)
            {
                Console.WriteLine("çekilen tutarı girin:");
                int çekilen = int.Parse(Console.ReadLine());

                int yenibakiye = 10000 - çekilen;
                Console.WriteLine("yeni bakiyeniz:" + yenibakiye);

            }
            else
            {
                Console.WriteLine("başka işlem yapmak istiyor musunuz:");
                Console.WriteLine("-1 evet " + "2-hayır");
                int rakam = int.Parse(Console.ReadLine());
                if(rakam==1)
                {
                    Console.WriteLine("lütfen yapmak istediğinizi seçiniz:");

                }
                else
                {
                    Console.WriteLine("iyi günler");

                }
            }


            Console.ReadLine();

        }
    }
}
