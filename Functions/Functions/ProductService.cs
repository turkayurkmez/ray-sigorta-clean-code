using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ProductService
    {
       
        public double Price { get; private set; }
        public void ChangeProductPrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Price), "Fiyat değeri negatif olamaz");
            }

            Price = price;
        }
    }
}
