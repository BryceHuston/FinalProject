using System;
using System.Text;
using System.Windows.Forms;

// Bryce Huston
// 30003673
// 5/11/2019
// Programming III
// AT 2.4

namespace PipeServer
{
    public partial class Server : Form
    {
        private PipeServer pipeServer = new PipeServer();

        public Server()
        {
            InitializeComponent();

            // Makes every messaged recieved the old on along with the new one
            pipeServer.MessageReceived += pipeServer_MessageReceived;
            pipeServer.ClientDisconnected += pipeServer_ClientDisconnected;

            // Start the pipe server if not running already
            if (!pipeServer.Running)
            {
                pipeServer.Start("\\\\.\\pipe\\30003673");
                btnConnect.Enabled = false;
            }
            else
                MessageBox.Show("Server running already");
        }

        // Methods that disconnect from server
        void pipeServer_ClientDisconnected()
        {
            Invoke(new PipeServer.ClientDisconnectedHandler(ClientDisconnected));
        }

        // Method that disconnects from client
        void ClientDisconnected()
        {
            MessageBox.Show("Total connected clients: " + pipeServer.TotalConnectedClients);
        }


        // Method that receives message
        void pipeServer_MessageReceived(byte[] message)
        {
            Invoke(new PipeServer.MessageReceivedHandler(DisplayMessageReceived),
                new object[] { message });
        }

        // Methods that show recieved messages
        void DisplayMessageReceived(byte[] message)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();

            string str = encoder.GetString(message, 0, message.Length);

            // If the plain string or hash string is admin, admin then accept the conection
            tbReceived.Text += str + "\r\n";
            if (str.Equals("admin,admin") || str.Equals("d6234daf47d9a155cdf5fa8149928219dcfc442648b8007323c3675472ea4616"))
            {
                byte[] messageBuffer = encoder.GetBytes("Accepted");

                pipeServer.SendMessage(messageBuffer);

                
            }
            else
            {
                byte[] messageBuffer = encoder.GetBytes("Not Accepted");

                pipeServer.SendMessage(messageBuffer);
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Start the pipe server if it's not already running
            if (!pipeServer.Running)
            {
                pipeServer.Start("\\\\.\\pipe\\30003673");
                btnConnect.Enabled = false;
            }
            else
                MessageBox.Show("Server running already.");
        }

        // Button that sends hash to client
        private void btnSend_Click(object sender, EventArgs e)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] messageBuffer = encoder.GetBytes(tbSend.Text);

            pipeServer.SendMessage(messageBuffer);
        }

        // Button that clears list box
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReceived.Clear();
        }
    }
}
