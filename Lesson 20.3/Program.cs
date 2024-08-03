// Напишите программу, которая выполняет логическое побитовое умножение, сложение, шифрование по ключу и инверсию.
//Пользователь вводит число, затем вид операции с числом и получает результат в зависимости от своего выбора

static void Main()
{
    Console.Write("Введите первое число: ");
    int firstNumber;
    int.TryParse(Console.ReadLine(), out firstNumber);
    Console.Write("Введите второе число: ");
    int secondNumber;
    int.TryParse(Console.ReadLine(), out secondNumber);
    Console.Write("Выберите операцию:\n" +
        "1 - логическое умножение\n"+
        "2 - логическое сложение\n"+
        "3 - шифрование\n"+
        "4 - инверсия\n");
    Console.Write("Ваш выбор: ");
    int choice=int.Parse(Console.ReadLine()!);
    switch (choice)
    {
        case 1: 
        Console.WriteLine($"Результат логического умножения: {BitwiseAnd(firstNumber, secondNumber)}");
        break;
        case 2: 
        Console.WriteLine($"Результат логического сложения: {BitwiseOr(firstNumber, secondNumber)}");
        break;
        case 3: 
        Console.WriteLine($"Зашифрованное число: {Encrypt(firstNumber, secondNumber)}");
        break;
        case 4:
        Console.WriteLine($"Результат инверсии: {BitwiseNot(firstNumber)}");
        break;
        default: Console.WriteLine("Некорректный выбор операции.");break;
    }
    int BitwiseAnd(int a, int b) => a & b;

    int BitwiseOr(int a, int b) => a | b;

    int Encrypt(int a, int key) => a ^ key;

    int BitwiseNot(int a) => ~a;
}
Main();



 

   

