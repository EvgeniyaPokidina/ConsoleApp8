//Задача 1//Мама купила 1 десяток яиц и еще 3 яйца. Когда съели несколько яиц, то осталось 9 яиц. Сколько яиц съели?
Console.Write("Сколько шт яиц купила мама:");
int egg = int.Parse(Console.ReadLine());
int breakfast = 9;
Console.Write("Сколько яиц съели:");
int result = egg - breakfast;
Console.WriteLine(result);


//Задача 2.// Журнал имеет ширину 25см. Он уже газеты на 16см. Какой ширины газета?
Console.Write("Ширина журнала в см:");
int x = int.Parse(Console.ReadLine());
Console.Write("Ширина газеты в см:");
int y = (x += 16);
Console.WriteLine(y);


//Задача 3.// Для приготовления обеда повару понадобилось 44 кг картошки, свеклы в 4 раза меньше, а лука в 2 раза меньше чем свеклы.Сколько килограмм лука потратил повар?
Console.Write("Количество кг картошки:");
int a = int.Parse(Console.ReadLine());
Console.Write("Количество кг свеклы:");
int b = a / 4;
Console.WriteLine(b);
Console.WriteLine($"Сколько кг лука потратил повару: {b/2}");
