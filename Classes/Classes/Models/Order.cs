using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Models
{
    internal class Order
    {
        public int OrderId;
        public int WaiterId;
        public int GuestId; 
        public string OrderType;
        public DateTime DateTime;
        public string Status;
    }
}
