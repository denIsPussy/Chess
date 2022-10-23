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
        public const int BoardWidth = 800;
        public const int boardHeight = 800;
        public const int boxWidth = 100;
        public const int boxHeight = 100;
        public Color brown = Color.FromArgb(207, 114, 58);
        public Color beige = Color.FromArgb(235, 204, 160);
        public Cell[,] board =
        {
            {new Cell(new RookPiece('b')), new Cell(new KnightPiece('b')), new Cell(new BishopPiece('b')), new Cell(new QueenPiece('b')), new Cell(new KingPiece('b')), new Cell(new BishopPiece('b')), new Cell(new KnightPiece('b')), new Cell(new RookPiece('b'))},
            {new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b')), new Cell(new PawnPiece('b'))},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null), new Cell(null)},
            {new Cell(new PawnPiece('b')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w')), new Cell(new PawnPiece('w'))},
            {new Cell(new RookPiece('b')), new Cell(new KnightPiece('w')), new Cell(new BishopPiece('w')), new Cell(new KingPiece('w')), new Cell(new QueenPiece('w')), new Cell(new BishopPiece('w')), new Cell(new KnightPiece('w')), new Cell(new RookPiece('w'))}
        };
        public Board()
        {
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
