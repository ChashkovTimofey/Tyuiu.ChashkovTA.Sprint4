﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChashkovTA.Sprint4.Task6.V15.Lib
{
    public class DataService : ISprint4Task6V15
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            foreach (string city in array)
            {
                if (city.Length < 7) 
                {
                    count++; 
                }
            }

            return count; 
        }
    }
}
