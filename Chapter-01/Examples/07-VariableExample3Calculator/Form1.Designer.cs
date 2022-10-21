namespace _07_VariableExample3Calculator
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
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(259, 193);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(382, 193);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(91, 32);
            this.subButton.TabIndex = 0;
            this.subButton.Text = "Substract";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(382, 250);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(91, 33);
            this.divideButton.TabIndex = 0;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(259, 250);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(88, 33);
            this.multiplyButton.TabIndex = 0;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // number1TextBox
            // 
            this.number1TextBox.AccessibleName = "";
            this.number1TextBox.Location = new System.Drawing.Point(259, 88);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(195, 22);
            this.number1TextBox.TabIndex = 1;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(259, 138);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(195, 22);
            this.number2TextBox.TabIndex = 1;
            this.number2TextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
    }
}

