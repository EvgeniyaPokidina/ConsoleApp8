//Задача.
//Проинициализируйте вручную два массива 4х4, значениями от -50 до 50.
//Напишите функции:
//1.Суммирующую массивы и возвращающую в качестве результата новый массив суммы.
//2. Поиска максимального значения массива.


Random random = new Random();
int[,] mas1 = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mas1[i, j] = random.Next(-50, 51);
        Console.Write(mas1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] mas2 = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mas2[i, j] = random.Next(-50, 51);
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
long max = long.MinValue;
void Summ(int[,] mas1, int[,] mas2, ref long max)
{
    int[,] mas3 = new int[4, 4];
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            mas3[i, j] = mas1[i, j] + mas2[i, j];
            if (mas3[i, j] > max) max = mas3[i, j];
            Console.Write(mas3[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Максимальное число = " + max);
}

Summ(mas1, mas2, ref max);

