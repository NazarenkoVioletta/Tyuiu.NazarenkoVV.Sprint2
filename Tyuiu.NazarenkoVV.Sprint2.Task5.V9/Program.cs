using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NazarenkoVV.Sprint2.Task5.V9.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
                DataService ds = new DataService();


                Console.Title = "Спринт #2| Выполнил:  Назаренко В.В.| ";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #2                                                               *");
                Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
                Console.WriteLine("* Задание #5                                                              *");
                Console.WriteLine("* Вариант #9                                                              *");
                Console.WriteLine("* Выполнил: |   Назаренко В. В.                                           *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
                Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Введите порядковый номер месяца");

                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число");
                int n = Convert.ToInt32(Console.ReadLine());
                if ((m > 12) || (n > 31))
                {
                    Console.WriteLine("Введены неправильные данные");
                }
                else
                {
                    if ((m == 2) && (n > 28))
                    {
                        Console.WriteLine("Такого дня не существует");
                    }
                    else if ((m == 4) && (n > 30))
                    {
                        Console.WriteLine("Такого дня не существует");
                    }
                    else if ((m == 6) && (n > 30))
                    {
                        Console.WriteLine("Такого дня не существует");
                    }
                    else if ((m == 9) && (n > 30))
                    {
                        Console.WriteLine("Такого дня не существует");
                    }
                    else if ((m == 11) && (n > 30))
                    {
                        Console.WriteLine("Такого дня не существует");
                    }
                    else
                    {
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine("На следующий день будет " + ds.FindDateOfNextDay(m, n));

                    }
                }
                Console.ReadKey();


            
        }
    }
}
    
