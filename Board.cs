using System;

public class Board
{
    private char[,] grid = new char[6, 7];

    public Board()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                grid[i, j] = '.';
            }
        }
    }

    public void Display()
    {
        Console.WriteLine();

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write("| " + grid[i, j] + " ");
            }
            Console.WriteLine("|");
        }

        Console.WriteLine("-----------------------------");
        Console.WriteLine("  1   2   3   4   5   6   7");
        Console.WriteLine();
    }

    public bool DropDisc(int column, char symbol)
    {
        column--; // user enters 1–7

        if (column < 0 || column > 6)
        {
            return false;
        }

        for (int i = 5; i >= 0; i--)
        {
            if (grid[i, column] == '.')
            {
                grid[i, column] = symbol;
                return true;
            }
        }

        return false;
    }

    public bool IsFull()
    {
        for (int j = 0; j < 7; j++)
        {
            if (grid[0, j] == '.')
            {
                return false;
            }
        }

        return true;
    }

    public bool CheckWin(char symbol)
    {
        // Horizontal
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (grid[i, j] == symbol &&
                    grid[i, j + 1] == symbol &&
                    grid[i, j + 2] == symbol &&
                    grid[i, j + 3] == symbol)
                {
                    return true;
                }
            }
        }

        // Vertical
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, j] == symbol &&
                    grid[i + 1, j] == symbol &&
                    grid[i + 2, j] == symbol &&
                    grid[i + 3, j] == symbol)
                {
                    return true;
                }
            }
        }

        // Diagonal top-left to bottom-right
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (grid[i, j] == symbol &&
                    grid[i + 1, j + 1] == symbol &&
                    grid[i + 2, j + 2] == symbol &&
                    grid[i + 3, j + 3] == symbol)
                {
                    return true;
                }
            }
        }

        // Diagonal bottom-left to top-right
        for (int i = 3; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (grid[i, j] == symbol &&
                    grid[i - 1, j + 1] == symbol &&
                    grid[i - 2, j + 2] == symbol &&
                    grid[i - 3, j + 3] == symbol)
                {
                    return true;
                }
            }
        }

        return false;
    }
}