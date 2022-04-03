using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheMelodyNET_Framework
{
    public partial class fMain : Form
    {
        fParameters fParameters = new fParameters();
        fGame fGame = new fGame();  

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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fGame.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadParametrs();
            Victorina.ReadMusic();
        }
    }
}
