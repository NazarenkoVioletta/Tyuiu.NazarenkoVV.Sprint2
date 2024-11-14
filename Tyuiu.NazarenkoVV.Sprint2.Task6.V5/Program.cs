using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NazarenkoVV.Sprint2.Task6.V5.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите номер карты:   ");
            int numcart = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numcart <= 6) || (numcart >= 14))
            {
                res = "Введено непраивльное значение";
            }
            else
            {
                res = "Это карта: " + ds.FindCardValue(numcart);
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
