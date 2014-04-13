namespace AD
{
    partial class Strings
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
            this.groupBoxStrings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowString = new System.Windows.Forms.Button();
            this.btnTwoWords = new System.Windows.Forms.Button();
            this.btnShowSubString = new System.Windows.Forms.Button();
            this.btnChangeString = new System.Windows.Forms.Button();
            this.btnSplitWords = new System.Windows.Forms.Button();
            this.btnSplitMethod = new System.Windows.Forms.Button();
            this.btnJoinMethod = new System.Windows.Forms.Button();
            this.btnInitDataAndCharArray = new System.Windows.Forms.Button();
            this.groupBoxStrings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStrings
            // 
            this.groupBoxStrings.Controls.Add(this.label4);
            this.groupBoxStrings.Controls.Add(this.label3);
            this.groupBoxStrings.Controls.Add(this.label2);
            this.groupBoxStrings.Controls.Add(this.label1);
            this.groupBoxStrings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStrings.Name = "groupBoxStrings";
            this.groupBoxStrings.Size = new System.Drawing.Size(328, 79);
            this.groupBoxStrings.TabIndex = 1;
            this.groupBoxStrings.TabStop = false;
            this.groupBoxStrings.Text = "String literals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "\"mmcmillan@pulaskitech.edu\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "\"123-45-6789\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"the quick brown fox jumped over the lazy dog\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"David Ruff\"";
            // 
            // btnShowString
            // 
            this.btnShowString.AutoSize = true;
            this.btnShowString.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowString.Location = new System.Drawing.Point(12, 97);
            this.btnShowString.Name = "btnShowString";
            this.btnShowString.Size = new System.Drawing.Size(83, 23);
            this.btnShowString.TabIndex = 2;
            this.btnShowString.Text = "Show a String";
            this.btnShowString.UseVisualStyleBackColor = true;
            this.btnShowString.Click += new System.EventHandler(this.btnShowString_Click);
            // 
            // btnTwoWords
            // 
            this.btnTwoWords.Location = new System.Drawing.Point(12, 126);
            this.btnTwoWords.Name = "btnTwoWords";
            this.btnTwoWords.Size = new System.Drawing.Size(75, 47);
            this.btnTwoWords.TabIndex = 3;
            this.btnTwoWords.Text = "First two words of a String";
            this.btnTwoWords.UseVisualStyleBackColor = true;
            this.btnTwoWords.Click += new System.EventHandler(this.btnTwoWords_Click);
            // 
            // btnShowSubString
            // 
            this.btnShowSubString.Location = new System.Drawing.Point(143, 97);
            this.btnShowSubString.Name = "btnShowSubString";
            this.btnShowSubString.Size = new System.Drawing.Size(74, 48);
            this.btnShowSubString.TabIndex = 4;
            this.btnShowSubString.Text = "Show substring of a String";
            this.btnShowSubString.UseVisualStyleBackColor = true;
            this.btnShowSubString.Click += new System.EventHandler(this.btnShowSubString_Click);
            // 
            // btnChangeString
            // 
            this.btnChangeString.Location = new System.Drawing.Point(135, 206);
            this.btnChangeString.Name = "btnChangeString";
            this.btnChangeString.Size = new System.Drawing.Size(91, 48);
            this.btnChangeString.TabIndex = 5;
            this.btnChangeString.Text = "Change String for Substring for above methods";
            this.btnChangeString.UseVisualStyleBackColor = false;
            this.btnChangeString.Click += new System.EventHandler(this.btnChangeString_Click);
            // 
            // btnSplitWords
            // 
            this.btnSplitWords.Location = new System.Drawing.Point(143, 148);
            this.btnSplitWords.Name = "btnSplitWords";
            this.btnSplitWords.Size = new System.Drawing.Size(74, 48);
            this.btnSplitWords.TabIndex = 6;
            this.btnSplitWords.Text = "Split words";
            this.btnSplitWords.UseVisualStyleBackColor = true;
            this.btnSplitWords.Click += new System.EventHandler(this.btnSplitWords_Click);
            // 
            // btnSplitMethod
            // 
            this.btnSplitMethod.Enabled = false;
            this.btnSplitMethod.Location = new System.Drawing.Point(236, 163);
            this.btnSplitMethod.Name = "btnSplitMethod";
            this.btnSplitMethod.Size = new System.Drawing.Size(75, 23);
            this.btnSplitMethod.TabIndex = 8;
            this.btnSplitMethod.Text = "Split method";
            this.btnSplitMethod.UseVisualStyleBackColor = true;
            this.btnSplitMethod.Click += new System.EventHandler(this.btnSplitMethod_Click);
            // 
            // btnJoinMethod
            // 
            this.btnJoinMethod.Enabled = false;
            this.btnJoinMethod.Location = new System.Drawing.Point(236, 192);
            this.btnJoinMethod.Name = "btnJoinMethod";
            this.btnJoinMethod.Size = new System.Drawing.Size(75, 23);
            this.btnJoinMethod.TabIndex = 9;
            this.btnJoinMethod.Text = "Join method";
            this.btnJoinMethod.UseVisualStyleBackColor = true;
            this.btnJoinMethod.Click += new System.EventHandler(this.btnJoinMethod_Click);
            // 
            // btnInitDataAndCharArray
            // 
            this.btnInitDataAndCharArray.Location = new System.Drawing.Point(236, 97);
            this.btnInitDataAndCharArray.Name = "btnInitDataAndCharArray";
            this.btnInitDataAndCharArray.Size = new System.Drawing.Size(75, 60);
            this.btnInitDataAndCharArray.TabIndex = 7;
            this.btnInitDataAndCharArray.Text = "Initialize data for the following buttons";
            this.btnInitDataAndCharArray.UseVisualStyleBackColor = true;
            this.btnInitDataAndCharArray.Click += new System.EventHandler(this.btnInitDataAndCharArray_Click);
            // 
            // Strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.btnInitDataAndCharArray);
            this.Controls.Add(this.btnJoinMethod);
            this.Controls.Add(this.btnSplitMethod);
            this.Controls.Add(this.btnSplitWords);
            this.Controls.Add(this.btnChangeString);
            this.Controls.Add(this.btnShowSubString);
            this.Controls.Add(this.btnTwoWords);
            this.Controls.Add(this.btnShowString);
            this.Controls.Add(this.groupBoxStrings);
            this.Name = "Strings";
            this.Text = "Strings";
            this.groupBoxStrings.ResumeLayout(false);
            this.groupBoxStrings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStrings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowString;
        private System.Windows.Forms.Button btnTwoWords;
        private System.Windows.Forms.Button btnShowSubString;
        private System.Windows.Forms.Button btnChangeString;
        private System.Windows.Forms.Button btnSplitWords;
        private System.Windows.Forms.Button btnSplitMethod;
        private System.Windows.Forms.Button btnJoinMethod;
        private System.Windows.Forms.Button btnInitDataAndCharArray;

    }
}