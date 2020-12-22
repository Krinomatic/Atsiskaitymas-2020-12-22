using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atsiskaitymas_2020_12_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] Masyvas = new int[10];
        public int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10)
                if (int.TryParse(textBox1.Text, out int isNumber))
                {
                    Masyvas[i] = isNumber;
                    listBox1.Items.Add(textBox1.Text);
                    i++;
                }
                else
                    MessageBox.Show($"Ivestas ne numeris, prašome patvarkyti įvedimą");
            else
                MessageBox.Show($"Pilnas sarąšas, prašome jį išvalyti, arba atlikti sumavimą");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (i < 10)
            {
                MessageBox.Show("Iveskite daugiau skaičių, kad galėtumėt atlikt sumavimą");
            }
            else
            {
                int i = 0, result = 0;
                while (i < listBox1.Items.Count)
                {
                    result += Convert.ToInt32(((string)listBox1.Items[i++]).Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries)[0]);
                }
                richTextBox1.Text = "Atsakymas yra: " + result;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int eilute; int q = 0; int asterix = 1; int tarpas;
            if (Int32.TryParse(textBox2.Text, out eilute) && eilute > 0)
            {
                richTextBox1.Text += ('\n');
                tarpas = eilute;
                do
                {
                    for (int i = 1; i < tarpas; i++)
                    {
                        richTextBox2.Text += (" ");
                    }
                    for (int i = 0; i < asterix; i++)
                    {
                        richTextBox2.Text += ("* ");
                    }
                    richTextBox2.Text += ("\n");
                    tarpas--; asterix++; q++;
                } while (q < eilute);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
