namespace FinalTaskAppC968
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreenPartModifyButton_Click(object sender, EventArgs e)
        {
            ModifyPart mp = new ModifyPart();
            mp.Show();
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
    }
}
