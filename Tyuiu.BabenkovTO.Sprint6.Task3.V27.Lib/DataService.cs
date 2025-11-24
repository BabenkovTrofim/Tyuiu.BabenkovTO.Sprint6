using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabenkovTO.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            int[] thirdColumn = new int[5];

            for (int i = 0; i < rows; i++)
            {
                thirdColumn[i] = matrix[i, 3];
            }
            Array.Sort(thirdColumn);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = thirdColumn[i];
            }
            return matrix;
        } 
    }
}
