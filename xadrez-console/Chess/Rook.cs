using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace Chess
{
    class Rook : Piece
    {
        public Rook(Board board, Color color) : base(board, color)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
