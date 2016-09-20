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
            Controls.Add(sum);
            Controls.Add(sub);
            Controls.Add(multiplication);
            Controls.Add(AC);
            Controls.Add(delete);
            Controls.Add(equals);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "1";
        }

        private void a2_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "2";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "3";
        }

        private void a4_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "4";
        }

        private void a5_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "5";
        }

        private void a6_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "6";
        }

        private void a7_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "7";
        }

        private void a8_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "8";
        }

        private void a9_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "9";
        }

        private void a0_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "0";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "-";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            /*Implementação Loka*/
            Parser p = new Parser(boxEquacao.Text.ToString());
            boxResultado.Text = p.getValue().ToString();

        }

        private void AC_Click(object sender, EventArgs e)
        {
            boxEquacao.Text = "";
            boxResultado.Text = "0";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(boxEquacao.TextLength>0)
                boxEquacao.Text = boxEquacao.Text.Remove(boxEquacao.Text.Length - 1);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            boxEquacao.Text += "*";
        }
    }
}
