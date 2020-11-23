namespace CSVErrorLog.Forms
{
    partial class DisplayErrorLog
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
            this.components = new System.ComponentModel.Container();
            this.uxDisplayLog = new System.Windows.Forms.ListBox();
            this.uxClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxDisplayLog
            // 
            this.uxDisplayLog.FormattingEnabled = true;
            this.uxDisplayLog.HorizontalScrollbar = true;
            this.uxDisplayLog.ItemHeight = 16;
            this.uxDisplayLog.Location = new System.Drawing.Point(12, 12);
            this.uxDisplayLog.Name = "uxDisplayLog";
            this.uxDisplayLog.Size = new System.Drawing.Size(479, 292);
            this.uxDisplayLog.TabIndex = 1;
            // 
            // uxClose
            // 
            this.uxClose.Location = new System.Drawing.Point(397, 325);
            this.uxClose.Name = "uxClose";
            this.uxClose.Size = new System.Drawing.Size(93, 32);
            this.uxClose.TabIndex = 2;
            this.uxClose.Text = "&Close";
            this.uxClose.UseVisualStyleBackColor = true;
            this.uxClose.Click += new System.EventHandler(this.uxClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // DisplayErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 373);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.uxClose);
            this.Controls.Add(this.uxDisplayLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayErrorLog";
            this.Text = "Display Error Log";
            this.Load += new System.EventHandler(this.DisplayErrorLog_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxDisplayLog;
        private System.Windows.Forms.Button uxClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}