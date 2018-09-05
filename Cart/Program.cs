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
            List<Item> inventory = new List<Item>()
            {
                new Item { Id = 1, name = "Lays", quantity = 50, price = 20 },
                new Item { Id = 2, name = "Pepsi", quantity = 10, price = 50 },
                new Item { Id = 1, name = "Ice-cream", quantity = 30, price = 40 }
            };

            int choice;
            Console.WriteLine("Enter 1 to Add item to your cart");
            Console.WriteLine("Enter 2 to remove item from cart");
            Console.WriteLine("Enter 3 to calculate amount");
            Console.WriteLine("Enter 4 to Display your cart");
            Console.WriteLine("Enter 0 to Checkout");
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 0)
            {
                if (choice == 1)
                {
                    int itemChoice=0;
                    Console.WriteLine("Enter 1 to add Lays");
                    Console.WriteLine("Enter 2 to add Pepsi");
                    Console.WriteLine("Enter 3 to add ice-cream");
                    itemChoice = Convert.ToInt32(Console.ReadLine());
                    inventory[itemChoice - 1].quantity--;
                    Item item = new Item();
                    item.Id = inventory[itemChoice - 1].Id;
                    item.name = inventory[itemChoice - 1].name;
                    item.quantity = 1;
                    item.price = inventory[itemChoice - 1].price;
                    _cart.AddItemToCart(item);
                }
                else if(choice == 2)
                {
                    int itemChoice = 0;
                    Console.WriteLine("Enter 1 to remove Lays");
                    Console.WriteLine("Enter 2 to remove Pepsi");
                    Console.WriteLine("Enter 3 to remove ice-cream");
                    itemChoice = Convert.ToInt32(Console.ReadLine());
                    _cart.RemoveItemFromCart(inventory[itemChoice - 1]);
                }
                else if (choice == 3)
                {
                    _cart.CalculateAmount();
                }
                else if (choice == 4)
                {
                    _cart.DisplayCart();
                }
                Console.WriteLine("Enter 1 to Add item to your cart");
                Console.WriteLine("Enter 2 to remove item from cart");
                Console.WriteLine("Enter 3 to calculate amount");
                Console.WriteLine("Enter 4 to Display your cart");
                Console.WriteLine("Enter 0 to Checkout");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Enter 1 for COD or 2 for online payment");
            int paymentchoice;
            paymentchoice = Convert.ToInt32(Console.ReadLine());
            if (paymentchoice == 1)
            {
                pay.CashOnDelivery(_cart.amount);
            }
            else if(paymentchoice == 2)
            {
                pay.OnlinePayment(_cart.amount);
            }
            pay.DisplayInvoice(_cart.cart,_cart.amount);
        }
    }
}
