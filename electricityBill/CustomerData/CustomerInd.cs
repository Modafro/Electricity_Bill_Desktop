using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /*Create industrial class that will be derived from Customer Class
    * Author: Mo Sagnia
    * Date: 02 Jan 19
    */
    public class CustomerInd : Customer
    {
        //declare all constants
        const decimal INDUS_PK_RATE = 0.065m;      //flat industrial rate during peak hours for first 1000 kWh
        const decimal INDUS_PK_KWH = 76m;      //rate applied per additional kWh after 1000 kWh during peak hours
        const decimal INDUS_OFF_RATE = 0.028m;     //flat industrial rate during off-peak hours for first 1000 kWh
        const decimal INDUS_OFF_KWH = 40m;   //rate applied per additional kWh after 1000 kWh during off-peak hours

        //declare all relevant properties
        private decimal kWhPeak;       //input: kWh used for industrial customers during peak hours
        private decimal kWhOff;        //input: kWh used for industrial customers during off-peak hours

        //create getters and setters
        public decimal KWhPeak
        {
            get
            {
                return kWhPeak;
            }
            set
            {
                kWhPeak = value;
            }
        }

        public decimal KWhOff
        {
            get
            {
                return kWhOff;
            }
            set
            {
                kWhOff = value;
            }
        }

        //create constructor with parameters for industrial customer
        public CustomerInd(int a, string cn, char ct, decimal kp, decimal ko) : base(a, cn,ct)
        {
            KWhPeak = kp;
            KWhOff = ko;
        }

        //override the CalculateCharge method from Customer class
        public override decimal CalculateCharge()
        {
            decimal billkWhPeak = 0m;        //variable used to store the bill for peak hours for industrial customers
            decimal billkWhOff = 0m;         //variable used to store the bill for off-peak hours for industrial customers

            //bill for peak hours
            if (KWhPeak <= FIRST_1000)
            {
                billkWhPeak = INDUS_PK_KWH;
            }
            else if (KWhPeak > FIRST_1000)
            {
                billkWhPeak = INDUS_PK_KWH + (KWhPeak - FIRST_1000) * INDUS_PK_RATE;
            }

            //bill for off-peak hours
            if (KWhOff <= FIRST_1000)
            {
                billkWhOff = INDUS_OFF_KWH;
            }
            else if (KWhOff > FIRST_1000)
            {
                billkWhOff = INDUS_OFF_KWH + (KWhOff- FIRST_1000) * INDUS_OFF_RATE;
            }

            chargeAmount = billkWhPeak + billkWhOff;

            return chargeAmount;
        }
    }
}
