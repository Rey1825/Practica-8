using System;

namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            textBox2.Text = area1.ToString();
            textBox3.Text = volumen1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double base1, altura1, area1;

            base1 = double.Parse(textBox4.Text);
            altura1 = double.Parse(textBox5.Text);
            area1 = (base1 * altura1) / 2;
            textBox6.Text = area1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double lado1, area1, volumen1;
            lado1 = double.Parse(textBox7.Text);
            area1 = 6 * (Math.Pow(lado1, 2));
            volumen1 = Math.Pow(lado1, 3);
            textBox8.Text = area1.ToString();
            textBox9.Text = volumen1.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, altura1, area1, volumen1;
            radio1 = double.Parse(textBox10.Text);
            altura1 = double.Parse(textBox11.Text);
            area1 = (2 * pi * radio1 * altura1) + (2 * pi * (Math.Pow(radio1, 2)));
            volumen1 = (pi * (Math.Pow(radio1, 2) * altura1));
            textBox12.Text = area1.ToString();
            textBox13.Text = volumen1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double Diagonal1, Diagonal2, area1;
            Diagonal1 = double.Parse(textBox14.Text);
            Diagonal2 = double.Parse(textBox15.Text);
            area1 = (Diagonal1 * Diagonal2) / 2;
            textBox16.Text = area1.ToString();

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox16.Text = " ";
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double lado1, area1, volumen1;
            double raiz1, potencia1, raiz2, potencia2;
            lado1 = double.Parse(textBox17.Text);
            raiz1 = 1.73205080757;
            potencia1 = Math.Pow(lado1, 2);
            raiz2 = 1.41421356237;
            potencia2 = Math.Pow(lado1,3);
            area1 = 2 * raiz1 * potencia1;
            volumen1 = (raiz2 / 3) * potencia2;
            textBox18.Text = area1.ToString();
            textBox19.Text = volumen1.ToString();

        }
    }
}