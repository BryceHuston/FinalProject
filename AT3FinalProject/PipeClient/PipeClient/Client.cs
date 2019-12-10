using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

// Bryce Huston
// 30003673
// 5/11/2019
// Programming III
// AT 2.4

namespace PipeClient
{
    public partial class Client : Form
    {
        private PipeClient pipeClient;
        public Client()
        {
            InitializeComponent();
            CreateNewPipeClient();
            AttemptConnection();
        }

        // https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/

        // Create hash 
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        // Attemps to connect to pipe server
        public void AttemptConnection()
        {
            pipeClient.Connect("\\\\.\\pipe\\30003673");

            if (pipeClient.Connected)
                btnConnect.Enabled = false;
            else
            {
                if (MessageBox.Show("Connection to server failed, would you like to retry?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AttemptConnection();
                }
                else
                {
                    this.Close();
                }
            }
        }


        // Creates a new pipe server
        void CreateNewPipeClient()
        {
            if (pipeClient != null)
            {
                pipeClient.MessageReceived -= pipeClient_MessageReceived;
                pipeClient.ServerDisconnected -= pipeClient_ServerDisconnected;
            }

            pipeClient = new PipeClient();
            pipeClient.MessageReceived += pipeClient_MessageReceived;
            pipeClient.ServerDisconnected += pipeClient_ServerDisconnected;
        }


        // Method to disconnect from pipe server
        void pipeClient_ServerDisconnected()
        {
            Invoke(new PipeClient.ServerDisconnectedHandler(EnableConnectButton));
        }

        // Allows for a connection via button
        void EnableConnectButton()
        {
            btnConnect.Enabled = true;
        }

        // Method for message recieved
        void pipeClient_MessageReceived(byte[] message)
        {
            Invoke(new PipeClient.MessageReceivedHandler(DisplayReceivedMessage),
                new object[] { message });
        }

        // Checks the response then displays it
        void DisplayReceivedMessage(byte[] message)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            string str = encoder.GetString(message, 0, message.Length);

            if (str == "Accepted")
            {
                MessageBox.Show("Connection Worked.");
            }
            else
            {
                pipeClient.Disconnect();
                MessageBox.Show("Connection failed. Please force disconnect then reconnect");
            }

            tbRecieved.Text += str + "\r\n";
        }

        // Button to connect to pipe server
        private void btnConnect_Click(object sender, EventArgs e)
        {
            pipeClient.Connect("\\\\.\\pipe\\30003673");

            if (pipeClient.Connected)
                btnConnect.Enabled = false;
        }

        // Button that disconnects from pipe server
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            pipeClient.Disconnect();
            EnableConnectButton();
        }


        // Button to generate hash string then send it 
        private void btnSend_Click(object sender, EventArgs e)
        {

            if ((tbUser.Text == "admin") && (tbPass.Text == "admin"))
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                pipeClient.SendMessage(encoder.GetBytes(ComputeSha256Hash(tbUser.Text + "," + tbPass.Text)));
                this.Hide();
                Main m = new Main();
                m.ShowDialog();
            }

            else
            {
                MessageBox.Show("Error.  Incorrect Username or Password.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }


        // Button to clear list box
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbRecieved.Clear();
        }


    }
}
