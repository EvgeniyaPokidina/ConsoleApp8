
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
