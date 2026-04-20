using System;

public class GameController
{
    private Board board;
    private Player player1;
    private Player player2;
    private Player currentPlayer;

    public GameController()
    {
        board = new Board();
        player1 = new HumanPlayer("Player 1", 'X');
        player2 = new HumanPlayer("Player 2", 'O');
        currentPlayer = player1;
    }

    public void StartGame()
    {
        while (true) // whole game loop (restart)
        {
            board = new Board(); // reset board
            currentPlayer = player1;

            Console.WriteLine("=== CONNECT FOUR ===");

            while (true) // single game loop
            {
                board.Display();

                int move = currentPlayer.MakeMove();

                if (!board.DropDisc(move, currentPlayer.Symbol))
                {
                    Console.WriteLine("Column is full! Try again.");
                    continue;
                }

                if (board.CheckWin(currentPlayer.Symbol))
                {
                    board.Display();
                    Console.WriteLine(currentPlayer.Name + " wins!");
                    break;
                }

                if (board.IsFull())
                {
                    board.Display();
                    Console.WriteLine("Game is a draw!");
                    break;
                }

                SwitchTurn();
            }

            // 🔁 PLAY AGAIN PART
            Console.Write("Play again? (y/n): ");
            string choice = Console.ReadLine().ToLower();

            if (choice != "y")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }
    private void SwitchTurn()
    {
        currentPlayer = (currentPlayer == player1) ? player2 : player1;
    }
}