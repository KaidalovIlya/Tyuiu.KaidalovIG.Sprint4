using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint4.Task1.V7.Lib;

namespace Tyuiu.KaidalovIG.Sprint4.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Кайдалов И. Г. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Кайдалов Илья Григорьевич | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.  С клавиатуры: 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write("Введите значение: " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введённый массив: ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
