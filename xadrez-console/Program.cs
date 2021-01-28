using System;
using board;
using Chess;

namespace xadrez_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            try{

            Board board = new Board(8, 8);

            board.putPiece(new Rook(board, Color.Black), new Position(0, 0));
            board.putPiece(new Rook(board, Color.Black), new Position(1, 9));
            board.putPiece(new King(board, Color.Black), new Position(0, 2));


            Screen.PrintBoard(board);

            
            }catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
