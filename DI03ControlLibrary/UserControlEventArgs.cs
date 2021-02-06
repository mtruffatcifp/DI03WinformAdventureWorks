using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI03ControlLibrary
{
    public class UserControlEventArgs:EventArgs
    {
        private string _ProductId;
        
        public UserControlEventArgs(Product product)
        {
            _ProductId = product.ProductId.ToString();
        }

        public string IdProduct { get { return _ProductId; } }
    }
}
