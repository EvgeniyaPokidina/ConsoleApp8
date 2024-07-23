using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28._2
{
    
    internal class PasswordGenerator
    {
        private static Random random = new Random();
        public static string Generate(int length)
        {
            string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            return GeneratePassword(str, length);
        }
        private static string GeneratePassword(string characterSet, int length)
        {
            StringBuilder password = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characterSet.Length);
                password.Append(characterSet[index]);
            }
            return password.ToString();
        }
    }
}
