//Задание 1. Произведите операцию логического умножения со следующими числами:
//8х3
//22х4

Console.WriteLine(8 & 3);
Console.WriteLine(22 & 4);


//2. Произведите операцию логического сложения со следующими числами:
//65,29;
//44,12;

Console.WriteLine(65 | 29);
Console.WriteLine(44 | 12);

//3.Произведите операцию логического исключения со следующими числами, разберитесь с возможностью шифрования чисел:
//249, (ключ)8;


Console.WriteLine(249 ^ 8);
Console.Write("Введите целое число:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите ключ:");
int key = int.Parse(Console.ReadLine());
int crypt = n ^ key;
Console.WriteLine($"Зашифрованное сообщение:{crypt}");
int encrypt = crypt ^ key;
Console.WriteLine($"Расшифрованное сообщение:{encrypt}");