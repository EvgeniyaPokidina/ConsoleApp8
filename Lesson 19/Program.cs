

string current = "| X |";
Console.Write("Введите размер игрового поля:");
int n = int.Parse(Console.ReadLine());
string[,] board = new string[n, n];
Random rand = new Random();
ConsoleKey geo = ConsoleKey.Escape;
int x = 1;
int y = 1;
int length = 0;
string[] x0 = new string[n * n];
int[,] ints = new int[length, 2];
do
{
    Console.Clear();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            board[i, j] = "| . |";
        }
    }
    switch (geo)
    {
        case ConsoleKey.LeftArrow: { if (y > 0) y--; geo = ConsoleKey.Escape; } break;
        case ConsoleKey.RightArrow: { if (y < n - 1) y++; geo = ConsoleKey.Escape; } break;
        case ConsoleKey.UpArrow: { if (x > 0) x--; geo = ConsoleKey.Escape; } break;
        case ConsoleKey.DownArrow: { if (x < n - 1) x++; geo = ConsoleKey.Escape; } break;
        case ConsoleKey.Enter:
            {
                x0[length] = current;
                length++;
                int[,] temp = new int[length, 2];
                Array.Copy(ints, temp, ints.Length);
                temp[length - 1, 0] = x;
                temp[length - 1, 1] = y;
                ints = new int[length, 2];
                Array.Copy(temp, ints, temp.Length);
                if (current == "| X |") current = "| 0 |";
                else current = "| X |";
            }
            break;
    }
    board[x, y] = current;
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        board[ints[i, 0], ints[i, 1]] = x0[i];
    }
    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();

       

    }
    geo = Console.ReadKey().Key;
    
}
while (true);

