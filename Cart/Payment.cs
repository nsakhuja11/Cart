using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Payment:IPayment
    { 
        public void CashOnDelivery(int amount)
        {
            Console.WriteLine("You have to pay Rs.{0} on delivery",amount);
        }

        public void OnlinePayment(int amount)
        {
            Console.WriteLine("You have to pay Rs.{0} using card",amount);
        }

        public void DisplayInvoice(List<Items> items, int amount)
        {
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].name);
                Console.WriteLine(items[i].price);
                Console.WriteLine(items[i].quantity);
            }
            Console.WriteLine(amount);
        }
    }
}
