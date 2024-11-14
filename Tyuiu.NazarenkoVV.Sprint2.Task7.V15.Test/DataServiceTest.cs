using Tyuiu.NazarenkoVV.Sprint2.Task7.V15.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void CheckDotInShadedAre()
        {
            DataService ds = new DataService();
            double x = 1.3;
            double y = 1.3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
