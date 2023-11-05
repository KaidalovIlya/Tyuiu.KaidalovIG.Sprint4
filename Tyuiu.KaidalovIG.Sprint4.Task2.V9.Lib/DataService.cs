﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KaidalovIG.Sprint4.Task2.V9.Lib
{
    public class DataService : ISprint4Task2V16
    {
        public int Calculate(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    summ += array[i];
                }
            }
            return summ;
        }

    }
}
