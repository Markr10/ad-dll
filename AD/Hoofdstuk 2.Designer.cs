namespace AD
{
    partial class Hoofdstuk_2
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
            this.ArrayList = new System.Windows.Forms.Button();
            this.btnCreateArrays = new System.Windows.Forms.Button();
            this.btnShowArrays = new System.Windows.Forms.Button();
            this.btnShowInfoArrays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArrayList
            // 
            this.ArrayList.Location = new System.Drawing.Point(197, 12);
            this.ArrayList.Name = "ArrayList";
            this.ArrayList.Size = new System.Drawing.Size(75, 23);
            this.ArrayList.TabIndex = 0;
            this.ArrayList.Text = "ArrayList";
            this.ArrayList.UseVisualStyleBackColor = true;
            // 
            // btnCreateArrays
            // 
            this.btnCreateArrays.Location = new System.Drawing.Point(12, 12);
            this.btnCreateArrays.Name = "btnCreateArrays";
            this.btnCreateArrays.Size = new System.Drawing.Size(94, 47);
            this.btnCreateArrays.TabIndex = 1;
            this.btnCreateArrays.Text = "Initializing and fill Student Arrays";
            this.btnCreateArrays.UseVisualStyleBackColor = true;
            this.btnCreateArrays.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnShowArrays
            // 
            this.btnShowArrays.Enabled = false;
            this.btnShowArrays.Location = new System.Drawing.Point(12, 66);
            this.btnShowArrays.Name = "btnShowArrays";
            this.btnShowArrays.Size = new System.Drawing.Size(94, 35);
            this.btnShowArrays.TabIndex = 2;
            this.btnShowArrays.Text = "Show\r\nStudent Arrays";
            this.btnShowArrays.UseVisualStyleBackColor = true;
            this.btnShowArrays.Click += new System.EventHandler(this.btnShowArrays_Click);
            // 
            // btnShowInfoArrays
            // 
            this.btnShowInfoArrays.Enabled = false;
            this.btnShowInfoArrays.Location = new System.Drawing.Point(12, 107);
            this.btnShowInfoArrays.Name = "btnShowInfoArrays";
            this.btnShowInfoArrays.Size = new System.Drawing.Size(94, 60);
            this.btnShowInfoArrays.TabIndex = 3;
            this.btnShowInfoArrays.Text = "Show information about Student Arrays";
            this.btnShowInfoArrays.UseVisualStyleBackColor = true;
            this.btnShowInfoArrays.Click += new System.EventHandler(this.btnShowInfoArrays_Click);
            // 
            // Hoofdstuk_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnShowInfoArrays);
            this.Controls.Add(this.btnShowArrays);
            this.Controls.Add(this.btnCreateArrays);
            this.Controls.Add(this.ArrayList);
            this.Name = "Hoofdstuk_2";
            this.Text = "Hoofdstuk_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ArrayList;
        private System.Windows.Forms.Button btnCreateArrays;
        private System.Windows.Forms.Button btnShowArrays;
        private System.Windows.Forms.Button btnShowInfoArrays;
    }
}