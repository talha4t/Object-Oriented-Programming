namespace _16_ComboBoxExample
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
            this.countryListComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // countryListComboBox
            // 
            this.countryListComboBox.FormattingEnabled = true;
            this.countryListComboBox.Location = new System.Drawing.Point(335, 129);
            this.countryListComboBox.Name = "countryListComboBox";
            this.countryListComboBox.Size = new System.Drawing.Size(121, 24);
            this.countryListComboBox.TabIndex = 0;
            this.countryListComboBox.SelectedIndexChanged += new System.EventHandler(this.countryListComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryListComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox countryListComboBox;
    }
}

