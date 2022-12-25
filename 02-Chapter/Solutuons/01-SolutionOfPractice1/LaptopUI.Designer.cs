namespace _01_SolutionOfPractice1
{
    partial class LaptopUI
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
            this.brandNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processorCoreNumberTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveAndClearButton
            // 
            this.saveAndClearButton.Location = new System.Drawing.Point(187, 270);
            this.saveAndClearButton.Name = "saveAndClearButton";
            this.saveAndClearButton.Size = new System.Drawing.Size(143, 33);
            this.saveAndClearButton.TabIndex = 0;
            this.saveAndClearButton.Text = "Save and Clear ";
            this.saveAndClearButton.UseVisualStyleBackColor = true;
            this.saveAndClearButton.Click += new System.EventHandler(this.saveAndClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand Name";
            // 
            // brandNameTextBox
            // 
            this.brandNameTextBox.Location = new System.Drawing.Point(273, 106);
            this.brandNameTextBox.Name = "brandNameTextBox";
            this.brandNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.brandNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM (GB)";
            // 
            // ramTextBox
            // 
            this.ramTextBox.Location = new System.Drawing.Point(273, 147);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(207, 22);
            this.ramTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Processor-Core i";
            // 
            // processorCoreNumberTextBox
            // 
            this.processorCoreNumberTextBox.Location = new System.Drawing.Point(273, 194);
            this.processorCoreNumberTextBox.Name = "processorCoreNumberTextBox";
            this.processorCoreNumberTextBox.Size = new System.Drawing.Size(207, 22);
            this.processorCoreNumberTextBox.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(379, 270);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(101, 33);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // LaptopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processorCoreNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ramTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brandNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveAndClearButton);
            this.Name = "LaptopUI";
            this.Text = "Laptop Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAndClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brandNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ramTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox processorCoreNumberTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

