using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessTheMelodyNET_Framework
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int MusicDuration = Victorina.MusicDuration;
        bool[] players = new bool[2];

        public fGame()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            wmplayer.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            MusicDuration = Victorina.MusicDuration;    
            lblMusicDuration.Text = MusicDuration.ToString();
            lblCountTrack.Text = Victorina.listWithMusic.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.GameDuration;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            MusicDuration--;
            lblMusicDuration.Text = MusicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                GameOver();
                return;
            }
            if(MusicDuration == 0) MakeMusic();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if(players[0] == false && e.KeyData == Keys.A)
            {
                GamePause();
                fMessag messege = new fMessag();
                messege.lblNamePlayer.Text = "Player 1";
                SoundPlayer soundone = new SoundPlayer("Resources\\Sound_Player_1.wav");
                soundone.PlaySync();
                players[0] = true;
                if (messege.ShowDialog() == DialogResult.Yes)
                {
                    lbPointsOne.Text = Convert.ToString((Convert.ToInt32(lbPointsOne.Text)) + 1);
                    MakeMusic();
                }
                else if (Convert.ToInt32(lbPointsOne.Text) > 0)
                {
                    lbPointsOne.Text = Convert.ToString((Convert.ToInt32(lbPointsOne.Text)) - 1);
                    MakeMusic();
                }
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                GamePlay();
            }

            if (players[1] == false && e.KeyData == Keys.P)
            {
                GamePause();
                fMessag messege = new fMessag();
                messege.lblNamePlayer.Text = "Player 2";
                SoundPlayer soundtwo = new SoundPlayer("Resources\\Sound_Player_2.wav");
                soundtwo.PlaySync();
                players[1] = true;
                if (messege.ShowDialog() == DialogResult.Yes)
                {
                    lbPointsTwo.Text = Convert.ToString((Convert.ToInt32(lbPointsTwo.Text)) + 1);
                    MakeMusic();
                }
                else if (Convert.ToInt32(lbPointsTwo.Text) > 0)
                {
                    lbPointsTwo.Text = Convert.ToString((Convert.ToInt32(lbPointsTwo.Text)) - 1);
                    MakeMusic();
                }
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                GamePlay();
            }
        }
        private void GamePause()
        {
            timer1.Stop();
            wmplayer.Ctlcontrols.pause();
        }
        private void GamePlay()
        {
            timer1.Start();
            wmplayer.Ctlcontrols.play();
        }
        private void GameOver()
        {
            timer1.Stop();
            wmplayer.Ctlcontrols.stop();
        }
        private void MakeMusic()
        {
            if(Victorina.listWithMusic.Count == 0) GameOver();
            else
            {
                MusicDuration = Victorina.MusicDuration;
                int RandomNamber = rnd.Next(0, Victorina.listWithMusic.Count);
                wmplayer.URL = Victorina.listWithMusic[RandomNamber];
                //Victorina.answer = System.IO.Path.GetFileNameWithoutExtension(wmplayer.URL); 
                Victorina.answer = wmplayer.URL;
                wmplayer.Ctlcontrols.play(); //if not autoplay 
                Victorina.listWithMusic.RemoveAt(RandomNamber);
                lblCountTrack.Text = Victorina.listWithMusic.Count.ToString();

                players[0] = false;
                players[1] = false;
            }
        }

        private void wmplayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (wmplayer.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    wmplayer.Ctlcontrols.currentPosition = rnd.Next(0, (int)wmplayer.currentMedia.duration / 2);
        }

        private void lbPointsOne_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left ) (sender as Label).Text = 
                    Convert.ToString((Convert.ToInt32((sender as Label).Text)) + 1);
            
            if (e.Button == MouseButtons.Right && (Convert.ToInt32((sender as Label).Text) > 0))
                (sender as Label).Text = Convert.ToString((Convert.ToInt32((sender as Label).Text)) - 1);
        }
    }
}
