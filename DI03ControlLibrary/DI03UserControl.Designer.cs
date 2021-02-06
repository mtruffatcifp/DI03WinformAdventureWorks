namespace DI03ControlLibrary
{
    partial class DI03UserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.sizesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageLabel = new System.Windows.Forms.Label();
            this.sizesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(10, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(329, 223);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameTextBox.Location = new System.Drawing.Point(10, 279);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(329, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.priceTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.priceTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.priceTextBox.Location = new System.Drawing.Point(349, 279);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(125, 25);
            this.priceTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(7, 257);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Product name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.priceLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.priceLabel.Location = new System.Drawing.Point(345, 257);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 19);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // sizesFlowLayoutPanel
            // 
            this.sizesFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.sizesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sizesFlowLayoutPanel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizesFlowLayoutPanel.Location = new System.Drawing.Point(349, 24);
            this.sizesFlowLayoutPanel.Name = "sizesFlowLayoutPanel";
            this.sizesFlowLayoutPanel.Size = new System.Drawing.Size(125, 223);
            this.sizesFlowLayoutPanel.TabIndex = 5;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.imageLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.imageLabel.Location = new System.Drawing.Point(7, 3);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(50, 19);
            this.imageLabel.TabIndex = 4;
            this.imageLabel.Text = "Image:";
            // 
            // sizesLabel
            // 
            this.sizesLabel.AutoSize = true;
            this.sizesLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.sizesLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sizesLabel.Location = new System.Drawing.Point(345, 3);
            this.sizesLabel.Name = "sizesLabel";
            this.sizesLabel.Size = new System.Drawing.Size(35, 19);
            this.sizesLabel.TabIndex = 4;
            this.sizesLabel.Text = "Size:";
            // 
            // DI03UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.sizesFlowLayoutPanel);
            this.Controls.Add(this.sizesLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "DI03UserControl";
            this.Size = new System.Drawing.Size(486, 317);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.FlowLayoutPanel sizesFlowLayoutPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label sizesLabel;
    }
}
