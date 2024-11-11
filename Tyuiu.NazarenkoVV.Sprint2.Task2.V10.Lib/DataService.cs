using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarenkoVV.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 14))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
