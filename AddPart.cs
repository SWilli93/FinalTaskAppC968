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

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void AddPartSave_Click(object sender, EventArgs e)
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
            } 
            else
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
            }
            this.Close();
        }
        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
