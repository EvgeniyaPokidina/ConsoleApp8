//Ошибка при делении на 0
//double Division(double a, double b)
//{
//    if (b != 0) return a / b;

//    throw new DivideByZeroException("Делить на ноль нельзя!");
//}
//    try
//    {
//        Console.Write("Введите первое число:");
//        int n = int.Parse(Console.ReadLine()!);
//        Console.Write("Введите второе число:");
//        int m = int.Parse(Console.ReadLine()!);
//        Console.WriteLine(Division(n, m));
//    }
//    catch(DivideByZeroException e)
//    {
//        Console.WriteLine (e.Message);
//    }
//выход за пределы массива
//try
//{
//    int[] mas = new int[5];
//    Console.WriteLine(mas[5]);
//    Random random = new Random();
//}
//catch(IndexOutOfRangeException e)
//{
//    Console.WriteLine(e.Message);
//}

//ошибка формата
//try
//{
//    Console.Write("Введите число:");
//    int x = int.Parse(Console.ReadLine()!);
//}
//catch (FormatException e)
//{
//    Console.WriteLine(e.Message);
//}
//
try
{
    Console.Write("Введите число:");
    int n = int.Parse(Console.ReadLine()!);
    if (n < 0) throw new Exception("Корень от отрицательного числа!!!");
    Console.WriteLine(Math.Sqrt(n));
}
catch (ArithmeticException e)
{
    Console.WriteLine(e.Message);
}