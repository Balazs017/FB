namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        int vx, vy;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            vx = rnd.Next(5, 10);
            if (rnd.NextDouble() < 0.5) { vx = -vx; }

            vy = rnd.Next(-3, 4);
            if (rnd.NextDouble() < 0.5)
            {
                vy = -vy;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int newLeft = Labda.Left + vx;
            int newTop = Labda.Top + vy;
            int newRight = newLeft + Labda.Width;
            int newBottom = newTop + Labda.Height;
            if (newTop < 0 || newBottom > ClientRectangle.Height)
            {
                vy = -vy;

            }
            else
            {
                Labda.Top = newTop;
            }

            if (newLeft < 0 || newRight > ClientRectangle.Width)
            {
                vx = -vx;

            }
            else
            {
                Labda.Left = newLeft;
            }
        }



        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (Jobbuto.Top - 10 >= 0)
                {
                    Jobbuto.Top -= 10;
                }
            }



            if (e.KeyCode == Keys.Down)
            {
                if (Jobbuto.Top + 10 + Jobbuto.Height <= ClientRectangle.Height)
                {
                    Jobbuto.Top += 10;
                }

            }
        }

        private void Jobbütõ_Click(object sender, EventArgs e)
        {

        }
    }
}
