namespace _02_EmployeeUserDefinedType
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
            this.saveAndClearButton_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.showSavedDataButton_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveAndClearButton_Click
            // 
            this.saveAndClearButton_Click.Location = new System.Drawing.Point(247, 286);
            this.saveAndClearButton_Click.Name = "saveAndClearButton_Click";
            this.saveAndClearButton_Click.Size = new System.Drawing.Size(134, 23);
            this.saveAndClearButton_Click.TabIndex = 0;
            this.saveAndClearButton_Click.Text = "Save and Clear";
            this.saveAndClearButton_Click.UseVisualStyleBackColor = true;
            this.saveAndClearButton_Click.Click += new System.EventHandler(this.saveAndClearButton_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(333, 115);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(217, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // showSavedDataButton_Click
            // 
            this.showSavedDataButton_Click.Location = new System.Drawing.Point(416, 286);
            this.showSavedDataButton_Click.Name = "showSavedDataButton_Click";
            this.showSavedDataButton_Click.Size = new System.Drawing.Size(134, 23);
            this.showSavedDataButton_Click.TabIndex = 0;
            this.showSavedDataButton_Click.Text = "Show Save Data";
            this.showSavedDataButton_Click.UseVisualStyleBackColor = true;
            this.showSavedDataButton_Click.Click += new System.EventHandler(this.showSavedDataButton_Click_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salary Amount";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(333, 162);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(217, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(333, 216);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 2;
            // 
            // EmployeeInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showSavedDataButton_Click);
            this.Controls.Add(this.saveAndClearButton_Click);
            this.Name = "EmployeeInfoUI";
            this.Text = "Employee Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAndClearButton_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button showSavedDataButton_Click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
    }
}

