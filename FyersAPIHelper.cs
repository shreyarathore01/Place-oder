using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FyersAPI;
namespace oderapp
{
    class FyersAPIHelper
    {
        public string PlaceOrder(Order order)
        {
            // TODO: Implement the code to place the order using the Fyers API.
            return "Order placed successfully.";
        }
    }
    public enum Side
    {
        Buy,
        Sell
    }

    public class Order
    {
        public string Symbol { get; set; }
        public Side Side { get; set; }
        public int Qty { get; set; }
    }
}
