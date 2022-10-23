using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class QueenPiece : Piece
    {
        public QueenPiece(char ch) : base(ch) { }
        public override Image getImage()
        {
            if (color == Color.White) return Properties.Resources.wQ;
            else return Properties.Resources.bQ;
        }
    }
}
