﻿namespace SolutionOfPractice1
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
            this.label3 = new System.Windows.Forms.Label();
            this.ramSizeTextBox = new System.Windows.Forms.TextBox();
            this.processorCoreNumberTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveAndClearButton
            // 
            this.saveAndClearButton.Location = new System.Drawing.Point(306, 296);
            this.saveAndClearButton.Name = "saveAndClearButton";
            this.saveAndClearButton.Size = new System.Drawing.Size(131, 23);
            this.saveAndClearButton.TabIndex = 0;
            this.saveAndClearButton.Text = "Save and Clear";
            this.saveAndClearButton.UseVisualStyleBackColor = true;
            this.saveAndClearButton.Click += new System.EventHandler(this.saveAndClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand Name";
            // 
            // brandNameTextBox
            // 
            this.brandNameTextBox.Location = new System.Drawing.Point(377, 73);
            this.brandNameTextBox.Name = "brandNameTextBox";
            this.brandNameTextBox.Size = new System.Drawing.Size(230, 22);
            this.brandNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM (GB)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Processor-Core i";
            // 
            // ramSizeTextBox
            // 
            this.ramSizeTextBox.Location = new System.Drawing.Point(377, 139);
            this.ramSizeTextBox.Name = "ramSizeTextBox";
            this.ramSizeTextBox.Size = new System.Drawing.Size(230, 22);
            this.ramSizeTextBox.TabIndex = 2;
            // 
            // processorCoreNumberTextBox
            // 
            this.processorCoreNumberTextBox.Location = new System.Drawing.Point(377, 207);
            this.processorCoreNumberTextBox.Name = "processorCoreNumberTextBox";
            this.processorCoreNumberTextBox.Size = new System.Drawing.Size(230, 22);
            this.processorCoreNumberTextBox.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(532, 296);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
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
            this.Controls.Add(this.ramSizeTextBox);
            this.Controls.Add(this.brandNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ramSizeTextBox;
        private System.Windows.Forms.TextBox processorCoreNumberTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

