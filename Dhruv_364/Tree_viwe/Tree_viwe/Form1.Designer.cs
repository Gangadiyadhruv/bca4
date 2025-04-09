namespace Tree_viwe
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("FY BCA");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("SY BCA");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("TY BCA");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("BCA", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("BSC");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("B.COM");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(67, 59);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Node1";
            treeNode13.Text = "FY BCA";
            treeNode14.Name = "Node2";
            treeNode14.Text = "SY BCA";
            treeNode15.Name = "Node3";
            treeNode15.Text = "TY BCA";
            treeNode16.Name = "Node0";
            treeNode16.Text = "BCA";
            treeNode17.Name = "Node4";
            treeNode17.Text = "BSC";
            treeNode18.Name = "Node5";
            treeNode18.Text = "B.COM";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(127, 118);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
    }
}

