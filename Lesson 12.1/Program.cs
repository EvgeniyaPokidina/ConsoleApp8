//Домашнее задание. Тема 12. Урок 1. Операторы ветвления Switch/ Case.
//Калькулятор: пользователь может выбрать операцию (сложение,вычитание, умножение, деление), ввести два числа и получить результат


Console.Write("Введите 1 число:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число:");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите оператор:");
char oper;
oper=Convert.ToChar(Console.ReadLine());

if (oper == '+')
{
    Console.WriteLine($"Общая сумма равна {a + b}");
}
else if (oper == '-')
{
    Console.WriteLine($"Общая сумма равна {a - b}");
}
else if (oper == '*')
{
    Console.WriteLine($"Общая сумма равна {a * b}");
}
else if (oper == '/')
{
    Console.WriteLine($"Общая сумма равна {a / b}");
}
else
{
    Console.WriteLine("Неизвестный оператор");
}