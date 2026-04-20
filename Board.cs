using System;

public class Board
{
    private char[,] grid = new char[6, 7];

    public Board()
    {
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 7; j++)
                grid[i, j] = '.';
    }

    public void Display()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("1 2 3 4 5 6 7");
    }

    public bool DropDisc(int column, char symbol)
    {
        column--; // user enters 1–7

        for (int i = 5; i >= 0; i--)
        {
            if (grid[i, column] == '.')
            {
                grid[i, column] = symbol;
                return true;
            }
        }
        return false; // column full
    }

    public bool IsFull()
    {
        for (int j = 0; j < 7; j++)
        {
            if (grid[0, j] == '.')
                return false;
        }
        return true;
    }
}