using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /*Create commercial class that will be derived from Customer Class
    * Author: Mo Sagnia
    * Date: 02 Jan 19
    */
    public class CustomerComm : CustomerRes
    {
        //declare all constants
        const decimal COMM_RATE = 60m;         //flat commercial rate for first 1000 kWh
        const decimal COMM_KWH = 0.045m;       //rate applied per additional kWh after 1000 kWh

        //create constructor with parameters for commercial (same parameters as residential customer)
        public CustomerComm(int a, string cn, char ct, decimal k) : base(a, cn, ct, k)
        {
            KWh = k;
        }

        //override the CalculateCharge method from Customer class
        public override decimal CalculateCharge()
        {
            if (KWh <= FIRST_1000)
            {
                chargeAmount = COMM_RATE;
            }
            else
            {
                chargeAmount = COMM_RATE + (KWh - FIRST_1000) * COMM_KWH;
            }

            return chargeAmount;
        }
    }
}
