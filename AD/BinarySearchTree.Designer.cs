namespace AD
{
    partial class BinarySearchTree
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
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindMax = new System.Windows.Forms.Button();
            this.btnFindMin = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(204, 163);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 49);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find(24)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindMax
            // 
            this.btnFindMax.Location = new System.Drawing.Point(105, 163);
            this.btnFindMax.Name = "btnFindMax";
            this.btnFindMax.Size = new System.Drawing.Size(93, 49);
            this.btnFindMax.TabIndex = 14;
            this.btnFindMax.Text = "FindMax";
            this.btnFindMax.UseVisualStyleBackColor = true;
            this.btnFindMax.Click += new System.EventHandler(this.btnFindMax_Click);
            // 
            // btnFindMin
            // 
            this.btnFindMin.Location = new System.Drawing.Point(12, 163);
            this.btnFindMin.Name = "btnFindMin";
            this.btnFindMin.Size = new System.Drawing.Size(87, 49);
            this.btnFindMin.TabIndex = 13;
            this.btnFindMin.Text = "FindMin";
            this.btnFindMin.UseVisualStyleBackColor = true;
            this.btnFindMin.Click += new System.EventHandler(this.btnFindMin_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(204, 108);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(89, 49);
            this.btnPostOrder.TabIndex = 10;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(105, 108);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(93, 49);
            this.btnPreOrder.TabIndex = 9;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(12, 108);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(87, 49);
            this.btnInOrder.TabIndex = 8;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "51, 89, 60, 24, 44, 19, 65, 39";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 73);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waarden in de Binary Search Tree";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(257, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Mark, Thomas, Wybren, Raymon, Danny, Reinier";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // BinarySearchTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnFindMax);
            this.Controls.Add(this.btnFindMin);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnInOrder);
            this.Name = "BinarySearchTree";
            this.Text = "BinarySearchTree";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnFindMin;
        private System.Windows.Forms.Button btnFindMax;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}