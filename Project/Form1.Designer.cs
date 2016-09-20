using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a6 = new System.Windows.Forms.Button();
            this.a9 = new System.Windows.Forms.Button();
            this.a5 = new System.Windows.Forms.Button();
            this.a8 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a7 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.equals = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.a0 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AC = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.boxResultado = new System.Windows.Forms.RichTextBox();
            this.multiplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.White;
            this.a1.Location = new System.Drawing.Point(82, 633);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(42, 31);
            this.a1.TabIndex = 1;
            this.a1.Text = "1";
            this.a1.UseVisualStyleBackColor = false;
            this.a1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a1_MouseDown);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.Transparent;
            this.a2.Location = new System.Drawing.Point(145, 633);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(42, 31);
            this.a2.TabIndex = 3;
            this.a2.Text = "2";
            this.a2.UseVisualStyleBackColor = false;
            this.a2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a2_MouseDown);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.Transparent;
            this.sum.Location = new System.Drawing.Point(270, 633);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(44, 31);
            this.sum.TabIndex = 4;
            this.sum.Text = "sum";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sum_MouseDown);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.Transparent;
            this.a3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.a3.Location = new System.Drawing.Point(206, 633);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(46, 31);
            this.a3.TabIndex = 5;
            this.a3.Text = "3";
            this.a3.UseVisualStyleBackColor = false;
            this.a3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a3_MouseDown);
            // 
            // a6
            // 
            this.a6.Location = new System.Drawing.Point(207, 578);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(46, 31);
            this.a6.TabIndex = 6;
            this.a6.Text = "6";
            this.a6.UseVisualStyleBackColor = true;
            this.a6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a6_MouseDown);
            // 
            // a9
            // 
            this.a9.Location = new System.Drawing.Point(207, 525);
            this.a9.Name = "a9";
            this.a9.Size = new System.Drawing.Size(46, 29);
            this.a9.TabIndex = 7;
            this.a9.Text = "9";
            this.a9.UseVisualStyleBackColor = true;
            this.a9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a9_MouseDown);
            // 
            // a5
            // 
            this.a5.Location = new System.Drawing.Point(145, 578);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(42, 31);
            this.a5.TabIndex = 8;
            this.a5.Text = "5";
            this.a5.UseVisualStyleBackColor = true;
            this.a5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a5_MouseDown);
            // 
            // a8
            // 
            this.a8.Location = new System.Drawing.Point(145, 524);
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(42, 30);
            this.a8.TabIndex = 9;
            this.a8.Text = "8";
            this.a8.UseVisualStyleBackColor = true;
            this.a8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a8_MouseDown);
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(82, 578);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(42, 31);
            this.a4.TabIndex = 10;
            this.a4.Text = "4";
            this.a4.UseVisualStyleBackColor = true;
            this.a4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a4_MouseDown);
            // 
            // a7
            // 
            this.a7.Location = new System.Drawing.Point(82, 524);
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(42, 31);
            this.a7.TabIndex = 11;
            this.a7.Text = "7";
            this.a7.UseVisualStyleBackColor = true;
            this.a7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a7_MouseDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(86, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(292, 35);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.Transparent;
            this.equals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equals.Location = new System.Drawing.Point(334, 687);
            this.equals.Margin = new System.Windows.Forms.Padding(0);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(45, 31);
            this.equals.TabIndex = 14;
            this.equals.Text = "equal";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.MouseDown += new System.Windows.Forms.MouseEventHandler(this.equals_MouseDown);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.Transparent;
            this.sub.Location = new System.Drawing.Point(334, 631);
            this.sub.Margin = new System.Windows.Forms.Padding(0);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(46, 33);
            this.sub.TabIndex = 15;
            this.sub.Text = "sub";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sub_MouseDown);
            // 
            // a0
            // 
            this.a0.BackColor = System.Drawing.Color.Transparent;
            this.a0.Location = new System.Drawing.Point(82, 687);
            this.a0.Name = "a0";
            this.a0.Size = new System.Drawing.Size(42, 31);
            this.a0.TabIndex = 16;
            this.a0.Text = "0";
            this.a0.UseVisualStyleBackColor = false;
            this.a0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.a0_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.calc21;
            this.pictureBox1.Location = new System.Drawing.Point(2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 784);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(333, 523);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(46, 31);
            this.AC.TabIndex = 17;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AC_MouseDown);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(270, 523);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(44, 31);
            this.delete.TabIndex = 18;
            this.delete.Text = "DEL";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.delete_MouseDown);
            // 
            // boxResultado
            // 
            this.boxResultado.BackColor = System.Drawing.SystemColors.Window;
            this.boxResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxResultado.Font = new System.Drawing.Font("Courier New", 20F);
            this.boxResultado.Location = new System.Drawing.Point(86, 170);
            this.boxResultado.Multiline = false;
            this.boxResultado.Name = "boxResultado";
            this.boxResultado.ReadOnly = true;
            this.boxResultado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.boxResultado.Size = new System.Drawing.Size(274, 39);
            this.boxResultado.TabIndex = 19;
            this.boxResultado.Text = "0";
            this.boxResultado.WordWrap = false;
            this.boxResultado.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(270, 578);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(44, 31);
            this.multiplication.TabIndex = 19;
            this.multiplication.Text = "mul";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.MouseDown += new System.Windows.Forms.MouseEventHandler(this.multiplication_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 778);
            this.Controls.Add(this.boxResultado);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.a0);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.a7);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a8);
            this.Controls.Add(this.a5);
            this.Controls.Add(this.a9);
            this.Controls.Add(this.a6);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a6;
        private System.Windows.Forms.Button a9;
        private System.Windows.Forms.Button a5;
        private System.Windows.Forms.Button a8;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button a0;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.RichTextBox boxResultado;
        private System.Windows.Forms.Button multiplication;
    }
}

