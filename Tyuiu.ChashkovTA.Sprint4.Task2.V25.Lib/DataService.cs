using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChashkovTA.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false; // Флаг для проверки наличия четных чисел

            foreach (int num in array)
            {
                if (num % 2 == 0) // Проверка на четность
                {
                    product *= num;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0; // Возврат произведения или 0, если четных чисел нет
        }
    }
}
