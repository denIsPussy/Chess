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
        public override void ShowAvailableMoves(Board board)
        {

        }
    }
}
