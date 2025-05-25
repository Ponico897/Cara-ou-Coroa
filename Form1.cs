namespace Cara_ou_corôa
{
    public partial class Form1 : Form
    {
        // Matriz de moedas

        Moeda[] moedas = new Moeda[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < moedas.Length; i++)
            {
                // Cria uma nova moeda com cara ou coroa
                moedas[i] = new Moeda(false);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            label1.Text = "";
            for (int i = 0; i < moedas.Length; i++)
            {
                moedas[i].CaraOuCoroa(r); // Sorteia primeiro
                label1.Text += moedas[i].isCaras ? "Cara, " : "Corôa, ";// Depois mostra o resultado
            }

            pictureBox1.Image = moedas[0].isCaras ? Properties.Resources.Cara : Properties.Resources.Corôa;
            pictureBox2.Image = moedas[1].isCaras ? Properties.Resources.Cara : Properties.Resources.Corôa;
            pictureBox3.Image = moedas[2].isCaras ? Properties.Resources.Cara : Properties.Resources.Corôa;
            pictureBox4.Image = moedas[3].isCaras ? Properties.Resources.Cara : Properties.Resources.Corôa;
            pictureBox5.Image = moedas[4].isCaras ? Properties.Resources.Cara : Properties.Resources.Corôa;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}