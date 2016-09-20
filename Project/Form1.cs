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
                boxSuporte.Text = "Normal: Algarismo 1"+
                    "\n\nSHIFT: Utilizado para obter símbolos estatísticos Σx, Σx² e n." +
                    "\n\nExemplo: Para calcular n, Ex, Ex² para os seguintes dados: 55, 54, 51, 55, 53, 53, 54, 52." +
                    "\n\nNumero de dados (n) = 8 -> [SHIFT] [S-SUM] [3] [=]" +
                    "\n\nSoma dos valores (Σx) = 427 -> [SHIFT] [S-SUM] [2] [=]" +
                    "\n\nSoma de quadrados dos valores (Σx²) = 22805 -> [SHIFT] [S-SUM] [1] [=]";
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
                boxSuporte.Text = "Normal: Algarismo 2" +
                    "\n\nSHIFT: Utilizado para obter símbolos estatísticos x̄, σn e σn-1." +
                    "\n\nExemplo: Para calcular x̄, σn e σn-1 para os seguintes dados: 55, 54, 51, 55, 53, 53, 54, 52." +
                    "\n\nDesvio padrão de amostra (σn-1) = 1,407885953 -> [SHIFT] [S-VAR] [3] [=]" +
                    "\n\nDesvio padrão populacional (σn) = 1,316956719 -> [SHIFT] [S-VAR] [2] [=]" +
                    "\n\nMédia aritmética (x̄) = 53,375 -> [SHIFT] [S-VAR] [1] [=]";
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
                boxSuporte.Text = "Normal: Algarismo 3";
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
                boxSuporte.Text = "Normal: Algarismo 4";
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
                boxSuporte.Text = "Normal: Algarismo 5";
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
                boxSuporte.Text = "Normal: Algarismo 6";
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
                boxSuporte.Text = "Normal: Algarismo 7";
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
                boxSuporte.Text = "Normal: Algarismo 8";
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
                boxSuporte.Text = "Normal: Algarismo 9";
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
                boxSuporte.Text = "Normal: Algarismo 0"+
                    "\n\nSHIFT: Arrendondamento interno. O argumento desta função torna-se um valor decimal e, em seguida, é arrendondado segundo o numero atual "+
                    "definido de dígitos de exibição (Norm, Fix ou Sci). Com Norm o argumento é arrendondado para 10 dígitos. Com Fix e Sci, o argumento é "+
                    "arrendondado para o dígito especificado." +
                    "\n\nExemplo: Quando a definição de dígitos de exibição for Fix 3, o resultado de 10/3 é exibido com 3,333, mas a calculadora preserva o valor "+
                    "3,333333333333333 (15 dígitos) para cálculos. No caso de [SHIFT] [Rnd] [=] -> 3,333; tanto o valor exibido como o valor interno da calculadora "+
                    "tornam-se 3,333. Por causa disso, uma série de cálculos produzirá resultados diferentes dependendo de Rnd se usado (Rnd(10/3) * 3 = 9,999) ou "+
                    "não (10/3 * 3 = 10).";
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
                    "\n\nExemplo: 2 + 2, 2 / 3 + 3.14, ans + 4, √2 + sin 63°52'41\"";
            }
        }

        private void sub_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "-";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "-";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                boxSuporte.Text = "Subtração: Utilizado para subtrair dois termos" +
                    "Exemplo: 2 - 2, 2/3 - 3.14, ans - 4, √2 - sin 63°52'41\"";
            }
        }

        private void equals_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                /*Implementação Loka*/
                Parser p = new Parser(boxEquacao.Text.ToString());
                boxResultado.Text = p.getValue().ToString();
                equal_clicked = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                boxSuporte.Text = "Normal: Toda vez que é pressionado depois de introduzir valores ou uma expressão, o conteúdo da memória" +
                    " é atualizado automaticamente com o armazenamento do resultado calculado." +
                    "\n\nSHIFT: Cálculos de porcentagem" +
                    "\n\nExemplo 1: Para calcular 12% de 1500 -> 1500[*]12[SHIFT][%]" +
                    "\n\nExemplo 2: Para calcular a porcentagem de 660 contra 880 -> 660 / 880 [SHIFT][%]" +
                    "\n\nExemplo 3: Para adicionar 15% a 2500 -> 2500[*]15[SHIFT][%][+]" +
                    "\n\nExemplo 4: Para descontar 25% de 3500 -> 3500[*]25[SHIFT][%][-]" +
                    "\n\nExemplo 5: Para descontar a soma de 168, 98 e 734 em 20% -> 168[+]98[+[734][=][Ans][SHIFT][STO][A] ->" +
                    " [ALPHA][A][*]20[SHIFT][%][-]" +
                    "\n\nExemplo 6: Se 300 gramas são adicionadas a uma amostra de teste que pesa originalmente 500 gramas, qual é a " +
                    "porcentagem de aumento do peso? -> 300[+]500[SHIFT][%]"+
                    "\n\nExemplo 7: Qual é a mudança de porcentagem quando um valor é aumentado de 40 para 46? -> 46[-]40[SHIFT][%]";
            }

        }

        private void AC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                boxEquacao.Text = "";
                boxResultado.Text = "0";
                equal_clicked = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
                boxSuporte.Text = "Normal: Apaga toda operação feita até o momento(não apaga a memória de releitura e, portanto," +
                    "  você pode chamar o último cálculo mesmo depois de pressionar [AC]). Pode ser pressionado para cancelar mensagens de erro." +
                    "\n\nSHIFT: Desliga a calculadora.";
            }
        }

        private void delete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    if (boxEquacao.TextLength > 0)
                        boxEquacao.Text = boxEquacao.Text.Remove(boxEquacao.Text.Length - 1);
                }
                else
                {
                    if (boxResultado.TextLength > 0)
                        boxEquacao.Text = boxResultado.Text.Remove(boxResultado.Text.Length - 1);
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                boxSuporte.Text = "Normal: Pressione para apagar o número ou função na posição atual do cursor." +
                    "\n\nSHIFT: Pressione para mudar para um cursor de inserção . Introduzir algo enquanto o cursor de inserção está no mostrador "+
                    "e insere os dados na posição do cursor de inserção. Pressionar [INS] ou [=] restaura o cursosr normal desde o cursor de inserção.";
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
                boxSuporte.Text = "Divisão: Utilizado para dividir dois termos" +
                    "\n\nExemplo: 2 / 2, ans / 4, √2 / sin 63°52'41\""+
                    "\n\nExceção: Não pode dividir um termo por zero";
            }
        }

        private void negative_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!equal_clicked)
                {
                    boxEquacao.Text += "(-)";
                }
                else
                {
                    boxEquacao.Text = boxResultado.Text + "(-)";
                    equal_clicked = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                boxSuporte.Text = "Normal: Para uso de números negativos" +
                    "\n\nALPHA: Variável A, pode ser usada para armazenar dados, constantes, resultados e outros valores.";
            }
        }
        
    }
}
