using Tyuiu.BabenkovTO.Sprint6.Task7.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = Path.Combine(new string[] { "C:", "Users", "Trofim", "AppData", "Local", "Temp", "InPutDataFileTask7V25.csv" });
        int[,] matrix = ds.GetMatrix(path);
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.Write("\n\r");
        }
    }
}