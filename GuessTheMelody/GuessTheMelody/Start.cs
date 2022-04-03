namespace GuessTheMelody
{
    public partial class fMain : Form
    {
        fParameters fParameters = new fParameters();

        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fParameters.ShowDialog();
        }
    }
}