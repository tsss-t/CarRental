using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCpart
{
    public static class ClientType
    {
        public enum Type:int 
        {
            UserSummery  = 0,
            UserManager = 1,
            OrderSummery ,
            CarSummery,
            Version,
            Type,
            Shop,
            Province,
            Order,
            City,
            Checkout,
            Brand,
            Action
        }
    }
}
