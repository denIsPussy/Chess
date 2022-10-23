using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Cell
    {
        public Piece piece { get; set; }
        public const int cellWidth = 100;
        public const int cellHeight = 100;
        public bool isSelected = false;
        public bool isAvailableMove = false;

        public Cell(Piece piece)
        {
            this.piece = piece;
        }
        public void Selected(int cellX, int cellY)
        {
            isSelected = true;
            if (piece is not null) piece.ShowAvailableMoves(Board.board);
        }
        public void Unselected(int cellX, int cellY)
        {
            isSelected = false;
            if (piece is not null) piece.HideAvailableMoves(Board.board);
        }
    }
}
