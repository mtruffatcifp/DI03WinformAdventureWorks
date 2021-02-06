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
    public partial class DI03UserControl:UserControl
    {
        Product product = new Product();
        public EventHandler<UserControlEventArgs> ButtonSize_Click;

        public virtual void OnButtonSize_Click(UserControlEventArgs e)
        {
            ButtonSize_Click?.Invoke(this, e);
        }

        public void Size_Click(Object sender, EventArgs e)
        {
            product.ProductId = Int32.Parse(((Button)sender).Name); //Conseguir id
            UserControlEventArgs args = new UserControlEventArgs(product); //se le pasa los argumentos al evento
            OnButtonSize_Click(args);
        }
        public DI03UserControl()
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
                button.Name = p.ProductId.ToString();
                button.Size = new Size(125, 25);
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Nirmala UI", 10F);
                button.ForeColor = Color.WhiteSmoke;
                sizesFlowLayoutPanel.Controls.Add(button);
                button.Click += Size_Click;
            }
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.SetToolTip(pictureBox, "Click to display another product");
        }
    }
}
