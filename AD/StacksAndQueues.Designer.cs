namespace AD
{
    partial class StacksAndQueues
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
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(87, 89);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(115, 46);
            this.btnQueue.TabIndex = 1;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(87, 22);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(115, 46);
            this.btnStack.TabIndex = 0;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // StacksAndQueues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 156);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Name = "StacksAndQueues";
            this.Text = "StacksAndQueues";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;

    }
}