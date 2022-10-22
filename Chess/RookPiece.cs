using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class RookPiece : Piece
    {
        public RookPiece(char ch) : base(ch)
        {
            if (color == Color.White) img = Properties.Resources.wR;
            else img = Properties.Resources.bR;
        }
    }
}
