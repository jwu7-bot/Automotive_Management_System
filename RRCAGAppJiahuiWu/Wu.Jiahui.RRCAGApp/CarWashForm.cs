/*
 * Name: JiaHui Wu 
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Create: 5-30-2023
 * Update: 6-19-2023
 */
using ACE.BIT.ADEV.CarWash;
using ACE.BIT.ADEV.Forms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wu.Jiahui.Business;

namespace Wu.Jiahui.RRCAGApp
{
    public class CarWashForm : ACE.BIT.ADEV.Forms.CarWashForm
    {
        private BindingList<CarWashItem> fragrances;
        private BindingList<Package> packages;
        private BindingList<string> exteriorServices;
        private BindingList<string> interiorServices;

        private BindingSource bindingSourceFragrances;
        private BindingSource bindingSourcePackages;
        private BindingSource bindingSourceExteriorServices;
        private BindingSource bindingSourceInteriorServices;
        private BindingSource bindingSourceCarWashInvoice;

        public const decimal provincialSalesTax = 0;
        public const decimal goodsAndServicesTax = 0.05m;

        private decimal packageCost;
        private decimal fragranceCost;
        private CarWashInvoice carWashInvoice;

        public CarWashForm()
        {
            this.fragrances = new BindingList<CarWashItem>();
            this.bindingSourceFragrances = new BindingSource();
            this.bindingSourceFragrances.DataSource = this.fragrances;

            this.packages = new BindingList<Package>();
            this.bindingSourcePackages = new BindingSource();
            this.bindingSourcePackages.DataSource = this.packages;

            this.exteriorServices = new BindingList<string>();
            this.bindingSourceExteriorServices = new BindingSource();
            this.bindingSourceExteriorServices.DataSource = this.exteriorServices;

            this.interiorServices = new BindingList<string>();
            this.bindingSourceInteriorServices = new BindingSource();
            this.bindingSourceInteriorServices.DataSource = this.interiorServices;

            this.bindingSourceCarWashInvoice = new BindingSource();
            this.bindingSourceCarWashInvoice.DataSource = typeof(CarWashInvoice);

            InitialState();

            BindControls();

            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;
        }

        /// <summary>
        /// Handles the Click event of the generete invoice menu.
        /// </summary>
        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm carWashInvoiceForm;
            
            carWashInvoiceForm =  new CarWashInvoiceForm(this.carWashInvoice);

            carWashInvoiceForm.ShowDialog();

            ResetForm();
        }

        /// <summary>
        /// Handles the Click event of the file close menu.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the fragrance combo box.
        /// </summary>
        private void CboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePackagesInteriorServices();

            UpdateInvoice();

            if(this.cboPackage.SelectedIndex == -1)
            {
                this.lblSubtotal.Text =
                this.lblProvincialSalesTax.Text =
                this.lblGoodsAndServicesTax.Text =
                this.lblTotal.Text = string.Empty;
            }

            if(this.cboPackage.SelectedIndex != -1)
            {
                this.mnuToolsGenerateInvoice.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the package combo box.
        /// </summary>
        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboPackage.SelectedIndex != -1)
            {
                UpdatePackagesInteriorServices();

                UpdatePackagesExteriorServices();

                UpdateInvoice();
            }

