/*
 * Name: JiaHui Wu 
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Create: 6-11-2023
 * Update: 6-11-2023
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wu.Jiahui.Business;

namespace Wu.Jiahui.RRCAGApp
{
    public class CarWashInvoiceForm : ACE.BIT.ADEV.Forms.CarWashInvoiceForm
    {
        private BindingSource bindingSourceCarWashInvoice;

        private CarWashInvoice carWashInvoice;

        public CarWashInvoiceForm(CarWashInvoice carWashInvoice)
        {
            this.carWashInvoice = carWashInvoice;

            this.bindingSourceCarWashInvoice = new BindingSource();
            this.bindingSourceCarWashInvoice.DataSource = this.carWashInvoice;

            InitialState();

            BindControl();
        }

        /// <summary>
        /// Method that defines the initial state of the Car Wash form.
        /// </summary>
        private void InitialState()
        {
            this.Text = "Car Wash Invoice";

            this.lblPackagePrice.Text =
                this.lblFragrancePrice.Text =
                this.lblSubtotal.Text =
                this.lblProvincialSalesTax.Text =
                this.lblGoodsAndServicesTax.Text =
                this.lblTotal.Text = string.Empty;
        }

        /// <summary>
        /// Method that does the data binding to the controls.
        /// </summary>
        private void BindControl()
        {
            Binding priceBindPackage = new Binding("Text", this.bindingSourceCarWashInvoice, "PackageCost", true);
            this.lblPackagePrice.DataBindings.Add(priceBindPackage);
            priceBindPackage.FormatString = "C";

            Binding numberBindFragrance = new Binding("Text", this.bindingSourceCarWashInvoice, "FragranceCost", true);
            this.lblFragrancePrice.DataBindings.Add(numberBindFragrance);
            numberBindFragrance.FormatString = "F";

            Binding priceBindSubTotal = new Binding("Text", this.bindingSourceCarWashInvoice, "SubTotal", true);
            this.lblSubtotal.DataBindings.Add(priceBindSubTotal);
            priceBindSubTotal.FormatString = "C";

            Binding numberBindPST = new Binding("Text", this.bindingSourceCarWashInvoice, "ProvincialSalesTaxCharged", true);
            this.lblProvincialSalesTax.DataBindings.Add(numberBindPST);
            numberBindPST.FormatString = "F";

            Binding numberBindGST = new Binding("Text", this.bindingSourceCarWashInvoice, "GoodsAndServicesTaxCharged", true);
            this.lblGoodsAndServicesTax.DataBindings.Add(numberBindGST);
            numberBindGST.FormatString = "F";

            Binding priceBindTotal = new Binding("Text", this.bindingSourceCarWashInvoice, "Total", true);
            this.lblTotal.DataBindings.Add(priceBindTotal);
            priceBindTotal.FormatString = "C";
        }
    }
}
