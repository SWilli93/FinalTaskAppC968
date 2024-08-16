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
            inventory.addPart(new Outsourced { PartID = 1, Name = "Motor", Price = 199.99m, InStock = 10, Min = 1, Max = 20, CompanyName = "ACME Corp" });
            inventory.addPart(new Outsourced { PartID = 2, Name = "Gearbox", Price = 89.99m, InStock = 15, Min = 1, Max = 30, CompanyName = "ACME Corp" });
            inventory.addProduct(new Product { ProductID = 1, Name = "Bike", Price = 199.95m, InStock = 3, Min = 5, Max = 25 });
        }

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

        private void MainScreen_Load(object sender, EventArgs e)
        {
        }

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

        private void MainScreenExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
