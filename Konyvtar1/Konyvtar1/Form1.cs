using System.Web;

namespace Konyvtar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"..\..\..\konyvek.txt");
            string sor = sr.ReadLine();
            while (sor != null)
            {
                if (sor.Trim() != "")
                {
                    string szebbSor = sor.Replace(";", "  :  ");
                    kkListBox.Items.Add(szebbSor);
                }
                sor = sr.ReadLine();
            }
            sr.Close();

            StreamReader sro = new StreamReader(@"..\..\..\olvasok.txt");
            string sorOlv = sro.ReadLine();
            while (sorOlv != null)
            {
                if (sorOlv.Trim() != "")
                {
                    string szebbSor = sorOlv.Replace(";", "  :  ");
                    OlvListBox.Items.Add(szebbSor);
                }
                sorOlv = sro.ReadLine();
            }
            sro.Close();

            StreamReader kzksr = new StreamReader(@"..\..\..\kolcsonzes.txt");
            string kzksor = kzksr.ReadLine();
            while (kzksor != null)
            {
                if (kzksor.Trim() != "")
                {

                    kzkListBox.Items.Add(kzksor);
                }
                kzksor = kzksr.ReadLine();
            }
            kzksr.Close();
        }

        private void kkFelvesz_Click(object sender, EventArgs e)
        {
            try
            {
                int azon = int.Parse(KKAzon.Text);
                bool van = false; // van-e már ilyen azonosító
                for (int i = 0; i < kkListBox.Items.Count; i++)
                {
                    int ezazazon = int.Parse(kkListBox.Items[i].ToString().Substring(0, 4));
                    if (azon == ezazazon)
                    {
                        van = true;
                    }
                }
                if (!van && azon >= 1000 && azon <= 9999)
                {
                    // jó az azonosító
                    string sor = $"{azon}  :  {kkSzerzo.Text}  :  {kkCim.Text}  :  {kkKiad.Text}";
                    kkListBox.Items.Add(sor);
                    KKAzon.Text = "";
                    kkSzerzo.Text = "";
                    kkCim.Text = "";
                    kkKiad.Text = "";
                }
                else
                {
                    MessageBox.Show("Hibás azonosító!");
                    KKAzon.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Hibás azonosító!");
                KKAzon.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\konyvek.txt");
            for (int i = 0; i < kkListBox.Items.Count; i++)
            {
                string sor = kkListBox.Items[i].ToString().Replace("  :  ", ";");
                sw.WriteLine(sor);
            }
            sw.Close();

            StreamWriter swOlv = new StreamWriter(@"..\..\..\olvasok.txt");
            for (int i = 0; i < OlvListBox.Items.Count; i++)
            {
                string sor = OlvListBox.Items[i].ToString().Replace("  :  ", ";");
                swOlv.WriteLine(sor);
            }
            swOlv.Close();

            StreamWriter kzksr = new StreamWriter(@"..\..\..\kolcsonzesek.txt");
            for (int i = 0; i < kzkListBox.Items.Count; i++)
            {
                string sor = kzkListBox.Items[i].ToString();
                kzksr.WriteLine(sor);
            }
            kzksr.Close();
        }

        private void kkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kkListBox.SelectedIndex != -1)
            {
                string[] felDarab = kkListBox.Items[kkListBox.SelectedIndex].ToString().Split("  :  ");
                KKAzon.Text = felDarab[0];
                kkSzerzo.Text = felDarab[1];
                kkCim.Text = felDarab[2];
                kkKiad.Text = felDarab[3];
            }
        }

        private void kkModosit_Click(object sender, EventArgs e)
        {
            if (kkListBox.SelectedIndex != -1)
                try
                {
                    int azon = int.Parse(KKAzon.Text);
                    bool van = false; // van-e másik!
                    for (int i = 0; i < kkListBox.Items.Count; i++)
                    {
                        int ezazazon = int.Parse(kkListBox.Items[i].ToString().Substring(0, 4));
                        if (azon == ezazazon && kkListBox.SelectedIndex != i)
                        {
                            van = true;
                        }
                    }
                    if (!van && azon >= 1000 && azon <= 9999)
                    {
                        // jó az azonosító
                        string sor = $"{azon}  :  {kkSzerzo.Text}  :  {kkCim.Text}  :  {kkKiad.Text}";
                        kkListBox.Items[kkListBox.SelectedIndex] = sor;
                    }
                    else
                    {
                        MessageBox.Show("Hibás azonosító!");
                        KKAzon.Focus();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás azonosító!");
                    KKAzon.Focus();
                }
        }

        private void kkTorol_Click(object sender, EventArgs e)
        {
            if (kkListBox.SelectedIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Valóban törlöd?", "Könyv törlése", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    kkListBox.Items.RemoveAt(kkListBox.SelectedIndex);
                    KKAzon.Text = "";
                    kkSzerzo.Text = "";
                    kkCim.Text = "";
                    kkKiad.Text = "";
                }
            }
        }

        private void kkUj_Click(object sender, EventArgs e)
        {
            KKAzon.Text = "";
            kkSzerzo.Text = "";
            kkCim.Text = "";
            kkKiad.Text = "";
        }

        private void OlvUj_Click(object sender, EventArgs e)
        {
            OlvAzon.Text = "";
            OlvNev.Text = "";
            OlvCim.Text = "";
            OlvKor.Text = "";
        }

        private void OlvFelvesz_Click(object sender, EventArgs e)
        {
            try
            {
                int azon = int.Parse(OlvAzon.Text);
                bool van = false; // van-e már ilyen azonosító
                for (int i = 0; i < OlvListBox.Items.Count; i++)
                {
                    int ezazazon = int.Parse(OlvListBox.Items[i].ToString().Substring(0, 4));
                    if (azon == ezazazon)
                    {
                        van = true;
                    }
                }
                if (!van && azon >= 1000 && azon <= 9999)
                {
                    // jó az azonosító
                    string sor = $"{azon}  :  {OlvNev.Text}  :  {OlvCim.Text}  :  {OlvKor.Text}";
                    OlvListBox.Items.Add(sor);
                    OlvAzon.Text = "";
                    OlvNev.Text = "";
                    OlvCim.Text = "";
                    OlvKor.Text = "";
                }
                else
                {
                    MessageBox.Show("Hibás azonosító!");
                    OlvAzon.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Hibás azonosító!");
                OlvAzon.Focus();
            }

        }

        private void OlvTorol_Click(object sender, EventArgs e)
        {
            if (OlvListBox.SelectedIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Valóban törlöd?", "Könyv törlése", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    OlvListBox.Items.RemoveAt(OlvListBox.SelectedIndex);
                    OlvAzon.Text = "";
                    OlvNev.Text = "";
                    OlvCim.Text = "";
                    OlvKor.Text = "";
                }
            }
        }

        private void OlvModosit_Click(object sender, EventArgs e)
        {
            if (OlvListBox.SelectedIndex != -1)
                try
                {
                    int azon = int.Parse(OlvAzon.Text);
                    bool van = false; // van-e másik!
                    for (int i = 0; i < OlvListBox.Items.Count; i++)
                    {
                        int ezazazon = int.Parse(OlvListBox.Items[i].ToString().Substring(0, 4));
                        if (azon == ezazazon && OlvListBox.SelectedIndex != i)
                        {
                            van = true;
                        }
                    }
                    if (!van && azon >= 1000 && azon <= 9999)
                    {
                        // jó az azonosító
                        string sor = $"{azon}  :  {OlvNev.Text}  :  {OlvCim.Text}  :  {OlvKor.Text}";
                        OlvListBox.Items[OlvListBox.SelectedIndex] = sor;
                    }
                    else
                    {
                        MessageBox.Show("Hibás azonosító!");
                        OlvAzon.Focus();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás azonosító!");
                    OlvAzon.Focus();
                }
        }

        private void OlvListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OlvListBox.SelectedIndex != -1)
            {
                string[] felDarab = OlvListBox.Items[OlvListBox.SelectedIndex].ToString().Split("  :  ");
                OlvAzon.Text = felDarab[0];
                OlvNev.Text = felDarab[1];
                OlvCim.Text = felDarab[2];
                OlvKor.Text = felDarab[3];
            }
        }

        private void kzksr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kzkKonyvValaszto_Enter(object sender, EventArgs e)
        {
            kzkKonyvValaszto.Items.Clear();
            for (int ki = 0; ki < kkListBox.Items.Count; ki++)
            {
                string sor = kkListBox.Items[ki].ToString();
                kzkKonyvValaszto.Items.Add(sor);
            }
        }

        private void kzkKonyvValaszto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kzkListBox.Items.Count > 0)
            {
                string sor = kzkKonyvValaszto.Items[kzkKonyvValaszto.SelectedIndex].ToString();
                string konyvAzon = sor.Substring(0, 4);

                int hol = 0;
                bool megvan = kzkListBox.Items[hol].ToString().Substring(0, 4) == konyvAzon;
                while (hol < kzkListBox.Items.Count && !megvan)
                {
                    hol++;
                    if (hol < kkListBox.Items.Count)
                    {
                        megvan = kkListBox.Items[hol].ToString().Substring(0, 4) == konyvAzon;
                    }
                }
                if (megvan)
                {

                    string kolcsAzon = kzkListBox.Items[hol].ToString().Substring(5, 4);

                    int holOlv = 0;
                    bool megvanOlv = OlvListBox.Items[holOlv].ToString().Substring(0, 4) == kolcsAzon;
                    while (holOlv < OlvListBox.Items.Count && !megvanOlv)
                    {
                        holOlv++;
                        if (holOlv < OlvListBox.Items.Count)
                        {
                            megvanOlv = OlvListBox.Items[holOlv].ToString().Substring(0, 4) == kolcsAzon;
                        }
                    }
                    string[] olvAdatai = OlvListBox.Items[holOlv].ToString().Split("  :  ");
                    kzkolvnev.Text = olvAdatai[1];
                    kzkmikortol.Text = kzkListBox.Items[hol].ToString().Substring(10, 10);
                    kzkmeddig.Text = kzkListBox.Items[hol].ToString().Substring(21, 10);
                }
                else
                {
                    kzkolvnev.Text = "";
                    kzkmikortol.Text = "";
                    kzkmeddig.Text = "";
                }
            }
            else
            {
                kzkolvnev.Text = "";
                kzkmikortol.Text = "";
                kzkmeddig.Text = "";
            }
        }
    }
}
