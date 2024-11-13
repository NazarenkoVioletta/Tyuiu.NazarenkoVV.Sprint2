using Tyuiu.NazarenkoVV.Sprint2.Task5.V9.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void FindDateOfNextDay()
            {
                DataService ds = new DataService();
                int n = 08;
                int m = 09;
                string wait = "10.08";
                var res = ds.FindDateOfNextDay(m, n);
                Assert.AreEqual(wait, res);

            }
        }
    }