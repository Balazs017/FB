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
 
                button1, button2, button3, button4, button5, button6, button7, button8, button9, button10
 
            };
 
        }
 
        private void button11_Click(object sender, EventArgs e)
 
        {
 
            Random rnd = new Random();
 
            for (int i = 0; i < 10; i++)
 
            {
 
                tomb[i].Text = rnd.Next(100, 999).ToString();
 
            }
 
        }
 
        private void timer1_Tick(object sender, EventArgs e)
 
        {
 
            tomb[melyik].BackColor = Color.Red;
 
            melyik++;
 
            if (melyik == 10)
 
            {
 
                melyik = 0;
 
            }
 
        }
 
        private void Csere(int i, int j)
 
        {
 
 
            Button ment = tomb[i];
 
            tomb[i] = tomb[j];
 
            tomb[j] = ment;
 
 
            tomb[i].BringToFront();
 
            tomb[j].BringToFront();
 
            int iLeft = tomb[i].Left;
 
            int jLeft = tomb[j].Left;
 
            while (Math.Abs(tomb[i].Left - jLeft) > 10)
 
            {
 
                if (iLeft < jLeft)
 
                {
 
                    tomb[i].Left += 10;
 
                    tomb[j].Left -= 10;
 
                }
 
                else
 
                {
 
                    tomb[i].Left -= 10;
 
                    tomb[j].Left += 10;
 
                }
 
                Refresh();
 
                Thread.Sleep(100);
 
            }
 
 
            tomb[j].Left = iLeft;
 
            tomb[i].Left = jLeft;
 
        }
 
        private void Buborek_Click(object sender, EventArgs e)
 
        {
 
 
            for (int meddig = 10 - 1; meddig >= 0; meddig--)
 
            {
 
                for (int mutato = 0; mutato < meddig; mutato++)
 
                {
 
                    if (tomb[mutato].Text.CompareTo(tomb[mutato + 1].Text) > 0)
 
                    {
 
                        Csere(mutato, mutato + 1);
 
                    }
 
                }
 
            }
 
        }
 
    }
 
}
 
 