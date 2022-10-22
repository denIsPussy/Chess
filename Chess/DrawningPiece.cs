using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class DrawningPiece
    {
        public Piece[,] board;
        public const int pieceWidth = 90;
        public const int pieceHeight = 90;
        public DrawningPiece(Piece[,] board)
        {
            this.board = board;
        }
        public void DrawPiece()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    //g.DrawImage(img, x, y, pieceWidth, pieceHeight);
                }
            }
            //g.DrawImage(img, x, y, pieceWidth, pieceHeight);
        }
    }
}
