
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(53, 55);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(185, 38);
            this.textBox.TabIndex = 1;
            this.textBox.ReadOnlyChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "7";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "8";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(326, 106);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(59, 40);
            this.mul.TabIndex = 3;
            this.mul.Text = "x";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(56, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(326, 169);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(59, 40);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(153, 169);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(245, 169);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 40);
            this.button9.TabIndex = 3;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(56, 233);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 40);
            this.button10.TabIndex = 3;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(153, 233);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 40);
            this.button11.TabIndex = 3;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(245, 233);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(59, 40);
            this.button12.TabIndex = 3;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(326, 233);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(59, 40);
            this.sub.TabIndex = 3;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(153, 296);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 40);
            this.button15.TabIndex = 3;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.dot_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(245, 296);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(59, 40);
            this.button16.TabIndex = 3;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.equal_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(326, 296);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(59, 40);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(56, 296);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(59, 40);
            this.button14.TabIndex = 4;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 411);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button14;
    }
}

