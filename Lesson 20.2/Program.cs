//Тема 20. Локальные функции. Домашнее задание.
//Задание.
//Напишите функцию, которая принимает массив целых чисел и возвращает среднее значение элементов массива. Массив задать явно
//Функция должна возвращать результат, который в последствии выводится на консоль.

Random random = new Random();
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{ 
mas[i] = random.Next(26);
    Console.Write(mas[i]+ " ");
}

double Avg(int[] array)
{
    double value = 0;
    for (int i = 0;i < array.Length;i++) value += array[i];
    return value / array.Length;
}
Console.WriteLine($"среднее значение элементов = {Avg(mas):F2}");
