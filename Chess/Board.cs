using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Board
    {
        public int BoardWidth;
        public int BoardHeight;
        public int boxWidth;
        public int boxHeight;
        public Color brown = Color.FromArgb(207, 114, 58);
        public Color beige = Color.FromArgb(235, 204, 160);
        public static Cell[,] board =
        {
            {new Cell(new RookPiece('b')), new Cell(new KnightPiece('b')), new Cell(new BishopPiece('b')), new Cell(new QueenPiece('b')), new Cell(new KingPiece('b')), new Cell(new BishopPiece('b')), new Cell(new KnightPiece('b')), new Cell(new RookPiece('b'))},
            {new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b'))},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w'))},
            {new Cell(new RookPiece('w')), new Cell(new KnightPiece('w')), new Cell(new BishopPiece('w')), new Cell(new KingPiece('w')), new Cell(new QueenPiece('w')), new Cell(new BishopPiece('w')), new Cell(new KnightPiece('w')), new Cell(new RookPiece('w'))}
        };
        public Board(int BoardWidth, int BoardHeight)
        {
            this.BoardWidth = BoardWidth;
            this.BoardHeight = BoardHeight;
            boxWidth = BoardWidth / 8;
            boxHeight = BoardHeight / 8;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j].piece is Piece)
                    {
                        board[i, j].piece.cellX = i;
                        board[i, j].piece.cellY = j;

                    }
                }
            }
        }
    }
}
