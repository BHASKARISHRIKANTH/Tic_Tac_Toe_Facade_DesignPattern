using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Facade_DesignPattern.Models
{
    internal class Player
    {
        private MarkType mark;

        public Player(MarkType type)
        {
            mark = type;
        }
        public void PlayGame(Board board)
        {
            Console.WriteLine("Enter your position (0-8):");
            int position = Convert.ToInt32(Console.ReadLine());
            board.SetCellMark(position, mark);
        }
    }
}
