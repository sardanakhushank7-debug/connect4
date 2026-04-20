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
        while (true)
        {
            board.Display();

            int move = currentPlayer.MakeMove();

            if (!board.DropDisc(move, currentPlayer.Symbol))
            {
                Console.WriteLine("Column full! Try again.");
                continue;
            }

            if (board.IsFull())
            {
                board.Display();
                Console.WriteLine("Game is a draw!");
                break;
            }

            SwitchTurn();
        }
    }

    private void SwitchTurn()
    {
        currentPlayer = (currentPlayer == player1) ? player2 : player1;
    }
}