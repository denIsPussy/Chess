using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class PawnPiece : Piece
    {
        public PawnPiece(char ch) : base(ch)
        {
            if (color == Color.White) img = Properties.Resources.wP;
            else img = Properties.Resources.bP;
        }
    }
}
