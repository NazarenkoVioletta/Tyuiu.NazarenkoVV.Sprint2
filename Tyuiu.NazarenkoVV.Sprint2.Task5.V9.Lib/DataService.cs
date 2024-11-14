using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarenkoVV.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            {
                if (n == 31)
                {
                    m += 1;
                    n -= 30;
                }
                else if (n < 31)
                {
                    if ((m == 2) && (n == 28))
                    {
                        m += 1;
                        n -= 27;
                    }
                    else if ((m == 4) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else if ((m == 6) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else if ((m == 9) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else if ((m == 11) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else
                    {
                        n += 1;
                    }

                }
                string res;
                switch (m)
                {
                    case 1:
                        res = "01";
                        break;
                    case 2:
                        res = "02";
                        break;
                    case 3:
                        res = "03";
                        break;
                    case 4:
                        res = "04";
                        break;
                    case 5:
                        res = "05";
                        break;
                    case 6:
                        res = "06";
                        break;
                    case 7:
                        res = "07";
                        break;
                    case 8:
                        res = "08";
                        break;
                    case 9:
                        res = "09";
                        break;
                    case 10:
                        res = "10";
                        break;
                    case 11:
                        res = "11";
                        break;
                    case 12:
                        res = "12";
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
                string res2;
                res2 = n + "." + res;
                return res2;

            }

        }
    }
}
    
