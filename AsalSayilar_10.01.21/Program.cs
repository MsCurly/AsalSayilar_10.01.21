using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar_10._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 ile 10000 arasındaki asal sayılar ");
            bool asalMi = true;
            for (int sayi = 2; sayi < 10001; sayi++)
            {
                for (int bolen = 2; bolen < sayi; bolen++)
                {
                    if (sayi % bolen == 0 && sayi != bolen)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    Console.Write("\t" + sayi);
                }
                asalMi = true;
            }

            Console.ReadLine();
        }
    }
}
