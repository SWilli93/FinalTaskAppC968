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
     MainScreen inventory;
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();

            inventory = new Inventory();
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
            inventory.AddPart(this);
        }
        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
