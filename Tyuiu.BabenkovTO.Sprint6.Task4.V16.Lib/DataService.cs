using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabenkovTO.Sprint6.Task4.V16.Lib
{
    public class DataService : ISprint6Task4V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] arrayResult = new double[(stopValue - startValue) + 1];
            int count = 0;
            for (double x = startValue; x <= stopValue; x++)
            {
                arrayResult[count] = Math.Round(((Math.Cos(x) / (x - 0.4)) + Math.Sin(x) * 8 * x + 2), 2);
                count++;
            }
            return arrayResult;
        }
    }
}
