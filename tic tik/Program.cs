static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //stores the variables to change
static readonly char[] playerMark = { 'x', 'o' };
static int player = 0;

static void Main()
{
    PrintIntro();
    PrintBoard();
    bool playing = true; //stops the game once someone wins
    while (playing) //is to stop the game once someone wins
    {
        Console.WriteLine($"Player {player + 1}'s turn");

        Console.WriteLine("type in your response: ");
        if (int.TryParse(Console.ReadLine(), out int playerInput) && playerInput is >= 1 and <= 9)
        {
            playerInput--; // Make it a 0-based index.
            if (board[playerInput] is 'x' or 'o')
            {
                Console.WriteLine("Stop stealing other people's place");
            }
            else
            {
                board[playerInput] = playerMark[player];
                PrintBoard();
                if (IsWinCondition())
                {
                    playing = false;
                    Console.WriteLine(
                        $"Congrats player {player + 1}, better luck next time player {2 - player}");
                }
                else if (IsBoardFull())
                {
                    playing = false;
                    Console.WriteLine("The game is a tie");
                }
                SwitchPlayer(); // Switch player after printing result.
            }
        }
        else
        {
            Console.WriteLine("Please input a valid expression");
        }
    }
}

private static void SwitchPlayer()
{
    player = (player + 1) % 2;
}

private static void PrintBoard() // makes the board
{
    Console.Clear();

    Console.WriteLine("     |     |      ");
    Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}");
    Console.WriteLine("_____|_____|_____ ");
    Console.WriteLine("     |     |      ");
    Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}");
    Console.WriteLine("_____|_____|_____ ");
    Console.WriteLine("     |     |      ");
    Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}");
    Console.WriteLine("     |     |      ");
}

private static bool IsWinCondition()
{
    return
        board[0] == board[1] && board[1] == board[2] ||
        board[3] == board[4] && board[4] == board[5] ||
        board[6] == board[7] && board[7] == board[8] ||
        board[0] == board[3] && board[3] == board[6] ||
        board[1] == board[4] && board[4] == board[7] ||
        board[2] == board[5] && board[5] == board[8] ||
        board[0] == board[4] && board[4] == board[8] ||
        board[2] == board[4] && board[4] == board[6];
}

private static void PrintIntro()
{
    ...
}

private static bool IsBoardFull()
{
    return board.All(square => square > '9');
}