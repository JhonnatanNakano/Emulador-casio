using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.Text;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //InitCustomLabelFont();

            Controls.Add(a1);
            Controls.Add(a2);
            Controls.Add(a3);
            Controls.Add(a4);
            Controls.Add(a5);
            Controls.Add(a6);
            Controls.Add(a7);
            Controls.Add(a8);
            Controls.Add(a9);
            Controls.Add(sum);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void a2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void a4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void a5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void a6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void a7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void a8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void a9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void equals_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //public void InitCustomLabelFont()
        //{
        //    PointF pointF = new PointF(10, 0);
        //    SolidBrush solidBrush = new SolidBrush(Color.Black);

        //    int count = 0;
        //    string familyName = "";
        //    string familyNameAndStyle;
        //    FontFamily[] fontFamilies;
        //    PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        //    privateFontCollection.AddFontFile("c:\users\jho\documents\visual studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\The Display St.ttf");

        //    richTextBox1.Font = new Font(privateFontCollection.Families[0], richTextBox1.Font.Size);
        //}
    }
}
