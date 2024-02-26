using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace paytaxt_olke
{
    #region
    //internal class Program
    //{
    //static void Main(string[] args)
    //{
    //    while (true)
    //    {
    //        Console.WriteLine("1-ci ededi ");
    //        int eded1 = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("2- ci ededi daxil edin");
    //        int eded2 = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("simvol yaz ");
    //        char sym = Convert.ToChar(Console.ReadLine());

    //        Calculator(eded1, eded2, sym);


    //        Console.WriteLine("1.exit \n 2.Continue");
    //        byte cvb = Convert.ToByte(Console.ReadLine());
    //        if( cvb == 1 )
    //        {
    //            Console.WriteLine("SYSTEM WAS STOPED");
    //            break;

    //        }
    //        else
    //        {
    //            continue;
    //        }

    //    }



    //}
    //public static void Calculator(int x, int y, char symbol)
    //{


    //        switch (symbol)
    //        {
    //            case '+':
    //                Console.WriteLine(x + y);
    //                break;

    //            case '-':
    //                Console.WriteLine(x - y);
    //                break;
    //            case '*':
    //                Console.WriteLine(x * y);
    //                break;
    //            case '/':
    //                if(x>=0 && y>0)
    //                {
    //                 Console.WriteLine(x / y);  
    //                 break;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("0 a bolunme yoxdur");
    //                    break;
    //                }


    //        }








    //    Console.ReadLine();
    //}



    // }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {            
            List<object> list = new List<object>();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1.add Student \n 2.exit ");
                byte cvb = Convert.ToByte(Console.ReadLine());
                if (cvb == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter Student's name");

                    string name1 = Console.ReadLine();
                    Console.WriteLine("Please enter Student's surname");
                    string surnm1 = Console.ReadLine();
                    Console.WriteLine("Please enter Student's age");
                    byte age1 = Convert.ToByte(Console.ReadLine());

                    dynamic student = new { Name = name1, Surname = surnm1, age = age1 };
                   
                    list.Add(student);

                    foreach (dynamic item in list)
                    {
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine(item.Name+ " "+ item.Surname+ " "+ item.age);
                    }

                }
                else if (cvb == 2)
                {
                    break;


                }
            }


        }
        public static void Studentlist(string name, string surname, byte age)
        {
            dynamic student = new { Name = name, Surname = surname, age = age };
            Console.WriteLine(student.Name + " " + student.Surname + " " + student.age);

        }

    }

}
