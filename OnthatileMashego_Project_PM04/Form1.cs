namespace OnthatileMashego_Project_PM04
{

    /* <summary>
        Main form for the Mzansi Tech Contractors Payroll System.
        Handles user input, validation, and delegates calculations to PayrollCalculator.
   
    */
    public partial class Form1 : Form
    {
        private readonly PayrollCalculator _calculator = new PayrollCalculator();
        public Form1()
        {
            InitializeComponent();
        }


        // CALCULATE NET PAY BUTTON
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // --- Input Validation ---
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the contractor name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!double.TryParse(txtHours.Text, out double hoursWorked))
            {
                MessageBox.Show("Hours Worked must be a valid number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHours.Focus();
                return;
            }

            if (hoursWorked < 0)
            {
                MessageBox.Show("Hours Worked cannot be negative.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHours.Focus();
                return;
            }

            if (!int.TryParse(txtDependents.Text, out int dependents))
            {
                MessageBox.Show("Number of Dependents must be a whole number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return;
            }

            if (dependents < 0)
            {
                MessageBox.Show("Number of Dependents cannot be negative.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return;
            }

            if (dependents > 10)
            {
                MessageBox.Show("Number of Dependents cannot exceed 10.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return;
            }

            // --- Calculations ---
            double grossPay = _calculator.CalculateGrossPay(hoursWorked);
            double uif = _calculator.CalculateUIF(grossPay);
            double membershipFee = _calculator.CalculateMembershipFee(grossPay);
            double paye = _calculator.CalculatePAYE(grossPay, dependents);
            double totalDeductions = _calculator.CalculateTotalDeductions(uif, paye, membershipFee);
            double netPay = _calculator.CalculateNetPay(grossPay, uif, paye, membershipFee);

            // --- Display Results ---
            string fmt = "R{0:N2}";
            txtGrossPay.Text = string.Format(fmt, grossPay);
            txtUIF.Text = string.Format(fmt, uif);
            txtPAYE.Text = string.Format(fmt, paye);
            txtMembership.Text = string.Format(fmt, membershipFee);
            txtTotalDeduct.Text = string.Format(fmt, totalDeductions);
            txtNetPay.Text = string.Format(fmt, netPay);
        }

        // RESET BUTTON
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtDependents.Clear();
            txtGrossPay.Clear();
            txtUIF.Clear();
            txtPAYE.Clear();
            txtMembership.Clear();
            txtTotalDeduct.Clear();
            txtNetPay.Clear();
            txtName.Focus();
        }

        //EXIT BUTTON

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
