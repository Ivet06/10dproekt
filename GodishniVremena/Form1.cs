namespace GodishniVremena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            string picturel1 = "Zima.jpg";
            string picturel2 = "Prolet.jpg";
            string picturel3 = "Lqto.jpg";
            string picturel4 = "Zima.jpg";
            switch (month)
            {   case 12:
                case 1:
                case 2:
                label3.Text= "Зима е";
                pictureBox1.ImageLocation = picturel1;
                break;

                case 3:
                case 4:
                case 5:
                label3.Text = "Пролет е";
                pictureBox1.ImageLocation = picturel2;
                break;

                case 6:
                case 7:
                case 8:
                label3.Text = "Лято е";
                pictureBox1.ImageLocation = picturel2;
                break;

                case 9:
                case 10:
                case 11:
                label3.Text = "Есен е";
                pictureBox1.ImageLocation = picturel2;
                break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string picturel5 = "Obshta.jpg";
            textBox1.Text = "";
            label3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}