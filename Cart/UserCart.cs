using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    public class UserCart : IUserCart
    {
        public List<Item> cart = new List<Item>();
        public int amount = 0;
        public void AddItemToCart(Item item)
        {
            int flag = 0;
            for(int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Id == item.Id)
                {
                    cart[i].quantity++;
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                cart.Add(item);
            }
            Console.WriteLine();
            Console.WriteLine("Item Added Succesfully");
            Console.WriteLine();
        }

        public void RemoveItemFromCart(Item item)
        {
            cart.Remove(item);
            Console.WriteLine();
            Console.WriteLine("Item Removed Succesfully");
            Console.WriteLine();
        }

        public void CalculateAmount()
        {
            amount = 0;
            for(int i=0; i < cart.Count; i++)
            {
                amount = amount + (cart[i].price * cart[i].quantity);
            }
            Console.WriteLine();
            Console.WriteLine("Your Payable amount is Rs.{0}",amount);
            Console.WriteLine();
        }

        public void DisplayCart()
        {
            Console.WriteLine();
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine("Item Name : {0}",cart[i].name);
                Console.WriteLine("Item Quantity : {0}", cart[i].quantity);
                Console.WriteLine("Item Price : {0}", cart[i].price);
                Console.WriteLine();
            }
        }
    }
}
