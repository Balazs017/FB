namespace Mozgo_kacsak
{
    public partial class Form1 : Form
    {
        int[,] elemx = new int[6, 8];
        int[,] elemy = new int[6, 8];


        PictureBox[,] kacsak = new PictureBox[6, 8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Width = 9 * Width / 10;
            Height = 9 * Height / 10;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int x = 0; x < kacsak.GetLength(0); x++)
            {
                for (global::System.Int32 y = 0; y < kacsak.GetLength(1); y++)
                {
                    elemx[x, y] = rnd.Next(-5, 6);
                    elemy[x, y] = rnd.Next(-5, 6);
                   
                }
            }
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < kacsak.GetLength(0); x++)
            {
                for (global::System.Int32 y = 0; y < kacsak.GetLength(1); y++)
                {
                    kacsak[x, y].Left += elemx[x, y];
                    kacsak[x, y].Top += elemy[x, y];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < kacsak.GetLength(0); x++)
            {
                for (int y = 0; y < kacsak.GetLength(1); y++)
                {

                    kacsak[x, y] = new PictureBox();
                    kacsak[x, y].Image = Image.FromFile(@"D:\Fekete Balazs\FB\Mozgo kacsak\images.jpg");

                    kacsak[x, y].Size = new Size(50, 50);
                    kacsak[x, y].Location = new Point(100 + 55 * x, 100 + 55 * y);
                    kacsak[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(kacsak[x, y]);
                }

            }
        }
    }
}
