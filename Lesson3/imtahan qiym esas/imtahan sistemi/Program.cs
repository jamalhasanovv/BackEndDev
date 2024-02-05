using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imtahan_qiymetlenmesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Telebenin giris balini daxil edin");
            int bal1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Telebenin Imtahan Bali");
            int bal2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Loading...");
            int yekun = (bal1 + bal2);
                       
            if (bal1 <= 50 & bal2 <= 50 & yekun <= 100)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("yekun Netice:" + yekun);



            }
           
            else

            {
                Console.WriteLine("sehvin var reqemlere diqqet et");
            }

            if (90 <= yekun & yekun <= 100)
            {

                Console.WriteLine("Qiymetiniz 'A' ");

            }

            else if (80 <= yekun & yekun <= 89)
            {
                Console.WriteLine("Qiymetiniz 'B' ");

            }
            else if (70 <= yekun & yekun <= 79)
            {
                Console.WriteLine("Qiymetiniz 'C' ");
            }
            else if (60 <= yekun & yekun <= 69)
            {
                Console.WriteLine("Qiymetiniz 'D' ");
            }
            else if (yekun <= 59)
            {
                Console.WriteLine("Qiymetiniz 'F' Kesilmisen ");
                Console.WriteLine("25% e muraciet ucun 050-862-52-60");

            }

            Console.ReadLine();
        }
    }
}
