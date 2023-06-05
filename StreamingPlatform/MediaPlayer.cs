using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace StreamingPlatform
{
    public partial class MediaPlayer : UserControl
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }
        bool play = true;
        string videoPath;

        private void PlaypauseBtn_Click(object sender, EventArgs e)
        {
            if (play)
            {
                VideoPlayer.Ctlcontrols.pause();
                PlaypauseBtn.Image = imageList1.Images[1];
                play = false;
            }
            else { 
                VideoPlayer.Ctlcontrols.play();
                PlaypauseBtn.Image = imageList1.Images[0];
                play = true;
            }
        }

        private void MuteBtn_Click(object sender, EventArgs e)
        {
            if (VideoPlayer.settings.mute == true) {
                VideoPlayer.settings.mute = false;
                MuteBtn.Image = imageList1.Images[3];
            }
            else {
                VideoPlayer.settings.mute = true;
                MuteBtn.Image = imageList1.Images[2];
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            MuteBtn.Image = imageList1.Images[3];
            VideoPlayer.settings.volume = VolumeBar.Value;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            VideoPlayer.Ctlcontrols.stop();
            PlaypauseBtn.Image = imageList1.Images[0];
            play = true;
            ShowTrailer.Show();
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
             VolumeBar.Value = VideoPlayer.settings.volume;
            VideoPlayer.uiMode = "None";
        }

        private void FullscreenBtn_Click(object sender, EventArgs e)
        {
            VideoPlayer.uiMode = "full";
            VideoPlayer.fullScreen = true;
        }

        private void VideoPlayer_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if (VideoPlayer.fullScreen == false) VideoPlayer.uiMode = "None";
        }

        private void ShowTrailer_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.avi;*.mp4;*.mov;*.mkv;*.flv;*.wmv|All Files|*.*";
                openFileDialog.Title = "Select a Video File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream fileStream = openFileDialog.OpenFile())
                    {
                        videoPath = ((FileStream)fileStream).Name;
                        VideoPlayer.URL = videoPath;
                    }
                }
            }
            ShowTrailer.Hide();
        }
    }
}
