﻿using Lesson_27._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27._3
{
    public class Numbers
    {
        public double CalculateAverage(int[] numbers)
        {
            if (numbers == null ||numbers.Length == 0)
                throw new ArgumentException("Массив чисел не может быть пустым.");
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;

        }
        public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public  bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public  bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
    
    




