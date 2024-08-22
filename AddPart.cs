using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalTaskAppC968
{
    public partial class AddPart : Form
    {
        bool isNumeric = false;

        public AddPart()
        {
            InitializeComponent();
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDLabel.Text = "Company Name";
        }

        private void InHouse_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDLabel.Text = "Machine ID";
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {

            if (runchecks(out string error))
            {
                if (Outsourced.Checked)
                {
                    Part newPart = new Outsourced(
                        Int32.Parse(this.AddPartPartIDTextBox.Text),
                        this.AddPartNameTextBox.Text,
                        decimal.Parse(this.AddPartPriceTextBox.Text),
                        Int32.Parse(this.AddPartInventoryTextBox.Text),
                        Int32.Parse(this.AddPartMinTextBox.Text),
                        Int32.Parse(this.AddPartMaxTextBox.Text),
                        this.AddPartMachineIDCompanyNameTextBox.Text
                        );

                    MainScreen.inventory.addPart(newPart);
                    this.Close();
                }
                else if (InHouse.Checked && Int32.TryParse(this.AddPartMachineIDCompanyNameTextBox.Text, out int MachineID))
                {
                    Part newPart = new Inhouse(
                        Int32.Parse(this.AddPartPartIDTextBox.Text),
                        this.AddPartNameTextBox.Text,
                        decimal.Parse(this.AddPartPriceTextBox.Text),
                        Int32.Parse(this.AddPartInventoryTextBox.Text),
                        Int32.Parse(this.AddPartMinTextBox.Text),
                        Int32.Parse(this.AddPartMaxTextBox.Text),
                        Int32.Parse(this.AddPartMachineIDCompanyNameTextBox.Text)
                        );

                    MainScreen.inventory.addPart(newPart);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private bool runchecks(out string error)
        {
            error = string.Empty;

            if (
                    !Int32.TryParse(this.AddPartPartIDTextBox.Text, out int resultID) ||
                    !decimal.TryParse(this.AddPartPriceTextBox.Text, out decimal resultPrice) ||
                    !Int32.TryParse(this.AddPartInventoryTextBox.Text, out int resultStock) ||
                    !Int32.TryParse(this.AddPartMinTextBox.Text, out int resultMin) ||
                    !Int32.TryParse(this.AddPartMaxTextBox.Text, out int resultMax))
            {
                error = "Please input valid numbers for required fields";
                return false;
            }


            if (!Validator.ValidateMinMaxInventory(Int32.Parse(AddPartMinTextBox.Text), Int32.Parse(AddPartMaxTextBox.Text), Int32.Parse(AddPartInventoryTextBox.Text), out string errorMessage))

            {
                error = errorMessage;
                return false;
            }
            return true;
        }
        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
