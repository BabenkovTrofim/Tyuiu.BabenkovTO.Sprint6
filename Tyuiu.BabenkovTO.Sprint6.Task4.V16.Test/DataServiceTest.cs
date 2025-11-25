using Tyuiu.BabenkovTO.Sprint6.Task4.V16.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int endValue = 5;
            double[] waitArray = { -36.41, -22.07, 5.68, 16.72, 8.35, -0.5, 9.63, 16.29, 5.01, -22.40, -36.30 };
            CollectionAssert.AreEqual(waitArray, ds.GetMassFunction(startValue, endValue));
        }
    }
}
