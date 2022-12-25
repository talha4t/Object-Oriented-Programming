namespace _01_EmployeePrimitiveType
{
    partial class EmployeeInfoUI
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
            this.saveAndClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.showSavedDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveAndClearButton
            // 
            this.saveAndClearButton.Location = new System.Drawing.Point(169, 249);
            this.saveAndClearButton.Name = "saveAndClearButton";
            this.saveAndClearButton.Size = new System.Drawing.Size(118, 23);
            this.saveAndClearButton.TabIndex = 0;
            this.saveAndClearButton.Text = "Save and Clear ";
            this.saveAndClearButton.UseVisualStyleBackColor = true;
            this.saveAndClearButton.Click += new System.EventHandler(this.saveAndClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(258, 93);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(232, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(258, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salary Amount";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(258, 176);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(182, 22);
            this.salaryTextBox.TabIndex = 2;
            // 
            // showSavedDataButton
            // 
            this.showSavedDataButton.Location = new System.Drawing.Point(319, 249);
            this.showSavedDataButton.Name = "showSavedDataButton";
            this.showSavedDataButton.Size = new System.Drawing.Size(131, 23);
            this.showSavedDataButton.TabIndex = 0;
            this.showSavedDataButton.Text = "Show Saved Data";
            this.showSavedDataButton.UseVisualStyleBackColor = true;
            this.showSavedDataButton.Click += new System.EventHandler(this.showSavedDataButton_Click);
            // 
            // EmployeeInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showSavedDataButton);
            this.Controls.Add(this.saveAndClearButton);
            this.Name = "EmployeeInfoUI";
            this.Text = "Employee Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAndClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button showSavedDataButton;
    }
}

