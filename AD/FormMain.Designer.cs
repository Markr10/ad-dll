﻿namespace AD
{
    partial class FormMain
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
            this.button3 = new System.Windows.Forms.Button();
            this.Sorteren = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnArrayAndArrayLists = new System.Windows.Forms.Button();
            this.btnBST = new System.Windows.Forms.Button();
            this.stacksQueues = new System.Windows.Forms.Button();
            this.CSet1 = new System.Windows.Forms.Button();
            this.Cset2 = new System.Windows.Forms.Button();
            this.btnBasicSearch = new System.Windows.Forms.Button();
            this.btnStrings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Timer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sorteren
            // 
            this.Sorteren.Location = new System.Drawing.Point(12, 41);
            this.Sorteren.Name = "Sorteren";
            this.Sorteren.Size = new System.Drawing.Size(82, 27);
            this.Sorteren.TabIndex = 4;
            this.Sorteren.Text = "Sorteren";
            this.Sorteren.UseVisualStyleBackColor = true;
            this.Sorteren.Click += new System.EventHandler(this.Sorteren_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArrayAndArrayLists
            // 
            this.btnArrayAndArrayLists.Location = new System.Drawing.Point(12, 107);
            this.btnArrayAndArrayLists.Name = "btnArrayAndArrayLists";
            this.btnArrayAndArrayLists.Size = new System.Drawing.Size(82, 36);
            this.btnArrayAndArrayLists.TabIndex = 6;
            this.btnArrayAndArrayLists.Text = "Array and ArrayLists";
            this.btnArrayAndArrayLists.UseVisualStyleBackColor = true;
            this.btnArrayAndArrayLists.Click += new System.EventHandler(this.btnArrayAndArrayLists_Click);
            // 
            // btnBST
            // 
            this.btnBST.Location = new System.Drawing.Point(100, 8);
            this.btnBST.Name = "btnBST";
            this.btnBST.Size = new System.Drawing.Size(81, 36);
            this.btnBST.TabIndex = 7;
            this.btnBST.Text = "Binary Search Tree";
            this.btnBST.UseVisualStyleBackColor = true;
            this.btnBST.Click += new System.EventHandler(this.btnBST_Click);
            // 
            // stacksQueues
            // 
            this.stacksQueues.Location = new System.Drawing.Point(12, 207);
            this.stacksQueues.Name = "stacksQueues";
            this.stacksQueues.Size = new System.Drawing.Size(82, 36);
            this.stacksQueues.TabIndex = 7;
            this.stacksQueues.Text = "Stacks and Queue";
            this.stacksQueues.UseVisualStyleBackColor = true;
            this.stacksQueues.Click += new System.EventHandler(this.stacksQueues_Click);
            // 
            // CSet1
            // 
            this.CSet1.Location = new System.Drawing.Point(12, 149);
            this.CSet1.Name = "CSet1";
            this.CSet1.Size = new System.Drawing.Size(82, 23);
            this.CSet1.TabIndex = 7;
            this.CSet1.Text = "Cset1";
            this.CSet1.UseVisualStyleBackColor = true;
            this.CSet1.Click += new System.EventHandler(this.CSet1_Click);
            // 
            // Cset2
            // 
            this.Cset2.Location = new System.Drawing.Point(12, 178);
            this.Cset2.Name = "Cset2";
            this.Cset2.Size = new System.Drawing.Size(82, 23);
            this.Cset2.TabIndex = 8;
            this.Cset2.Text = "Cset2";
            this.Cset2.UseVisualStyleBackColor = true;
            this.Cset2.Click += new System.EventHandler(this.Cset2_Click);
            // 
            // btnBasicSearch
            // 
            this.btnBasicSearch.Location = new System.Drawing.Point(100, 50);
            this.btnBasicSearch.Name = "btnBasicSearch";
            this.btnBasicSearch.Size = new System.Drawing.Size(81, 34);
            this.btnBasicSearch.TabIndex = 8;
            this.btnBasicSearch.Text = "Basic Search";
            this.btnBasicSearch.UseVisualStyleBackColor = true;
            this.btnBasicSearch.Click += new System.EventHandler(this.btnBasicSearch_Click);
            // 
            // btnStrings
            // 
            this.btnStrings.Location = new System.Drawing.Point(100, 90);
            this.btnStrings.Name = "btnStrings";
            this.btnStrings.Size = new System.Drawing.Size(81, 23);
            this.btnStrings.TabIndex = 9;
            this.btnStrings.Text = "Strings";
            this.btnStrings.UseVisualStyleBackColor = true;
            this.btnStrings.Click += new System.EventHandler(this.btnStrings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 261);
            this.Controls.Add(this.btnStrings);
            this.Controls.Add(this.btnBasicSearch);
            this.Controls.Add(this.btnBST);
            this.Controls.Add(this.stacksQueues);
            this.Controls.Add(this.Cset2);
            this.Controls.Add(this.CSet1);
            this.Controls.Add(this.btnArrayAndArrayLists);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sorteren);
            this.Controls.Add(this.button3);
            this.Name = "FormMain";
            this.Text = "AD Dll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Sorteren;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnArrayAndArrayLists;
        private System.Windows.Forms.Button btnBST;
        private System.Windows.Forms.Button stacksQueues;
        private System.Windows.Forms.Button CSet1;
        private System.Windows.Forms.Button Cset2;
        private System.Windows.Forms.Button btnBasicSearch;
        private System.Windows.Forms.Button btnStrings;
    }
}
