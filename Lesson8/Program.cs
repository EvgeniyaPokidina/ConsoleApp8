using System.Security.Cryptography.X509Certificates;

Console.Write("Сколько книг взял Петя:");
int x = 10;
Console.WriteLine(x);
Console.WriteLine("Сколько книг взял Алеша:");
string a = ($" {x -= 4}");
Console.WriteLine(x);
Console.WriteLine("Сколько книг взял Ваня:");
string b= ($" {x += 2}");
Console.WriteLine(x);
string summ = x + a + b;
Console.WriteLine(summ);

//Console.Write("Введите количество:");
//int count1 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price1 = int.Parse(Console.ReadLine());