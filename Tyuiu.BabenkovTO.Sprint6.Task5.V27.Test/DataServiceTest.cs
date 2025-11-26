using Tyuiu.BabenkovTO.Sprint6.Task5.V27.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { "C:", "Users", "Trofim", "AppData", "Local", "Temp", "InPutFileTask5V27.txt" });
            double[] wait = {6, 3, 11, 18};
            CollectionAssert.AreEqual(wait, ds.LoadFromDataFile(path));
        }
    }
}
