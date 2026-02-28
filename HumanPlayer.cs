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
            Console.Write($"{Name}, choose a column (1-7): ");
            return int.Parse(Console.ReadLine());
        }
    }
}
