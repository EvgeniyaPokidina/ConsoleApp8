//Домашнее задание. Тема 16. Урок 1. Двумерные массивы.
//1. Создать двумерный массив 3х3. Заполнить его дробными числами от 0 до 20.
//Оформить вывод на экран всех чисел. //Добавить возможность замены значения пользователем.
//Вывод нового массива.
Random random = new Random();
double[,] mas1 = new double[3, 3];
for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i, j] = random.Next(0, 21);
        Console.Write(mas1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("введите строку для замены:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите столбец для замены:");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение для замены:");
double k = double.Parse(Console.ReadLine());
mas1[n - 1, m - 1] = k;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{mas1[i, j]:F2}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();



//2. Создать массив символов 5х2.
//Заполнить его символами по желанию в разнобой.
//Вывести на экран понятное слово.
string[,] mas = 
{ 
    { "ь","е"},
    { "б","ж"},
    { "н","з"},
    { "г","и"},
    { "д","к"},
};
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(mas[4, 0] + mas[0, 1]+ mas[2,0]+ mas[0,0]);