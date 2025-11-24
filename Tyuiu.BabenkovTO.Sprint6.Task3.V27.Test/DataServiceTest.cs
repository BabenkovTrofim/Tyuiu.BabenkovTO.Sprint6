using Tyuiu.BabenkovTO.Sprint6.Task3.V27.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = {
            {  9,  13, -14,  23,   1 },
            { 15, -17,  21,  25,  23 },
            { -4,  29, -20, -10,  14 },
            { 27,  33,  12,  33, -12 },
            { 18,  -9,  -5,   6,   3 }
            };
            int[,] waitMatrix = {
            { -4,  29, -20, -10,  14 },
            { 18,  -9,  -5,   6,   3 },
            {  9,  13, -14,  23,   1 },
            { 15, -17,  21,  25,  23 },
            { 27,  33,  12,  33, -12 },
            };
            DataService ds = new DataService();
            CollectionAssert.AreEqual(waitMatrix, ds.Calculate(matrix));
        }
    }
}
