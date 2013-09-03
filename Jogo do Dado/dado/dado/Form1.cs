using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace dado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int R, R1;
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Dado1
            Random numAleatorio = new Random();
            numAleatorio.Next();
            R = numAleatorio.Next(1, 6);
            if (R == 1)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.dado1;
            }
            if (R == 2)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.dado2;
            }
            if (R == 3)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.dado3;
            }
            if (R == 4)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.dado4;
            }
            if (R == 5)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.dado5;
            }
            if (R == 6)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.dado6;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dado2
            Random numAleatorio2 = new Random();
            numAleatorio2.Next();
            R1 = numAleatorio2.Next(1, 6);
            if (R1 == 1)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.dado1;
            }
            if (R1 == 2)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.dado2;
            }
            if (R1 == 3)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.dado3;
            }
            if (R1 == 4)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.dado4;
            }
            if (R1 == 5)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.dado5;
            }
            if (R1 == 6)
            {
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int RESULTADO;
            RESULTADO = R + R1;
            int C, C1;
            C = int.Parse(textBox1.Text);
            C1 = int.Parse(textBox2.Text);
            
            if (RESULTADO == C && RESULTADO != C1)
            {
                MessageBox.Show("Jogador UM é o vencedor!!!");
            }
            if (RESULTADO == C1 && RESULTADO != C)
            {
                MessageBox.Show("Jogador DOIS é o vencedor!!!");
            }
            if (RESULTADO == C && RESULTADO == C1)
            {
                MessageBox.Show("Ambos jogadores acertaram!!!");
            }
            if(RESULTADO != C && RESULTADO != C1)
            {
                MessageBox.Show("Ambos jogadores não acertaram!!!");
            }
            pictureBox1.Image = Properties.Resources.ícone_da_ajuda_dos_dados_155126101;
            pictureBox2.Image = Properties.Resources.ícone_da_ajuda_dos_dados_155126101;
            textBox1.Text = null;
            textBox2.Text = null;
        }
    }
}
