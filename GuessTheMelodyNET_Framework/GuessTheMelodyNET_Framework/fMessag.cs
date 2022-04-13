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
    public partial class fMessag : Form
    {
        int timeForAnswer;

        public fMessag()
        {
            InitializeComponent();
        }
        private void fMessag_Load(object sender, EventArgs e)
        {
            timeForAnswer = 15;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeForAnswer--;
            lblTimeForAnswer.Text = timeForAnswer.ToString();
            if(timeForAnswer == 0)
            {
                timer1.Stop();
                SoundPlayer sound = new SoundPlayer("Resources\\Sound.wav");
                sound.Play();
                this.Close();
                fGame point = new fGame();
                if (lblNamePlayer.Text == "Player 1")
                { 
                    if (Convert.ToInt32(point.lbPointsOne.Text) > 0)
                    {
                        point.lbPointsOne.Text = Convert.ToString((Convert.ToInt32(point.lbPointsOne.Text)) - 1);
                    }
                }
                else
                {
                    if (Convert.ToInt32(point.lbPointsTwo.Text) > 0)
                    {
                        point.lbPointsTwo.Text = Convert.ToString((Convert.ToInt32(point.lbPointsTwo.Text)) - 1);
                    }
                }
            }
        }

        private void fMessag_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void lblShowAnswer_Click(object sender, EventArgs e)
        {
            var mp3file = TagLib.File.Create(Victorina.answer);
            lblShowAnswer.Text = mp3file.Tag.FirstAlbumArtist + " " + mp3file.Tag.Title;
        }
    }
}
