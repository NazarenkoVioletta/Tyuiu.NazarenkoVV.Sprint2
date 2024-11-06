using Tyuiu.NazarenkoVV.Sprint2.Task0.V7.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidGetCompareOperetions()
        {
            DataServiceTest ds = new DataServiceTest();
            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperetions( x, y );
            bool[] wait = new bool[6] { true, false, true, true, true, false };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}