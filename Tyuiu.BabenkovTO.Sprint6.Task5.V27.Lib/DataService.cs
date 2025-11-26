using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabenkovTO.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index++] = Convert.ToDouble(line);
                }
            }

            numsArray = numsArray.Where(val => val % 5 != 0).ToArray();

            return numsArray;
        }
    }
}
