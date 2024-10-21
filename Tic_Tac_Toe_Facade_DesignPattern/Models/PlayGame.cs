using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Facade_DesignPattern.Models
{
    internal class PlayGame
    {
        public void DisplayBoard(Board board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board.GetMarkType(i) == MarkType.EMPTY)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write($"{board.GetMarkType(i)} | ");
                }
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                    if (i != 8)
                    {
                        Console.WriteLine("____________");
                    }

                }
            }

        }
        public void StartGame(Board board, Player Shrikanth, Player Varshith, ResultAnalyzer resultAnalyzer)
        {
            bool gameFinished = false;
            while (!gameFinished)
            {
                Shrikanth.PlayGame(board);
                DisplayBoard(board);
                if (resultAnalyzer.CheckFirstRow(board) || resultAnalyzer.CheckSecondRow(board) || resultAnalyzer.CheckThirdRow(board) || resultAnalyzer.CheckRightDiagonal(board) || resultAnalyzer.CheckLeftDiagonal(board))
                {
                    gameFinished = true;
                    break;
                }
                Varshith.PlayGame(board);
                DisplayBoard(board);
                if (resultAnalyzer.CheckFirstRow(board) || resultAnalyzer.CheckSecondRow(board) || resultAnalyzer.CheckThirdRow(board) || resultAnalyzer.CheckRightDiagonal(board) || resultAnalyzer.CheckLeftDiagonal(board))
                {
                    gameFinished = true;
                    break;
                }



            }
        }
    }
}
