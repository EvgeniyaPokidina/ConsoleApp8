//Написать программу, которая запрашивает у пользователя значение радиуса окружности и выводит на экран ее длину и площадь, вычисленные с помощью методов класса Math


Console.Write("Введите радиус:");
const double PI = Math.PI;
double R = double.Parse(Console.ReadLine());
double S = PI * R * R;
double L = 2 * PI * R;
Console.WriteLine($"Площадь: {S:F2} Длина: {L:F2}");