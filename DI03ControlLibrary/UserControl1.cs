using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace DI03ControlLibrary
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            var productModel = DataAccess.getProductModel(DataAccess.getRandomId());
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image img = Image.FromStream(ms);
            pictureBox.Image = img;
            nameTextBox.Text = $"{productModel.ProductModelId} -  {productModel.Name}";
            priceTextBox.Text = productModel.ListPrice.ToString() + " €";
            loadSizeButtons(productModel.ProductModelId);
        }

        private void loadSizeButtons(int id)
        {
            sizesFlowLayoutPanel.Controls.Clear();
            List<Product> products = DataAccess.getProductSizes(id);

            foreach (var p in products)
            {
                //Avoid creating emtpy button in case product has no size options
                if (p.Size == null)
                {
                    continue;
                }
                Button button = new Button();
                button.Text = p.Size;
                button.Size = new Size(160, 20);
                sizesFlowLayoutPanel.Controls.Add(button);
            }
        }
    }
}
