using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessTheMelodyNET_Framework
{
    public partial class fParameters : Form
    {
        public fParameters()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Victorina.WriteParametrs();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] MusicList = Directory.GetFiles(dialog.SelectedPath, "*.mp3",
                    cbSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                lbListMusik.Items.Clear();
                lbListMusik.Items.AddRange(MusicList);
                Victorina.listWithMusic.Clear();
                Victorina.listWithMusic.AddRange(MusicList);
            }
        }
    }
}
