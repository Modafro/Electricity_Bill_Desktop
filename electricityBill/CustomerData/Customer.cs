using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /*Create a main customer class that will be a parent to derived classes
    * Author: Mo Sagnia
    * Date: 02 Jan 19
    */
    public class Customer
    {
        //declare all constants
        protected const decimal FIRST_1000 = 1000m;      //save first 1000 kWh in a variable

        //declare all relevant properties
        private int accountNo;
        private string customerName;
        private char customerType;
        protected decimal chargeAmount;
        
       
        //create getters and setters for all properties
        public int AccountNo
        {
            get
            {
                return accountNo;
            }
            set
            {
                if (accountNo >= 0)
                { accountNo = value; }
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public char CustomerType
        {
            get
            {
                return customerType;
            }
            set
            {
                customerType = value;
            }
        }

        public decimal ChargeAmount
        {
            get
            {
                return chargeAmount;
            }
            set
            {
                chargeAmount = value;
            }
        }

        //create base constructor for child classes
        public Customer(int a, string cn, char ct)
        {
            AccountNo = a;
            CustomerName = cn;
            CustomerType = ct;
        }

        //create constructor if the charge amount is provided
        public Customer(int a, string cn, char ct, decimal ca)
        {
            AccountNo = a;
            CustomerName = cn;
            CustomerType = ct;
            ChargeAmount = ca;
        }

        //create method to calculate the charge amount
        public virtual decimal CalculateCharge()
        {
            return ChargeAmount;
        }

        //create a method to return a string with customer information
        public override string ToString()
        {
            return "Account#: " + accountNo.ToString() + "  Customer: " + customerName + "  Type: " + customerType.ToString() + "  Charge: " + chargeAmount.ToString("c");
        }

        //create a method to return a string for ease of storing in a text file
        public string ToFileString()
        {
            return accountNo.ToString() + ", " + customerName + ", " + customerType.ToString() + ", " + chargeAmount.ToString("c");
        }
    }
}
