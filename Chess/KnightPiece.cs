using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class KnightPiece : Piece
    {
        public KnightPiece(char ch) : base(ch)
        {
            if (color == Color.White) img = Properties.Resources.wN;
            else img = Properties.Resources.bN;
        }
    }
}
