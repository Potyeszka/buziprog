namespace gyak2_2
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox_nev = new TextBox();
            label1 = new Label();
            label_ar = new Label();
            textBox_ar = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(795, 162);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox_nev
            // 
            textBox_nev.Location = new Point(107, 269);
            textBox_nev.Name = "textBox_nev";
            textBox_nev.ReadOnly = true;
            textBox_nev.Size = new Size(100, 23);
            textBox_nev.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 272);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Név";
            // 
            // label_ar
            // 
            label_ar.AutoSize = true;
            label_ar.Location = new Point(327, 275);
            label_ar.Name = "label_ar";
            label_ar.Size = new Size(19, 15);
            label_ar.TabIndex = 4;
            label_ar.Text = "Ár";
            // 
            // textBox_ar
            // 
            textBox_ar.Location = new Point(361, 272);
            textBox_ar.Name = "textBox_ar";
            textBox_ar.ReadOnly = true;
            textBox_ar.Size = new Size(100, 23);
            textBox_ar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 353);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "Név";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 350);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 353);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "Név";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 350);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label_ar);
            Controls.Add(textBox_ar);
            Controls.Add(label1);
            Controls.Add(textBox_nev);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox_nev;
        private Label label1;
        private Label label_ar;
        private TextBox textBox_ar;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
    }
}
