using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnthatileMashego_Project_PM04;

namespace OnthatileMashego_Project_PM04.Tests
{
    /*
         Unit and Integration tests for the PayrollCalculator class.
         Covers: Gross Pay, UIF, Membership Fee, PAYE, Net Pay and full integration.
    */
    [TestClass]
    public class PayrollCalculatorTest
    {
        private PayrollCalculator _calc;

        // TestContext allows logging output visible in Test Explorer
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            _calc = new PayrollCalculator();
        }

        // UNIT TESTS – Individual calculation methods!!!!!!
        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("Gross Pay should equal Hours Worked x R950.00")]
        public void GrossPay_ShouldReturnR2550_WhenHoursWorkedIs17()
        {
            // Arrange
            double hoursWorked = 17;
            double expectedGross = 17 * 950.00; // R16 150.00

            // Act
            double actualGross = _calc.CalculateGrossPay(hoursWorked);

            // Assert
            TestContext.WriteLine($"Hours Worked: {hoursWorked}");
            TestContext.WriteLine($"Expected Gross Pay: R{expectedGross:N2}");
            TestContext.WriteLine($"Actual Gross Pay:   R{actualGross:N2}");

            Assert.AreEqual(expectedGross, actualGross, 0.01,
                "Gross Pay calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("UIF should be exactly 1% of gross pay")]
        public void UIF_ShouldReturn1Percent_OfGrossPay()
        {
            // Arrange
            double grossPay = 19000.00;
            double expectedUIF = 190.00; // 1%

            // Act
            double actualUIF = _calc.CalculateUIF(grossPay);

            // Assert
            TestContext.WriteLine($"Gross Pay:    R{grossPay:N2}");
            TestContext.WriteLine($"Expected UIF: R{expectedUIF:N2}");
            TestContext.WriteLine($"Actual UIF:   R{actualUIF:N2}");

            Assert.AreEqual(expectedUIF, actualUIF, 0.01,
                "UIF calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("Membership Fee should be exactly 13% of gross pay")]
        public void MembershipFee_ShouldReturn13Percent_OfGrossPay()
        {
            // Arrange
            double grossPay = 19000.00;
            double expectedMembership = 2470.00; // 13%

            // Act
            double actualMembership = _calc.CalculateMembershipFee(grossPay);

            // Assert
            TestContext.WriteLine($"Gross Pay:              R{grossPay:N2}");
            TestContext.WriteLine($"Expected Membership Fee: R{expectedMembership:N2}");
            TestContext.WriteLine($"Actual Membership Fee:   R{actualMembership:N2}");

            Assert.AreEqual(expectedMembership, actualMembership, 0.01,
                "Membership Fee calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("PAYE should use simplified formula: (Gross - Gross*0.0575*Deps) * 25%")]
        public void PAYE_ShouldReturnCorrectAmount_WithDependents()
        {
            // Arrange
            double grossPay = 19000.00;
            int dependents = 2;
            /* PAYE = (19000 - (19000 * 0.0575 * 2)) * 0.25
                    = (19000 - 2185.00) * 0.25
                    = 16815.00 * 0.25
                    = R4203.75
            */
            double expectedPAYE = (grossPay - (grossPay * 0.0575 * dependents)) * 0.25;

            // Act
            double actualPAYE = _calc.CalculatePAYE(grossPay, dependents);

            // Assert
            TestContext.WriteLine($"Gross Pay:     R{grossPay:N2}");
            TestContext.WriteLine($"Dependents:    {dependents}");
            TestContext.WriteLine($"Expected PAYE: R{expectedPAYE:N2}");
            TestContext.WriteLine($"Actual PAYE:   R{actualPAYE:N2}");

            Assert.AreEqual(expectedPAYE, actualPAYE, 0.01,
                "PAYE calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("PAYE with 0 dependents: no dependent reduction applied")]
        public void PAYE_ShouldReturnCorrectAmount_WithZeroDependents()
        {
            // Arrange
            double grossPay = 19000.00;
            int dependents = 0;
            double expectedPAYE = grossPay * 0.25; // R4750.00

            // Act
            double actualPAYE = _calc.CalculatePAYE(grossPay, dependents);

            TestContext.WriteLine($"Expected PAYE (0 deps): R{expectedPAYE:N2}");
            TestContext.WriteLine($"Actual PAYE:            R{actualPAYE:N2}");

            Assert.AreEqual(expectedPAYE, actualPAYE, 0.01,
                "PAYE with zero dependents is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("Net Pay = Gross - UIF - PAYE - Membership Fee")]
        public void PAYE_ShouldReturnR004_74W()
        {
            // Arrange – use 40 hours, 2 dependents
            double hours = 40;
            double grossPay = _calc.CalculateGrossPay(hours); // R38 000.00
            double uif = _calc.CalculateUIF(grossPay);
            double membership = _calc.CalculateMembershipFee(grossPay);
            double paye = _calc.CalculatePAYE(grossPay, 2);

            double expectedNet = grossPay - uif - paye - membership;

            // Act
            double actualNet = _calc.CalculateNetPay(grossPay, uif, paye, membership);

            // Assert
            TestContext.WriteLine($"Gross Pay:       R{grossPay:N2}");
            TestContext.WriteLine($"UIF:             R{uif:N2}");
            TestContext.WriteLine($"PAYE:            R{paye:N2}");
            TestContext.WriteLine($"Membership Fee:  R{membership:N2}");
            TestContext.WriteLine($"Expected Net Pay:R{expectedNet:N2}");
            TestContext.WriteLine($"Actual Net Pay:  R{actualNet:N2}");

            Assert.AreEqual(expectedNet, actualNet, 0.01,
                "Net Pay calculation is incorrect.");
        }

        
        // INTEGRATION TEST – Full pipeline: input → calculations → output

        [TestMethod]
        [TestCategory("Integration")]
        [Description("End-to-end: verify all calculations chain correctly for a known dataset")]
        public void NetPay_ShouldReturnR1628_81_WhenAllDeductionsAreApplied()
        {
            // Arrange
            double hours = 2.75;   // Small realistic test
            int dependents = 1;

            // Act – chain all methods as the form does
            double gross = _calc.CalculateGrossPay(hours);       // 2.75 * 950 = R2612.50
            double uif = _calc.CalculateUIF(gross);            // 1%
            double membership = _calc.CalculateMembershipFee(gross);  // 13%
            double paye = _calc.CalculatePAYE(gross, dependents);
            double totalDed = _calc.CalculateTotalDeductions(uif, paye, membership);
            double netPay = _calc.CalculateNetPay(gross, uif, paye, membership);

            // Assert – net pay must be gross minus all deductions
            double expectedNet = gross - uif - paye - membership;

            TestContext.WriteLine("Testing Net Pay calculation with all deductions.");
            TestContext.WriteLine($"Gross Pay: R{gross:N2}");
            TestContext.WriteLine($"UIF: R{uif:N2}");
            TestContext.WriteLine($"PAYE: R{paye:N2}");
            TestContext.WriteLine($"Membership Fee: R{membership:N2}");
            TestContext.WriteLine($"Total Deductions: R{totalDed:N2}");
            TestContext.WriteLine($"Calculated Net Pay: R{netPay:N2}");

            Assert.AreEqual(expectedNet, netPay, 0.01,
                "Integration test failed: Net Pay does not equal Gross minus all deductions.");
            Assert.IsTrue(netPay > 0,
                "Net Pay should be positive for valid input.");
            Assert.AreEqual(uif + paye + membership, totalDed, 0.01,
                "Total Deductions should equal sum of UIF + PAYE + Membership.");
        }
        

        // REGRESSION / BOUNDARY TESTS

        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("Gross Pay must be zero when zero hours are worked")]
        public void GrossPay_ShouldReturnZero_WhenHoursIsZero()
        {
            double result = _calc.CalculateGrossPay(0);
            TestContext.WriteLine($"Gross Pay for 0 hours: R{result:N2}");
            Assert.AreEqual(0.00, result, 0.01, "Gross Pay for zero hours must be R0.00.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        [Description("UIF must be zero when gross pay is zero")]
        public void UIF_ShouldReturnZero_WhenGrossPayIsZero()
        {
            double result = _calc.CalculateUIF(0);
            TestContext.WriteLine($"UIF for R0 gross: R{result:N2}");
            Assert.AreEqual(0.00, result, 0.01, "UIF for zero gross pay must be R0.00.");
        }
    }
}
