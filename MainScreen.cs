namespace FinalTaskAppC968
{
    public partial class MainScreen : Form
    {
        
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
  
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
    }
}
