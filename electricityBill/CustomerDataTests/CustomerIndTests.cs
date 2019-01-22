using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    /*Create Unit Tests for the various method(s) contained in CustomerInd class
     * Author: Mo Sagnia
     * Date: 02 Jan 19
     */
    [TestClass()]
    public class CustomerIndTests
    {
        int accountNumber = 1;
        string accountName = "Mbye S";
        char custType = 'I';
        [TestMethod()]
        public void IndustrialChargeWithLowUsageTestSucc()
        {
            // Arrange
            decimal usagePeak = 100m; //low usage during peak hours defined as <= 1000 kWh
            decimal usageOff = 100m; //low usage during off-peak hours defined as <= 1000 kWh
            CustomerInd customerInd = new CustomerInd(accountNumber, accountName, custType, usagePeak, usageOff);
            decimal expectedCharge = 116;
            decimal actualCharge;

            //Act
            actualCharge = customerInd.CalculateCharge();

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void IndustrialChargeWithHighUsageTestSucc()
        {
            // Arrange
            decimal usagePeak = 2000m; //high usage during peak hours defined as > 1000 kWh
            decimal usageOff = 3000m; //high usage during off-peak hours defined as > 1000 kWh
            CustomerInd customerInd = new CustomerInd(accountNumber, accountName, custType, usagePeak, usageOff);
            decimal expectedCharge = 237;
            decimal actualCharge;

            //Act
            actualCharge = customerInd.CalculateCharge();

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}