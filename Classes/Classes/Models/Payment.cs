using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Models
{
    internal class Payment
    {
        public int PaymentId;
        public int OrderId;
        public decimal Amount;
        public string PaymentType;
    }
}
