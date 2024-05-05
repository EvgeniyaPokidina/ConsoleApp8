//Домашнее задание. Тема 15. Урок 3. Свойства и методы одномерных массивов.
//Напишите программу, которая запрашивает у пользователя 10 целых чисел и сохраняет их в массиве. Затем программа сортирует массив по возрастанию и выводит отсортированный массив на экран.
//Далее программа запрашивает у пользователя число и находит его индекс в массиве. Если число не найдено, программа выводит сообщение об ошибке

int[] mas = new int[10];
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Введите {i}-й элемент массива ");
    int n = int.Parse(Console.ReadLine());
    mas[i - 1] = n;
}
Array.Sort(mas);
foreach (int n in mas)
{
    Console.Write(n + " ");
}
Console.WriteLine();
Console.Write("Введите число:");
int k = int.Parse(Console.ReadLine());
bool isFind = false;
for (int i = 0; i < mas.Length; i++)
{
    if (k == mas[i])
    {
        Console.WriteLine($"Элемент найден по индексу {i}");
        isFind = true;
        break;
    }
}
if (isFind == false) Console.WriteLine("Элемент не найден");

