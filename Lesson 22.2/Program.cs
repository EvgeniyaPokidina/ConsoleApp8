//Напишите программу, которая запрашивает у пользователя список чисел, разделенных пробелами, и вычисляет их сумму. Обработайте исключение,
//которое может возникнуть при некорректном вводе (например, если введены символы, отличные от цифр и пробелов).


try
{
    Console.Write("Введите первое число:");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе число:");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine(n+m);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}

//try
//{
//    Console.Write("Введите положительное число:");
//    int n = int.Parse(Console.ReadLine()!);
//    if (n < 0) throw new Exception("Корень от отрицательного числа!!!");
//    Console.WriteLine(Math.Sqrt(n));
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}