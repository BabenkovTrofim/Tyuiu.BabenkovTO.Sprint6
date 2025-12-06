using Tyuiu.BabenkovTO.Sprint6.Task6.V18.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { "C:", "Users", "Trofim", "AppData", "Local", "Temp", "InPutFileTask6V18.txt" });
            DataService ds = new DataService();
            string wait = "VAYYbnhDwTg sNnk CMmHkUlnNoZen nqrB";
            Assert.AreEqual(wait, ds.CollectTextFromFile(path));
        }
    }
}
