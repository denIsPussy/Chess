using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class DrawningBoardWithPiece
    {
        public Board board;
        public DrawningBoardWithPiece(Board board, Graphics g) 
        {
            this.board = board;
            Drawning(g);
        }
        public void DrawningBoard(Graphics g)
        {
            int coordX = 0;
            int coordY = 0;
            Color clr;
            for (int i = 0; i < board.board.GetLength(0); i++)
            {
                for (int j = 0; j < board.board.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0) clr = board.beige;
                        else clr = board.brown;
                    }
                    else
                    {
                        if (j % 2 == 0) clr = board.brown;
                        else clr = board.beige;
                    }
                    g.FillRectangle(new SolidBrush(clr), coordX, coordY, Board.boxWidth, Board.boxHeight);
                    coordX += Board.boxWidth;
                }
                coordY += Board.boxHeight;
                coordX = 0;
            }
        }
        public void Drawning(Graphics g)
        {
            DrawningBoard(g);
            for (int i = 0; i < board.board.GetLength(0); i++)
            {
                for (int j = 0; j < board.board.GetLength(1); j++)
                {
                    Piece piece = board.board[i, j];
                    if (!(piece is null)) piece.Draw(i, j, g);
                }
            }
        }
    }
}
