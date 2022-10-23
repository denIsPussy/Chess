using System;
using System.Windows.Forms;
using Timer = System.Threading.Timer;
using System.Threading;
using System.Runtime.InteropServices;

namespace Chess
{
    public partial class FormChess : Form
    {
        [DllImport("user32.dll")]
        public static extern int GetDoubleClickTime();
        [DllImport("user32.dll")]
        public static extern bool SetDoubleClickTime(uint Arg1);
        Graphics g;
        Bitmap bmp;
        Board board;
        private Timer _timer = null;
        public FormChess()
        {
            InitializeComponent();
            SetDoubleClickTime(1);
            Timer();
        }
        private void Timer()
        {
            bmp = new(pictureBoxChess.Width, pictureBoxChess.Height);
            g = Graphics.FromImage(bmp);
            board = new Board();
            Draw();
            timerChess.Enabled = true;
        }
        private void Draw()
        {
            g.Clear(Color.Empty);
            DrawningBoardWithPiece _boardWithPiece = new DrawningBoardWithPiece(board, g);
            pictureBoxChess.Image = bmp;
        }
        private void pictureBoxChess_MouseClick(object sender, MouseEventArgs e)
        {
            int CursorX = e.Location.X;
            int CursorY = e.Location.Y;

            int x = CursorX / 100;
            int y = CursorY / 100;

            Cell cell = board.board[y, x];

            if (!SelectedBoxOnBoard())
            {
                if (!cell.isSelected) cell.Selected(y, x);
            }
            else
            {
                if (cell.isSelected) cell.Unselected(y, x);
                else
                {
                    var indexSelectedCell = getIndexSelectedCell();
                    Cell selectedCell = board.board[indexSelectedCell.Item1, indexSelectedCell.Item2];
                    if (selectedCell.piece is Piece && cell.piece == null)
                    {
                        selectedCell.piece.Move(y, x, board);
                    }
                    else
                    {
                        selectedCell.isSelected = false;
                    }

                }
            }
            pictureBoxChess.Image = bmp;
        }

        private void timerChess_Tick(object sender, EventArgs e)
        {
            Draw();
        }
        private bool SelectedBoxOnBoard()
        {
            foreach (Cell c in board.board)
            {
                if (c.isSelected) return true;
            }
            return false;
        }
        private (int x, int y) getIndexSelectedCell()
        {
            for(int i = 0; i < board.board.GetLength(0); i++)
            {
                for (int j = 0; j < board.board.GetLength(1); j++)
                {
                    Cell c = board.board[i, j];
                    if (c.isSelected) return (i, j);
                }
            }
            return (0, 0);
        }
    }
}