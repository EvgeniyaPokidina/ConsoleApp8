//Домашнее задание. Тема 15. Урок 4. Свойства и методы одномерных массивов. Тип Object.
//Создать 4 массива. Заполнить их случайными числами.
//Конечным результатом должен быть, выведенный на консоль, массив, хранящий следующее:
//Произведение средних арифметических (1и2) и (3и4) массивов поиндексно.
//Пример:
//1 массив = { 4, 8 };
//2 массив = { 16, 2 }; //ср.ариф. 1 и 2 массивов = { 10, 5 }
//3 массив = { 1, 22 };
//4 массив = { 13, 3 }; //ср.ариф. 3 и 4 массивов = { 7, 12.5 }
//Произведение ср. арифметических:
//ср.ариф. 1 и 2 массивов = { 10, 5 }
//ср.ариф. 3 и 4 массивов = { 7, 12.5 } //Произведение = { 70, 62.5 }

Random random = new Random();
double[] mas1 = new double[2];
double[] mas2 = new double[2];
double[] mas3 = new double[2];
double[] mas4 = new double[2];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(1, 41);
    Console.Write(mas1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = random.Next(1, 41);
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas3.Length; i++)
{
    mas3[i] = random.Next(1, 41);
    Console.Write(mas3[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas4.Length; i++)
{
    mas4[i] = random.Next(1, 41);
    Console.Write(mas4[i] + " ");
}
Console.WriteLine();
double[] mas1_2 = new double[2];
Console.Write($"среднее арифметическое значение 1 и 2 массивов= ");
for (int i = 0; i < 2; i++)
{
    mas1_2[i] = (mas1[i] + mas2[i]) / 2;
    Console.Write(mas1_2[i] + " ");
}
Console.WriteLine();
double[] mas3_4 = new double[2];
Console.Write($"среднее арифметическое значение 3 и 4 массивов= ");
for (int i = 0; i < 2; i++)
{
    mas3_4[i] = (mas3[i] + mas4[i]) / 2;
    Console.Write(mas3_4[i] + " ");
}
Console.WriteLine();
Console.Write("Поизведение полученных средних арифметических значений массивов (1 и 2) и (3 и 4) = ");
double[] masResult = new double[2];
for (int i = 0; i < 2; i++)
{
    masResult[i] = (mas1_2[i] * mas3_4[i]);
    Console.Write(masResult[i] + " ");
}
Console.WriteLine();
