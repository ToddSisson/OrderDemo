using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Order
    {
        private const double PRICE =  19.95;
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public int QuantityOrdered { get; set; }
        public double TotalPrice
        {
            get
            {
                return QuantityOrdered* PRICE;
            }
        }

        public Order(int orderNumber, string customerName, int quantityOrdered)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            QuantityOrdered = quantityOrdered;
        }

        public override bool Equals(object obj)
        {
            bool isEqual;
            Order temp = (Order)obj;
            if (OrderNumber == temp.OrderNumber)
                isEqual = true;
            else
                isEqual = false;
            return isEqual; 
        }

        public override int GetHashCode()
        {
            return OrderNumber;
        }

        public override string ToString()
        {
            return ($"\nOrder Number: {OrderNumber}\nCustomer Name: {CustomerName}\nQuanity Ordered: {QuantityOrdered}\nPrice per Object: {PRICE}\nTotal Price: {TotalPrice}");
        }

    }
}
