﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint4.Task6.V20.Lib;

namespace Tyuiu.KaidalovIG.Sprint4.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кайдалов И. Г. | Смарт-Б-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Кайдалов Илья Григорьевич | Смарт-Б-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Автомобиль\", \"Велосипед\", \"Самолет\",    *");
            Console.WriteLine("* \"Поезд\", \"Трамвай\", \"Троллейбус\", \"Метро\"], используя класс Array,  *");
            Console.WriteLine("* выведите элементы массива, длина которых равна 8 символам.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] transportArray = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < transportArray.Length; i++)
            {
                Console.Write($"{transportArray[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(transportArray);
            string result = string.Join(", ", res);
            Console.Write("Элементы, длина которых больше 8 символов:\n" + result);

            Console.ReadLine();
        }
    }
}
