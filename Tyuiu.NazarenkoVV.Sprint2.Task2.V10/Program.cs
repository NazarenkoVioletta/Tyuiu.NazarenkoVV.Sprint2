using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NazarenkoVV.Sprint2.Task2.V10.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" Введите значение переменной X:                                                 ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение переменной Y:                                                 ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");
            if (res)
            {
                Console.WriteLine(" Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine(" Точка не находится в  заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}