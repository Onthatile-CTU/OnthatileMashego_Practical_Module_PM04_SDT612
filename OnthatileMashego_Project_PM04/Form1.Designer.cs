namespace OnthatileMashego_Project_PM04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblHours = new Label();
            lblDependents = new Label();
            lblTitle = new Label();
            txtName = new TextBox();
            txtHours = new TextBox();
            txtDependents = new TextBox();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            pnlSep = new Panel();
            txtTotalDeduct = new TextBox();
            txtNetPay = new TextBox();
            txtMembership = new TextBox();
            txtUIF = new TextBox();
            txtPAYE = new TextBox();
            txtGrossPay = new TextBox();
            lblNetPay = new Label();
            lblTotalDeduct = new Label();
            lblMembershipFee = new Label();
            lblUIF = new Label();
            lblPAYE = new Label();
            lblGrossPay = new Label();
            pnlSep.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(140, 247);
            lblName.Name = "lblName";
            lblName.Size = new Size(278, 37);
            lblName.TabIndex = 0;
            lblName.Text = "Contractor Name";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblHours.ForeColor = Color.White;
            lblHours.Location = new Point(140, 323);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(235, 37);
            lblHours.TabIndex = 1;
            lblHours.Text = "Hours Worked";
            // 
            // lblDependents
            // 
            lblDependents.AutoSize = true;
            lblDependents.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDependents.ForeColor = Color.White;
            lblDependents.Location = new Point(140, 401);
            lblDependents.Name = "lblDependents";
            lblDependents.Size = new Size(368, 37);
            lblDependents.TabIndex = 2;
            lblDependents.Text = "Number of Dependents";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(229, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(767, 73);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Mzansi Tech Contractors";
            // 
            // txtName
            // 
            txtName.Location = new Point(531, 247);
            txtName.Name = "txtName";
            txtName.Size = new Size(482, 39);
            txtName.TabIndex = 4;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(531, 323);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(482, 39);
            txtHours.TabIndex = 5;
            // 
            // txtDependents
            // 
            txtDependents.Location = new Point(531, 401);
            txtDependents.Name = "txtDependents";
            txtDependents.Size = new Size(482, 39);
            txtDependents.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(300, 537);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(270, 82);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate Net Pay";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(632, 537);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(167, 82);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(861, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 82);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlSep
            // 
            pnlSep.BorderStyle = BorderStyle.FixedSingle;
            pnlSep.Controls.Add(txtTotalDeduct);
            pnlSep.Controls.Add(txtNetPay);
            pnlSep.Controls.Add(txtMembership);
            pnlSep.Controls.Add(txtUIF);
            pnlSep.Controls.Add(txtPAYE);
            pnlSep.Controls.Add(txtGrossPay);
            pnlSep.Controls.Add(lblNetPay);
            pnlSep.Controls.Add(lblTotalDeduct);
            pnlSep.Controls.Add(lblMembershipFee);
            pnlSep.Controls.Add(lblUIF);
            pnlSep.Controls.Add(lblPAYE);
            pnlSep.Controls.Add(lblGrossPay);
            pnlSep.Location = new Point(1087, 281);
            pnlSep.Name = "pnlSep";
            pnlSep.Size = new Size(769, 586);
            pnlSep.TabIndex = 10;
            // 
            // txtTotalDeduct
            // 
            txtTotalDeduct.Location = new Point(310, 343);
            txtTotalDeduct.Name = "txtTotalDeduct";
            txtTotalDeduct.ReadOnly = true;
            txtTotalDeduct.Size = new Size(362, 39);
            txtTotalDeduct.TabIndex = 11;
            // 
            // txtNetPay
            // 
            txtNetPay.Location = new Point(310, 412);
            txtNetPay.Name = "txtNetPay";
            txtNetPay.ReadOnly = true;
            txtNetPay.Size = new Size(362, 39);
            txtNetPay.TabIndex = 10;
            // 
            // txtMembership
            // 
            txtMembership.Location = new Point(310, 277);
            txtMembership.Name = "txtMembership";
            txtMembership.ReadOnly = true;
            txtMembership.Size = new Size(362, 39);
            txtMembership.TabIndex = 9;
            // 
            // txtUIF
            // 
            txtUIF.Location = new Point(310, 205);
            txtUIF.Name = "txtUIF";
            txtUIF.ReadOnly = true;
            txtUIF.Size = new Size(362, 39);
            txtUIF.TabIndex = 8;
            // 
            // txtPAYE
            // 
            txtPAYE.Location = new Point(310, 135);
            txtPAYE.Name = "txtPAYE";
            txtPAYE.ReadOnly = true;
            txtPAYE.Size = new Size(362, 39);
            txtPAYE.TabIndex = 7;
            // 
            // txtGrossPay
            // 
            txtGrossPay.Location = new Point(310, 63);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.ReadOnly = true;
            txtGrossPay.Size = new Size(362, 39);
            txtGrossPay.TabIndex = 6;
            // 
            // lblNetPay
            // 
            lblNetPay.AutoSize = true;
            lblNetPay.ForeColor = Color.White;
            lblNetPay.Location = new Point(88, 403);
            lblNetPay.Name = "lblNetPay";
            lblNetPay.Size = new Size(101, 32);
            lblNetPay.TabIndex = 5;
            lblNetPay.Text = "Net Pay:";
            // 
            // lblTotalDeduct
            // 
            lblTotalDeduct.AutoSize = true;
            lblTotalDeduct.ForeColor = Color.White;
            lblTotalDeduct.Location = new Point(88, 343);
            lblTotalDeduct.Name = "lblTotalDeduct";
            lblTotalDeduct.Size = new Size(198, 32);
            lblTotalDeduct.TabIndex = 4;
            lblTotalDeduct.Text = "Total Deductions:";
            // 
            // lblMembershipFee
            // 
            lblMembershipFee.AutoSize = true;
            lblMembershipFee.ForeColor = Color.White;
            lblMembershipFee.Location = new Point(87, 277);
            lblMembershipFee.Name = "lblMembershipFee";
            lblMembershipFee.Size = new Size(199, 32);
            lblMembershipFee.TabIndex = 3;
            lblMembershipFee.Text = "Membership Fee:";
            // 
            // lblUIF
            // 
            lblUIF.AutoSize = true;
            lblUIF.ForeColor = Color.White;
            lblUIF.Location = new Point(87, 212);
            lblUIF.Name = "lblUIF";
            lblUIF.Size = new Size(171, 32);
            lblUIF.TabIndex = 2;
            lblUIF.Text = "UIF Deduction:";
            // 
            // lblPAYE
            // 
            lblPAYE.AutoSize = true;
            lblPAYE.ForeColor = Color.White;
            lblPAYE.Location = new Point(87, 142);
            lblPAYE.Name = "lblPAYE";
            lblPAYE.Size = new Size(186, 32);
            lblPAYE.TabIndex = 1;
            lblPAYE.Text = "PAYE Deduction:";
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.ForeColor = Color.White;
            lblGrossPay.Location = new Point(87, 66);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(120, 32);
            lblGrossPay.TabIndex = 0;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(2002, 999);
            Controls.Add(pnlSep);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(txtDependents);
            Controls.Add(txtHours);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            Controls.Add(lblDependents);
            Controls.Add(lblHours);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Mzansi Tech Contractors Payroll System";
            pnlSep.ResumeLayout(false);
            pnlSep.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblHours;
        private Label lblDependents;
        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtHours;
        private TextBox txtDependents;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Panel pnlSep;
        private Label lblMembershipFee;
        private Label lblUIF;
        private Label lblPAYE;
        private Label lblGrossPay;
        private Label lblNetPay;
        private Label lblTotalDeduct;
        private TextBox txtTotalDeduct;
        private TextBox txtNetPay;
        private TextBox txtMembership;
        private TextBox txtUIF;
        private TextBox txtPAYE;
        private TextBox txtGrossPay;
    }
}
