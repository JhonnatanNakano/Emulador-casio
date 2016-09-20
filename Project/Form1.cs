using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(System.IO.Path.Combine(Application.StartupPath, "Resources\\digital7italic.ttf"));

            //boxResultado.Font = new Font(pfc.Families[0], 22, FontStyle.Regular);
            boxEquacao.Font = new Font(pfc.Families[0], 22, FontStyle.Regular);
            boxResultado.Font = new Font(pfc.Families[0], 28, FontStyle.Regular);

            //Algarismos
            Controls.Add(a1);
            Controls.Add(a2);
            Controls.Add(a3);
            Controls.Add(a4);
            Controls.Add(a5);
            Controls.Add(a6);
            Controls.Add(a7);
            Controls.Add(a8);
            Controls.Add(a9);
            Controls.Add(a0);

            //Sinal
            Controls.Add(negative);

            //Aritmetico
            Controls.Add(sum);
            Controls.Add(sub);
            Controls.Add(multiplication);

            //Controle
            Controls.Add(AC);
            Controls.Add(delete);
            Controls.Add(equals);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void a1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "1";
            else if (e.Button == MouseButtons.Right)
                richTextBox1.Text += "0";
        }

        private void a2_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                richTextBox1.Text += "2";
        }

        private void a3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "3";
        }

        private void a4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "4";
        }

        private void a5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "5";
        }

        private void a6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "6";
        }

        private void a7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "7";
        }

        private void a8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "8";
        }

        private void a9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "9";
        }

        private void a0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "0";
        }

        private void sum_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "+";
        }

        private void sub_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "-";
        }

        private void equals_MouseDown(object sender, MouseEventArgs e)
        {
            /*Implementação Loka*/
            Parser p = new Parser(boxEquacao.Text.ToString());
            boxResultado.Text = p.getValue().ToString();

        }

        private void AC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                richTextBox1.Text = "";
                boxResultado.Text = "0";
            }
        }

        private void delete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (richTextBox1.TextLength > 0)
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }
        }

        private void multiplication_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.Text += "*";
        }

        private void negative_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "(-)";
        }


        
    }
}
