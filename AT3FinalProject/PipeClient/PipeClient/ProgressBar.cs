using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PipeClient
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy != true)
            {
                // Start the asynchronous operation
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation
                backgroundWorker.CancelAsync();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 100; i++)
            {
                // If Cancel button is pressed then stop proccess
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                // Else keep running
                else
                {
                    // Perform a time consuming operation and report progress
                    System.Threading.Thread.Sleep(100);
                    worker.ReportProgress(i);
                }
            }
        }

        // Event handler that updates the progress
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbResult.Text = (e.ProgressPercentage.ToString() + " %");
        }

        // Event handler that deals with the results of the background operation
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                lbResult.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                lbResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
                lbResult.Text = "Done!";
            }
        }

        private void ProgressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                backgroundWorker.CancelAsync();
                lbResult.Text = "Canceled!";
                MessageBox.Show("Program Stopped");
            }
        }
    }
}
