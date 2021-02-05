using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI03ControlLibrary
{
    class ProductModel
    {
        public int ProductModelId { get; set; }
        public string Name { get; set; }
        public float ListPrice { get; set; }
        public byte[] LargePhoto { get; set; }
    }
}
