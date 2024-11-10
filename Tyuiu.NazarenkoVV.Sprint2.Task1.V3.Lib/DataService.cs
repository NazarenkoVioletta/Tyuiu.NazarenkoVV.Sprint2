using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarenkoVV.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | ( c > d);
            res[1] = (a + 2 > b) & (c + 3 == d);
            res[2] = ( a > b) || ( d < c);
            res[3] = ( a + 3 > b) && ( c == d);
            res[4] = !res[0];
            res[5] = (a < b) ^ ( c == d);
            return res;
        }
    }
}
