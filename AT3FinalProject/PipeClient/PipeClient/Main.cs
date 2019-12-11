using System;
using System.Windows.Forms;

// Bryce Huston
// 30003673
// 10/12/2019
// Programming III
// AT3 Project

namespace PipeClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnSortForm_Click(object sender, EventArgs e)
        {
            SortPayroll payroll = new SortPayroll();
            payroll.Show();
        }

        private void BtnAudioPlayer_Click(object sender, EventArgs e)
        {
            AudioPlayer audio = new AudioPlayer();
            audio.Show();
        }



        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void BtnCSVFormat_Click(object sender, EventArgs e)
        {
            CSVFormat finalProject = new CSVFormat();
            finalProject.Show();
        }

        private void BtnBST_Click(object sender, EventArgs e)
        {
            FormBST searchTree = new FormBST();
            searchTree.Show();
        }
    }
}
