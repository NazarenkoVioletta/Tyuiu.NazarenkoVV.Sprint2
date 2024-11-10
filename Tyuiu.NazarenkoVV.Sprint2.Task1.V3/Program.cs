using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NazarenkoVV.Sprint2.Task1.V3.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations( a, b, c, d);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}

        
    
