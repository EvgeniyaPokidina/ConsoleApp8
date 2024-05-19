//Домашнее задание. Тема 12. Урок 1. Операторы ветвления Switch/ Case.
//Калькулятор: пользователь может выбрать операцию (сложение,вычитание, умножение, деление), ввести два числа и получить результат


Console.Write("Введите 1 число:");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число:");
int second = int.Parse(Console.ReadLine());
Console.Write("Введите оператор:");
string oper= Console.ReadLine();
switch (oper)
{
    case "+": oper = "+"; Console.WriteLine($"Общая сумма равна {first + second}"); break;
    case "-": oper = "-"; Console.WriteLine($"Общая сумма равна {first - second}"); break; 
    case "*": oper = "*"; Console.WriteLine($"Общая сумма равна {first * second}"); break;
    case "/": oper = "/"; Console.WriteLine($"Общая сумма равна {first / second}"); break;
    default: Console.WriteLine("Неизвестный оператор"); break;
}