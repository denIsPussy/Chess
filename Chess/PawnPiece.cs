using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class PawnPiece : Piece
    {
        public PawnPiece(char ch) : base(ch) { }
        public override Image getImage()
        {
            if (color == Color.White) return Properties.Resources.wP;
            else return Properties.Resources.bP;
        }
        public override void ShowAvailableMoves(Cell[,] board)
        {
            Cell currentPiece = board[cellX, cellY];

            if (cellX - 1 >= 0 && cellY + 1 < 8) 
            {
                if (board[cellX - 1, cellY + 1].piece == null) board[cellX - 1, cellY + 1].isAvailableMove = true;
            }
            if (cellX - 1 >= 0 && cellY - 1 >= 0)
            {
                if (board[cellX - 1, cellY - 1].piece == null) board[cellX - 1, cellY - 1].isAvailableMove = true;
            }
        }
        public override void HideAvailableMoves(Cell[,] board)
        {
            Cell currentPiece = board[cellX, cellY];

            if (cellX - 1 >= 0 && cellY + 1 < 8)
            {
                if (board[cellX - 1, cellY + 1].piece == null) board[cellX - 1, cellY + 1].isAvailableMove = false;
            }
            if (cellX - 1 >= 0 && cellY - 1 >= 0)
            {
                if (board[cellX - 1, cellY - 1].piece == null) board[cellX - 1, cellY - 1].isAvailableMove = false;
            }
        }
    }
}
