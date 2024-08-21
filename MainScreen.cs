using System.ComponentModel;
using System.Windows.Forms;

namespace FinalTaskAppC968
{
    public partial class MainScreen : Form
    {
        public static Inventory inventory;
        private DataGridView dataGridViewParts;
        private DataGridView dataGridViewProducts;

        public static Part? selectedPart;
        private Product selectedProduct;

        public MainScreen()
        {
            InitializeComponent();

            inventory = new Inventory();
            dataGridViewParts = new DataGridView();
            dataGridViewProducts = new DataGridView();


            SetupDataGridView1();
            SetupDataGridView2();

            // Bind the DataGridView to the BindingList
            dataGridViewMainScreenParts.DataSource = inventory.AllParts;
            dataGridViewMainScreenProducts.DataSource = inventory.Products;

            // Example: Populate the inventory with some parts
            PopulateParts();

            // Search Functionality for parts
            //this.MainScreenSearchPartTextBox.TextChanged += new System.EventHandler(this.PartSearchButton_Click);

        }


        private void SetupDataGridView1()
        {
            dataGridViewParts.AutoGenerateColumns = true; // Automatically create columns based on Part properties
        }
        private void SetupDataGridView2()
        {
            dataGridViewProducts.AutoGenerateColumns = true; // Automatically create columns based on Part properties
        }

        private void PopulateParts()
        {
            // Add some example parts to the inventory
            inventory.addPart(new Outsourced(1, "Motor", 199.99m, 10, 1, 20, "ACME Corp"));
            inventory.addPart(new Outsourced(2, Name = "Gearbox", 89.99m, 15, 1, 30, "ACME Corp"));

        }


        // Part Add/Modify
        private void MainScreenPartModifyButton_Click(object sender, EventArgs e)
        {
            if (selectedPart != null)
            {
                ModifyPart mp = new ModifyPart();
                mp.Show();

            }
        }

        private void MainScreenPartAddButton_Click(object sender, EventArgs e)
        {
            AddPart ap = new AddPart();
            ap.Show();

        }

        // Product Add/Modify
        private void MainScreenProductAddButton_Click(object sender, EventArgs e)
        {
            AddProduct newproduct = new AddProduct();
            newproduct.Show();
        }

        private void MainScreenProductModifyButton_Click(object sender, EventArgs e)
        {
            ModifyProduct modproduct = new ModifyProduct();
            modproduct.Show();
        }


        // On Load
        private void MainScreen_Load(object sender, EventArgs e)
        {
        }



        // Delete Buttons Part and Product
        private void MainScreenPartDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedPart != null)
            {
                inventory.AllParts.Remove(selectedPart);
                selectedPart = null;
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void MainScreenProductDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                inventory.Products.Remove(selectedProduct);
                selectedProduct = null;
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        // Exit Button 
        private void MainScreenExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click on Cell = Part/Product id
        private void dataGridViewMainScreenParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int partID = (int)dataGridViewMainScreenParts.Rows[e.RowIndex].Cells["PartID"].Value;
                selectedPart = inventory.AllParts.FirstOrDefault(p => p.PartID == partID);
            }
        }

        private void dataGridViewMainScreenProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productID = (int)dataGridViewMainScreenProducts.Rows[e.RowIndex].Cells["ProductID"].Value;
                selectedProduct = inventory.Products.FirstOrDefault(p => p.ProductID == productID);
            }
        }

        // No item selected on Load
        private void dataGridViewMainScreenParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewMainScreenParts.ClearSelection();
        }

        private void dataGridViewMainScreenProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewMainScreenProducts.ClearSelection();
        }


        // Search Buttons Functionality
        private void PartSearchButton_Click(object sender, EventArgs e)
        {
            if (MainScreenSearchPartTextBox.Text != null)
            {
                string searchText = MainScreenSearchPartTextBox.Text.ToLower();

                BindingList<Part> filteredParts = new BindingList<Part>();

                foreach (Part part in inventory.AllParts)
                {
                    if (part.Name.ToLower().Contains(searchText))
                        filteredParts.Add(part);
                }

                dataGridViewMainScreenParts.DataSource = filteredParts;
            }
        }

        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            if (MainScreenSearchProductsTextBox.Text != null)
            {
                string searchText = MainScreenSearchProductsTextBox.Text.ToLower();

                BindingList<Product> filteredProducts = new BindingList<Product>();

                foreach (Product product in inventory.Products)
                {
                    if (product.Name.ToLower().Contains(searchText))
                        filteredProducts.Add(product);
                }

                dataGridViewMainScreenProducts.DataSource = filteredProducts;
            }
        }



        // Search button Clearing Functionality
        private void MainScreenSearchPartTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainScreenSearchPartTextBox.Text))
            {
                dataGridViewMainScreenParts.DataSource = inventory.AllParts;
            }
        }

        private void MainScreenSearchProductsTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainScreenSearchProductsTextBox.Text))
            {
                dataGridViewMainScreenProducts.DataSource = inventory.Products;
            }
        }

        private void dataGridViewMainScreenParts_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainScreenSearchPartTextBox.Text))
            {
                dataGridViewMainScreenParts.DataSource = inventory.AllParts;
            }
        }

        private void dataGridViewMainScreenProducts_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainScreenSearchProductsTextBox.Text))
            {
                dataGridViewMainScreenProducts.DataSource = inventory.Products;
            }
        }
    }
}
