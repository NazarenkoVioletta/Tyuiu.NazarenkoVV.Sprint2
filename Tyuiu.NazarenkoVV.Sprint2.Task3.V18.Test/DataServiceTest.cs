using Tyuiu.NazarenkoVV.Sprint2.Task3.V18.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 36;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -50;
            double res = ds.Calculate(x);
            double wait = -549.98;
            Assert.AreEqual(res, wait);
        }
    }
}