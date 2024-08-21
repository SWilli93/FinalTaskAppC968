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
    public partial class ModifyPart : Form
    {
        Part part;
        bool isNumeric = false;

        public ModifyPart()
        {
            part = MainScreen.selectedPart;
            InitializeComponent();
            this.ModifyPartPartIDTextBox.Text = Convert.ToString(part.PartID);
            this.ModifyPartNameTextBox.Text = Convert.ToString(part.Name);
            this.ModifyPartInventoryTextBox.Text = Convert.ToString(part.InStock);
            this.ModifyPartPriceTextBox.Text = Convert.ToString(part.Price);
            this.ModifyPartMaxTextBox.Text = Convert.ToString(part.Max);
            this.ModifyPartMinTextBox.Text = Convert.ToString(part.Min);
            if (MainScreen.selectedPart is Outsourced outsourcedPart)
            {
                this.Outsourced.Checked = true;
                this.MachineIDLabel.Text = "Company Name";
                this.ModifyPartMachineIDCompanyNameTextBox.Text = outsourcedPart.CompanyName; // Access CompanyName property
            }
            else if (MainScreen.selectedPart is Inhouse inhousePart)
            {
                this.InHouse.Checked = true;
                this.ModifyPartMachineIDCompanyNameTextBox.Text = Convert.ToString(inhousePart.MachineID); // Access MachineID property
            }

        }

        private void ModifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPartSaveButton_Click(object sender, EventArgs e)
        {
            // Validation if fields have valid numbers
            if (
                    Int32.TryParse(this.ModifyPartPartIDTextBox.Text, out int resultID) &&
                    decimal.TryParse(this.ModifyPartPriceTextBox.Text, out decimal resultPrice) &&
                    Int32.TryParse(this.ModifyPartInventoryTextBox.Text, out int resultStock) &&
                    Int32.TryParse(this.ModifyPartMinTextBox.Text, out int resultMin) &&
                    Int32.TryParse(this.ModifyPartMaxTextBox.Text, out int resultMax) 
                )
            {
                isNumeric = true;
            }


            if (isNumeric)
            {
                // Modify Part if it is all validated
                part.Name = this.ModifyPartNameTextBox.Text;
                part.InStock = Int32.Parse(this.ModifyPartInventoryTextBox.Text);
                part.Price = decimal.Parse(this.ModifyPartPriceTextBox.Text);
                part.Max = Int32.Parse(this.ModifyPartMaxTextBox.Text);
                part.Min = Int32.Parse(this.ModifyPartMinTextBox.Text);
                if (part is Outsourced outsourcedPart)
                {
                    outsourcedPart.CompanyName = this.ModifyPartMachineIDCompanyNameTextBox.Text; // Access CompanyName property
                    this.Close();
                }
                else if (part is Inhouse inhousePart && Int32.TryParse(this.ModifyPartMachineIDCompanyNameTextBox.Text, out int resultMachineID))
                {
                    inhousePart.MachineID = Int32.Parse(this.ModifyPartMachineIDCompanyNameTextBox.Text); // Access MachineID property
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please input valid numbers for required fields");
                }
            }
            else
            {
                MessageBox.Show("Please input valid numbers for required fields");
            }
        }
    }
}
