public partial class Form1 : Form
    {
        Point A = new Point(0, 0);
        Point B = new Point();
        Graphics G;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Point A = new Point(0, 0);
        }

        private void pnl_MouseDown(object sender, MouseEventArgs e)
        {
            G = pnl.CreateGraphics();
            Pen pen = new Pen(Brushes.Red, 5f);

            if (A.X == 0 && A.Y == 0)
            {
                B = new Point(e.X, e.Y);
                A = B;
            }
            else
            {
                A = B;
                B = new Point(e.X, e.Y);
                G.DrawLine(pen, A, B);
            }
        }
    }
}
