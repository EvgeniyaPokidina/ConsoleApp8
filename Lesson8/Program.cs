//В школьной библиотеке дети получают книги.
//Петя взял 10 книг, Алеша – на 4 книги меньше, чем Петя, а Ваня
//на 2 книги больше чем Алеша.
//Сколько книг взял каждый мальчик?
//Сколько книг они взяли вместе?

Console.Write("Сколько книг взял Петя:");
int x=int.Parse(Console.ReadLine());
Console.Write("Сколько книг взял Алеша:");
int y=(x-4);
Console.WriteLine(y);
Console.Write("Сколько книг взял Ваня:");
int z = (y + 2);
Console.WriteLine(z);
int summ = x + y + z;
Console.WriteLine(summ);

//2/ В первой корзине 23 яблока, а во второй на 11 яблок меньше.Сколько яблок в обеих корзинах?
Console.Write("Сколько яблок в первой корзине:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Сколько яблок во второй корзине:");
int x2 = (x1 - 11);
Console.WriteLine(x2);
int summa = x1+x2;
Console.WriteLine(summa);