

// Гра хрестики-нолики; Tic Tac Toe


char[] grid = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
char currentPlayer = 'X';
int counter = 0;
bool runGame = true;

while (runGame)
{
    Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
    Console.WriteLine("--|---|--");
    Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
    Console.WriteLine("--|---|--");
    Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
    Console.Write($"Player {currentPlayer} enter number of cell: ");
    int cell;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out cell) && cell >= 1 && cell <= 9)
        {
            if (grid[cell - 1] != 'X' && grid[cell - 1] != 'O')
            {
                grid[cell - 1] = currentPlayer;
                counter++;
                break;
            }
            else
            {
                Console.WriteLine("This cell is already taken, try again");
            }
        }
        else
        {
            Console.WriteLine("Incorrect input, try again");
        }
    }
    if ((grid[0] == currentPlayer && grid[1] == currentPlayer && grid[3] == currentPlayer) ||
        (grid[3] == currentPlayer && grid[4] == currentPlayer && grid[5] == currentPlayer) ||
        (grid[6] == currentPlayer && grid[7] == currentPlayer && grid[8] == currentPlayer) ||
        (grid[0] == currentPlayer && grid[3] == currentPlayer && grid[6] == currentPlayer) ||
        (grid[1] == currentPlayer && grid[4] == currentPlayer && grid[7] == currentPlayer) ||
        (grid[2] == currentPlayer && grid[5] == currentPlayer && grid[8] == currentPlayer) ||
        (grid[0] == currentPlayer && grid[4] == currentPlayer && grid[8] == currentPlayer) ||
        (grid[2] == currentPlayer && grid[4] == currentPlayer && grid[6] == currentPlayer))
    {
        Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
        Console.WriteLine("--|---|--");
        Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
        Console.WriteLine("--|---|--");
        Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
        Console.WriteLine($"Player {currentPlayer} won");
        runGame = false;
    }
    else if (counter == 9)
    {
        Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
        Console.WriteLine("--|---|--");
        Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
        Console.WriteLine("--|---|--");
        Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
        Console.WriteLine($"Draw");
        runGame = false;
    }
    else
    {
        if (currentPlayer == 'X')
        {
            currentPlayer = 'O';
        }
        else
        {
            currentPlayer = 'X';
        }
    }
}
    Console.WriteLine("Push any button to exit");
    Console.ReadKey();
