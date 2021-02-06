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
            this.idLabel = new System.Windows.Forms.Label();
            this.dI03UserControl1 = new DI03ControlLibrary.DI03UserControl();
            this.SuspendLayout();
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.productIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productIdTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productIdTextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBox.ForeColor = System.Drawing.Color.White;
            this.productIdTextBox.Location = new System.Drawing.Point(572, 297);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(70, 26);
            this.productIdTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(532, 297);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 25);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // dI03UserControl1
            // 
            this.dI03UserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dI03UserControl1.Location = new System.Drawing.Point(12, 12);
            this.dI03UserControl1.Name = "dI03UserControl1";
            this.dI03UserControl1.Size = new System.Drawing.Size(486, 317);
            this.dI03UserControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(654, 335);
            this.Controls.Add(this.dI03UserControl1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.productIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "DI03 SPDVI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label idLabel;
        private DI03ControlLibrary.DI03UserControl dI03UserControl1;
    }
}

