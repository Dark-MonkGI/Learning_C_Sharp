namespace Utility
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my first windows form program for learning C#.\nStudent: Ilia.G.","About");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
            {
                count = 0;
            }
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int number;
            number = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)+1);
            lblRandom.Text = number.ToString();

            if (cbRandom.Checked)
            {
                int i = 0;

                while (txtRandom.Text.IndexOf(number.ToString()) != -1)
                {
                    number = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;
                    if (i > 1000) break; 
                }
                if (i <= 1000)
                {
                    txtRandom.AppendText(number.ToString() + " \r\n");
                    lblRandom.Text = number.ToString();
                }             
                
            }
            else
                txtRandom.AppendText(number.ToString() + " \r\n");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtRandom.Clear();
            lblRandom.Text = "Null";
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtRandom.Text);
        }
    }
}