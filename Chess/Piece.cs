using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Piece
    {
        public int cellX { get; set; }
        public int cellY { get; set; }
        public Color color { get; set; }
        public bool onTheBoard { get; set; }
        public const int pieceWidth = 70;
        public const int pieceHeight = 70;
        public Piece(char ch)
        {
            if (ch == 'b') color = Color.Black;
            else if (ch == 'w') color = Color.White;
            onTheBoard = true;
        }
        public virtual Image getImage() { return null; }
        public void Move(int newX, int newY, Board board)
        {
            Cell oldCell = Board.board[cellX, cellY];
            Cell newCell = Board.board[newX, newY];

            newCell.piece = oldCell.piece;
            oldCell.piece = null;

            newCell.isSelected = false;
            oldCell.isSelected = false;

            newCell.piece.cellX = newX;
            newCell.piece.cellY = newY;
        }
        public virtual void ShowAvailableMoves(Cell[,] board) { }
        public virtual void HideAvailableMoves(Cell[,] board) { }
    }
}
