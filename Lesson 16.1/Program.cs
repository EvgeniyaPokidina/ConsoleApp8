string[,] masLamp =
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
    Console.Clear(); for (int j = 0; j < masLamp.GetUpperBound(0) + 1; j++)
    {
        for (int l = 0; l < masLamp.GetUpperBound(1) + 1; l++)
        {
             Console.Write($"{masLamp[j, l],2}");
        }
        Console.WriteLine();
    }
    if (isChecked == false) Console.Write("Включить лампочку?"); else Console.Write("Выключить лампочку?");
    answer = Console.ReadLine()!; if (answer == "yes") isChecked = !isChecked;
    if (isChecked)
    {
        masLamp[2, 2] = "x"; masLamp[2, 3] = "x";
    }
    else
    {
        masLamp[2, 2] = "";
        masLamp[2, 3] = "";
    }
}
while (true);
