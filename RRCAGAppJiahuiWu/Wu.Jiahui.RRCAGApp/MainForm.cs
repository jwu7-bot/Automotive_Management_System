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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wu.Jiahui.RRCAGApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
            this.mnuDataVehicles.Click += MnuDataVehicles_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
        }

        /// <summary>
        /// Handles the Click event of the data vehicles menu item.
        /// </summary>
        private void MnuDataVehicles_Click(object sender, EventArgs e)
        {
            VehicleDataForm existingForm = null;

            foreach(Form childForm in this.MdiChildren)
            {
                if(childForm is VehicleDataForm)
                {
                    existingForm = (VehicleDataForm)childForm;
                    break;
                }
            }

            if(existingForm == null)
            {
                VehicleDataForm form = new VehicleDataForm();
                CreateMdiChildForm(form);
            }
            else
            {
                existingForm.Activate();
            }
        }

        /// <summary>
        /// Handles the Click event of the car wash menu item.
        /// </summary>
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm form = new CarWashForm();
            CreateMdiChildForm(form);
        }

        /// <summary>
        /// Handles the Click event of the sales quote menu item.
        /// </summary>
        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm form = new SalesQuoteForm();
            CreateMdiChildForm(form);
        }

        /// <summary>
        /// Reusable method for mdi child creation.
        /// </summary>
        private void CreateMdiChildForm(Form mdiChildForm)
        {
            mdiChildForm.MdiParent = this;
            mdiChildForm.Show();
        }

        /// <summary>
        /// Handles the Click event of exit menu item.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the CLick event of the about menu item.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }
    }
}
