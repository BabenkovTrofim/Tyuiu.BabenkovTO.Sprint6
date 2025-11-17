using Tyuiu.BabenkovTO.Sprint6.Task1.V5.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = -5;
            int stop = 5;
            double[] wait = { 8.04, 6.68, 4.84, 1.76, 0.45, 0.5, -0.87, -2.42, -3.88, -6.83, -8.88 };
            DataService ds = new DataService();
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(start, stop));
        }
    }
}
