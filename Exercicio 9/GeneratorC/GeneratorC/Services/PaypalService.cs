﻿using System;
using System.Collections.Generic;
using System.Text;
using GeneratorC.Entities;

namespace GeneratorC.Services
{
    class PaypalService : IOnlinePaymentoService
    {


        public double Interest(double amaunt, int month)
        {
            double temp = (amaunt*0.01 * month) +amaunt;
            return temp;
        }

        public double Paymentfee(double amaunt)
        {
            double temp = (amaunt * 0.02) + amaunt;
            return temp;
        }

    }
}
