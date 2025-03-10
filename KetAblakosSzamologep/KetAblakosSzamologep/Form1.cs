namespace KetAblakosSzamologep
{
    public partial class Ketablakos : Form
    {
        public Ketablakos()
        {
            InitializeComponent();
        }

        private void BalSzamok(object sender, EventArgs e)
        {
            char be = (sender as Button).Text[0];

            if (balSzam.Text == "0")
            {
                balSzam.Text = be.ToString();

            }
            else
            {
                balSzam.Text += be.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            balSzam.Text = balSzam.Text.Substring(0, balSzam.Text.Length - 1);
            if (balSzam.Text == "")
            {
                balSzam.Text = "0";
            }
        }

        private void Jobbszamokklikk(object sender, EventArgs e)
        {
            char be = (sender as Button).Text[0];

            if (jobbSzam.Text == "0")
            {
                jobbSzam.Text = be.ToString();

            }
            else
            {
                jobbSzam.Text += be.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            jobbSzam.Text = jobbSzam.Text.Substring(0, jobbSzam.Text.Length - 1);
            if (jobbSzam.Text == "")
            {
                jobbSzam.Text = "0";
            }

        }

        private void Muveletklikk(object sender, EventArgs e)
        {
            int bal = int .Parse(balSzam.Text);
            int jobb = int .Parse(jobbSzam.Text);
            char muv = (sender as Button).Text[0];
            switch(muv)
            {
                case '+':
                    int osszeg = bal + jobb;
                    balSzam.Text = osszeg.ToString();
                    break;
            }
        }
    }
}
