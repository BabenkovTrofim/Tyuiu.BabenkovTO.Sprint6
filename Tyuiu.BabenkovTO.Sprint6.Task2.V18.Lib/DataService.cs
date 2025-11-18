using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabenkovTO.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[(stopValue - startValue) + 1];
            int index = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                result[index] = Math.Round(((3 * Math.Cos(x)) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2), 2);
                index++;
            }
            return result;
        }
    }
}
