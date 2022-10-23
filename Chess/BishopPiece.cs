using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class BishopPiece : Piece
    {
        public BishopPiece(char ch) : base(ch) { }
        public override Image getImage()
        {
            if (color == Color.White) return Properties.Resources.wB;
            else return Properties.Resources.bB;
        }
        public override void ShowAvailableMoves(Board board)
        {
        }
    }
}
