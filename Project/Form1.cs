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
        private bool equal_clicked = false;

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
            Controls.Add(division);

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
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "1";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "1";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "2";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "2";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "3";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "3";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "4";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "4";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "5";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "5";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "6";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "6";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "7";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "7";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "8";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "8";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "9";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "9";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void a0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "0";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "0";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                //  "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void sum_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "+";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "+";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                boxSuporte.Text = "Soma: Utilizado para somar dois termos" +
                    "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41";
            }
        }

        private void sub_MouseDown(object sender, MouseEventArgs e)
        {
            if (!equal_clicked)
            {
                if (e.Button == MouseButtons.Left)
                    boxEquacao.Text += "-";
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                    boxEquacao.Text = boxResultado.Text + "-";
                equal_clicked = false;
            }
        }

        private void equals_MouseDown(object sender, MouseEventArgs e)
        {
            /*Implementação Loka*/
            Parser p = new Parser(boxEquacao.Text.ToString());
            boxResultado.Text = p.getValue().ToString();
            equal_clicked = true;

        }

        private void AC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                boxEquacao.Text = "";
                boxResultado.Text = "0";
                equal_clicked = false;
            }
        }

        private void delete_MouseDown(object sender, MouseEventArgs e)
        {
            if (!equal_clicked)
            {
                if (e.Button == MouseButtons.Left)
                    if (boxEquacao.TextLength > 0)
                        boxEquacao.Text = boxEquacao.Text.Remove(boxEquacao.Text.Length - 1);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                    if (boxResultado.TextLength > 0)
                        boxEquacao.Text = boxResultado.Text.Remove(boxResultado.Text.Length - 1);
                equal_clicked = false;
            }
        }

        private void multiplication_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                    boxEquacao.Text += "*";   
                else
                {
                    boxEquacao.Text = boxResultado.Text + "*";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                boxSuporte.Text = "Multiplicação: Utilizado para multiplicar dois termos" +
                    "\n\nExemplo: 2 * 2, 2/3 * 3.14, ans * 4, √2 * sin 63°52'41";
            }
        }

        private void division_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                    boxEquacao.Text += "/";
                else
                {
                    boxEquacao.Text = boxResultado.Text + "/";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //boxSuporte.Text = "Multiplicação: Utilizado para multiplicar dois termos" +
                //    "\n\nExemplo: 2 * 2, 2/3 * 3.14, ans * 4, √2 * sin 63°52'41";
            }
        }

        private void negative_MouseDown(object sender, MouseEventArgs e)
        {
            if (!equal_clicked)
            {
                if (e.Button == MouseButtons.Left)
                    boxEquacao.Text += "(-)";
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                    boxEquacao.Text = boxResultado.Text + "(-)";
                equal_clicked = false;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void boxSuporte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
