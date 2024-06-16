//Домашнее задание. Тема 17. Урок 2. Многомерный массив и массив массивов.
//Создайте массив из трех одномерных массивов. [3][ ]
//Заполните его значениями чисел от 1 до 10 (можно вручную, можно рандомом)
//Далее добавьте вывод всех значений массива. каждый одномерный массив выводится построчно в консоль/ Далее выведите сумму каждого одномерного массива
//*Выведите в конце среднее арифметическое всех значений массива.


int[][] mas = new int[3][];
Random random = new Random();
double all_summ = 0;
int count = 0;
for (int i = 0; i < 3; i++) 
{
    int m = random.Next(1, 11);
    mas[i] = new int[m];
    int sum = 0;
    for (int j = 0; j < m; j++)
    {
        count++;
        mas[i][j] = random.Next(11);
        sum += mas[i][j];
        all_summ += mas[i][j];
        Console.Write(mas[i][j] + " ");
    }
    Console.Write(" Сумма = " + sum);
    Console.WriteLine();
}
all_summ = all_summ / count;
Console.WriteLine($"Среднее арифметическое всех значений = {all_summ:f2}");



