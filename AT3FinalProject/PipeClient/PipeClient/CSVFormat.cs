using LumenWorks.Framework.IO.Csv;
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


namespace PipeClient
{
    public partial class CSVFormat : Form
    {
        public CSVFormat()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            // Clear list box incase there is previous data
            lstShowFiles.Items.Clear();

            try
            {
                // Using the file that browse from the openfiledialog in the textbox which is a CSV file with headers
                using (CsvReader csv = new CsvReader(new StreamReader(tbBrowseFile.Text), true))
                {
                    // Declare a variable that get the maximum number of fields to retrieve each record
                    int fieldCount = csv.FieldCount;

                    // Get the field header and insert into array
                    string[] headers = csv.GetFieldHeaders();
                    while (csv.ReadNextRecord())
                    {
                        for (int i = 0; i < fieldCount; i++)
                        {
                            // Display every headers and records into the list box
                            lstShowFiles.Items.Add(string.Format("{0} = {1};", headers[i], csv[i]));
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            // Creeat a new instance of a OpenFileDialog Class
            OpenFileDialog ofd = new OpenFileDialog();

            // Launch new File Dialog to select a directory
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Determine the variable value as the browsed file name
                string filepath = ofd.FileName;

                // Text box property represents the files that browsed from the openfiledialog
                tbBrowseFile.Text = filepath;
            }
        }
    }
}
