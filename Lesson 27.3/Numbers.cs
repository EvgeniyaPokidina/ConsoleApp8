using Lesson_27._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27._3
{
    public static class Numbers
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            return numbers.Average();
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Метод для проверки, является ли число четным
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Метод для проверки, является ли число нечетным
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

    }
    }
    




