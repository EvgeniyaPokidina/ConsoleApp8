string[,] mas1 =
{
    {"","","x","x","",""},    {"","x","x","x","x",""},
    {"x","x","","","x","x"},    {"","x","x","x","x",""},
    {"","","x","x","",""},    {"","","x","x","",""},
    {"","","x","x","",""},    {"","","x","x","",""},
    {"","","x","x","",""},    {"","","x","x","",""},
    {"","x","x","x","x",""}
};
string answer = "no"; bool isChecked = false;
do
{
    Console.Clear(); for (int j = 0; j < mas1.GetUpperBound(0) + 1; j++)
    {
        for (int l = 0; l < mas1.GetUpperBound(1) + 1; l++)
        {
             Console.Write($"{mas1[j, l],2}");
        }
        Console.WriteLine();
    }
    if (isChecked == false) Console.Write("Включить лампочку?"); else Console.Write("Выключить лампочку?");
    answer = Console.ReadLine()!; if (answer == "yes") isChecked = !isChecked;
    if (isChecked)
    {
        mas1[2, 2] = "x"; mas1[2, 3] = "x";
    }
    else
    {
        mas1[2, 2] = "";
        mas1[2, 3] = "";
    }
}
while (true);
