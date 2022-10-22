using System.Windows.Forms;

namespace Chess
{
    public partial class FormChess : Form
    {
        Graphics g;
        Bitmap bmp;
        public FormChess()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            bmp = new(pictureBoxChess.Width, pictureBoxChess.Height);
            g = Graphics.FromImage(bmp);
            Board board = new Board();
            DrawningBoardWithPiece _boardWithPiece = new DrawningBoardWithPiece(board, g);
            pictureBoxChess.Image = bmp;
        }
        private void pictureBoxChess_MouseClick(object sender, MouseEventArgs e)
        {
            int CursorX = e.Location.X;
            int CursorY = e.Location.Y;
            g.DrawRectangle(new Pen(Color.Black), CursorX - 10, CursorY - 10, 20, 20);
            pictureBoxChess.Image = bmp;
        }
    }
}