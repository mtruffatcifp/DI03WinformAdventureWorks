namespace DI03WinformAdventureWorks
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
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.dI03UserControl1 = new DI03ControlLibrary.DI03UserControl();
            this.SuspendLayout();
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(542, 12);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(78, 20);
            this.productIdTextBox.TabIndex = 1;
            // 
            // dI03UserControl1
            // 
            this.dI03UserControl1.Location = new System.Drawing.Point(12, 12);
            this.dI03UserControl1.Name = "dI03UserControl1";
            this.dI03UserControl1.Size = new System.Drawing.Size(512, 270);
            this.dI03UserControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 289);
            this.Controls.Add(this.dI03UserControl1);
            this.Controls.Add(this.productIdTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productIdTextBox;
        private DI03ControlLibrary.DI03UserControl dI03UserControl1;
    }
}

