using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PipeClient
{
    public partial class AudioPlayer : Form
    {
        public AudioPlayer()
        {
            InitializeComponent();
        }

        //Static string[] FilePath = { "song1.mp3, "song2.mp3, song3.mp3
        LinkedList<string> MySong = new LinkedList<string>();

        //This button will open up file explorer in order for you to select at soundtrack to add to the lstSongOutput box
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                string newsong = filepath.ToString();
                MySong.AddLast(newsong);
            }
            DisplaySongList();
        }

        //Method display all songs in linked list
        private void DisplaySongList()
        {
            //Remove path 
            lstSongOutput.Items.Clear();

            foreach (var newsong in MySong)
            {
                lstSongOutput.Items.Add(newsong);
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                PlaySong(MySong.First.Value);
            }
            //If there is no song playing an error box message with pop up
            catch
            {
                MessageBox.Show("Error", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            try
            {

                PlaySong(MySong.Last.Value);
            }
            //If there is no song playing an error box message with pop up
            catch
            {
                MessageBox.Show("Error", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //This button will create a variable as currentsong to the current song being played find the next value and play it from the PlaySong method
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                string currentSong = axWindowsMediaPlayer1.URL;
                string previousSong = MySong.Find(currentSong).Previous.Value;
                PlaySong(previousSong);
            }
            //If there is no song playing an error box message with pop up
            catch
            {
                MessageBox.Show("Error", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Method that plays the song with the media player
        public void PlaySong(string path)
        {
            axWindowsMediaPlayer1.URL = path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //This button will open file explorer and let you click the song that you want to remove
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstSongOutput.SelectedIndex != -1)
                {
                    string removesong = lstSongOutput.GetItemText(lstSongOutput.SelectedItem);
                    MySong.Remove(removesong);
                    DisplaySongList();
                }
            }
            //If there is no song playing an error box message with pop up
            catch
            {
                MessageBox.Show("Error", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
