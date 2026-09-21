namespace gyak2_2
{
    public partial class Form1 : Form
    {

        List<string> gyümölcsök = new List<string> { "alma", "banán", "cseresznye", "dinnye", "eper" };
        List<int> árak = new List<int> { 100, 200, 300, 400, 500 };

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < gyümölcsök.Count; i++)
            {
                Button button = new Button();
                button.Text = gyümölcsök[i] + ", " + árak[i];
                button.Size = new System.Drawing.Size(100, 100);
                button.Click += anyButton_click;
                flowLayoutPanel1.Controls.Add(button);
            }

        }

        private void anyButton_click( object sender, EventArgs e )
        {
            string név = ((Button)sender).Text.Split(", ")[0];
            if (int.TryParse((sender as Button).Text.Split(", ")[1], out int egységár))
            {
                textBox_ar.Text = egységár.ToString();
            }
            else
            {
                MessageBox.Show("Hiba történt az egységár beolvasása közben");
            }
        }
    }
}
