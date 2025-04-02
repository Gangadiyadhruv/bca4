namespace paractical_form
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
            this.In_number1 = new System.Windows.Forms.TextBox();
            this.In_number2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.ans_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // In_number1
            // 
            this.In_number1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.In_number1.Location = new System.Drawing.Point(102, 48);
            this.In_number1.Name = "In_number1";
            this.In_number1.Size = new System.Drawing.Size(100, 20);
            this.In_number1.TabIndex = 0;
            this.In_number1.TextChanged += new System.EventHandler(this.In_number1_TextChanged);
            this.In_number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.In_number1_KeyPress);
            // 
            // In_number2
            // 
            this.In_number2.Location = new System.Drawing.Point(102, 99);
            this.In_number2.Name = "In_number2";
            this.In_number2.Size = new System.Drawing.Size(100, 20);
            this.In_number2.TabIndex = 1;
            this.In_number2.TextChanged += new System.EventHandler(this.In_number2_TextChanged);
            this.In_number2.MouseLeave += new System.EventHandler(this.In_number2_MouseLeave);
            this.In_number2.MouseHover += new System.EventHandler(this.In_number2_MouseHover);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(91, 231);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 3;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(188, 231);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(91, 276);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 23);
            this.mul.TabIndex = 5;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(188, 276);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 6;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(12, 55);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(69, 13);
            this.num1.TabIndex = 7;
            this.num1.Text = "Input_num1:-";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(12, 102);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(69, 13);
            this.num2.TabIndex = 8;
            this.num2.Text = "Input_num2:-";
            // 
            // ans_label
            // 
            this.ans_label.AutoSize = true;
            this.ans_label.Location = new System.Drawing.Point(33, 161);
            this.ans_label.Name = "ans_label";
            this.ans_label.Size = new System.Drawing.Size(38, 13);
            this.ans_label.TabIndex = 9;
            this.ans_label.Text = "ANS :-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(486, 409);
            this.Controls.Add(this.ans_label);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.In_number2);
            this.Controls.Add(this.In_number1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox In_number1;
        private System.Windows.Forms.TextBox In_number2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label ans_label;

    }
}

