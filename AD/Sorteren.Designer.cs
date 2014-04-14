namespace AD
{
    partial class Sorteren
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
            this.SelectionSort = new System.Windows.Forms.Button();
            this.InsertionSort = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.random = new System.Windows.Forms.Button();
            this.inputArray = new System.Windows.Forms.TextBox();
            this.outputArray = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectionSort
            // 
            this.SelectionSort.Location = new System.Drawing.Point(373, 78);
            this.SelectionSort.Name = "SelectionSort";
            this.SelectionSort.Size = new System.Drawing.Size(82, 26);
            this.SelectionSort.TabIndex = 6;
            this.SelectionSort.Text = "Selection sort";
            this.SelectionSort.UseVisualStyleBackColor = true;
            this.SelectionSort.Click += new System.EventHandler(this.SelectionSort_Click);
            // 
            // InsertionSort
            // 
            this.InsertionSort.Location = new System.Drawing.Point(283, 78);
            this.InsertionSort.Name = "InsertionSort";
            this.InsertionSort.Size = new System.Drawing.Size(82, 26);
            this.InsertionSort.TabIndex = 5;
            this.InsertionSort.Text = "Insertion sort";
            this.InsertionSort.UseVisualStyleBackColor = true;
            this.InsertionSort.Click += new System.EventHandler(this.InsertionSort_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(195, 78);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(82, 27);
            this.BubbleSort.TabIndex = 4;
            this.BubbleSort.Text = "Bubble sort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Input:";
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(259, 13);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(129, 23);
            this.random.TabIndex = 3;
            this.random.Text = "Random getal";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // inputArray
            // 
            this.inputArray.Location = new System.Drawing.Point(107, 122);
            this.inputArray.Multiline = true;
            this.inputArray.Name = "inputArray";
            this.inputArray.ReadOnly = true;
            this.inputArray.Size = new System.Drawing.Size(309, 58);
            this.inputArray.TabIndex = 13;
            // 
            // outputArray
            // 
            this.outputArray.Location = new System.Drawing.Point(107, 186);
            this.outputArray.Multiline = true;
            this.outputArray.Name = "outputArray";
            this.outputArray.ReadOnly = true;
            this.outputArray.Size = new System.Drawing.Size(308, 58);
            this.outputArray.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(448, 122);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(111, 30);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(448, 168);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(111, 30);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(448, 214);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(111, 30);
            this.textBox4.TabIndex = 17;
            // 
            // Sorteren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 270);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.outputArray);
            this.Controls.Add(this.inputArray);
            this.Controls.Add(this.random);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SelectionSort);
            this.Controls.Add(this.InsertionSort);
            this.Controls.Add(this.BubbleSort);
            this.Name = "Sorteren";
            this.Text = "Sorteren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectionSort;
        private System.Windows.Forms.Button InsertionSort;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.TextBox inputArray;
        private System.Windows.Forms.TextBox outputArray;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}