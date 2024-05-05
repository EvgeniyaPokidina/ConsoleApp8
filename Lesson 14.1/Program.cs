//Домашнее задание. Тема 14. Урок 1. Цикл For.
//Нужно разработать программу, которая будет генерировать пароли заданной длины для пользователей.
//Требования к программе:
//Пользователь должен иметь возможность указать длину пароля при запуске программы.
//Пароль должен состоять из букв латинского алфавита (в верхнем и нижнем регистре) и цифр.
//Для реализации генерации пароля требуется использовать цикл for.
//Программа должна создавать случайный набор символов, выбирая из списка допустимых символов на каждой итерации цикла.

//Console.Write("Введите пароль:");
////int n = int.Parse(Console.ReadLine());
//string str = Console.ReadLine();
//string a = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//Random random = new Random();
//string parol = "";
//for (int i = 1; i <= n; i++)
//{
//    int b = random.Next(a.Length);
//    parol += a[b];
//}
//Console.WriteLine("Ваш пароль = " + parol);


Console.Write("Введите длину пароля:");
string str = Console.ReadLine();
//int n = int.Parse(Console.ReadLine());
string str = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
Random random=new Random();
for (int i = 0; i < str; i++)
{ 
int parol = random.Next(str.Length);
    Console.WriteLine(parol);
}

//Console.Write("Введите строку:");
//string str=Console.ReadLine();
//for(int i=str.Length-1; i>=0; i--) Console.Write(str[i]);