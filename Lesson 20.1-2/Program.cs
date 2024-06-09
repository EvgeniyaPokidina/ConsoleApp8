//Урок 1/2
//Тема 20. Локальные функции. Домашнее задание.
//Задание 1.
//Напишите функцию, которая принимает два числа и выводит на экран их сумму.
//Числа передаются пользователем в переменные, которые затем передаются в функцию. Функция должна возвращать результат, который в последствии выводится на консоль.
//Задание 2.
//Напишите функцию, которая принимает массив целых чисел и возвращает среднее значение элементов массива. Массив задать явно
//Функция должна возвращать результат, который в последствии выводится на консоль.

//1
Console.Write("Введите первое число:");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int second = int.Parse(Console.ReadLine());
int Summ(int first, int second)
{
    int summ = first + second;
    return summ;
}
Console.WriteLine($"Cумма:  {Summ(first, second)}");

//2
Random random = new Random();
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(26);
    Console.Write(mas[i] + " ");
}

double Avg(int[] array)
{
    double value = 0;
    for (int i = 0; i < array.Length; i++) value += array[i];
    return value / array.Length;
}
Console.WriteLine($"среднее значение элементов = {Avg(mas):F2}");