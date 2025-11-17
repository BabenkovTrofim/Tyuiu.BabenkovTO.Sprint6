using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabenkovTO.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[(stopValue - startValue) + 1];
            int count = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                double fx = Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x;
                fx = Math.Round(fx, 2);
                res[count] = fx;
                count++;
            }
            return res;
        }
    }
}
