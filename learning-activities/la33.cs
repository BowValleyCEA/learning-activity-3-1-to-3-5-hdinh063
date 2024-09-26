namespace MyApplication
{
    public class LA33
    {
        public static void Run()
        {
            int[,] ticTacToeBoard = new int[3, 3];
            PrintBoard(ticTacToeBoard);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Help: 0: empty --- 1: X --- 2: O");
                    Console.Write($"Enter value for cell ({i}, {j}): ");
                    ticTacToeBoard[i, j] = int.Parse(Console.ReadLine());
                    Console.Clear();
                    PrintBoard(ticTacToeBoard);
                }
            }



            int winner = CheckWinner(ticTacToeBoard);
            if (winner == 1)
            {
                Console.WriteLine("X wins!");
            }
            else if (winner == 2)
            {
                Console.WriteLine("O wins!");
            }
            else
            {
                Console.WriteLine("It's a draw.");
            }
        }

        private static void PrintBoard(int[,] board)
        {
            string[] symbols = new string[]
            {
                " ", "X", "O"
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(symbols[board[i, j]] + "|");
                }
                Console.WriteLine();
                Console.WriteLine("-------");
            }
        }

        private static int CheckWinner(int[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                    return board[i, 0];

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0)
                    return board[0, i];
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
                return board[0, 0];

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
                return board[0, 2];

            return 0;
        }

    }
}