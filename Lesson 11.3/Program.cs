//Тема 11. Урок 3. Условные операторы и класс Random.
//1. Сгенерировать случайное целое число в диапазоне от 0 до 5, запросить еще одно число у пользователя и в случае совпадения вывести на экран
//информацию о победе, в противном случае - поражении.
//2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
//* Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»

Random random = new Random();
int x = random.Next(0, 6);
Console.Write("Введите число:");
int z=int.Parse(Console.ReadLine());
if (x == z) Console.WriteLine("Победа");
else Console.WriteLine("Поражение");

//2/

Console.Write("Введите номер месяца:");
int n = int.Parse(Console.ReadLine());

if (n == 1) Console.WriteLine("Январь");
else if (n == 2) Console.WriteLine("Февраль");
else if (n == 3) Console.WriteLine("Март");
else if (n == 4) Console.WriteLine("Апрель");
else if (n == 5) Console.WriteLine("Май");
else if (n == 6) Console.WriteLine("Июнь");
else if (n == 7) Console.WriteLine("Июль");
else if (n == 8) Console.WriteLine("Август");
else if (n == 9) Console.WriteLine("Сентябрь");
else if (n == 10) Console.WriteLine("Октябрь");
else if (n == 11) Console.WriteLine("Ноябрь");
else if (n == 12) Console.WriteLine("Декабрь");

switch (n)
{
    case 1: case 2: case 12: Console.Write("Дождливая зима"); break;
}


