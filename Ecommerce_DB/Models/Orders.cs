using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAKERS_SUCK.Models
{
    public class Orders
    {
        public int OrderID;
        public int CustomerID;
        public decimal ProductsPrice;
        public decimal ShippingPrice;
        public decimal Taxes;
        public string createdAt = "";
    }
}
