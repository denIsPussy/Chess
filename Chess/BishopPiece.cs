using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class BishopPiece : Piece
    {
        public BishopPiece(char ch) : base(ch)
        {
            if (color == Color.White) img = Properties.Resources.wB;
            else img = Properties.Resources.bB;
        }
    }
}
