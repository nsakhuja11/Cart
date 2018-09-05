using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    interface IPayment
    {
        void CashOnDelivery(int amount);

        void OnlinePayment(int amount);

        void DisplayInvoice(List<Item> item, int amount);
    }
}
