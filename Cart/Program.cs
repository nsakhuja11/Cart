using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCart _cart = new UserCart();
            Payment pay = new Payment();
            Items items = new Items();
            //Sample
            items.Id = 1;
            items.name = "qaergqer";
            items.price = 20;
            items.quantity = 3;
            //Sample

            _cart.AddItemToCart(items);
            _cart.RemoveItemFromCart(items);
            _cart.CalculateAmount();
            _cart.DisplayCart();

            Console.WriteLine("Enter 1 for COD and 2 for online payment");
            int choice;
            choice = Console.Read();
            if (choice == 1)
            {
                pay.CashOnDelivery(_cart.amount);
            }
            else if(choice == 2)
            {
                pay.OnlinePayment(_cart.amount);
            }

            pay.DisplayInvoice(_cart.cart, _cart.amount);
        }
    }
}
