namespace gyak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_alma_Click(object sender, EventArgs e)
        {
            string név = (sender as Button).Text.Split(", ")[0];
            textBox_nev.Text = név;
            if(int.TryParse((sender as Button).Text.Split(", ")[1], out int egységár))
            {
                textBox_egyseg.Text = egységár.ToString();
            }
            else
            {
                MessageBox.Show("Hiba az egységár beolvasásakor");
            }
            if (double.TryParse(textBox_suj.Text , out double suly))
            {
                textBox_fizetendo.Text = (suly * egységár).ToString();
            }
            else
            {
                MessageBox.Show("Hiba az súly beolvasásakor");
            }
        }
    }
}
