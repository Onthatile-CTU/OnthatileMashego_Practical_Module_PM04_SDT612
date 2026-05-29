using System;

namespace OnthatileMashego_Project_PM04
{
    /*
         PayrollCalculator handles all payroll business logic for Mzansi Tech Contractors.
         Separated from UI to support unit testing and clean architecture.
    */
    public class PayrollCalculator
    {
        public const double HourlyRate = 950.00;

        /*
             Calculates gross pay based on hours worked.
             Gross Pay = Hours Worked x Hourly Rate (R950.00)
       */
        public double CalculateGrossPay(double hoursWorked)
        {
            return hoursWorked * HourlyRate;
        }

        /// Calculates UIF deduction: 1% of gross pay (employee contribution).
        public double CalculateUIF(double grossPay)
        {
            return grossPay * 0.01;
        }

        /// Calculates Membership Fee: 13% of gross pay.
        public double CalculateMembershipFee(double grossPay)
        {
            return grossPay * 0.13;
        }

        /*
             Calculates PAYE using simplified SARS-based rule:
             PAYE = (GrossPay - (GrossPay x 0.0575 x NumberOfDependents)) x 25%
        */
        public double CalculatePAYE(double grossPay, int numberOfDependents)
        {
            return (grossPay - (grossPay * 0.0575 * numberOfDependents)) * 0.25;
        }

        /// Calculates total deductions (UIF + PAYE + Membership Fee).
        public double CalculateTotalDeductions(double uif, double paye, double membershipFee)
        {
            return uif + paye + membershipFee;
        }

        /// Calculates net pay: Gross Pay - UIF - PAYE - Membership Fee.
        public double CalculateNetPay(double grossPay, double uif, double paye, double membershipFee)
        {
            return grossPay - uif - paye - membershipFee;
        }
    }
}
