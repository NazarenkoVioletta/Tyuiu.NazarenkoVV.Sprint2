using Tyuiu.NazarenkoVV.Sprint2.Task6.V5.Lib;

namespace Tyuiu.NazarenkoVV.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void FindCardValue()
        {
            DataService ds = new DataService();
            Assert.AreEqual("��������", ds.FindCardValue(6));
            Assert.AreEqual("�������", ds.FindCardValue(7));
            Assert.AreEqual("���������", ds.FindCardValue(8));
            Assert.AreEqual("�������", ds.FindCardValue(9));
            Assert.AreEqual("�������", ds.FindCardValue(10));
            Assert.AreEqual("�����", ds.FindCardValue(11));
            Assert.AreEqual("����", ds.FindCardValue(12));
            Assert.AreEqual("������", ds.FindCardValue(13));
            Assert.AreEqual("���", ds.FindCardValue(14));
            Assert.ThrowsException<ArgumentException>(() =>
                {
                    ds.FindCardValue(5);
                });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(15);
            });
        }
    }
}