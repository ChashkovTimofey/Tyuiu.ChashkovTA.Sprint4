using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChashkovTA.Sprint4.Task7.V5.Lib
{
    public class DataService : ISprint4Task7V5
    {
        public int Calculate(int n, int m, string value)
        {
            if (value.Length != n * m)
            {
                throw new ArgumentException("Длина строки не соответствует размеру матрицы.");
            }

            int[,] matrix = new int[n, m];
            int evenCount = 0;

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    if (matrix[i, j] % 2 == 0) 
                    {
                        evenCount++; 
                    }
                    index++;
                }
            }

            return evenCount;
        }
    }
}
