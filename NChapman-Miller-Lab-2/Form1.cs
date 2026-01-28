using Microsoft.VisualBasic;
/*
* Nicholas Chapman-Miller
* CPT 185 - A01H
* Lab 2
 */
namespace NChapman_Miller_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Six of Diamonds";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Ace of Spades";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Five of Hearts";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("***** THANK YOU *****");
            this.Close();
          
        }

        private void picBoxKingClub_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "King of Clubs";
        }

        private void picBoxTenDia_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Ten of Diamonds";

        }
    }
}
