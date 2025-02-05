namespace Mozgo_kacsak
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
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Gomb";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(347, 73);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AccessibleName = "Röpködő Kacsak";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1413, 634);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
    }
}
