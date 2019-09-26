using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Product : BaseClass
    {
        private int price;

        public Product(string productName, int productId, int price)
        {
            this.Name = productName;
            this.Id = productId;
            this.price = price;
        }
    }
}
