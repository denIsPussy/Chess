using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class RookPiece : Piece
    {
        public RookPiece(char ch) : base(ch) { }
        public override void Draw(int cellX, int cellY, Graphics g)
        {
            Image img;
            if (color == Color.White) img = Properties.Resources.wR;
            else img = Properties.Resources.bR;
            g.DrawImage(img, cellY * 100 + 5, cellX * 100 + 5);
        }
    }
}
