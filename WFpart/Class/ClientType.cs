using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFpart
{
    public static class ClientType
    {
        public enum Type:int 
        {
            UserSummery  = 0,
            UserManager = 1,
            SalaryInfoSummery ,
            OrderSummery ,
            CarSummery,
            WorkRAP,
            SalaryLog,
            SalaryAppend,
            Salary,
            RAP,
            Version,
            Type,
            Shop,
            Province,
            Order,
            City,
            Checkout,
            Brand,
            Action,
            Account,
            GetCar
        }
    }
}
