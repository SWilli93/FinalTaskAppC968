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
    public partial class ModifyProduct : Form
    {
        Product newProduct = new Product();
        int productID = MainScreen.selectedProduct;
        public Part? partToAdd;
        public int partToDelete;

        Product oldProduct = MainScreen.inventory.Products.FirstOrDefault(p => p.ProductID == MainScreen.selectedProduct);

        public ModifyProduct()
        {

            InitializeComponent();
            if (oldProduct != null)
            {
                newProduct.AssociatedParts = oldProduct.AssociatedParts;

                this.ModifyProductIDTextBox.Text = Convert.ToString(oldProduct.ProductID);
                this.ModifyProductNameTextBox.Text = oldProduct.Name;
                this.ModifyProductPriceTextBox.Text = Convert.ToString(oldProduct.Price);
                this.ModifyProductInventoryTextBox.Text = Convert.ToString(oldProduct.InStock);
                this.ModifyProductMinTextBox.Text = Convert.ToString(oldProduct.Min);
                this.ModifyProductMaxTextBox.Text = Convert.ToString(oldProduct.Max);

                ModifyProductAllParts.DataSource = MainScreen.inventory.AllParts;
                ModifyProductAssociatedParts.DataSource = newProduct.AssociatedParts;
            }
        }


        // Cancel Button
        private void ModifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save Button
        private void ModifyProductSaveButton_Click(object sender, EventArgs e)
        {
            if (oldProduct != null)
            {
                oldProduct.Name = ModifyProductNameTextBox.Text;
                oldProduct.Price = decimal.Parse(ModifyProductPriceTextBox.Text);
                oldProduct.InStock = Int32.Parse(ModifyProductInventoryTextBox.Text);
                oldProduct.Min = Int32.Parse(ModifyProductMinTextBox.Text);
                oldProduct.Max = Int32.Parse(ModifyProductMaxTextBox.Text);
            }
            this.Close();
        }


        // Add Associated Part Button
        private void ModifyProductAddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            if (partToAdd != null)
            {
                newProduct.addAssociatedPart(partToAdd);
            }
        }


        // Search Functionality
        private void ModifyProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int partID = (int)ModifyProductAllParts.Rows[e.RowIndex].Cells["PartID"].Value;
                partToAdd = MainScreen.inventory.AllParts.FirstOrDefault(p => p.PartID == partID);
            }
        }

        private void ModifyProductAllParts_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProductSearchTextBox.Text))
            {
                ModifyProductAllParts.DataSource = MainScreen.inventory.AllParts;
            }
        }

        private void ModifyProductSearchButton_Click(object sender, EventArgs e)
        {
            if (ModifyProductSearchTextBox.Text != null)
            {
                string searchText = ModifyProductSearchTextBox.Text.ToLower();

                BindingList<Part> filteredParts = new BindingList<Part>();

                foreach (Part part in MainScreen.inventory.AllParts)
                {
                    if (part.Name.ToLower().Contains(searchText))
                        filteredParts.Add(part);
                }

                ModifyProductAllParts.DataSource = filteredParts;
            }
        }

        // Associated Parts Delete and selection 
        private void ModifyProductAssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                partToDelete = (int)ModifyProductAssociatedParts.Rows[e.RowIndex].Cells["PartID"].Value;
            }
        }

        // Delete Button
        private void ModifyProductDeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            newProduct.removeAssociatedPart(partToDelete);
        }

        // No selection on load
        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            ModifyProductAssociatedParts.ClearSelection();
            ModifyProductAllParts.ClearSelection();
        }
    }
}
