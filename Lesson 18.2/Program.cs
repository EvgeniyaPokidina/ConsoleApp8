//1
Console.Write("Введите строку:");
string str = Console.ReadLine();
string[] mas = str.Split(' ');
int sum = 0;
int[] array = new int[str.Length];
for (int i = 0; i < mas.Length; i++)
{
    int a = int.Parse(mas[i]);
    array[i] = int.Parse(mas[i]);
    sum += a;
}
Console.WriteLine("Сумма = " + sum);

//2 задача
//Console.Write("Введите предложение:");
//string sentense = Console.ReadLine()!;
//string[] mas1 = sentense.Split(" ");
//Console.WriteLine("Количество слов в предложении = " + mas1.Length);