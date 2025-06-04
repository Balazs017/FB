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

            foreach (var item in OlvListBox.Items)
            {
                kzkolvasov.Items.Add(item);
            }
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

            StreamWriter kzksr = new StreamWriter(@"..\..\..\kolcsonzes.txt");
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
                    if (hol < kzkListBox.Items.Count)
                    {
                        megvan = kzkListBox.Items[hol].ToString().Substring(0, 4) == konyvAzon;
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

        private void visszavetel_Click(object sender, EventArgs e)
        {
            if (kzkKonyvValaszto.SelectedIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Biztosan visszaveszed a könyvet?", "Visszavétel megerõsítése", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
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
                            if (hol < kzkListBox.Items.Count)
                            {
                                megvan = kzkListBox.Items[hol].ToString().Substring(0, 4) == konyvAzon;
                            }
                        }

                        kzkListBox.Items.RemoveAt(hol);
                        kzkolvnev.Text = "";
                        kzkmikortol.Text = "";
                        kzkmeddig.Text = "";
                    }

                }
            }

        }

        private void meghosszabit_Click(object sender, EventArgs e)
        {
            if (kzkKonyvValaszto.SelectedIndex < 0)
                return;

            string kivalasztottSor = kzkKonyvValaszto.Items[kzkKonyvValaszto.SelectedIndex].ToString();

            string konyvAzon = kivalasztottSor.Substring(0, 4);

            int index = -1;
            for (int i = 0; i < kzkListBox.Items.Count; i++)
            {
                string sor = kzkListBox.Items[i].ToString();
                string[] mezok = sor.Split(';');
                if (mezok.Length >= 4 && mezok[0] == konyvAzon)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                MessageBox.Show("Nem található kölcsönzés a kiválasztott könyvhöz.");
                return;
            }

            string eredetiSor = kzkListBox.Items[index].ToString();
            string[] mezokSor = eredetiSor.Split(';');

            string datumStr = mezokSor[3].Trim();
            string[] parts = datumStr.Split('-');

            if (parts.Length != 3)
            {
                MessageBox.Show("Nem megfelelõ formátumú 'meddig' dátum!");
                return;
            }

            int ev, ho, nap;
            if (!int.TryParse(parts[0], out ev) || !int.TryParse(parts[1], out ho) || !int.TryParse(parts[2], out nap))
            {
                MessageBox.Show("A 'meddig' dátum nem értelmezhetõ!");
                return;
            }


            bool szokoev(int year)
            {
                if (year % 400 == 0) return true;
                if (year % 100 == 0) return false;
                if (year % 4 == 0) return true;
                return false;
            }

            int[] honapNapjai = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            nap += 10;

            while (true)
            {
                int maxNap = honapNapjai[ho - 1];
                if (ho == 2 && szokoev(ev))
                    maxNap = 29;

                if (nap > maxNap)
                {
                    nap -= maxNap;
                    ho++;
                    if (ho > 12)
                    {
                        ho = 1;
                        ev++;
                    }
                }
                else
                {
                    break;
                }
            }

            string ujDatum = $"{ev:D4}-{ho:D2}-{nap:D2}";
            mezokSor[3] = ujDatum;

            string ujSor = string.Join(";", mezokSor);

            kzkListBox.Items[index] = ujSor;

            kzkmeddig.Text = ujDatum;
        }

        private void kolcsonzes_Click(object sender, EventArgs e)
        {

            

            if (kzkKonyvValaszto.SelectedIndex < 0 || kzkolvasov.SelectedIndex < 0)

                return;

            string konyvSor = kzkKonyvValaszto.Items[kzkKonyvValaszto.SelectedIndex].ToString();

            string konyvAzon = konyvSor.Substring(0, 4);

            string olvasoSor = kzkolvasov.Items[kzkolvasov.SelectedIndex].ToString();

            string olvasoAzon = olvasoSor.Substring(0, 4);

            DateTime mettol = DateTime.Today;

            DateTime meddig = mettol.AddDays(14);

            string mettolStr = mettol.ToString("yyyy-MM-dd");

            string meddigStr = meddig.ToString("yyyy-MM-dd");

            string ujKolcsonzes = $"{konyvAzon};{olvasoAzon};{mettolStr};{meddigStr}";

            kzkListBox.Items.Add(ujKolcsonzes);

            kzkolvnev.Text = "";

            kzkmikortol.Text = mettolStr;

            kzkmeddig.Text = meddigStr;

        }
 

        

        private void kzkolvasov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
