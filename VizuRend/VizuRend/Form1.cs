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

        private void KozvCsere(object sender, EventArgs e)

        {

            for (int i = 0; i < tomb.Length - 1; i++)

            {

                for (int j = i + 1; j < tomb.Length; j++)

                {

                    if (tomb[i].Text.CompareTo(tomb[j].Text) > 0)

                    {

                        Csere(i, j);

                    }

                }

            }

        }

        private void MinKiv(object sender, EventArgs e)

        {

            for (int i = 0; i < tomb.Length - 1; i++)

            {

                int minIndex = i;

                tomb[i].BackColor = Color.Yellow;

                for (int j = i + 1; j < tomb.Length; j++)

                {

                    tomb[j].BackColor = Color.Green;

                    Refresh();

                    Thread.Sleep(300);

                    if (tomb[j].Text.CompareTo(tomb[minIndex].Text) < 0)

                    {

                        if (minIndex != i)

                            tomb[minIndex].BackColor = Color.Transparent;

                        minIndex = j;

                    }

                    tomb[j].BackColor = Color.Transparent;

                }

                tomb[i].BackColor = Color.Transparent;

                if (minIndex != i)

                {

                    Csere(i, minIndex);

                }

            }

        }

        private void Eltol(int i)

        {

            if (i < 9)

            {

                tomb[i].Text = tomb[i + 1].Text;

                tomb[i].BackColor = Color.Yellow;

                Refresh();

                Thread.Sleep(300);

                Eltol(i + 1);

            }

            else

            {

                tomb[i].Text = tomb[i + 1].Text;

                tomb[i].BackColor = Color.Transparent;

            }

        }

        private void Beszuras(object sender, EventArgs e)

        {

            for (int i = 1; i < tomb.Length; i++)

            {

                int j = i;

                string key = tomb[j].Text;

                while (j > 0 && tomb[j - 1].Text.CompareTo(key) > 0)

                {

                    tomb[j].Text = tomb[j - 1].Text;

                    tomb[j].BackColor = Color.Yellow;

                    j--;

                    Refresh();

                    Thread.Sleep(300);

                }

                tomb[j].Text = key;

                tomb[j].BackColor = Color.Transparent;

            }

        }

    }

}

