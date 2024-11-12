using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NazarenkoVV.Sprint2.Task3.V18.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" Введите значение переменной X:                                                 ");
            double x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" Значение функции = " + res);
            Console.ReadKey();
        }
    }
}