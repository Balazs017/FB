using System.Diagnostics.Eventing.Reader;

namespace lapfordito
{
    public partial class Form1 : Form
    {
        Button[,] gombok;
        void Fordit(Button btn)
        {
            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Red;
            }
            else { btn.BackColor = Color.Blue; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gombok = new Button[4, 4]
            {
                {button1, button2, button3,button4},
                {button5, button6, button7, button8},
                {button9, button10, button11,button12},
                {button13, button14, button15, button16}

             };
        }

        private void Lapokkatt(object sender, EventArgs e)
        {
            int sor, oszlop;

            sor = 0;
            oszlop = 0;
            bool megvan = false;
            while (!megvan)
            {
                if (gombok[sor, oszlop] == (sender as Button))
                {
                    megvan = true;
                }
                else
                {
                    sor++;
                    if (sor == 4)
                    {
                        oszlop++;
                        sor = 0;
                    }
                }
            }

            if (oszlop > 0)
            {
                Fordit(gombok[sor, oszlop - 1]);
            }
            if (oszlop < 3)
            {
                Fordit(gombok[sor, oszlop + 1]);
            }
            if (sor > 0)
            {
                Fordit(gombok[sor - 1, oszlop]);
            }
            if (sor < 3)
            {
                Fordit(gombok[sor + 1, oszlop]);
            }




        }

        private void Ujjatek_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    gombok[i,j].BackColor = Color.Blue ;
                }
            }
            int szint = comboBox1.SelectedIndex + 3;
            Random rnd = new Random();
            for (int i = 0; i < szint; i++)
            {
                int sor = rnd.Next(0, 4);
                int oszlop = rnd.Next(0, 4);
                Lapokkatt(gombok[sor, oszlop], EventArgs.Empty);
            }
        }

        
    }
}
