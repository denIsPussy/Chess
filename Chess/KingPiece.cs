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
        public override void Draw(int cellX, int cellY, Graphics g)
        {
            Image img;
            if (color == Color.White) img = Properties.Resources.wK;
            else img = Properties.Resources.bK;
            g.DrawImage(img, cellY * 100 + 5, cellX * 100 + 5);
        }
    }
}
