using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    /*Create Unit Tests for the various method(s) contained in CustomerComm class
     * Author: Mo Sagnia
     * Date: 02 Jan 19
     */
    [TestClass()]
    public class CustomerCommTests
    {
        int accountNumber = 1;
        string accountName = "Alli K.";
        char custType = 'C';
        [TestMethod()]
        public void CommercialChargeWithLowUsageTestSucc()
        {
            //Arrange
            decimal usage = 100m; //low usage defined as <= 1000 kWh
            CustomerComm customerComm = new CustomerComm(accountNumber, accountName, custType, usage);
            decimal expectedCharge = 60;
            decimal actualCharge;

            //Act
            actualCharge = customerComm.CalculateCharge();

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CommercialChargeWithHighUsageTestSucc()
        {
            //Arrange
            decimal usage = 2000m; //high usage defined as > 1000 kWh
            CustomerComm customerComm = new CustomerComm(accountNumber, accountName, custType, usage);
            decimal expectedCharge = 105;
            decimal actualCharge;

            //Act
            actualCharge = customerComm.CalculateCharge();

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}