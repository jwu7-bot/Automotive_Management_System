namespace Wu.Jiahui.RRCAGApp
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtVehiclesSalePrice = new System.Windows.Forms.TextBox();
            this.lblTradeInAmount = new System.Windows.Forms.Label();
            this.txtTradeInAmount = new System.Windows.Forms.TextBox();
            this.lblAccessories = new System.Windows.Forms.Label();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkAccessoriesLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkAccessoriesComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkAccessoriesStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radExteriorFinishCustomized = new System.Windows.Forms.RadioButton();
            this.radExteriorFinishPearlized = new System.Windows.Forms.RadioButton();
            this.radExteriroFinishStandard = new System.Windows.Forms.RadioButton();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblSumaryAmountDue = new System.Windows.Forms.Label();
            this.lblSummaryTradeInAmount = new System.Windows.Forms.Label();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.lblSummarySalesTax = new System.Windows.Forms.Label();
            this.lblSummarySubtotal = new System.Windows.Forms.Label();
            this.lblSummaryOptions = new System.Windows.Forms.Label();
            this.lblSummaryVehiclesSalePrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSummarySalesTaxPercentage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblFinanceMonthlyPayment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudFinanceAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.nudFinanceNumberOfYears = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceNumberOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVehiclesSalePrice
            // 
            this.txtVehiclesSalePrice.Location = new System.Drawing.Point(130, 18);
            this.txtVehiclesSalePrice.Name = "txtVehiclesSalePrice";
            this.txtVehiclesSalePrice.Size = new System.Drawing.Size(124, 20);
            this.txtVehiclesSalePrice.TabIndex = 0;
            this.txtVehiclesSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTradeInAmount
            // 
            this.lblTradeInAmount.AutoSize = true;
            this.lblTradeInAmount.Location = new System.Drawing.Point(46, 54);
            this.lblTradeInAmount.Name = "lblTradeInAmount";
            this.lblTradeInAmount.Size = new System.Drawing.Size(79, 13);
            this.lblTradeInAmount.TabIndex = 2;
            this.lblTradeInAmount.Text = "Trade-in Value:";
            // 
            // txtTradeInAmount
            // 
            this.txtTradeInAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTradeInAmount.Location = new System.Drawing.Point(130, 51);
            this.txtTradeInAmount.Name = "txtTradeInAmount";
            this.txtTradeInAmount.Size = new System.Drawing.Size(124, 20);
            this.txtTradeInAmount.TabIndex = 1;
            this.txtTradeInAmount.Text = "0";
            this.txtTradeInAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccessories
            // 
            this.lblAccessories.AutoSize = true;
            this.lblAccessories.Location = new System.Drawing.Point(35, 96);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(0, 13);
            this.lblAccessories.TabIndex = 5;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkAccessoriesLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkAccessoriesComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkAccessoriesStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(24, 91);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(230, 142);
            this.grpAccessories.TabIndex = 6;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkAccessoriesLeatherInterior
            // 
            this.chkAccessoriesLeatherInterior.AutoSize = true;
            this.chkAccessoriesLeatherInterior.Location = new System.Drawing.Point(22, 65);
            this.chkAccessoriesLeatherInterior.Name = "chkAccessoriesLeatherInterior";
            this.chkAccessoriesLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkAccessoriesLeatherInterior.TabIndex = 1;
            this.chkAccessoriesLeatherInterior.Text = "Leather Interior";
            this.chkAccessoriesLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkAccessoriesComputerNavigation
            // 
            this.chkAccessoriesComputerNavigation.AutoSize = true;
            this.chkAccessoriesComputerNavigation.Location = new System.Drawing.Point(22, 101);
            this.chkAccessoriesComputerNavigation.Name = "chkAccessoriesComputerNavigation";
            this.chkAccessoriesComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.chkAccessoriesComputerNavigation.TabIndex = 2;
            this.chkAccessoriesComputerNavigation.Text = "Computer Navigation";
            this.chkAccessoriesComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkAccessoriesStereoSystem
            // 
            this.chkAccessoriesStereoSystem.AutoSize = true;
            this.chkAccessoriesStereoSystem.Location = new System.Drawing.Point(22, 29);
            this.chkAccessoriesStereoSystem.Name = "chkAccessoriesStereoSystem";
            this.chkAccessoriesStereoSystem.Size = new System.Drawing.Size(97, 17);
            this.chkAccessoriesStereoSystem.TabIndex = 0;
            this.chkAccessoriesStereoSystem.Text = "Strereo System";
            this.chkAccessoriesStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radExteriorFinishCustomized);
            this.grpExteriorFinish.Controls.Add(this.radExteriorFinishPearlized);
            this.grpExteriorFinish.Controls.Add(this.radExteriroFinishStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(24, 258);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(231, 141);
            this.grpExteriorFinish.TabIndex = 7;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radExteriorFinishCustomized
            // 
            this.radExteriorFinishCustomized.AutoSize = true;
            this.radExteriorFinishCustomized.Location = new System.Drawing.Point(22, 103);
            this.radExteriorFinishCustomized.Name = "radExteriorFinishCustomized";
            this.radExteriorFinishCustomized.Size = new System.Drawing.Size(123, 17);
            this.radExteriorFinishCustomized.TabIndex = 2;
            this.radExteriorFinishCustomized.TabStop = true;
            this.radExteriorFinishCustomized.Text = "Customized Detailing";
            this.radExteriorFinishCustomized.UseVisualStyleBackColor = true;
            // 
            // radExteriorFinishPearlized
            // 
            this.radExteriorFinishPearlized.AutoSize = true;
            this.radExteriorFinishPearlized.Location = new System.Drawing.Point(22, 68);
            this.radExteriorFinishPearlized.Name = "radExteriorFinishPearlized";
            this.radExteriorFinishPearlized.Size = new System.Drawing.Size(68, 17);
            this.radExteriorFinishPearlized.TabIndex = 1;
            this.radExteriorFinishPearlized.TabStop = true;
            this.radExteriorFinishPearlized.Text = "Pearlized";
            this.radExteriorFinishPearlized.UseVisualStyleBackColor = true;
            // 
            // radExteriroFinishStandard
            // 
            this.radExteriroFinishStandard.AutoSize = true;
            this.radExteriroFinishStandard.Checked = true;
            this.radExteriroFinishStandard.Location = new System.Drawing.Point(22, 33);
            this.radExteriroFinishStandard.Name = "radExteriroFinishStandard";
            this.radExteriroFinishStandard.Size = new System.Drawing.Size(68, 17);
            this.radExteriroFinishStandard.TabIndex = 0;
            this.radExteriroFinishStandard.TabStop = true;
            this.radExteriroFinishStandard.Text = "Standard";
            this.radExteriroFinishStandard.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblSumaryAmountDue);
            this.grpSummary.Controls.Add(this.lblSummaryTradeInAmount);
            this.grpSummary.Controls.Add(this.lblSummaryTotal);
            this.grpSummary.Controls.Add(this.lblSummarySalesTax);
            this.grpSummary.Controls.Add(this.lblSummarySubtotal);
            this.grpSummary.Controls.Add(this.lblSummaryOptions);
            this.grpSummary.Controls.Add(this.lblSummaryVehiclesSalePrice);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.lblSummarySalesTaxPercentage);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Controls.Add(this.label2);
            this.grpSummary.Controls.Add(this.label1);
            this.grpSummary.Location = new System.Drawing.Point(293, 12);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(299, 279);
            this.grpSummary.TabIndex = 9;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblSumaryAmountDue
            // 
            this.lblSumaryAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSumaryAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumaryAmountDue.Location = new System.Drawing.Point(144, 231);
            this.lblSumaryAmountDue.Name = "lblSumaryAmountDue";
            this.lblSumaryAmountDue.Size = new System.Drawing.Size(124, 20);
            this.lblSumaryAmountDue.TabIndex = 13;
            this.lblSumaryAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTradeInAmount
            // 
            this.lblSummaryTradeInAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTradeInAmount.Location = new System.Drawing.Point(144, 197);
            this.lblSummaryTradeInAmount.Name = "lblSummaryTradeInAmount";
            this.lblSummaryTradeInAmount.Size = new System.Drawing.Size(124, 20);
            this.lblSummaryTradeInAmount.TabIndex = 12;
            this.lblSummaryTradeInAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTotal.Location = new System.Drawing.Point(144, 163);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(124, 20);
            this.lblSummaryTotal.TabIndex = 11;
            this.lblSummaryTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySalesTax
            // 
            this.lblSummarySalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySalesTax.Location = new System.Drawing.Point(144, 129);
            this.lblSummarySalesTax.Name = "lblSummarySalesTax";
            this.lblSummarySalesTax.Size = new System.Drawing.Size(124, 20);
            this.lblSummarySalesTax.TabIndex = 10;
            this.lblSummarySalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySubtotal
            // 
            this.lblSummarySubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySubtotal.Location = new System.Drawing.Point(144, 95);
            this.lblSummarySubtotal.Name = "lblSummarySubtotal";
            this.lblSummarySubtotal.Size = new System.Drawing.Size(124, 20);
            this.lblSummarySubtotal.TabIndex = 9;
            this.lblSummarySubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryOptions
            // 
            this.lblSummaryOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryOptions.Location = new System.Drawing.Point(144, 61);
            this.lblSummaryOptions.Name = "lblSummaryOptions";
            this.lblSummaryOptions.Size = new System.Drawing.Size(124, 20);
            this.lblSummaryOptions.TabIndex = 8;
            this.lblSummaryOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryVehiclesSalePrice
            // 
            this.lblSummaryVehiclesSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryVehiclesSalePrice.Location = new System.Drawing.Point(144, 31);
            this.lblSummaryVehiclesSalePrice.Name = "lblSummaryVehiclesSalePrice";
            this.lblSummaryVehiclesSalePrice.Size = new System.Drawing.Size(124, 20);
            this.lblSummaryVehiclesSalePrice.TabIndex = 7;
            this.lblSummaryVehiclesSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount Due:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trade-in:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySalesTaxPercentage
            // 
            this.lblSummarySalesTaxPercentage.AutoSize = true;
            this.lblSummarySalesTaxPercentage.Location = new System.Drawing.Point(52, 133);
            this.lblSummarySalesTaxPercentage.Name = "lblSummarySalesTaxPercentage";
            this.lblSummarySalesTaxPercentage.Size = new System.Drawing.Size(88, 13);
            this.lblSummarySalesTaxPercentage.TabIndex = 3;
            this.lblSummarySalesTaxPercentage.Text = "Sales Tax (##%):";
            this.lblSummarySalesTaxPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subtotal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Options:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle\'s Sale Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblFinanceMonthlyPayment);
            this.grpFinance.Controls.Add(this.label8);
            this.grpFinance.Controls.Add(this.nudFinanceAnnualInterestRate);
            this.grpFinance.Controls.Add(this.lblAnnualInterestRate);
            this.grpFinance.Controls.Add(this.nudFinanceNumberOfYears);
            this.grpFinance.Controls.Add(this.lblNumberOfYears);
            this.grpFinance.Location = new System.Drawing.Point(293, 297);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(299, 102);
            this.grpFinance.TabIndex = 10;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblFinanceMonthlyPayment
            // 
            this.lblFinanceMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFinanceMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinanceMonthlyPayment.Location = new System.Drawing.Point(198, 57);
            this.lblFinanceMonthlyPayment.Name = "lblFinanceMonthlyPayment";
            this.lblFinanceMonthlyPayment.Size = new System.Drawing.Size(88, 20);
            this.lblFinanceMonthlyPayment.TabIndex = 5;
            this.lblFinanceMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Monthly Payment";
            // 
            // nudFinanceAnnualInterestRate
            // 
            this.nudFinanceAnnualInterestRate.DecimalPlaces = 2;
            this.nudFinanceAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudFinanceAnnualInterestRate.Location = new System.Drawing.Point(116, 57);
            this.nudFinanceAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFinanceAnnualInterestRate.Name = "nudFinanceAnnualInterestRate";
            this.nudFinanceAnnualInterestRate.Size = new System.Drawing.Size(65, 20);
            this.nudFinanceAnnualInterestRate.TabIndex = 3;
            this.nudFinanceAnnualInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(113, 20);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(68, 26);
            this.lblAnnualInterestRate.TabIndex = 2;
            this.lblAnnualInterestRate.Text = "Annual \r\nInterest Rate";
            // 
            // nudFinanceNumberOfYears
            // 
            this.nudFinanceNumberOfYears.Location = new System.Drawing.Point(21, 57);
            this.nudFinanceNumberOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFinanceNumberOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFinanceNumberOfYears.Name = "nudFinanceNumberOfYears";
            this.nudFinanceNumberOfYears.Size = new System.Drawing.Size(65, 20);
            this.nudFinanceNumberOfYears.TabIndex = 1;
            this.nudFinanceNumberOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(18, 31);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(66, 13);
            this.lblNumberOfYears.TabIndex = 0;
            this.lblNumberOfYears.Text = "No. of Years";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(481, 418);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(111, 28);
            this.btnCalculateQuote.TabIndex = 11;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 412);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 28);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(22, 21);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(103, 13);
            this.lblVehicleSalePrice.TabIndex = 0;
            this.lblVehicleSalePrice.Text = "Vehicle\'s Sale Price:";
            this.lblVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 458);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.lblAccessories);
            this.Controls.Add(this.txtTradeInAmount);
            this.Controls.Add(this.lblTradeInAmount);
            this.Controls.Add(this.txtVehiclesSalePrice);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceNumberOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVehiclesSalePrice;
        private System.Windows.Forms.Label lblTradeInAmount;
        private System.Windows.Forms.TextBox txtTradeInAmount;
        private System.Windows.Forms.Label lblAccessories;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkAccessoriesStereoSystem;
        private System.Windows.Forms.CheckBox chkAccessoriesComputerNavigation;
        private System.Windows.Forms.CheckBox chkAccessoriesLeatherInterior;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radExteriroFinishStandard;
        private System.Windows.Forms.RadioButton radExteriorFinishCustomized;
        private System.Windows.Forms.RadioButton radExteriorFinishPearlized;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSummarySalesTaxPercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSummaryVehiclesSalePrice;
        private System.Windows.Forms.Label lblSummaryOptions;
        private System.Windows.Forms.Label lblSummarySubtotal;
        private System.Windows.Forms.Label lblSummarySalesTax;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.Label lblSummaryTradeInAmount;
        private System.Windows.Forms.Label lblSumaryAmountDue;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.NumericUpDown nudFinanceNumberOfYears;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.NumericUpDown nudFinanceAnnualInterestRate;
        private System.Windows.Forms.Label lblFinanceMonthlyPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}