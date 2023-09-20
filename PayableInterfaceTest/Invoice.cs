using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    // Invoice class implements IPayable
    public class Invoice : IPayable
    {
        public string partNumber { get; }
        public string partDescription { get; }
        private int quantity;
        private decimal princePerItem;

        public Invoice(string partNumber, string partDescription, int quantity, decimal princePerItem)
        {

           
        }

        public decimal GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
