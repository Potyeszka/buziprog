namespace gyak2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button_alma = new Button();
            button_barack = new Button();
            button_banan = new Button();
            button_narancs = new Button();
            textBox_nev = new TextBox();
            label_nev = new Label();
            label_egyseg = new Label();
            textBox_egyseg = new TextBox();
            label1 = new Label();
            textBox_suj = new TextBox();
            label2 = new Label();
            textBox_fizetendo = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button_alma);
            flowLayoutPanel1.Controls.Add(button_barack);
            flowLayoutPanel1.Controls.Add(button_banan);
            flowLayoutPanel1.Controls.Add(button_narancs);
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(798, 151);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button_alma
            // 
            button_alma.BackgroundImage = (Image)resources.GetObject("button_alma.BackgroundImage");
            button_alma.BackgroundImageLayout = ImageLayout.Stretch;
            button_alma.Font = new Font("Segoe UI", 14F);
            button_alma.Location = new Point(3, 3);
            button_alma.Name = "button_alma";
            button_alma.Size = new Size(145, 148);
            button_alma.TabIndex = 0;
            button_alma.Text = "Alma 500";
            button_alma.UseVisualStyleBackColor = true;
            button_alma.Click += button_alma_Click;
            // 
            // button_barack
            // 
            button_barack.BackgroundImage = (Image)resources.GetObject("button_barack.BackgroundImage");
            button_barack.BackgroundImageLayout = ImageLayout.Stretch;
            button_barack.Font = new Font("Segoe UI", 14F);
            button_barack.Location = new Point(154, 3);
            button_barack.Name = "button_barack";
            button_barack.Size = new Size(145, 148);
            button_barack.TabIndex = 2;
            button_barack.Text = "Alma 500";
            button_barack.UseVisualStyleBackColor = true;
            // 
            // button_banan
            // 
            button_banan.BackgroundImage = (Image)resources.GetObject("button_banan.BackgroundImage");
            button_banan.BackgroundImageLayout = ImageLayout.Stretch;
            button_banan.Font = new Font("Segoe UI", 14F);
            button_banan.Location = new Point(305, 3);
            button_banan.Name = "button_banan";
            button_banan.Size = new Size(145, 148);
            button_banan.TabIndex = 3;
            button_banan.Text = "Alma 500";
            button_banan.UseVisualStyleBackColor = true;
            // 
            // button_narancs
            // 
            button_narancs.BackgroundImage = (Image)resources.GetObject("button_narancs.BackgroundImage");
            button_narancs.BackgroundImageLayout = ImageLayout.Stretch;
            button_narancs.Font = new Font("Segoe UI", 14F);
            button_narancs.Location = new Point(456, 3);
            button_narancs.Name = "button_narancs";
            button_narancs.Size = new Size(145, 148);
            button_narancs.TabIndex = 1;
            button_narancs.Text = "Alma 500";
            button_narancs.UseVisualStyleBackColor = true;
            // 
            // textBox_nev
            // 
            textBox_nev.Location = new Point(167, 220);
            textBox_nev.Name = "textBox_nev";
            textBox_nev.ReadOnly = true;
            textBox_nev.Size = new Size(100, 23);
            textBox_nev.TabIndex = 2;
            // 
            // label_nev
            // 
            label_nev.AutoSize = true;
            label_nev.ForeColor = SystemColors.ControlText;
            label_nev.Location = new Point(123, 223);
            label_nev.Name = "label_nev";
            label_nev.Size = new Size(31, 15);
            label_nev.TabIndex = 3;
            label_nev.Text = "Név:";
            label_nev.Click += label1_Click;
            // 
            // label_egyseg
            // 
            label_egyseg.AutoSize = true;
            label_egyseg.ForeColor = SystemColors.ControlText;
            label_egyseg.Location = new Point(393, 226);
            label_egyseg.Name = "label_egyseg";
            label_egyseg.Size = new Size(57, 15);
            label_egyseg.TabIndex = 5;
            label_egyseg.Text = "Egységár:";
            // 
            // textBox_egyseg
            // 
            textBox_egyseg.Location = new Point(456, 223);
            textBox_egyseg.Name = "textBox_egyseg";
            textBox_egyseg.ReadOnly = true;
            textBox_egyseg.Size = new Size(100, 23);
            textBox_egyseg.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(123, 305);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "Súly:";
            // 
            // textBox_suj
            // 
            textBox_suj.Location = new Point(167, 302);
            textBox_suj.Name = "textBox_suj";
            textBox_suj.Size = new Size(100, 23);
            textBox_suj.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(393, 300);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Fizetendő:";
            // 
            // textBox_fizetendo
            // 
            textBox_fizetendo.Location = new Point(456, 297);
            textBox_fizetendo.Name = "textBox_fizetendo";
            textBox_fizetendo.ReadOnly = true;
            textBox_fizetendo.Size = new Size(100, 23);
            textBox_fizetendo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox_fizetendo);
            Controls.Add(label1);
            Controls.Add(textBox_suj);
            Controls.Add(label_egyseg);
            Controls.Add(textBox_egyseg);
            Controls.Add(label_nev);
            Controls.Add(textBox_nev);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button_alma;
        private Button button_barack;
        private Button button_banan;
        private Button button_narancs;
        private TextBox textBox_nev;
        private Label label_nev;
        private Label label_egyseg;
        private TextBox textBox_egyseg;
        private Label label1;
        private TextBox textBox_suj;
        private Label label2;
        private TextBox textBox_fizetendo;
    }
}
