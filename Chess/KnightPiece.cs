using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class KnightPiece : Piece
    {
        public KnightPiece(char ch) : base(ch) { }
        public override Image getImage()
        {
            if (color == Color.White) return Properties.Resources.wN;
            else return Properties.Resources.bN;
        }
    }
}
