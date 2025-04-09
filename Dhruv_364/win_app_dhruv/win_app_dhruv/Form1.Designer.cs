namespace win_app_dhruv
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
            this.name = new System.Windows.Forms.TextBox();
            this.addres = new System.Windows.Forms.TextBox();
            this.sbmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Other = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reading = new System.Windows.Forms.CheckBox();
            this.gaming = new System.Windows.Forms.CheckBox();
            this.wreting = new System.Windows.Forms.CheckBox();
            this.reset = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AccessibleDescription = "Enter Name";
            this.name.BackColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(306, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // addres
            // 
            this.addres.BackColor = System.Drawing.SystemColors.Window;
            this.addres.Location = new System.Drawing.Point(306, 47);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(100, 20);
            this.addres.TabIndex = 0;
            this.addres.Text = "addres";
            this.addres.TextChanged += new System.EventHandler(this.addres_TextChanged);
            // 
            // sbmit
            // 
            this.sbmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sbmit.Location = new System.Drawing.Point(457, 368);
            this.sbmit.Name = "sbmit";
            this.sbmit.Size = new System.Drawing.Size(75, 23);
            this.sbmit.TabIndex = 1;
            this.sbmit.Text = "submit";
            this.sbmit.UseVisualStyleBackColor = false;
            this.sbmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name :-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Male.Location = new System.Drawing.Point(306, 93);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 3;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Female.Location = new System.Drawing.Point(306, 117);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 4;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Other.Location = new System.Drawing.Point(306, 141);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(51, 17);
            this.Other.TabIndex = 5;
            this.Other.TabStop = true;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(306, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "reading";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // reading
            // 
            this.reading.AutoSize = true;
            this.reading.BackColor = System.Drawing.SystemColors.HighlightText;
            this.reading.Location = new System.Drawing.Point(306, 187);
            this.reading.Name = "reading";
            this.reading.Size = new System.Drawing.Size(61, 17);
            this.reading.TabIndex = 6;
            this.reading.Text = "reading";
            this.reading.UseVisualStyleBackColor = false;
            // 
            // gaming
            // 
            this.gaming.AutoSize = true;
            this.gaming.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gaming.Location = new System.Drawing.Point(306, 211);
            this.gaming.Name = "gaming";
            this.gaming.Size = new System.Drawing.Size(56, 17);
            this.gaming.TabIndex = 7;
            this.gaming.Text = "writing";
            this.gaming.UseVisualStyleBackColor = false;
            // 
            // wreting
            // 
            this.wreting.AutoSize = true;
            this.wreting.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wreting.Location = new System.Drawing.Point(306, 235);
            this.wreting.Name = "wreting";
            this.wreting.Size = new System.Drawing.Size(60, 17);
            this.wreting.TabIndex = 8;
            this.wreting.Text = "gaming";
            this.wreting.UseVisualStyleBackColor = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.reset.Location = new System.Drawing.Point(539, 367);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 9;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cancel.Location = new System.Drawing.Point(621, 366);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Addrese :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Geneder :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hobby :-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(755, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.wreting);
            this.Controls.Add(this.gaming);
            this.Controls.Add(this.reading);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbmit);
            this.Controls.Add(this.addres);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox addres;
        private System.Windows.Forms.Button sbmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Other;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox reading;
        private System.Windows.Forms.CheckBox gaming;
        private System.Windows.Forms.CheckBox wreting;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

