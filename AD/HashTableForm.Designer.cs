namespace AD
{
    partial class HashTableForm
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
            this.btnBetterHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBetterHash
            // 
            this.btnBetterHash.Location = new System.Drawing.Point(63, 40);
            this.btnBetterHash.Name = "btnBetterHash";
            this.btnBetterHash.Size = new System.Drawing.Size(134, 32);
            this.btnBetterHash.TabIndex = 0;
            this.btnBetterHash.Text = "Get BetterHASH";
            this.btnBetterHash.UseVisualStyleBackColor = true;
            this.btnBetterHash.Click += new System.EventHandler(this.btnBetterHash_Click);
            // 
            // HashTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBetterHash);
            this.Name = "HashTableForm";
            this.Text = "HashTable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBetterHash;
    }
}