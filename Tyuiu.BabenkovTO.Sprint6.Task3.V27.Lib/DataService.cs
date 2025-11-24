using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabenkovTO.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columnIndex = 3;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (matrix[j, columnIndex] > matrix[j + 1, columnIndex])
                    {
                        SwapRows(matrix, j, j + 1);
                    }
                }
            }
            return matrix;
        }
        static void SwapRows(int[,] matrix, int row1, int row2)
        {
            int cols = matrix.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                int temp = matrix[row1, col];
                matrix[row1, col] = matrix[row2, col];
                matrix[row2, col] = temp;
            }
        }
    }
}
