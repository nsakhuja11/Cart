using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class UserCart:IUserCart
    {
        public List<Items> cart = new List<Items>();
        public int amount = 0;
        public void AddItemToCart(Items item)
        {
            cart.Add(item);
        }

        public void RemoveItemFromCart(Items item)
        {
            cart.Remove(item);
        }

        public void CalculateAmount()
        {
            for(int i=0; i < cart.Count; i++)
            {
                amount = amount + (cart[i].price * cart[i].quantity);
            }
        }

        public void DisplayCart()
        {
            for(int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine(cart[i].name);
                Console.WriteLine(cart[i].quantity);
                Console.WriteLine(cart[i].price);
            }
        }
    }
}
