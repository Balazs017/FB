namespace VizuRend
{
    public partial class Form1 : Form
    {
        Button[] tomb;
        int melyik = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tomb = new Button[10]
        {
            button1, button2, button3, button4, button5, button6,button7, button8,button9, button10
        };
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            for (int i = 0; i < 10; i++)
            {
                tomb[i].Text = rnd.Next(100, 1000).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tomb[melyik].BackColor = Color.Blue;
            melyik++;
            if (melyik == 10) melyik = 0;
        }
    }
}
