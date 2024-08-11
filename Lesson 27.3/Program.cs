//Напишите класс "Numbers", содержащий методы для работы с числами.
//Класс должен иметь следующие методы:
//● CalculateAverage - метод, который принимает массив чисел и возвращает их среднее арифметическое.
//● IsPrime - метод, который принимает число и проверяет, является ли оно простым числом. Метод возвращает булево значение true, если число
//простое, и false в противном случае.
//● IsEven - метод, который принимает число и проверяет, является ли оно четным. Метод возвращает булево значение true, если число четное, и
//false в противном случае.
//● IsOdd - метод, который принимает число и проверяет, является ли оно нечетным. Метод возвращает булево значение true, если число
//нечетное, и false в противном случае
using Lesson_27._3;
class Program
{
    static void Main(string[] args)
    {
        Numbers numbers = new Numbers();
        int[] array = { 10, 27, 31, 4, 15 };
        double average = numbers.CalculateAverage(array);
        Console.WriteLine($"Среднее арифметическое: {average}");
        Console.WriteLine("Введите число для проверки");
        int x;
        int.TryParse(Console.ReadLine(), out x);       
        Console.WriteLine($"Число является простым? {numbers.IsPrime(x)}");
        int y;
        int.TryParse(Console.ReadLine(), out y);
        Console.WriteLine($"Число является четным? {numbers.IsEven(y)}");
        int z;
        int.TryParse(Console.ReadLine(), out z);
        Console.WriteLine($"Число является не четным? {numbers.IsOdd(z)}");
    }
}

