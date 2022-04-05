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
    public partial class fGame : Form
    {
        Random rnd = new Random();
        public fGame()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        void MakeMusic()
        {
            int RandomNamber = rnd.Next(0, Victorina.listWithMusic.Count);
            wmplayer.URL = Victorina.listWithMusic[RandomNamber];
            wmplayer.Ctlcontrols.play(); //if not autoplay 
            Victorina.listWithMusic.RemoveAt(RandomNamber);
        }
    }
}
