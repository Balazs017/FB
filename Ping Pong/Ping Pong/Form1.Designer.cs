namespace Ping_Pong
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Labda = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Jobbuto = new PictureBox();
            Baluto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Labda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Jobbuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Baluto).BeginInit();
            SuspendLayout();
            // 
            // Labda
            // 
            Labda.Image = Properties.Resources.football;
            Labda.Location = new Point(377, 138);
            Labda.Name = "Labda";
            Labda.Size = new Size(54, 67);
            Labda.SizeMode = PictureBoxSizeMode.StretchImage;
            Labda.TabIndex = 1;
            Labda.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Jobbuto
            // 
            Jobbuto.Image = (Image)resources.GetObject("Jobbuto.Image");
            Jobbuto.Location = new Point(726, 226);
            Jobbuto.Name = "Jobbuto";
            Jobbuto.Size = new Size(71, 108);
            Jobbuto.SizeMode = PictureBoxSizeMode.StretchImage;
            Jobbuto.TabIndex = 2;
            Jobbuto.TabStop = false;
            Jobbuto.Click += Jobbütő_Click;
            // 
            // Baluto
            // 
            Baluto.Image = (Image)resources.GetObject("Baluto.Image");
            Baluto.Location = new Point(12, 226);
            Baluto.Name = "Baluto";
            Baluto.Size = new Size(54, 111);
            Baluto.SizeMode = PictureBoxSizeMode.StretchImage;
            Baluto.TabIndex = 3;
            Baluto.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Baluto);
            Controls.Add(Jobbuto);
            Controls.Add(Labda);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PreviewKeyDown += Form1_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)Labda).EndInit();
            ((System.ComponentModel.ISupportInitialize)Jobbuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Baluto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox Labda;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Jobbuto;
        private PictureBox Baluto;
    }
}
