using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using Tyuiu.ChashkovTA.Sprint4.Task0.V17.Lib;
namespace Tyuiu.ChashkovTA.Sprint4.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Чашков Тимофей Александрович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Чашков Тимофей Александрович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*                                                                         *");
            int[] array = new int[]{ 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 } ;
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetSumEvenArrEl(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}