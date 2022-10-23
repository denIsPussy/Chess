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
            for (int i = 0; i < Board.board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.board.GetLength(1); j++)
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
                    g.FillRectangle(new SolidBrush(clr), coordX, coordY, board.boxWidth, board.boxHeight);
                    coordX += board.boxWidth;
                }
                coordY += board.boxHeight;
                coordX = 0;
            }
        }
        public void Drawning(Graphics g)
        {
            DrawningBoard(g);
            for (int i = 0; i < Board.board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.board.GetLength(1); j++)
                {
                    Cell cell = Board.board[i, j];
                    if (!(cell.piece is null)) g.DrawImage(cell.piece.getImage(), cell.piece.cellY * 100 + 9, cell.piece.cellX * 100 + 5);
                    if (cell.isSelected)
                    {
                        g.DrawRectangle(new Pen(Color.Green, 5), j * 100, i * 100, 100, 100);
                    }
                }
            }
        }
    }
}
