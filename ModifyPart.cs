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

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void ModifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPartSaveButton_Click(object sender, EventArgs e)
        {
            part.Name = this.ModifyPartNameTextBox.Text;
            part.InStock = Int32.Parse(this.ModifyPartInventoryTextBox.Text);
            part.Price = decimal.Parse(this.ModifyPartPriceTextBox.Text);
            part.Max = Int32.Parse(this.ModifyPartMaxTextBox.Text);
            part.Min = Int32.Parse(this.ModifyPartMinTextBox.Text);
            if (part is Outsourced outsourcedPart)
            {
                outsourcedPart.CompanyName = this.ModifyPartMachineIDCompanyNameTextBox.Text; // Access CompanyName property
            }
            else if (part is Inhouse inhousePart)
            {
                inhousePart.MachineID = Int32.Parse(this.ModifyPartMachineIDCompanyNameTextBox.Text); // Access MachineID property
            }
            this.Close();
        }
    }
}
