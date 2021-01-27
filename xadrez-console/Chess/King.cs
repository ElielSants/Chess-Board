using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace Chess
{
    class King : Piece
    {
        public King(Board board, Color color) : base(board, color)
        {

        }
        public override string ToString()
        {
            return "K";
        }
    }
}
