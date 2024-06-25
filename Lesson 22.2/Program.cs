//Напишите программу, которая запрашивает у пользователя список чисел, разделенных пробелами, и вычисляет их сумму. Обработайте исключение,
//которое может возникнуть при некорректном вводе (например, если введены символы, отличные от цифр и пробелов).

try
{
    Console.Write("Введите первое число:");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе число:");
    int y = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Сумма равна {x + y}");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}



