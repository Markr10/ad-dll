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
            this.btnSimpleHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBetterHash
            // 
            this.btnBetterHash.Location = new System.Drawing.Point(87, 22);
            this.btnBetterHash.Name = "btnBetterHash";
            this.btnBetterHash.Size = new System.Drawing.Size(115, 46);
            this.btnBetterHash.TabIndex = 0;
            this.btnBetterHash.Text = "Get BetterHash";
            this.btnBetterHash.UseVisualStyleBackColor = true;
            this.btnBetterHash.Click += new System.EventHandler(this.btnBetterHash_Click);
            // 
            // btnSimpleHash
            // 
            this.btnSimpleHash.Location = new System.Drawing.Point(87, 89);
            this.btnSimpleHash.Name = "btnSimpleHash";
            this.btnSimpleHash.Size = new System.Drawing.Size(115, 46);
            this.btnSimpleHash.TabIndex = 1;
            this.btnSimpleHash.Text = "Get SimpleHash";
            this.btnSimpleHash.UseVisualStyleBackColor = true;
            this.btnSimpleHash.Click += new System.EventHandler(this.btnSimpleHash_Click);
            // 
            // HashTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 156);
            this.Controls.Add(this.btnSimpleHash);
            this.Controls.Add(this.btnBetterHash);
            this.Name = "HashTableForm";
            this.Text = "HashTable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBetterHash;
        private System.Windows.Forms.Button btnSimpleHash;
    }
}