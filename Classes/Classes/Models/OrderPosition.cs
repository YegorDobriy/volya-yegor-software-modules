using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Models
{
    internal class OrderPosition
    {
        public int PositionId;
        public int OrderId;
        public int DishId;
        public int Quantity;
        public decimal AgreedPrice;
        public string LineStatus;
    }
}
