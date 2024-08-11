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

static void Main(string[] args)
{
    Numbers numbers = new Numbers();
    int[] values = { 1, 2, 3, 4, 5 };
    double average = numbers.CalculateAverage(values);
    Console.WriteLine($"Среднее арифметическое: {average}");
    int testNumb = 7;
    Console.WriteLine($"{testNumb} является простым? {numbers.IsPrime(testNumb)}");
    int testEven = 4;
    Console.WriteLine($"{testEven} четное? {numbers.IsEven(testEven)}");
    int testOdd = 5;
    Console.WriteLine($"{testOdd} нечетное? {numbers.IsOdd(testOdd)}");
}
