using System.Windows.Forms.VisualStyles;

namespace premierekenen
{
    public partial class PremieRekenen : Form
    {
        public PremieRekenen()
        {
            InitializeComponent();
            comboBox1.MouseEnter += new EventHandler(comboBox1_MouseEnter);
            comboBox1.MouseLeave += new EventHandler(comboBox1_MouseLeave);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Voer aub alle velden in.");
                return; // Stop further execution
            }
            if (!double.TryParse(korting.Text.Trim('%'), out double kortingValue) ||
           !double.TryParse(textBox2.Text, out double eigendomswaarde))
                {
                    MessageBox.Show("voer een getal in bij eigendomswaarde.");
                    return;
                }
            if (radioButton1.Checked) { 
               
                double brutoresult = 100.00 + (eigendomswaarde * 0.03);
                double nettoresult = brutoresult * ((100 - kortingValue) / 100);
                string typeverzeker = "Type verzekering: Autoverzekering";
                listBox1.Items.Clear();
                listBox1.Items.Add(typeverzeker);
                listBox1.Items.Add("Brutoprijs:" +" " + brutoresult.ToString("F2"));
                listBox1.Items.Add("Nettoprijs:" + " " + nettoresult.ToString("F2"));


            }
            else if (radioButton2.Checked == true)
            {
             
                double brutoresult = 150.00 + (eigendomswaarde * 0.01);
                double nettoresult = brutoresult * ((100 - kortingValue) / 100);
                string typeverzeker = "Type verzekering: Huisverzekering";
                listBox1.Items.Clear();
                listBox1.Items.Add(typeverzeker);
                listBox1.Items.Add("Brutoprijs:" + " " + brutoresult.ToString("F2"));
                listBox1.Items.Add("Nettoprijs:" + " " + nettoresult.ToString("F2"));
            }
            else if (radioButton3.Checked == true)
                {
               
                double brutoresult = 100.00 + (eigendomswaarde * 0.001);
                double nettoresult = brutoresult * ((100 - kortingValue) / 100);
                string typeverzeker = "Type verzekering: Inboedelverzekering";
                listBox1.Items.Clear();
                listBox1.Items.Add(typeverzeker);
                listBox1.Items.Add("Brutoprijs:" + " " + brutoresult.ToString("F2"));
                listBox1.Items.Add("Nettoprijs:" + " " + nettoresult.ToString("F2"));

            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindex = comboBox1.SelectedIndex;
            switch (selectedindex)
            {
                case 0:
                    korting.Text = "25%";
                    break;
                case 1:
                    korting.Text = "10%";
                    break;
                case 2:
                    korting.Text = "15%";
                    break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox2.Visible = true;
        }
        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox2.Visible=false;
        }
    }
}
