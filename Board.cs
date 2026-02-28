using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Board
    {
        private char[,] grid;

        public Board()
        {
            grid = new char[6, 7];
        }

        public bool DropDisc(int column, char symbol)
        {
            return true; // logic later
        }

        public bool CheckWin()
        {
            return false;
        }

        public bool IsFull()
        {
            return false;
        }
    }
}
