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
            timer1.Start();
            MakeMusic();
        }

        void MakeMusic()
        {
            int RandomNamber = rnd.Next(0, Victorina.listWithMusic.Count);
            wmplayer.URL = Victorina.listWithMusic[RandomNamber];
            wmplayer.Ctlcontrols.play(); //if not autoplay 
            Victorina.listWithMusic.RemoveAt(RandomNamber);
            lblCountTrack.Text = Victorina.listWithMusic.Count.ToString();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            wmplayer.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblCountTrack.Text = Victorina.listWithMusic.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.GameDuration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            wmplayer.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            wmplayer.Ctlcontrols.play();
        }
    }
}
