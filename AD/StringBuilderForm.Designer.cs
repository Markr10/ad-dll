namespace AD
{
    partial class StringBuilderForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAppendMethod = new System.Windows.Forms.Button();
            this.btnFormatString = new System.Windows.Forms.Button();
            this.btnInsertMethod = new System.Windows.Forms.Button();
            this.btnRemoveMethod = new System.Windows.Forms.Button();
            this.btnReplaceMethod = new System.Windows.Forms.Button();
            this.btnToStringMethod = new System.Windows.Forms.Button();
            this.btnTiming = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(13, 13);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 48);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Initialize and fill StringBuilders";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(13, 68);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(83, 60);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show information about StringBuilders";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAppendMethod
            // 
            this.btnAppendMethod.Location = new System.Drawing.Point(102, 12);
            this.btnAppendMethod.Name = "btnAppendMethod";
            this.btnAppendMethod.Size = new System.Drawing.Size(83, 34);
            this.btnAppendMethod.TabIndex = 2;
            this.btnAppendMethod.Text = "Append Method";
            this.btnAppendMethod.UseVisualStyleBackColor = true;
            this.btnAppendMethod.Click += new System.EventHandler(this.btnAppendMethod_Click);
            // 
            // btnFormatString
            // 
            this.btnFormatString.Location = new System.Drawing.Point(102, 52);
            this.btnFormatString.Name = "btnFormatString";
            this.btnFormatString.Size = new System.Drawing.Size(83, 34);
            this.btnFormatString.TabIndex = 3;
            this.btnFormatString.Text = "Format StringBuilder";
            this.btnFormatString.UseVisualStyleBackColor = true;
            this.btnFormatString.Click += new System.EventHandler(this.btnFormatString_Click);
            // 
            // btnInsertMethod
            // 
            this.btnInsertMethod.Location = new System.Drawing.Point(102, 92);
            this.btnInsertMethod.Name = "btnInsertMethod";
            this.btnInsertMethod.Size = new System.Drawing.Size(83, 34);
            this.btnInsertMethod.TabIndex = 4;
            this.btnInsertMethod.Text = "Insert Method";
            this.btnInsertMethod.UseVisualStyleBackColor = true;
            this.btnInsertMethod.Click += new System.EventHandler(this.btnInsertMethod_Click);
            // 
            // btnRemoveMethod
            // 
            this.btnRemoveMethod.Location = new System.Drawing.Point(101, 132);
            this.btnRemoveMethod.Name = "btnRemoveMethod";
            this.btnRemoveMethod.Size = new System.Drawing.Size(84, 34);
            this.btnRemoveMethod.TabIndex = 5;
            this.btnRemoveMethod.Text = "Remove Method";
            this.btnRemoveMethod.UseVisualStyleBackColor = true;
            this.btnRemoveMethod.Click += new System.EventHandler(this.btnRemoveMethod_Click);
            // 
            // btnReplaceMethod
            // 
            this.btnReplaceMethod.Location = new System.Drawing.Point(101, 172);
            this.btnReplaceMethod.Name = "btnReplaceMethod";
            this.btnReplaceMethod.Size = new System.Drawing.Size(84, 34);
            this.btnReplaceMethod.TabIndex = 6;
            this.btnReplaceMethod.Text = "Replace Method";
            this.btnReplaceMethod.UseVisualStyleBackColor = true;
            this.btnReplaceMethod.Click += new System.EventHandler(this.btnReplaceMethod_Click);
            // 
            // btnToStringMethod
            // 
            this.btnToStringMethod.Location = new System.Drawing.Point(101, 212);
            this.btnToStringMethod.Name = "btnToStringMethod";
            this.btnToStringMethod.Size = new System.Drawing.Size(84, 34);
            this.btnToStringMethod.TabIndex = 7;
            this.btnToStringMethod.Text = "ToString Method";
            this.btnToStringMethod.UseVisualStyleBackColor = true;
            this.btnToStringMethod.Click += new System.EventHandler(this.btnToStringMethod_Click);
            // 
            // btnTiming
            // 
            this.btnTiming.Location = new System.Drawing.Point(192, 13);
            this.btnTiming.Name = "btnTiming";
            this.btnTiming.Size = new System.Drawing.Size(75, 23);
            this.btnTiming.TabIndex = 8;
            this.btnTiming.Text = "Timing";
            this.btnTiming.UseVisualStyleBackColor = true;
            this.btnTiming.Click += new System.EventHandler(this.btnTiming_Click);
            // 
            // StringBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTiming);
            this.Controls.Add(this.btnToStringMethod);
            this.Controls.Add(this.btnReplaceMethod);
            this.Controls.Add(this.btnRemoveMethod);
            this.Controls.Add(this.btnInsertMethod);
            this.Controls.Add(this.btnFormatString);
            this.Controls.Add(this.btnAppendMethod);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCreate);
            this.Name = "StringBuilderForm";
            this.Text = "StringBuilder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAppendMethod;
        private System.Windows.Forms.Button btnFormatString;
        private System.Windows.Forms.Button btnInsertMethod;
        private System.Windows.Forms.Button btnRemoveMethod;
        private System.Windows.Forms.Button btnReplaceMethod;
        private System.Windows.Forms.Button btnToStringMethod;
        private System.Windows.Forms.Button btnTiming;
    }
}