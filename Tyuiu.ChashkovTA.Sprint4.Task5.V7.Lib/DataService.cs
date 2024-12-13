using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChashkovTA.Sprint4.Task5.V7.Lib
{
    public class DataService : ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            int negativeCount = 0;

            // Проходим по всем элементам массива
            for (int i = 0; i < matrix.GetLength(0); i++) // Пройдем по строкам
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Пройдем по столбцам
                {
                    if (matrix[i, j] < 0) // Проверка на отрицательное число
                    {
                        negativeCount++; // Увеличиваем счетчик отрицательных элементов
                    }
                }
            }

            return negativeCount;
        }
    }
}
