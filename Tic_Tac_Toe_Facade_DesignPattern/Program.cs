using Tic_Tac_Toe_Facade_DesignPattern.Models;

namespace Tic_Tac_Toe_Facade_DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player Player1 = new Player(MarkType.X);
            Player Player2 = new Player(MarkType.O);

            ResultAnalyzer analyzer = new ResultAnalyzer();
            PlayGame game = new PlayGame();

            game.DisplayBoard(board);
            game.StartGame(board, Player1, Player2, analyzer);
        }
    }
}
