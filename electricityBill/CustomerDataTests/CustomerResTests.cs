using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    /*Create Unit Tests for the various method(s) contained in CustomerRes class
     * Author: Mo Sagnia
     * Date: 02 Jan 19
     */
    [TestClass()]
    public class CustomerResTests
    {
        int accountNumber = 1;
        string accountName = "Mo S.";
        char custType = 'R';
        [TestMethod()]
        public void ResidentialChargeWithUsageTestSucc()
        {
            //Arrange
            decimal usage = 100m;
            CustomerRes customerRes = new CustomerRes(accountNumber, accountName, custType, usage);
            decimal expectedCharge = 11.2m;
            decimal actualCharge;

            //Act
            actualCharge = customerRes.CalculateCharge();

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void ResidentialChargeWithoutUsageTestSucc()
        {
            //Arrange
            decimal usage = 0m; //no usage by customer should still render a charge of $6
            CustomerRes customerRes = new CustomerRes(accountNumber, accountName, custType, usage);
            decimal expectedCharge = 6m;
            decimal actualCharge;

            //Act
            actualCharge = customerRes.CalculateCharge();

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}