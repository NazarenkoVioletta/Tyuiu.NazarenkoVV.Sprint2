using Tyuiu.NazarenkoVV.Sprint2.Task2.V10.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}