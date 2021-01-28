namespace board
{
    public class Board
    {
        public Board(int lines, int columns) 
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
               
        }
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Piece Piece(int line, int column)
        {
            return pieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return pieces[pos.line, pos.column]; ;
        }

        public bool existPiece(Position pos)
        {
            validatePosition(pos);
            return Piece(pos) != null;
        }

        public void putPiece(Piece p, Position pos)
        {
            if(existPiece(pos)){
                throw new BoardException("Já existe uma peça nessa posição");
            }
            pieces[pos.line, pos.column] = p;
            p.position = pos;
        }

        public bool validPosition(Position pos)
        {
            if (pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Posi��o inv�lida!");
            }
        }
    }
}