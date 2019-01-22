using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /*Create residential class that will be derived from Customer Class
    * Author: Mo Sagnia
    * Date: 02 Jan 19
    */
    public class CustomerRes: Customer
    {
        //declare all constants
        const decimal RES_RATE = 6m;           //flat residential rate
        const decimal RES_KWH = 0.052m;        //rate applied per additional kWh used

        //declare all relevant properties
        private decimal kWh;           //input: kWh used for residential or commercial customers

        //create getter and setter
        public decimal KWh
        {
            get
            {
                return kWh;
            }
            set
            {
                kWh = value;
            }
        }

        //create constructor with parameters for residential
        public CustomerRes(int a, string cn, char ct, decimal k) : base(a, cn, ct)
        {
            KWh = k;
        }

        //override the CalculateCharge method from Customer class
        public override decimal CalculateCharge()
        {
            chargeAmount = RES_RATE + RES_KWH * KWh;

            return chargeAmount;
        }

    }
}
