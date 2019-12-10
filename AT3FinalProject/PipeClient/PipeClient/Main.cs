using System;
using System.Windows.Forms;

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

        private void Button1_Click(object sender, EventArgs e)
        {
            FormBST searchTree = new FormBST();
            searchTree.Show();
        }

        private void BtnProgressBar_Click(object sender, EventArgs e)
        {
            ProgressBar bar = new ProgressBar();
            bar.Show();
        }

        private void BtnCSV_Click(object sender, EventArgs e)
        {
            CSVFormat csv = new CSVFormat();
            csv.Show();
        }

        private void BtnFinalProject_Click(object sender, EventArgs e)
        {
            FinalProject finalProject = new FinalProject();
            finalProject.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
