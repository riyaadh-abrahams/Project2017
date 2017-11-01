using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2017.BusinessLayer.Entities
{
    public class PaymentDetails
    {
        public string PaymentID { get; set; }
        public string CreditCardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public string CVC { get; set; }

        public PaymentDetails(string paymentID, string creditCardNumber, int expiryMonth, int expiryYear, string cVC)
        {
            PaymentID = paymentID;
            CreditCardNumber = creditCardNumber;
            ExpiryMonth = expiryMonth;
            ExpiryYear = expiryYear;
            CVC = cVC;
        }

    }
}
