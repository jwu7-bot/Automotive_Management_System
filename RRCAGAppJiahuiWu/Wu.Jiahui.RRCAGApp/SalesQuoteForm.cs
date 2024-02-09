/*
 * Name: JiaHui Wu 
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Create: 5-30-2023
 * Update: 6-3-2023
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wu.Jiahui.Business;

namespace Wu.Jiahui.RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {
        private decimal provincialSalesTax;
        private decimal goodsAndServicesTax;
        private decimal salesTaxRate;
        SalesQuote salesQuote;

        public SalesQuoteForm()
        {
            InitializeComponent();

            InitialState();

            this.btnReset.Click += BtnReset_Click;
            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;

            this.txtVehiclesSalePrice.TextChanged += SalesPriceOrTradeInAmount_TextChanged;
            this.txtTradeInAmount.TextChanged += SalesPriceOrTradeInAmount_TextChanged;

            this.chkAccessoriesStereoSystem.CheckedChanged += AccessoriesAndExteriorFinish_CheckedChanged;
            this.chkAccessoriesLeatherInterior.CheckedChanged += AccessoriesAndExteriorFinish_CheckedChanged;
            this.chkAccessoriesComputerNavigation.CheckedChanged += AccessoriesAndExteriorFinish_CheckedChanged;

            this.radExteriroFinishStandard.CheckedChanged += AccessoriesAndExteriorFinish_CheckedChanged;
            this.radExteriorFinishPearlized.CheckedChanged += AccessoriesAndExteriorFinish_CheckedChanged;
            this.radExteriorFinishCustomized.CheckedChanged += AccessoriesAndExteriorFinish_CheckedChanged;

            this.nudFinanceAnnualInterestRate.ValueChanged += NumberOfYearsAndFinanceAnnualInterestRate_ValueChanged;
            this.nudFinanceNumberOfYears.ValueChanged += NumberOfYearsAndFinanceAnnualInterestRate_ValueChanged;
        }

        /// <summary>
        /// Handles the ValueChanged event of the number of years and interest numeric up/down.
        /// </summary>
        private void NumberOfYearsAndFinanceAnnualInterestRate_ValueChanged(object sender, EventArgs e)
        {
            if(salesQuote != null)
            {
                DisplayLabels();
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of accessories and exterior finish checkboxes.
        /// </summary>
        private void AccessoriesAndExteriorFinish_CheckedChanged(object sender, EventArgs e)
        {
            if(this.salesQuote != null)
            {
                this.salesQuote.AccessoriesChosen = CheckAccessoriesChosen();
                this.salesQuote.ExteriorFinishChosen = CheckExteriorFinishChosen();

                DisplayLabels();
            }
        }

        /// <summary>
        /// Handles the Click event of the reset button.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            string text = "Do you want to reset the form?";
            string caption = "Reset Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;

            DialogResult result = MessageBox.Show(text, caption, buttons, icon, defaultButton);

            if (result == DialogResult.Yes)
            {
                InitialState();
            }
        }

        /// <summary>
        /// Method that sets the initial state of the form.
        /// </summary>
        private void InitialState()
        {
            this.txtVehiclesSalePrice.Text = string.Empty;
            this.txtVehiclesSalePrice.Focus();

            this.txtTradeInAmount.Text = "0";

            this.chkAccessoriesComputerNavigation.Checked = false;
            this.chkAccessoriesLeatherInterior.Checked = false;
            this.chkAccessoriesStereoSystem.Checked = false; 
            this.radExteriroFinishStandard.Checked = true;

            ClearSummaryOutputLabels();

            this.provincialSalesTax = 0.07m;
            this.goodsAndServicesTax = 0.05m;
            this.salesTaxRate = this.provincialSalesTax + this.goodsAndServicesTax;
            string salesTaxRateFormat = (this.salesTaxRate * 100).ToString("0.##") + "%";
            lblSummarySalesTaxPercentage.Text = string.Format("Sales Tax ({0}):", salesTaxRateFormat);

            this.nudFinanceNumberOfYears.Value = 1;

            this.nudFinanceAnnualInterestRate.Value = 5;

            this.lblFinanceMonthlyPayment.Text = string.Empty;

            this.errorProvider.SetError(this.txtTradeInAmount, string.Empty);
            this.errorProvider.SetError(this.txtVehiclesSalePrice, string.Empty);

            this.salesQuote = null;
        }

        /// <summary>
        /// Handles the TextChanged event of the vehicles sales price or trade in amount textboxes.
        /// </summary>
        private void SalesPriceOrTradeInAmount_TextChanged(object sender, EventArgs e)
        {
            ClearSummaryOutputLabels();

            this.salesQuote = null;
        }

        /// <summary>
        /// Method clears all the summary labels.
        /// </summary>
        private void ClearSummaryOutputLabels()
        {
            this.lblSummaryVehiclesSalePrice.Text = string.Empty;
            this.lblSummaryOptions.Text = string.Empty;
            this.lblSummarySubtotal.Text = string.Empty;
            this.lblSummarySalesTax.Text = string.Empty;
            this.lblSummaryTotal.Text = string.Empty;
            this.lblSummaryTradeInAmount.Text = string.Empty;
            this.lblSumaryAmountDue.Text = string.Empty;
            this.lblFinanceMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// Handles the Click event of the calculate quote button.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            CheckVehiclesSalesPrice();

            CheckTradeInValue();

            if(this.errorProvider.GetError(this.txtVehiclesSalePrice) == string.Empty &&
                this.errorProvider.GetError(this.txtTradeInAmount) == string.Empty)
            {
                this.salesQuote = new SalesQuote(decimal.Parse(this.txtVehiclesSalePrice.Text),
                                                 decimal.Parse(this.txtTradeInAmount.Text),
                                                 this.salesTaxRate, CheckAccessoriesChosen(), CheckExteriorFinishChosen());
                DisplayLabels();
            }
        }

        /// <summary>
        /// Method that displays each item of summary.
        /// </summary>
        private void DisplayLabels()
        {
            this.lblSummaryVehiclesSalePrice.Text = this.salesQuote.VehicleSalePrice.ToString("C");

            this.lblSummaryOptions.Text = this.salesQuote.TotalOptions.ToString("N");

            this.lblSummarySubtotal.Text = this.salesQuote.SubTotal.ToString("C");

            this.lblSummarySalesTax.Text = this.salesQuote.SalesTax.ToString("N");

            this.lblSummaryTotal.Text = this.salesQuote.Total.ToString("C");

            this.lblSummaryTradeInAmount.Text = string.Format("-{0}", this.salesQuote.TradeInAmount.ToString("N"));

            this.lblSumaryAmountDue.Text = this.salesQuote.AmountDue.ToString("C");

            this.lblFinanceMonthlyPayment.Text = (Financial.GetPayment((this.nudFinanceAnnualInterestRate.Value / 100) / 12,
                                                                       Convert.ToInt32(this.nudFinanceNumberOfYears.Value) * 12,
                                                                       this.salesQuote.AmountDue)).ToString("C");
        }

        /// <summary>
        /// Helper method that checks accessories chosen in the checkbox.
        /// </summary>
        /// <returns>The accessories chosen.</returns>
        private Accessories CheckAccessoriesChosen()
        {
            bool stereoSystemChecked = chkAccessoriesStereoSystem.Checked;
            bool leatherInteriorChecked = chkAccessoriesLeatherInterior.Checked;
            bool computerNavigationChecked = chkAccessoriesComputerNavigation.Checked;

            if(stereoSystemChecked && leatherInteriorChecked && computerNavigationChecked)
            {
                return Accessories.All;
            }

            if (stereoSystemChecked)
            {
                if(leatherInteriorChecked)
                {
                    return Accessories.StereoAndLeather;
                }
                if(computerNavigationChecked)
                {
                    return Accessories.StereoAndNavigation;
                }

                return Accessories.StereoSystem;
            }

            if(leatherInteriorChecked)
            {
                if(stereoSystemChecked)
                {
                    return Accessories.StereoAndLeather;
                }
                if(computerNavigationChecked)
                {
                   return Accessories.LeatherAndNavigation;
                }

                return Accessories.LeatherInterior;
            }

            if(computerNavigationChecked)
            {
                if(stereoSystemChecked)
                {
                    return Accessories.StereoAndNavigation;
                }
                if(leatherInteriorChecked)
                {
                    return Accessories.LeatherAndNavigation;
                }

                return Accessories.ComputerNavigation;
            }

            return Accessories.None;
        }

        /// <summary>
        /// Helper method that checks exterior finish chosen in the checkbox.
        /// </summary>
        /// <returns>The exterior finish chosen.</returns>
        private ExteriorFinish CheckExteriorFinishChosen()
        {
            bool pearlizedChecked = radExteriorFinishPearlized.Checked;
            bool customizedChecked = radExteriorFinishCustomized.Checked;

            if(pearlizedChecked)
            {
                return ExteriorFinish.Pearlized;
            }

            if(customizedChecked)
            {
                return ExteriorFinish.Custom;
            }

            return ExteriorFinish.Standard;
        }

        /// <summary>
        /// Method that checks if vehicles sale price textbox has errors.
        /// </summary>
        private void CheckVehiclesSalesPrice()
        {
            this.errorProvider.SetIconPadding(this.txtVehiclesSalePrice, 3);

            if (string.IsNullOrEmpty(this.txtVehiclesSalePrice.Text))
            {
                this.errorProvider.SetError(this.txtVehiclesSalePrice, "Vehicle price is a required field.");
            }
            else
            {
                if (!decimal.TryParse(this.txtVehiclesSalePrice.Text, out decimal vehiclesSalePrice))
                {
                    this.errorProvider.SetError(this.txtVehiclesSalePrice, "Vehicle price cannot contain letters or special characters.");
                }
                else if(vehiclesSalePrice <= 0)
                {
                    this.errorProvider.SetError(this.txtVehiclesSalePrice, "Vehicle price cannot be less than or equal to 0.");
                }
                else
                {
                    this.errorProvider.SetError(this.txtVehiclesSalePrice, string.Empty);
                }
            }
        }

        /// <summary>
        /// Method that checks if trade in amount textbox has errors.
        /// </summary>
        private void CheckTradeInValue()
        {
            this.errorProvider.SetIconPadding(this.txtTradeInAmount, 3);

            if (string.IsNullOrEmpty(this.txtTradeInAmount.Text))
            {
                this.errorProvider.SetError(this.txtTradeInAmount, "Trade-in value is a required field.");
            }
            else
            {
                if (!decimal.TryParse(this.txtTradeInAmount.Text, out decimal tradeInAmount))
                {
                    this.errorProvider.SetError(this.txtTradeInAmount, "Trade-in value cannot contain letters or special characters.");
                }
                else
                {
                    if (tradeInAmount < 0)
                    {
                        this.errorProvider.SetError(this.txtTradeInAmount, "Trade-in value cannot be less than 0.");
                    }
                    else if (decimal.TryParse(this.txtVehiclesSalePrice.Text, out decimal salePrice)
                        && tradeInAmount > salePrice)
                    {
                        this.errorProvider.SetError(this.txtTradeInAmount, "Trade-in value cannot exceed the vehicle sale price.");
                    }
                    else
                    {
                        this.errorProvider.SetError(this.txtTradeInAmount, string.Empty);
                    }
                }
            }
        }
    }
}
