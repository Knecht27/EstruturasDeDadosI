using System;

class Program
{
    static void Main()
    {
        char[,] board = new char[3, 3];
        char currentPlayer = 'X';
        int moves = 0;

        while (true)
        {
            Console.Clear();
            PrintBoard(board);

            Console.WriteLine($"Jogador {currentPlayer}, insira a linha e a coluna (0-2) separadas por espaço:");
            string[] input = Console.ReadLine().Split(' ');
            int row = int.Parse(input[0]);
            int col = int.Parse(input[1]);

            if (board[row, col] != '\0')
            {
                Console.WriteLine("Posição já ocupada. Tente novamente.");
                continue;
            }

            board[row, col] = currentPlayer;
            moves++;

            if (CheckWin(board, currentPlayer))
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine($"Jogador {currentPlayer} venceu!");
                break;
            }
            else if (moves == 9)
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine("Empate!");
                break;
            }

            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }

    static void PrintBoard(char[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] == '\0' ? ' ' : board[i, j]);
                if (j < 2) Console.Write('|');
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("-----");
        }
    }

    static bool CheckWin(char[,] board, char player)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) return true;
            if (board[0, i] == player && board[1, i] == player && board[2, i] == player) return true;
        }

        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) return true;
        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) return true;

        return false;
    }
}
