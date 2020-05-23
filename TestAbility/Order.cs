using System;
using System.Collections.Generic;
using System.Text;

namespace TestAbility
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped { 
            get { return Shipment != null; } 
        }

    }
}
