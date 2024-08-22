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
    public partial class AddProduct : Form
    {
        private Product newProduct;
        public Part? partToAdd;
        
        public int partToDelete;
        
        public AddProduct()
        {
            InitializeComponent();
            newProduct = new Product();


            AddProductAllParts.DataSource = MainScreen.inventory.AllParts;
            AddProductsAssociatedParts.DataSource = newProduct.AssociatedParts;
        }

        // Cancel Button
        private void AddProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add Associated Part to Product Button
        private void AddProductAddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            if (partToAdd != null)
            {
                newProduct.addAssociatedPart(partToAdd);
            }
        }

        // Delete Associated Part Button
        private void AddProductDeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            newProduct.removeAssociatedPart(partToDelete);
        }


        // Select Part from AllParts Functionality
        private void AddProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int partID = (int)AddProductAllParts.Rows[e.RowIndex].Cells["PartID"].Value;
                partToAdd = MainScreen.inventory.AllParts.FirstOrDefault(p => p.PartID == partID);
            }

        }

        // Select Part from Associated Parts

        private void AddProductsAssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                partToDelete = (int)AddProductsAssociatedParts.Rows[e.RowIndex].Cells["PartID"].Value;
            }
        }


        // Save Button & Validation
        private void AddProductSaveButton_Click(object sender, EventArgs e)
        {
            

            if (runchecks(out string error))
            {
                newProduct.ProductID = Int32.Parse(AddProductIDTextBox.Text);
                newProduct.Name = AddProductNameTextBox.Text;
                newProduct.Price = decimal.Parse(AddProductPriceTextBox.Text);
                newProduct.InStock = Int32.Parse(AddProductInventoryTextBox.Text);
                newProduct.Min = Int32.Parse(AddProductMinTextBox.Text);
                newProduct.Max = Int32.Parse(AddProductMaxTextBox.Text);

                MainScreen.inventory.addProduct(newProduct);
                this.Close();
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
                    !Int32.TryParse(this.AddProductIDTextBox.Text, out int resultID) ||
                    !decimal.TryParse(this.AddProductPriceTextBox.Text, out decimal resultPrice) ||
                    !Int32.TryParse(this.AddProductInventoryTextBox.Text, out int resultStock) ||
                    !Int32.TryParse(this.AddProductMinTextBox.Text, out int resultMin) ||
                    !Int32.TryParse(this.AddProductMaxTextBox.Text, out int resultMax))
            {
                error = "Please input valid numbers for required fields";
                return false;
            }


            if (!Validator.ValidateMinMaxInventory(Int32.Parse(AddProductMinTextBox.Text), Int32.Parse(AddProductMaxTextBox.Text), Int32.Parse(AddProductInventoryTextBox.Text), out string errorMessage))

            {
                error = errorMessage;
                return false;
            }
            return true;
        }

        // Search button
        private void AddProductSearchButton_Click(object sender, EventArgs e)
        {
            if (AddProductSearchTextBox.Text != null)
            {
                string searchText = AddProductSearchTextBox.Text.ToLower();

                BindingList<Part> filteredParts = new BindingList<Part>();

                foreach (Part part in MainScreen.inventory.AllParts)
                {
                    if (part.Name.ToLower().Contains(searchText))
                        filteredParts.Add(part);
                }

                AddProductAllParts.DataSource = filteredParts;
            }
        }
        // Reset the datasource after clearing text
        private void AddProductAllParts_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddProductSearchTextBox.Text))
            {
                AddProductAllParts.DataSource = MainScreen.inventory.AllParts;
            }
        }
    }
}
