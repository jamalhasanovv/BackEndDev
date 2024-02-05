using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_with_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1-ci reqemi yazin");
            //int eded1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2-ci reqemi yazin");
            //int eded2 = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.Green;   
            //Console.BackgroundColor = ConsoleColor.Red;
            //// Console.WriteLine(ad + " salamss");

            //if (eded1>eded2)
            //{
            //    Console.WriteLine($"{eded1} boyukdur {eded2} den ");
            //    Console.WriteLine("Eded 1 > eded 2");

            //}
            //else
            //{
            //    Console.WriteLine($"{eded2} > {eded1} den");


            //}

            //for (double i = 1; i < 100; i++)
            {
                //if(i % 2 == 0)
                {
                    //Console.WriteLine(i+ " "+ (i*0));

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" Birinci Ededi daxil edin:");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi daxil edin:");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    int x2 = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Simvolu Daxil edin ( + - * / ):");
                    Console.ForegroundColor = ConsoleColor.Green;
                    char sign = Convert.ToChar(Console.ReadLine());



                    //if (sign == '+')
                    //{
                    //    Console.Write("CAVAB");
                    //    Console.WriteLine($"{x1} {sign} {x2} = {x1 + x2}");

                    //}
                    //else if (sign == '-')
                    //{
                    //    Console.Write("CAVAB");
                    //    Console.WriteLine(x1 - x2);
                    //    Console.WriteLine($"{x1} {sign} {x2} = {x1 - x2}");
                    //}
                    //else if (sign == '*')
                    //{
                    //    Console.Write("CAVAB");
                    //    Console.WriteLine(x1 * x2);
                    //    Console.WriteLine($"{x1} {sign} {x2} = {x1 * x2}");

                    //}
                    //else if (sign == '/')
                    //{
                    //    Console.Write("CAVAB");
                    //    Console.WriteLine(x1 / x2);
                    //    Console.WriteLine($"{x1} {sign} {x2} = {x1 / x2}");
                    //}
                    //else
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Magenta;
                    //    Console.Write("CAVAB");
                    //    Console.WriteLine("  Bele isareni hele elave elememisem telesme");
                    //    Console.ForegroundColor = ConsoleColor.White;
                    //    Console.BackgroundColor = ConsoleColor.Blue;
                    //}
                    //Console.WriteLine("Tesekkurler");


                    switch (sign)
                    {
                        case '+':
                            Console.Write("Cavab:");
                            Console.WriteLine($"{x1} {sign} {x2} = {x1 + x2}");
                            break;
                        case '-':
                            Console.Write("Cavab:");
                            Console.WriteLine($"{x1} {sign} {x2} = {x1 - x2}");
                            break;
                        case '*':
                            Console.Write("Cavab:");
                            Console.WriteLine($"{x1} {sign} {x2} = {x1 * x2}");
                            break;
                        case '/':
                            Console.Write("Cavab:" + " ");
                            Console.WriteLine($"{x1} {sign} {x2} = {x1 / x2}");
                            break;
                        default:
                            Console.WriteLine("Bele isareni hele elave elememisem telesme");

                            break;





                            Console.WriteLine("Tesekkurler");




                    }
























                }
                
            }




            Console.ReadLine();

        }
    }
}
