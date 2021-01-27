using System;
using board;


namespace xadrez_console
{
    public class Screen
    {
        public static void PrintBoard(Board board)
        {
            for( int i = 0; i < board.lines; i++)
            {
                for (int j = 0; j < board.lines; j++)
                {
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
