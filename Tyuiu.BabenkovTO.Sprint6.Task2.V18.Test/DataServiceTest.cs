using Tyuiu.BabenkovTO.Sprint6.Task2.V18.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = -2;
            int stop = 2;
            double[] wait = { 7.24, 1.80, -8.00, -5.70, -11.26 };
            DataService ds = new DataService();
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(start, stop));
        }
    }
}
