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
            Console.WriteLine();
            Console.WriteLine("You have to pay Rs.{0} on delivery",amount);
            Console.WriteLine();
        }

        public void OnlinePayment(int amount)
        {
            Console.WriteLine();
            Console.WriteLine("You have to pay Rs.{0} using card",amount);
            Console.WriteLine();
        }

        public void DisplayInvoice(List<Item> item,int amount)
        {
            Console.WriteLine();
            for (int i = 0; i < item.Count; i++)
            {
                Console.WriteLine("Item Name : {0}", item[i].name);
                Console.WriteLine("Item Price : {0}", item[i].price);
                Console.WriteLine("Item Quantity : {0}", item[i].quantity);
                Console.WriteLine();
            }
            Console.WriteLine("Amount Paid {0}",amount);
            Console.ReadKey();
        }
    }
}
