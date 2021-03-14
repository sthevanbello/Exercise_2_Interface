﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Interface.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
