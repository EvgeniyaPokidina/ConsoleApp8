//1.Произведите операцию инверсии со следующими числами,используя тип данных long:264895468854;
//256;

long n = 264895468854;
Console.WriteLine(~n);

long m = 256;
Console.WriteLine(~m);

//2.Произведите операцию сдвига вправо и влево со следующими числами:
//256;
//32856;
int x1 = 256;
Console.WriteLine(x1 >> 1);
Console.WriteLine(x1 << 1);

int x2 = 32856;
Console.WriteLine(x2 >> 1);
Console.WriteLine(x2 << 1);

//3.Произведите операцию присваивания со следующими числами:289, 144, 36274;
//С изменением на 2487;
int x = 289;
x += 2198;
Console.WriteLine(x);

int y = 144;
y += 2343;
Console.WriteLine(y);

int z = 36274;
z -= 33787;
Console.WriteLine(z);