using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    internal class KingPiece : Piece
    {
        public KingPiece(char ch) : base(ch) { }
        public override Image getImage()
        {
            if (color == Color.White) return Properties.Resources.wK;
            else return Properties.Resources.bK;
        }
    }
}
