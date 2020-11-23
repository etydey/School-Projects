namespace CSVErrorLog.Forms
{
    partial class AddEmployeeData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxPhone = new System.Windows.Forms.TextBox();
            this.uxDepartmentCombo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department: ";
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(126, 23);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(272, 23);
            this.uxFirstName.TabIndex = 1;
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(126, 66);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(272, 23);
            this.uxLastName.TabIndex = 2;
            // 
            // uxPhone
            // 
            this.uxPhone.Location = new System.Drawing.Point(126, 109);
            this.uxPhone.Name = "uxPhone";
            this.uxPhone.Size = new System.Drawing.Size(272, 23);
            this.uxPhone.TabIndex = 3;
            // 
            // uxDepartmentCombo
            // 
            this.uxDepartmentCombo.FormattingEnabled = true;
            this.uxDepartmentCombo.Items.AddRange(new object[] {
            "Human Resource",
            "Financial Reporting",
            "Sales"});
            this.uxDepartmentCombo.Location = new System.Drawing.Point(126, 155);
            this.uxDepartmentCombo.Name = "uxDepartmentCombo";
            this.uxDepartmentCombo.Size = new System.Drawing.Size(272, 24);
            this.uxDepartmentCombo.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uxAdd);
            this.panel1.Controls.Add(this.uxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 53);
            this.panel1.TabIndex = 8;
            // 
            // uxAdd
            // 
            this.uxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAdd.Location = new System.Drawing.Point(192, 3);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(91, 41);
            this.uxAdd.TabIndex = 5;
            this.uxAdd.Text = "&Add";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxClose
            // 
            this.uxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxClose.Location = new System.Drawing.Point(306, 3);
            this.uxClose.Name = "uxClose";
            this.uxClose.Size = new System.Drawing.Size(91, 41);
            this.uxClose.TabIndex = 6;
            this.uxClose.Text = "&Close";
            this.uxClose.UseVisualStyleBackColor = true;
            this.uxClose.Click += new System.EventHandler(this.uxClose_Click);
            // 
            // AddEmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uxDepartmentCombo);
            this.Controls.Add(this.uxPhone);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmployeeData";
            this.Text = "Add Employee Data";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.TextBox uxPhone;
        private System.Windows.Forms.ComboBox uxDepartmentCombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxClose;
    }
}