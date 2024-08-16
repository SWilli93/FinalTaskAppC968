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
        public ModifyPart()
        {
            InitializeComponent();
            this.ModifyPartPartIDTextBox.Text = Convert.ToString(MainScreen.selectedPart.PartID);
            this.ModifyPartNameTextBox.Text = Convert.ToString(MainScreen.selectedPart.Name);
            this.ModifyPartInventoryTextBox.Text = Convert.ToString(MainScreen.selectedPart.InStock);
            this.ModifyPartPriceTextBox.Text = Convert.ToString(MainScreen.selectedPart.Price);
            this.ModifyPartMaxTextBox.Text = Convert.ToString(MainScreen.selectedPart.Max);
            this.ModifyPartMinTextBox.Text = Convert.ToString(MainScreen.selectedPart.Min);
            if (MainScreen.selectedPart is Outsourced outsourcedPart)
            {
                this.Outsourced.Checked = true;
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

        }
    }
}
