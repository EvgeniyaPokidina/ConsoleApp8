using Lesson_27._4;

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
        Console.Write("Введите число для вычисления факториала:");
        int fact;
        int.TryParse(Console.ReadLine(), out fact);
        long factorial = numbers.CalculateFactorial(fact);
        Console.WriteLine($"Факториал числа {fact} равен {factorial}");
        Console.Write("Введите число для преобразования в двоичное представление:");
        int binary;
        int.TryParse(Console.ReadLine(), out binary);
        string BinaryRepresent = numbers.ConvertToBinary(binary);
        Console.WriteLine($"Число {binary} в двоичном представлении {BinaryRepresent}");
        Console.Write("Введите число для преобразования в шестнадцатиричном представление:");
        int numberHex;
        int.TryParse(Console.ReadLine(), out numberHex);
        string hexRepresent= numbers.ConvertToHex(numberHex);
        Console.WriteLine($"Число {numberHex} в шестнадцатиричной представлении {hexRepresent}");
    }
}

