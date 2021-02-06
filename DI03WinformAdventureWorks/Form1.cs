using DI03ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI03WinformAdventureWorks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dI03UserControl1.ButtonSize_Click += getProductId;
        }

        private void getProductId(Object sender, UserControlEventArgs e)
        {
            productIdTextBox.Text = e.IdProduct;
        }
    }
}
