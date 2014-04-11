namespace AD
{
    partial class BasicSearch
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
            this.btnShowSeqSearch = new System.Windows.Forms.Button();
            this.btnShowBinSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowSeqSearch
            // 
            this.btnShowSeqSearch.Location = new System.Drawing.Point(48, 105);
            this.btnShowSeqSearch.Name = "btnShowSeqSearch";
            this.btnShowSeqSearch.Size = new System.Drawing.Size(75, 48);
            this.btnShowSeqSearch.TabIndex = 0;
            this.btnShowSeqSearch.Text = "Sequential search";
            this.btnShowSeqSearch.UseVisualStyleBackColor = true;
            this.btnShowSeqSearch.Click += new System.EventHandler(this.btnShowSeqSearch_Click);
            // 
            // btnShowBinSearch
            // 
            this.btnShowBinSearch.Location = new System.Drawing.Point(161, 105);
            this.btnShowBinSearch.Name = "btnShowBinSearch";
            this.btnShowBinSearch.Size = new System.Drawing.Size(75, 48);
            this.btnShowBinSearch.TabIndex = 1;
            this.btnShowBinSearch.Text = "Binary search";
            this.btnShowBinSearch.UseVisualStyleBackColor = true;
            this.btnShowBinSearch.Click += new System.EventHandler(this.btnShowBinSearch_Click);
            // 
            // BasicSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowBinSearch);
            this.Controls.Add(this.btnShowSeqSearch);
            this.Name = "BasicSearch";
            this.Text = "BasicSearch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowSeqSearch;
        private System.Windows.Forms.Button btnShowBinSearch;
    }
}