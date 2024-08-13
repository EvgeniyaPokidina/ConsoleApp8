using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27._4
{
    internal class Numbers
    {
        public double CalculateAverage(int[] numbers)
        {
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
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public long CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
       public string ConvertToBinary(int value) 
        {
           return Convert.ToString(value,2);
        }
        public string ConvertToHex(int number)
        {
            return Convert.ToString(number, 16);
        }
    
    }
}

