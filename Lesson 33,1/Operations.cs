using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_33_1
{
    internal class Operations
    {
        public List<string>? ListStrings { get; set; } = new();
        public Operations()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите " + (i + 1) + " строку:");
                ListStrings.Add(Console.ReadLine()!);
            }
        }
        public void Print()
        {
            //if (ListStrings.Count == 0)
            //{
            //    Console.WriteLine("Список пуст.");
            //}
            //else
            //{
            //for (int i = 0; i < ListStrings.Count; i++)
            //{
            //Console.WriteLine($"{i}: {ListStrings[i]}");
            Console.WriteLine();
            //}
            //}
        }
    }
}
