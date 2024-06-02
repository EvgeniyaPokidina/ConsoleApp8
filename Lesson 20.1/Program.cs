//Тема 20. Локальные функции. Домашнее задание.
//Задание.
//Напишите функцию, которая принимает два числа и выводит на экран их сумму.
//Числа передаются пользователем в переменные, которые затем передаются в функцию.
//Функция должна возвращать результат, который в последствии выводится на консоль.



Console.Write("Введите первое число:");
int first=int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int second = int.Parse(Console.ReadLine());
int Summ(int first, int second)
{ 
int summ= first+ second;
    return summ;
}
Console.WriteLine($"Cумма:  {Summ(first,second)}");
