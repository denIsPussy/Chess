using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class PawnPiece : Piece
    {
        public PawnPiece(char ch) : base(ch) { }
        public override void Draw(int cellX, int cellY, Graphics g)
        {
            Image img;
            if (color == Color.White) img = Properties.Resources.wP;
            else img = Properties.Resources.bP;
            g.DrawImage(img, cellY * 100 + 5, cellX * 100 + 5);
        }
    }
}
