using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class OrderDetails
    {
        String Address { get; set; }
        DateTime deliverDate;
        public override string ToString()
        {
            return Address+" 预计"+deliverDate+"送到";
        }
        public OrderDetails(string address)
        {
            Address = address;
            deliverDate = System.DateTime.Now.AddDays(7);
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
