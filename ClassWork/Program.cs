
//8.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран все простые числа от 1 до этого числа 
//включительно. 

//using System.Threading.Channels;

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    int j = 2;
//    int k = 0; //кол-во делителей
//    while (j < i)
//    {
//        if (i % j == 0)
//        {
//            k++;
//            break;
//        }
//        j++;
//    }
//    if (k == 0) Console.Write(i + " ");
//    i++;
//}


//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//string result = "";
//while (n!= 1)
//{
//    result += n % 2;
//    n /= 2;
//}
//result += "1";
//int i=result.Length -1;
//while (i >= 0)
//{
//    Console.Write(result[i--]);
//}


//сумма чисел от 1 до числа n

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int S = 1;
//for (int i = 1; i <= n; i++) S *= i;
//Console.WriteLine(S);

//int a,b;
//do
//{
//    Console.Write("Введите нижнюю границу:");
//    a = int.Parse(Console.ReadLine());
//    Console.Write("Введите верхнюю границу:");
//    b = int.Parse(Console.ReadLine());
//}
//while (a >= b);
//for (int i=a; i<=b;i++)
//    if(i%3==0||i%5==0) Console.Write(i+ " ");

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n<= 0);
//int pred = 0;
//Console.Write(pred);
//int current = 1;
//for (int i = 1; i < n; i++)
//{
//    Console.Write(current);
//    int temp = pred;
//    pred=current;
//    current = pred+temp;
//}

//Console.Write("Введите текущую температуру по Цельсию:");
//int n =int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 12: case 1: case 2: Console.WriteLine("Зима"); break;
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
//    default: Console.WriteLine("Нет такого месяца"); break;
//}



//Console.Write("Введите строку:");
//string str=Console.ReadLine();
//for(int i=str.Length-1; i>=0; i--) Console.WriteLine(str[i]);


//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//string reverse = "";
//for (int i = str.Length - 1; i >= 0; i--) reverse += str[i];
//if (str == reverse) Console.WriteLine("Полиндром");
//else Console.WriteLine("Не полиндром");

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//for (int i=1; i<str.Length;i+=2)
//    Console.WriteLine(str[i]);

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.Write($"{i}*{j}={i*j} ");
//    }
//    Console.WriteLine();
//}


//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write($"*");
//    }
//    Console.WriteLine();
//}

//for (int i = 5; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"*");
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i <= 9; i++)
//{
//    for (int j = 1; j <= 9; j++)
//    {
//        if (i == 1 && j == 5) Console.Write("*");
//        else if (i==2&&j>3&&j<7) Console.Write("*");
//    }
//    Console.Write($"");
//}