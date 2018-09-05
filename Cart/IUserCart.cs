using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    interface IUserCart
    {
        void AddItemToCart(Item item);

        void RemoveItemFromCart(Item item);

        void CalculateAmount();

        void DisplayCart();
    }
}
