using Tyuiu.NazarenkoVV.Sprint2.Task4.V17.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 24;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 6.003;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}