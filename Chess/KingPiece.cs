using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    internal class KingPiece : Piece
    {
        public KingPiece(char ch) : base(ch)
        {
            if (color == Color.White) img = Properties.Resources.wK;
            else img = Properties.Resources.bK;
        }
        public override void Move(int cellX, int cellY, Board board)
        {
            if (board.board[cellY, cellX] != null)
            {
                this.cellX = cellX;
                this.cellY = cellY;
            }
        }
        public override void Selected(int cellX, int cellY, Board board)
        {
            if (board.board[cellY  + 1, cellX + 1] != null)
            {
                board.board[cellY + 1, cellX + 1] = null;
            }
        }
    }
}
