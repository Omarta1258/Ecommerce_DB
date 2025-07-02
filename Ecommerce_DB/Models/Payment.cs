using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAKERS_SUCK.Models
{
    public class Payment
    {
        public int PaymentID;
        public int OrderID;
        public decimal Amount;
        public string Method = "";
    }
}
