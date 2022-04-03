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
            Victorina.allDirectories = cbSubfolders.Checked;
            Victorina.GameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.MusicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;
            Victorina.WriteParametrs();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetParametrs();
            this.Close();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] MusicList = Directory.GetFiles(dialog.SelectedPath, "*.mp3",
                    cbSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = dialog.SelectedPath;
                lbListMusik.Items.Clear();
                lbListMusik.Items.AddRange(MusicList);
                Victorina.listWithMusic.Clear();
                Victorina.listWithMusic.AddRange(MusicList);
            }
        }

        private void fParameters_Load(object sender, EventArgs e)
        {
            SetParametrs();
            lbListMusik.Items.Clear();
            lbListMusik.Items.AddRange(Victorina.listWithMusic.ToArray());
        }

        void SetParametrs()
        {
            cbSubfolders.Checked = Victorina.allDirectories;
            cbGameDuration.Text = Victorina.GameDuration.ToString();
            cbMusicDuration.Text = Victorina.MusicDuration.ToString();
            cbRandomStart.Checked = Victorina.randomStart;
        }
    }
}
