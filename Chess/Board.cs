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
        public Piece[,] board =
        {
            {new RookPiece('b'), new KnightPiece('b'), new BishopPiece('b'), new QueenPiece('b'), new KingPiece('b'), new BishopPiece('b'), new KnightPiece('b'), new RookPiece('b')},
            {new PawnPiece('b'), new PawnPiece('b'), new PawnPiece('b'), new PawnPiece('b'), new PawnPiece('b'), new PawnPiece('b'), new PawnPiece('b'), new PawnPiece('b')},
            {null, null, null, null, null, null, null, null},
            {null, null, null, null, null, null, null, null},
            {null, null, null, null, null, null, null, null},
            {null, null, null, null, null, null, null, null},
            {new PawnPiece('w'), new PawnPiece('w'), new PawnPiece('w'), new PawnPiece('w'), new PawnPiece('w'), new PawnPiece('w'), new PawnPiece('w'), new PawnPiece('w')},
            {new RookPiece('w'), new KnightPiece('w'), new BishopPiece('w'), new KingPiece('w'), new QueenPiece('w'), new BishopPiece('w'), new KnightPiece('w'), new RookPiece('w')}
        };
        //public void DrawningBoard(Graphics g)
        //{
        //    int coordX = 0;
        //    int coordY = 0;
        //    Color clr;
        //    for (int i = 0; i < board.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < board.GetLength(1); j++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                if (j % 2 == 0) clr = beige;
        //                else clr = brown;
        //            }
        //            else
        //            {
        //                if (j % 2 == 0) clr = brown;
        //                else clr = beige;
        //            }
        //            g.FillRectangle(new SolidBrush(clr), coordX, coordY, boxWidth, boxHeight);
        //            coordX += boxWidth;
        //        }
        //        coordY += boxHeight;
        //        coordX = 0;
        //    }
        //}
        //public void DrawningBoardWithPiece(Graphics g)
        //{
        //    DrawningBoard(g);
        //    for (int i = 0; i < board.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < board.GetLength(1); j++)
        //        {
        //            switch (board[i, j])
        //            {
        //                case SidePiece.king:
        //                    KingPiece.Draw(j * 100 + 5, i * 100 + 5, g);
        //                    break;
        //                case SidePiece.queen:
        //                    QueenPiece.Draw(j * 100 + 5, i * 100 + 5, g);
        //                    break;
        //                case SidePiece.rook:
        //                    RookPiece.Draw(j * 100 + 5, i * 100 + 5, g);
        //                    break;
        //                case SidePiece.bishop:
        //                    BishopPiece.Draw(j * 100 + 5, i * 100 + 5, g);
        //                    break;
        //                case SidePiece.knight:
        //                    KnightPiece.Draw(j * 100 + 5, i * 100 + 5, g);
        //                    break;
        //                case SidePiece.pawn:
        //                    PawnPiece.Draw(j * 100 + 5, i * 100 + 5, g);
        //                    break;
        //            }
        //        }
        //    }
        //}
    }
}
