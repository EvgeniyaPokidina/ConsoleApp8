﻿// Создайте перечисление месяцев Month и к каждому присвойте числовое значение порядкового номера месяца, например: January = 1;
//Затем: 1.Выведите на экран список месяцев и их порядковые номера, используя цикл for и метод Enum.GetValues().
//Для каждого месяца выведите его имя и соответствующее числовое значение. Сделать это с помощью следующей конструкции:
//Console.WriteLine($"Выбран месяц: {selectedMonth}");
//2.Запросите у пользователя ввод порядкового номера месяца с помощью метода Console.ReadLine() и преобразуйте его в тип int.
//Проверьте, является ли введенное значение допустимым номером месяца, используя метод Enum.IsDefined(). Если введенное значение
//является допустимым, преобразуйте его в тип Month и выведите выбранный месяц на экран. Если введенное значение недопустимо,
//выведите сообщение о недопустимом номере месяца.

enum Month
{ 
January = 1,
February = 2,
March = 3,
April = 4,
May = 5,
June = 6,
July = 7,
August = 8,
September = 9,
October = 10,
November = 11,
December = 12
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Список месяцев с порядковыми номерами: ");
        foreach (Month month in Enum.GetValues(typeof(Month)))
        {
            Console.WriteLine($"№ {(int)month} месяц - {month}");
        }
        Console.Write("Введите номер месяца: ");
        string input=Console.ReadLine()!;
        if (int.TryParse(input, out int monthNumber))
        {
            if (Enum.IsDefined(typeof(Month), monthNumber))
            {
                Month selectedMonth = (Month)monthNumber;
                Console.WriteLine($"Выбран месяц: {selectedMonth}");
            }
            else 
            {
                Console.WriteLine("Введен неверный номер месяца");
            }
        }
    }
}