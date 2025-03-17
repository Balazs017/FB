namespace KetAblakosSzamologep
{
    public partial class Ketablakos : Form
    {
        int bal, jobb;
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





        private void Muveletklikk(object sender, EventArgs e)
        {

            char muv = (sender as Button).Text[0];
            if (History.Items.Count > 0)
            {
                string utolso = History.Items[History.Items.Count - 1].ToString();
                char utut = utolso[utolso.Length - 1];
                if (utut == '+' || utut == '-' || utut == '*' || utut == '/')
                {
                    jobb = int.Parse(balSzam.Text);
                    int eredm = 0;
                    bool hiba = false;
                    switch (utut)
                    {
                        case '+':
                            eredm = bal + jobb;
                            break;

                        case '-':
                            eredm = bal -jobb;
                            break;

                        case '*':
                            eredm = bal * jobb;
                            break;
                        case '/':
                            if (jobb != 0)
                            {
                                eredm = bal / jobb;
                            }
                            else
                            {
                                MessageBox.Show("Osztás nullával");
                                hiba = true;
                            }
                            break;
                    }
                    if (!hiba)
                    {
                        History.Items[History.Items.Count - 1] += jobb.ToString() + " " + eredm.ToString();
                        if (muv == '=')
                        {
                            balSzam.Text = "0";
                        }
                        else {
                            bal = eredm;
                            History.Items.Add(eredm.ToString() + muv.ToString());
                        }
                    }     
                }
                else
                {
                    bal = int.Parse(balSzam.Text);
                    History.Items.Add(bal.ToString()+ muv.ToString());
                }

            }
            else
            {
                bal = int.Parse(balSzam.Text);
                History.Items.Add(bal.ToString() + muv.ToString());
            }
            balSzam.Text = "0";

        }
    }
}