            this.mnuToolsGenerateInvoice.Enabled = true;
        }

        /// <summary>
        /// Method that resets the form.
        /// </summary>
        private void ResetForm()
        {
            this.lblSubtotal.Text =
            this.lblProvincialSalesTax.Text =
            this.lblGoodsAndServicesTax.Text =
            this.lblTotal.Text = string.Empty;

            this.bindingSourceInteriorServices.Clear();
            this.bindingSourceExteriorServices.Clear();

            this.cboPackage.SelectedIndex = -1;

            int index = -1;
            foreach (CarWashItem item in this.fragrances)
            {
                if (!(item.Description.Equals("Pine")) && !(item.Price == 0))
                    index++;
            }
            this.cboFragrance.SelectedIndex = index;

            this.mnuToolsGenerateInvoice.Enabled = false;
        }

        /// <summary>
        /// Method that updates the CarWashInvoice oobject.
        /// </summary>
        private void UpdateInvoice()
        {
            if(this.cboPackage.SelectedIndex != -1)
            {
                this.packageCost = ((Package)this.cboPackage.SelectedItem).Price;
            }

            this.fragranceCost = ((CarWashItem)this.cboFragrance.SelectedItem).Price;

            if (carWashInvoice == null)
            {
                this.carWashInvoice = new CarWashInvoice(provincialSalesTax, goodsAndServicesTax);
            }

            this.carWashInvoice.PackageCost = packageCost;
            this.carWashInvoice.FragranceCost = fragranceCost;

            this.bindingSourceCarWashInvoice.DataSource = this.carWashInvoice;
        }

        /// <summary>
        /// Method that updates the package interior services.
        /// </summary>
        private void UpdatePackagesInteriorServices()
        {
            this.interiorServices.Clear();

            Package package;
            package = (Package)this.cboPackage.SelectedItem;

            CarWashItem carWashItem;
            carWashItem = (CarWashItem)this.cboFragrance.SelectedItem;

            if(this.cboPackage.SelectedIndex != -1)
            {
                this.interiorServices.Insert(0, $"Fragrance - {carWashItem.Description}");

                foreach (string interiorService in package.InteriorServices)
                    this.interiorServices.Add(interiorService);
            }
        }

        /// <summary>
        /// Method that updates the package exterior services.
        /// </summary>
        private void UpdatePackagesExteriorServices()
        {
            this.exteriorServices.Clear();

            Package package;
            package = (Package)this.cboPackage.SelectedItem;

            foreach (string exteriorService in package.ExteriorServices)
                this.exteriorServices.Add(exteriorService);
        }

        /// <summary>
        /// Method that defines the initial state of the Car Wash form.
        /// </summary>
        private void InitialState()
        {
            this.Text = "Car Wash";
            this.mnuToolsGenerateInvoice.Enabled = false;
            List<string> interiorServices = new List<string>();
            List<string> exteriorServices = new List<string>();

            ReadData();

            exteriorServices.Add("Hand Wash");
            Package standard = new Package(
                "Standard",
                7.5m,
                interiorServices,
                exteriorServices);

            interiorServices.Add("Shampoo Carpets");
            exteriorServices.Add("Hand Wax");
            Package deluxe = new Package(
                "Deluxe",
                15,
                interiorServices,
                exteriorServices);

            interiorServices.Add("Shampoo Upholstery");
            exteriorServices.Add("Wheel Polish");
            Package executive = new Package(
                "Executive",
                35,
                interiorServices,
                exteriorServices);

            interiorServices.Add("Interior Protection Coat");
            exteriorServices.Add("Detail Engine Compartment");
            Package luxury = new Package(
                "Luxury",
                55,
                interiorServices,
                exteriorServices);

            this.bindingSourcePackages.Add(standard);
            this.bindingSourcePackages.Add(deluxe);
            this.bindingSourcePackages.Add(executive);
            this.bindingSourcePackages.Add(luxury);

            this.lblSubtotal.Text = 
                this.lblProvincialSalesTax.Text = 
                this.lblGoodsAndServicesTax.Text = 
                this.lblTotal.Text = string.Empty;

            this.carWashInvoice = null;
        }

        /// <summary>
        /// Method that reads the data from a txt file.
        /// </summary>
        private void ReadData()
        {
            try
            {
                string filePath = "fragrances.txt";

                if (!File.Exists(filePath))
                {
                    string messsage = "Fragrance data file not found.";
                    string caption = "Data File Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(messsage, caption, buttons, icon, MessageBoxDefaultButton.Button3);
                    this.Close();
                }

                else
                {
                    FileStream stream;
                    stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                    StreamReader reader;
                    reader = new StreamReader(stream);

                    while (reader.Peek() != -1)
                    {
                        string record = reader.ReadLine();

                        string[] fields = record.Split(new char[] { ',' });

                        string description = fields[0];
                        decimal price = decimal.Parse(fields[1]);

                        CarWashItem carWashItem;

                        carWashItem = new CarWashItem(description, price);

                        if(!carWashItem.Description.Equals("Pine") && !(carWashItem.Price == 0))
                        {
                            this.fragrances.Add(carWashItem);
                        }
                    }

                    this.fragrances.Add(new CarWashItem("Pine", 0));

                    this.cboFragrance.Sorted = true;

                    stream.Close();
                    reader.Close();
                }
            }

            catch(Exception)
            {
                string messsage = "An error occurred while reading the data file.";
                string caption = "Data File Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(messsage, caption, buttons, icon, MessageBoxDefaultButton.Button3);
                this.Close();
            }
        }

        /// <summary>
        /// Method that does the data binding to the controls.
        /// </summary>
        private void BindControls()
        {
            this.cboFragrance.DataSource = this.bindingSourceFragrances;
            this.cboFragrance.DisplayMember = "Description";
            int index = -1;
            foreach (CarWashItem item in this.fragrances)
            {
                if (!(item.Description.Equals("Pine")) && !(item.Price == 0))
                    index++;
            }
            this.cboFragrance.SelectedIndex = index;

            this.cboPackage.DataSource = this.bindingSourcePackages;
            this.cboPackage.DisplayMember = "Description";
            this.cboPackage.SelectedIndex = -1;

            this.lstInterior.DataSource = this.bindingSourceInteriorServices;

            this.lstExterior.DataSource = this.bindingSourceExteriorServices;

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
