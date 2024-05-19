//Создать числовой массив одномерных числовых массивов.
//Вручную заполнить его значениями от 1 до 10. //Взять от пользователя число 200 и присвоить его одному из элементов массива.
//Вывести весь массив на консоль.

int[] mas1 = {1,2,3,4,5};
int[] mas2 = {6,7,8,9,10 };

for (int i = 0; i < mas1.Length; i++)
{
     Console.Write(mas1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();
Console.Write("Введите число:");
int n = int.Parse(Console.ReadLine());
mas1[mas1.GetUpperBound(0)] = 200;
for (int i = 0; i < mas1.Length; i++)
{
    Console.Write(mas1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();
//Console.WriteLine();
//int[,] mas3 = new int[5, 5];
//for (int i = 0; i < mas3.GetLength(0); i++)
//{
//    for (int j = 0; j < mas3.GetLength(1); j++)
//    {
//        if (i == 0) mas3[i, j] = mas1[j];
//        else mas3[i, j] = mas2[j];
//        Console.Write(mas3[i, j] + " ");
//    }
//    Console.WriteLine();
//}
