using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarenkoVV.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x * x + y * y >= 1) && (x >= 1) && (x<= 2) && ((y >= 1) && (y <= 2)))
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
