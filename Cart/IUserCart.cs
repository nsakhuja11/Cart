using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    interface IUserCart
    {
        void AddItemToCart(Items item);

        void RemoveItemFromCart(Items item);

        void CalculateAmount();

        void DisplayCart();
    }
}
