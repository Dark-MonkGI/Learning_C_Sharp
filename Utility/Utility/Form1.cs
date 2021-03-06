namespace Utility
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        char[] special_chars = new char[] {'%','*',')','?', '#','$', '^', '&', '~'};
        Dictionary<string, double> metrica;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);

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

        private void tsmiAddDate_Click(object sender, EventArgs e)
        {
            rtbNotebook.AppendText(DateTime.Now.ToShortDateString() + "\r\n");
        }

        private void tsmiAddTime_Click(object sender, EventArgs e)
        {
            rtbNotebook.AppendText(DateTime.Now.ToShortTimeString() + "\r\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotebook.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("File save error");
            }
            
        }

        private void tsmiDownload_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        void LoadNotepad()
        {
            try
            {
                rtbNotebook.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("File upload error");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            clbPassword.SetItemChecked(0, true);
            clbPassword.SetItemChecked(1, true);
            clbPassword.SetItemChecked(2, true);
            clbPassword.SetItemChecked(3, true);
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";

            for(int i = 0; i < nudPassLength.Value; i++)
            {
                int NumberElements = rnd.Next(0, clbPassword.CheckedItems.Count);
                string NameElements = clbPassword.CheckedItems[NumberElements].ToString();
                switch (NameElements)
                {
                    case "Numbers": password+= rnd.Next(10).ToString();
                        break;
                    case "Uppercase": password += Convert.ToChar(rnd.Next(65,88));
                        break;
                    case "lower case":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += special_chars[rnd.Next(special_chars.Length)];
                        break;
                }

                tbPassword.Text = password;

                Clipboard.SetText(password);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double metricaFrom = metrica[cbFrom.Text];
            double metricaTo = metrica[cbTo.Text];
            double numberConvdert = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (numberConvdert * metricaFrom / metricaTo).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string tampVariable =cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = tampVariable;
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "Length":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);

                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");

                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");

                    cbFrom.Text = "mm";
                    cbTo.Text = "m";

                    break;

                case "Weight":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);

                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("t");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("oz");

                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");

                    cbFrom.Text = "g";
                    cbTo.Text = "kg";

                    break;

                default:
                    break;
            }
        }
    }
}