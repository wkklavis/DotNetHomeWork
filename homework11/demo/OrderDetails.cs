﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    [Serializable]
    public  class OrderDetails
    {

        public  String Address { get; set; }
        public DateTime DeliverDate { get; set; }
        public override string ToString()
        {
            return Address+" 预计"+DeliverDate+"送到";
        }
        public OrderDetails(string address)
        {
            Address = address;
            DeliverDate = System.DateTime.Now.AddDays(7);
        }

        public OrderDetails()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   Address == details.Address;
        }

        public override int GetHashCode()
        {
            return -1984154133 + EqualityComparer<string>.Default.GetHashCode(Address);
        }
    }
}
