using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_CarDatabaseManagement
{
    public partial class Form1 : Form
    {
        CarRepository carRepository;
        public Form1()
        {
            InitializeComponent();
        }

        #region MenuItems
        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = true;
            grpDisplay.Visible = true;
            lblBegin.Visible = false;
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = false;
            grpDisplay.Visible = false;
            lblBegin.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            carRepository = new CarRepository();
            dtgrdInventory.DataSource = carRepository.GetAllRecords();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVINToAdd.Text) && !string.IsNullOrEmpty(txtMakeToAdd.Text) && !string.IsNullOrEmpty(txtModelToAdd.Text))
            {
                Car carToAdd = new Car();
                carToAdd.VIN = txtVINToAdd.Text;
                carToAdd.Make = txtMakeToAdd.Text;
                carToAdd.Model = txtModelToAdd.Text;

                if (string.IsNullOrEmpty(txtPriceToAdd.Text))
                    carToAdd.Price = null;
                else
                    carToAdd.Price = Decimal.Parse(txtPriceToAdd.Text);

                if (string.IsNullOrEmpty(txtYearToAdd.Text))
                    carToAdd.Year = null;
                else
                    carToAdd.Year = Int32.Parse(txtYearToAdd.Text);

                carRepository.AddRecord(carToAdd);
                RefreshAddRecord();
            }
            else
            {
                MessageBox.Show("VIN, Make and Model cannot be blank.");
            }
        }

        public void RefreshAddRecord()
        {
            dtgrdInventory.DataSource = null;
            dtgrdInventory.DataSource = carRepository.GetAllRecords();
            txtVINToAdd.Clear();
            txtMakeToAdd.Clear();
            txtModelToAdd.Clear();
            txtPriceToAdd.Clear();
            txtYearToAdd.Clear();
        }

        private void txtVINToAdd_Validating(object sender, CancelEventArgs e)
        {
            if(carRepository.VINInDatabase(txtVINToAdd.Text))
            {
                MessageBox.Show("This VIN is already in the inventory.\nPlease go to the Edit tab if you want to update this record");
                txtVINToAdd.Clear();
            }
            else if(txtVINToAdd.Text.Length<5 || txtVINToAdd.Text.Length>17)
            {
                MessageBox.Show("VIN must be 5 to 17 characters long");
                txtVINToAdd.Clear();
            }
        }

        private void txtYearToAdd_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYearToAdd.Text))
            {
                int tempYear;
                bool parsed = Int32.TryParse(txtYearToAdd.Text, out tempYear);
                if (parsed == false)
                {
                    MessageBox.Show("Year value must be a whole number. Please try again.");
                    txtYearToAdd.Clear();
                }
                else if (tempYear < 1800 || tempYear > 2030)
                {
                    MessageBox.Show("Year must range between 1800 to 2030");
                    txtPriceToAdd.Clear();
                }
            }
        }

        private void txtPriceToAdd_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPriceToAdd.Text))
            {
                decimal tempPrice;
                bool parsed = Decimal.TryParse(txtPriceToAdd.Text, out tempPrice);
                if(parsed == false)
                { 
                    MessageBox.Show("Price value must be a whole number or decimal. Please try again.");
                    txtPriceToAdd.Clear();
                }
                else if(tempPrice<0)
                {
                    MessageBox.Show("Price cannot be negative. Please enter a zero or higher value or leave field blank if unknown");
                    txtPriceToAdd.Clear();
                }
            }
        }

        private void dtgrdInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVINToEdit.Text = dtgrdInventory.CurrentRow.Cells[0].Value.ToString();
            txtVINToDelete.Text = dtgrdInventory.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtVINToDelete.Text))
            {
                MessageBox.Show("Nothing was selected or typed on the VIN to be deleted.");
            }
            else if(!carRepository.VINInDatabase(txtVINToDelete.Text))
            {
                MessageBox.Show("A record with this VIN does not exist. Cannot delete.");
            }
            else
            {
                carRepository.DeleteRecord(carRepository.FindRecord(txtVINToDelete.Text));
                MessageBox.Show("Record deleted");
                dtgrdInventory.DataSource = null;
                dtgrdInventory.DataSource = carRepository.GetAllRecords();
            }
        }

        private void btnEditThisRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVINToEdit.Text))
            {
                MessageBox.Show("Nothing was selected or typed on the VIN to be edited.");
            }
            else if (!carRepository.VINInDatabase(txtVINToEdit.Text))
            {
                MessageBox.Show("A record with this VIN does not exist. Cannot edit.");
            }
            else
            {
                lblUpdateTheFields.Visible = true;
                tblUpdate.Visible = true;
                btnUpdateRecord.Visible = true;
                txtVINToEdit.ReadOnly = true;
                Car temp = carRepository.FindRecord(txtVINToEdit.Text);
                txtUpdatedVin.Text = temp.VIN;
                txtUpdatedMake.Text = temp.Make;
                txtUpdatedModel.Text = temp.Model;
                txtUpdatedYear.Text = temp.Year.ToString();
                txtUpdatedPrice.Text = temp.Price.ToString();
            }
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpdatedVin.Text) && !string.IsNullOrEmpty(txtUpdatedMake.Text) && !string.IsNullOrEmpty(txtUpdatedModel.Text))
            {
                Car carToEdit = new Car();
                carToEdit.VIN = txtUpdatedVin.Text;
                carToEdit.Make = txtUpdatedMake.Text;
                carToEdit.Model = txtUpdatedModel.Text;

                if (string.IsNullOrEmpty(txtUpdatedPrice.Text))
                    carToEdit.Price = null;
                else
                    carToEdit.Price = Decimal.Parse(txtUpdatedPrice.Text);

                if (string.IsNullOrEmpty(txtUpdatedYear.Text))
                    carToEdit.Year = null;
                else
                    carToEdit.Year = Int32.Parse(txtUpdatedYear.Text);

                carRepository.UpdateRecord(txtVINToEdit.Text, carToEdit);                
                MessageBox.Show("Record updated");
                tblUpdate.Visible = false;
                lblUpdateTheFields.Visible = false;
                btnUpdateRecord.Visible = false;
                txtVINToEdit.ReadOnly = false;
                dtgrdInventory.DataSource = null;
                dtgrdInventory.DataSource = carRepository.GetAllRecords();
            }
            else
            {
                MessageBox.Show("VIN, Make and Model cannot be blank.");
            }
        }

        private void txtUpdatedVin_Validating(object sender, CancelEventArgs e)
        {
            if (carRepository.VINInDatabase(txtUpdatedVin.Text) && txtVINToEdit.Text != txtUpdatedVin.Text)
            {
                MessageBox.Show("This VIN is already in the inventory in another record.");
                txtUpdatedVin.Clear();
            }
            else if (txtUpdatedVin.Text.Length < 5 || txtUpdatedVin.Text.Length > 17)
            {
                MessageBox.Show("VIN must be 5 to 17 characters long");
                txtUpdatedVin.Clear();
            }
        }

        private void txtUpdatedYear_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpdatedYear.Text))
            {
                int tempYear;
                bool parsed = Int32.TryParse(txtUpdatedYear.Text, out tempYear);
                if (parsed == false)
                {
                    MessageBox.Show("Year value must be a whole number. Please try again.");
                    txtUpdatedYear.Clear();
                }
                else if (tempYear < 1800 || tempYear > 2030)
                {
                    MessageBox.Show("Year must range between 1800 to 2030");
                    txtUpdatedYear.Clear();
                }
            }
        }

        private void txtUpdatedPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpdatedPrice.Text))
            {
                decimal tempPrice;
                bool parsed = Decimal.TryParse(txtUpdatedPrice.Text, out tempPrice);
                if (parsed == false)
                {
                    MessageBox.Show("Price value must be a whole number or decimal. Please try again.");
                    txtUpdatedPrice.Clear();
                }
                else if (tempPrice < 0)
                {
                    MessageBox.Show("Price cannot be negative. Please enter a zero or higher value or leave field blank if unknown");
                    txtUpdatedPrice.Clear();
                }
            }
        }

        private void txtVINToEdit_TextChanged(object sender, EventArgs e)
        {
            lblUpdateTheFields.Visible = false;
            tblUpdate.Visible = false;
            btnUpdateRecord.Visible = false;
        }
    }
}
