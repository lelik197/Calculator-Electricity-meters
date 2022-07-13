namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string T1 = textBox1.Text;
            string T11 = textBox2.Text;
            double T111 = Convert.ToDouble(T1);
            double TT1 = Convert.ToDouble(T11);
            double Tres1 = T111 - TT1;
            textBox3.Text = Tres1.ToString();

            string T2 = textBox4.Text;
            string T22 = textBox5.Text;
            double T222 = Convert.ToDouble(T2);
            double TT2 = Convert.ToDouble(T22);
            double Tres2 = T222 - TT2;
            textBox6.Text = Tres2.ToString();

            string T3 = textBox7.Text;
            string T33 = textBox8.Text;
            double T333 = Convert.ToDouble(T3);
            double TT3 = Convert.ToDouble(T33);
            double Tres3 = T333 - TT3;
            textBox9.Text = Tres3.ToString();
            //Цена T1
            double r1 = Tres1 * 7.40;
            textBox10.Text = r1.ToString();
            //Цена T2
            double r2 = Tres2 * 2.69;
            textBox11.Text = r2.ToString();
            //Цена T3
            double r3 = Tres3 * 6.17;
            textBox12.Text = r3.ToString();

            double s = Tres1 + Tres2 + Tres3;
            textBox13.Text = s.ToString();

            double R = r1 + r2 + r3;
            textBox14.Text = R.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}