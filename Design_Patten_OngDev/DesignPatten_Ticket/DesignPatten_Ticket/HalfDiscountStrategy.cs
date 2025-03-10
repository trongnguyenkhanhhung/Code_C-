﻿using System;
using System.Collections.Generic;
using System.Text;
using Ticket_StrategyDesignPatten.Base;

namespace DesignPatten_Ticket
{
    internal class HalfDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price*0.5;
        }
    }
}
