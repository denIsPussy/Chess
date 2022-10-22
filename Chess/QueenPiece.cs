using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class QueenPiece : Piece
    {
        public QueenPiece(char ch) : base(ch)
        {
            if (color == Color.White) img = Properties.Resources.wQ;
            else img = Properties.Resources.bQ;
        }
    }
}
