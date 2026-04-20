using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    using System;

    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol)
            : base(name, symbol)
        {
        }

        public override int MakeMove()
        {
            while (true)
            {
                Console.Write($"{Name}, choose a column (1-7): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int column) && column >= 1 && column <= 7)
                {
                    return column;
                }

                Console.WriteLine("Invalid input! Enter a number between 1 and 7.");
            }
        }
    }
}
