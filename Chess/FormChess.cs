using System.Windows.Forms;

namespace Chess
{
    public partial class FormChess : Form
    {
        public FormChess()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new(pictureBoxChess.Width, pictureBoxChess.Height);
            Graphics g = Graphics.FromImage(bmp);
            Board board = new Board();
            DrawningBoardWithPiece _boardWithPiece = new DrawningBoardWithPiece(board, g);
            pictureBoxChess.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}