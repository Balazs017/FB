namespace Konyvtar1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            kkUj = new Button();
            kkTorol = new Button();
            kkModosit = new Button();
            kkFelvesz = new Button();
            kkKiad = new TextBox();
            label4 = new Label();
            kkCim = new TextBox();
            label3 = new Label();
            kkSzerzo = new TextBox();
            label2 = new Label();
            KKAzon = new TextBox();
            label1 = new Label();
            kkListBox = new ListBox();
            tabPage2 = new TabPage();
            OlvUj = new Button();
            OlvTorol = new Button();
            OlvModosit = new Button();
            OlvFelvesz = new Button();
            OlvKor = new TextBox();
            label77 = new Label();
            OlvCim = new TextBox();
            label6 = new Label();
            OlvNev = new TextBox();
            label45 = new Label();
            OlvAzon = new TextBox();
            label8 = new Label();
            OlvListBox = new ListBox();
            tabPage3 = new TabPage();
            kzkmeddig = new TextBox();
            kzkMeddigLabel = new Label();
            kzkmikortol = new TextBox();
            kzkMikortolLabel = new Label();
            kzkolvnev = new TextBox();
            label7 = new Label();
            label5 = new Label();
            kzkKonyvValaszto = new ComboBox();
            kzkListBox = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 325);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(kkUj);
            tabPage1.Controls.Add(kkTorol);
            tabPage1.Controls.Add(kkModosit);
            tabPage1.Controls.Add(kkFelvesz);
            tabPage1.Controls.Add(kkKiad);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(kkCim);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(kkSzerzo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(KKAzon);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(kkListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(671, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Könyvek";
            // 
            // kkUj
            // 
            kkUj.Location = new Point(568, 271);
            kkUj.Margin = new Padding(2);
            kkUj.Name = "kkUj";
            kkUj.Size = new Size(85, 20);
            kkUj.TabIndex = 12;
            kkUj.Text = "Új könyv";
            kkUj.UseVisualStyleBackColor = true;
            kkUj.Click += kkUj_Click;
            // 
            // kkTorol
            // 
            kkTorol.Location = new Point(568, 143);
            kkTorol.Margin = new Padding(2);
            kkTorol.Name = "kkTorol";
            kkTorol.Size = new Size(78, 20);
            kkTorol.TabIndex = 11;
            kkTorol.Text = "Töröl";
            kkTorol.UseVisualStyleBackColor = true;
            kkTorol.Click += kkTorol_Click;
            // 
            // kkModosit
            // 
            kkModosit.Location = new Point(568, 81);
            kkModosit.Margin = new Padding(2);
            kkModosit.Name = "kkModosit";
            kkModosit.Size = new Size(78, 20);
            kkModosit.TabIndex = 10;
            kkModosit.Text = "Módosít";
            kkModosit.UseVisualStyleBackColor = true;
            kkModosit.Click += kkModosit_Click;
            // 
            // kkFelvesz
            // 
            kkFelvesz.Location = new Point(568, 204);
            kkFelvesz.Margin = new Padding(3, 2, 3, 2);
            kkFelvesz.Name = "kkFelvesz";
            kkFelvesz.Size = new Size(85, 25);
            kkFelvesz.TabIndex = 9;
            kkFelvesz.Text = "Felvesz";
            kkFelvesz.UseVisualStyleBackColor = true;
            kkFelvesz.Click += kkFelvesz_Click;
            // 
            // kkKiad
            // 
            kkKiad.Location = new Point(484, 272);
            kkKiad.Margin = new Padding(3, 2, 3, 2);
            kkKiad.Name = "kkKiad";
            kkKiad.Size = new Size(68, 23);
            kkKiad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 255);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Kiadás éve";
            // 
            // kkCim
            // 
            kkCim.Location = new Point(277, 272);
            kkCim.Margin = new Padding(3, 2, 3, 2);
            kkCim.Name = "kkCim";
            kkCim.Size = new Size(203, 23);
            kkCim.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 255);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Cím";
            // 
            // kkSzerzo
            // 
            kkSzerzo.Location = new Point(81, 272);
            kkSzerzo.Margin = new Padding(3, 2, 3, 2);
            kkSzerzo.Name = "kkSzerzo";
            kkSzerzo.Size = new Size(192, 23);
            kkSzerzo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 255);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Szerző";
            // 
            // KKAzon
            // 
            KKAzon.Location = new Point(8, 272);
            KKAzon.Margin = new Padding(3, 2, 3, 2);
            KKAzon.Name = "KKAzon";
            KKAzon.Size = new Size(68, 23);
            KKAzon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 255);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Azonosító";
            // 
            // kkListBox
            // 
            kkListBox.FormattingEnabled = true;
            kkListBox.ItemHeight = 15;
            kkListBox.Location = new Point(6, 10);
            kkListBox.Margin = new Padding(3, 2, 3, 2);
            kkListBox.Name = "kkListBox";
            kkListBox.Size = new Size(546, 244);
            kkListBox.TabIndex = 0;
            kkListBox.SelectedIndexChanged += kkListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.Controls.Add(OlvUj);
            tabPage2.Controls.Add(OlvTorol);
            tabPage2.Controls.Add(OlvModosit);
            tabPage2.Controls.Add(OlvFelvesz);
            tabPage2.Controls.Add(OlvKor);
            tabPage2.Controls.Add(label77);
            tabPage2.Controls.Add(OlvCim);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(OlvNev);
            tabPage2.Controls.Add(label45);
            tabPage2.Controls.Add(OlvAzon);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(OlvListBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(671, 297);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Olvasók";
            // 
            // OlvUj
            // 
            OlvUj.Location = new Point(576, 271);
            OlvUj.Margin = new Padding(2);
            OlvUj.Name = "OlvUj";
            OlvUj.Size = new Size(85, 20);
            OlvUj.TabIndex = 25;
            OlvUj.Text = "Új olvasó";
            OlvUj.UseVisualStyleBackColor = true;
            OlvUj.Click += OlvUj_Click;
            // 
            // OlvTorol
            // 
            OlvTorol.Location = new Point(576, 143);
            OlvTorol.Margin = new Padding(2);
            OlvTorol.Name = "OlvTorol";
            OlvTorol.Size = new Size(78, 20);
            OlvTorol.TabIndex = 24;
            OlvTorol.Text = "Töröl";
            OlvTorol.UseVisualStyleBackColor = true;
            OlvTorol.Click += OlvTorol_Click;
            // 
            // OlvModosit
            // 
            OlvModosit.Location = new Point(576, 82);
            OlvModosit.Margin = new Padding(2);
            OlvModosit.Name = "OlvModosit";
            OlvModosit.Size = new Size(78, 20);
            OlvModosit.TabIndex = 23;
            OlvModosit.Text = "Módosít";
            OlvModosit.UseVisualStyleBackColor = true;
            OlvModosit.Click += OlvModosit_Click;
            // 
            // OlvFelvesz
            // 
            OlvFelvesz.Location = new Point(576, 205);
            OlvFelvesz.Margin = new Padding(3, 2, 3, 2);
            OlvFelvesz.Name = "OlvFelvesz";
            OlvFelvesz.Size = new Size(85, 25);
            OlvFelvesz.TabIndex = 22;
            OlvFelvesz.Text = "Felvesz";
            OlvFelvesz.UseVisualStyleBackColor = true;
            OlvFelvesz.Click += OlvFelvesz_Click;
            // 
            // OlvKor
            // 
            OlvKor.Location = new Point(492, 273);
            OlvKor.Margin = new Padding(3, 2, 3, 2);
            OlvKor.Name = "OlvKor";
            OlvKor.Size = new Size(68, 23);
            OlvKor.TabIndex = 21;
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.Location = new Point(492, 256);
            label77.Name = "label77";
            label77.Size = new Size(25, 15);
            label77.TabIndex = 20;
            label77.Text = "Kor";
            // 
            // OlvCim
            // 
            OlvCim.Location = new Point(285, 273);
            OlvCim.Margin = new Padding(3, 2, 3, 2);
            OlvCim.Name = "OlvCim";
            OlvCim.Size = new Size(203, 23);
            OlvCim.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 256);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 18;
            label6.Text = "Olvasó címe";
            // 
            // OlvNev
            // 
            OlvNev.Location = new Point(89, 273);
            OlvNev.Margin = new Padding(3, 2, 3, 2);
            OlvNev.Name = "OlvNev";
            OlvNev.Size = new Size(192, 23);
            OlvNev.TabIndex = 17;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(89, 256);
            label45.Name = "label45";
            label45.Size = new Size(71, 15);
            label45.TabIndex = 16;
            label45.Text = "Olvasó neve";
            // 
            // OlvAzon
            // 
            OlvAzon.Location = new Point(15, 273);
            OlvAzon.Margin = new Padding(3, 2, 3, 2);
            OlvAzon.Name = "OlvAzon";
            OlvAzon.Size = new Size(68, 23);
            OlvAzon.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 256);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 14;
            label8.Text = "Azonosító";
            // 
            // OlvListBox
            // 
            OlvListBox.FormattingEnabled = true;
            OlvListBox.ItemHeight = 15;
            OlvListBox.Location = new Point(13, 10);
            OlvListBox.Margin = new Padding(3, 2, 3, 2);
            OlvListBox.Name = "OlvListBox";
            OlvListBox.Size = new Size(546, 244);
            OlvListBox.TabIndex = 13;
            OlvListBox.SelectedIndexChanged += OlvListBox_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.SeaShell;
            tabPage3.Controls.Add(kzkmeddig);
            tabPage3.Controls.Add(kzkMeddigLabel);
            tabPage3.Controls.Add(kzkmikortol);
            tabPage3.Controls.Add(kzkMikortolLabel);
            tabPage3.Controls.Add(kzkolvnev);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(kzkKonyvValaszto);
            tabPage3.Controls.Add(kzkListBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(671, 297);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kölcsönzések";
            // 
            // kzkmeddig
            // 
            kzkmeddig.Location = new Point(559, 104);
            kzkmeddig.Margin = new Padding(3, 2, 3, 2);
            kzkmeddig.Name = "kzkmeddig";
            kzkmeddig.Size = new Size(81, 23);
            kzkmeddig.TabIndex = 12;
            // 
            // kzkMeddigLabel
            // 
            kzkMeddigLabel.AutoSize = true;
            kzkMeddigLabel.Location = new Point(559, 87);
            kzkMeddigLabel.Name = "kzkMeddigLabel";
            kzkMeddigLabel.Size = new Size(51, 15);
            kzkMeddigLabel.TabIndex = 11;
            kzkMeddigLabel.Text = "Meddig:";
            // 
            // kzkmikortol
            // 
            kzkmikortol.Location = new Point(465, 104);
            kzkmikortol.Margin = new Padding(3, 2, 3, 2);
            kzkmikortol.Name = "kzkmikortol";
            kzkmikortol.Size = new Size(78, 23);
            kzkmikortol.TabIndex = 10;
            // 
            // kzkMikortolLabel
            // 
            kzkMikortolLabel.AutoSize = true;
            kzkMikortolLabel.Location = new Point(462, 87);
            kzkMikortolLabel.Name = "kzkMikortolLabel";
            kzkMikortolLabel.Size = new Size(55, 15);
            kzkMikortolLabel.TabIndex = 9;
            kzkMikortolLabel.Text = "Mikortól:";
            // 
            // kzkolvnev
            // 
            kzkolvnev.Location = new Point(338, 104);
            kzkolvnev.Margin = new Padding(3, 2, 3, 2);
            kzkolvnev.Name = "kzkolvnev";
            kzkolvnev.Size = new Size(113, 23);
            kzkolvnev.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 87);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 7;
            label7.Text = "Olvasó neve:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 11);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 2;
            label5.Text = "Kölcsönözve:";
            // 
            // kzkKonyvValaszto
            // 
            kzkKonyvValaszto.FormattingEnabled = true;
            kzkKonyvValaszto.Location = new Point(400, 29);
            kzkKonyvValaszto.Name = "kzkKonyvValaszto";
            kzkKonyvValaszto.Size = new Size(249, 23);
            kzkKonyvValaszto.TabIndex = 1;
            kzkKonyvValaszto.SelectedIndexChanged += kzkKonyvValaszto_SelectedIndexChanged;
            kzkKonyvValaszto.Enter += kzkKonyvValaszto_Enter;
            // 
            // kzkListBox
            // 
            kzkListBox.FormattingEnabled = true;
            kzkListBox.ItemHeight = 15;
            kzkListBox.Location = new Point(3, 7);
            kzkListBox.Name = "kzkListBox";
            kzkListBox.Size = new Size(309, 184);
            kzkListBox.TabIndex = 0;
            kzkListBox.SelectedIndexChanged += kzksr_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 343);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Könyvtár";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox kkListBox;
        private TextBox KKAzon;
        private Label label1;
        private Button kkFelvesz;
        private TextBox kkKiad;
        private Label label4;
        private TextBox kkCim;
        private Label label3;
        private TextBox kkSzerzo;
        private Label label2;
        private Button kkTorol;
        private Button kkModosit;
        private Button kkUj;
        private Button OlvUj;
        private Button OlvTorol;
        private Button OlvModosit;
        private Button OlvFelvesz;
        private TextBox OlvKor;
        private Label label77;
        private TextBox OlvCim;
        private Label label6;
        private TextBox OlvNev;
        private Label label45;
        private TextBox OlvAzon;
        private Label label8;
        private ListBox OlvListBox;
        private ListBox kzkListBox;
        private Label label5;
        private ComboBox kzkKonyvValaszto;
        private TextBox kzkmeddig;
        private Label kzkMeddigLabel;
        private TextBox kzkmikortol;
        private Label kzkMikortolLabel;
        private TextBox kzkolvnev;
        private Label label7;
    }
}
