using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Piece
    {
        public int cellX { get; set; }
        public int cellY { get; set; }
        public Color color { get; set; }
        public bool onTheBoard { get; set; }
        public const int pieceWidth = 70;
        public const int pieceHeight = 70;
        public Image img { get; set; }
        public Piece(char ch)
        {
            if (ch == 'b') color = Color.Black;
            else if (ch == 'w') color = Color.White;
            onTheBoard = true;
        }
        public Image getImage()
        {
            return img;
        }
        public virtual void Move(int cellX, int cellY, Board board) { }
        public virtual void Selected(int cellX, int cellY, Board board) { }
    }
}
