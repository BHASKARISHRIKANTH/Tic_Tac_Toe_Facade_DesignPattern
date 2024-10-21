using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Facade_DesignPattern.Models
{
    internal class Board
    {
        private Cell[] cells;

        public Board()
        {
            cells = new Cell[9];
            for (int i = 0; i < 9; i++)
            {
                cells[i] = new Cell();
            }
        }
        public void SetCellMark(int index, MarkType type)
        {
            if (cells[index].IsEmpty())
            {
                cells[index].SetMark(type);
            }
        }
        public MarkType GetMarkType(int index)
        {
            return cells[index].GetMark();
        }
    }
}
