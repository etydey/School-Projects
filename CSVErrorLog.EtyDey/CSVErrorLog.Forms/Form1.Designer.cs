namespace CSVErrorLog.Forms
{
    partial class Form1
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
            this.uxError = new System.Windows.Forms.TextBox();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxDisplay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxError
            // 
            this.uxError.Location = new System.Drawing.Point(17, 33);
            this.uxError.Margin = new System.Windows.Forms.Padding(4);
            this.uxError.Name = "uxError";
            this.uxError.Size = new System.Drawing.Size(427, 23);
            this.uxError.TabIndex = 0;
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(309, 104);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(75, 28);
            this.uxAdd.TabIndex = 1;
            this.uxAdd.Text = "&Add";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxDisplay
            // 
            this.uxDisplay.Location = new System.Drawing.Point(309, 329);
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.Size = new System.Drawing.Size(75, 27);
            this.uxDisplay.TabIndex = 2;
            this.uxDisplay.Text = "&Display";
            this.uxDisplay.UseVisualStyleBackColor = true;
            this.uxDisplay.Click += new System.EventHandler(this.uxDisplay_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 132);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 357);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxError);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxError;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxDisplay;
        private System.Windows.Forms.ListBox listBox1;
    }
}

