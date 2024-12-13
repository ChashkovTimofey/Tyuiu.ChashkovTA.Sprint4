﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChashkovTA.Sprint4.Task4.V19.Lib
{
    public class DataService : ISprint4Task4V19
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] % 2 != 0) 
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
