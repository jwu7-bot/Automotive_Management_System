/*
 * Name: JiaHui Wu 
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Create: 5-30-2023
 * Update: 6-19-2023
 */
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Diagnostics;

namespace Wu.Jiahui.RRCAGApp
{
    public class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;

        public VehicleDataForm()
        {
            this.bindingSource = new BindingSource();

            this.Load += VehicleDataForm_Load;
        }

        /// <summary>
        /// Handles the Load event of the VehicleDataForm.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            InitialState();

            BindControls();

            this.mnuFileClose.Click += MnuFileClose_Click;
            this.mnuFileSave.Click += MnuFileSave_Click;
            this.mnuEditDelete.Click += MnuEditDelete_Click;
            this.dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
            this.dgvVehicles.CellValueChanged += DgvVehicles_CellValueChanged;
            this.dgvVehicles.DefaultValuesNeeded += DgvVehicles_DefaultValuesNeeded;
            this.adapter.RowUpdated += new OleDbRowUpdatedEventHandler(dataAdapter_RowUpdated);
            this.FormClosing += VehicleDataForm_FormClosing;
        }

        /// <summary>
        /// Handles the FormClosing event of the Vehicle Data form.
        /// </summary>
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               if (this.Text.Equals("* Vehicle Data"))
                {
                    string text = "Do you wish to save the changes?";
                    string caption = "Save";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3;

                    DialogResult result = MessageBox.Show(text, caption, buttons, icon, defaultButton);

                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        this.adapter.Update(this.dataset, "VehicleStock");
                    }
                }

                this.connection.Close();
                this.connection.Dispose();
            }
            catch(Exception)
            {
                string text = "An error occurred while saving the changes. Do you still wish to close?";
                string caption = "Save Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;

                DialogResult result = MessageBox.Show(text, caption, buttons, icon, defaultButton);

                if(result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Handles the CellValueChanged event of the data grid view.
        /// </summary>
        private void DgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "* Vehicle Data";

            this.mnuFileSave.Enabled = true;
        }

        /// <summary>
        /// Handles the SelectionChanged event of the data grid view.
        /// </summary>
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvVehicles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dgvVehicles.SelectedRows[0];

                if (!selectedRow.IsNewRow)
                {
                    this.mnuEditDelete.Enabled = true;
                    return;
                }
            }
            this.mnuEditDelete.Enabled = false;
        }

        /// <summary>
        /// Handles the DefaultValuesNeeded event of the data grid view.
        /// </summary>
        private void DgvVehicles_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["SoldBy"].Value = 0;
        }

        /// <summary>
        /// Handles the Click event of the edit delete menu strip.
        /// </summary>
        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvVehicles.Rows[this.dgvVehicles.CurrentRow.Index];
            string text = string.Format($"Are you sure you want to permanently delete stock item {row.Cells["StockNumber"].Value}?");
            string caption = "Delete Stock Item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;

            DialogResult result = MessageBox.Show(text, caption, buttons, icon, defaultButton);

            if(result == DialogResult.Yes)
            {
                this.dgvVehicles.Rows.RemoveAt(this.dgvVehicles.CurrentRow.Index);

                try
                {
                    this.adapter.Update(this.dataset, "VehicleStock");
                }
                catch(Exception)
                {
                    MessageBox.Show("An error occurred while deleting the selected vehicle.",
                               "Deletion Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                }

                this.Text = "Vehicle Data";
                this.mnuEditDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the file save menu strip.
        /// </summary>
        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            this.dgvVehicles.EndEdit();

            this.bindingSource.EndEdit();

            try
            {
                this.adapter.Update(this.dataset, "VehicleStock");
            }
            catch(Exception)
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data.",
                                "Save Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            this.Text = "Vehicle Data";
            this.mnuFileSave.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the file close menu strip.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the auto number feature of the Database.
        /// </summary>
        void dataAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // When the update is an Insert (new record)
            if (e.StatementType == StatementType.Insert)
            {
                // Creates a new command
                // @@IDENTITY - a database value that returns the last-inserted identity 
                // (AutoNumber) value from the last statement
                OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", this.connection);

                // Assigns the ID value of the new row in the database to the DataColumn "ID" 
                // of the new
                // DataRow in the DataTable
                // ***
                // ExecuteScalar - Executes the command and returns the value of first column 
                // of the first row returned
                // e.Row - reference to the DataRow being updated from the DataTable.
                // e.Row["ID"] - reference to the "ID" DataColumn in the DataRow.
                e.Row["ID"] = (int)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Method that sets the initial state of the form.
        /// </summary>
        private void InitialState()
        {
            this.mnuFileSave.Enabled = 
                this.mnuEditDelete.Enabled = false;

            this.Text = "Vehicle Data";

            this.WindowState = FormWindowState.Maximized;

            this.dgvVehicles.AllowUserToDeleteRows = 
                this.dgvVehicles.AllowUserToResizeRows = false;

            this.dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvVehicles.MultiSelect = false;

            RetrieveDataFromDataBase();
        }

        /// <summary>
        /// Method that retrieves data from the database and displays it.
        /// </summary>
        private void RetrieveDataFromDataBase()
        {
            try
            {
                this.connection = new OleDbConnection();

                this.connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AMDatabase.mdb";

                this.connection.Open();

                OleDbCommand selectCommand;
                selectCommand = new OleDbCommand();

                selectCommand.CommandText = "SELECT * FROM VehicleStock;";
                selectCommand.Connection = this.connection;

                this.adapter = new OleDbDataAdapter();
                this.adapter.SelectCommand = selectCommand;

                this.dataset = new DataSet();

                this.adapter.Fill(this.dataset, "VehicleStock");

                OleDbCommandBuilder commandBuilder;
                commandBuilder = new OleDbCommandBuilder();

                commandBuilder.DataAdapter = this.adapter;
                commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

                this.adapter.InsertCommand = commandBuilder.GetInsertCommand();
                this.adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                this.adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method that sets the binding.
        /// </summary>
        private void BindControls()
        {
            this.bindingSource.DataSource = this.dataset.Tables["VehicleStock"];

            this.dgvVehicles.DataSource = this.bindingSource;

            this.dgvVehicles.Columns["ID"].Visible = false;
            this.dgvVehicles.Columns["SoldBy"].Visible = false;
        }
    }
}
