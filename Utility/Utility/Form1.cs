namespace Utility
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        char[] special_chars = new char[] {'%','*',')','?', '#','$', '^', '&', '~'};

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
    }
}