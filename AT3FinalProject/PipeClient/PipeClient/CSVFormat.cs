using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Windows.Forms;

// Bryce Huston
// 30003673
// 10/12/2019
// Programming III
// AT3 Project

namespace PipeClient
{
    public partial class CSVFormat : Form
    {
        public CSVFormat()
        {
            InitializeComponent();
        }

        //number of Items is set to zero
        int numItems = 0;

        //3 string arrays set to 20
        string[] names = new string[20];
        string[] age = new string[20];
        string[] annualIncome = new string[20];

        //Adds input from text boxs to the array and then displays it on the list box
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //if text box is empty display error message
            if (String.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter First and Last Name", "Error", MessageBoxButtons.OK);
            }
            //if it exceeds 20 arrays
            else if (numItems > 20)
            {
                MessageBox.Show("You have exceeded the amount of entrys available", "Error", MessageBoxButtons.OKCancel);
            }
            //else display input 
            else
            {
                names[numItems] = tbName.Text;
                age[numItems] = tbAge.Text;
                annualIncome[numItems] = tbAnnualIncome.Text;


                numItems++;
                Bubblesort(names, age, annualIncome);
                DisplayGames();
                Clear();
            }
        }

        //Method for displaying the 3 arrays in the list box (lstOutput)
        private void DisplayGames()
        {
            lstOutput.Items.Clear();

            for (int i = 0; i < numItems; i++)
            {
                lstOutput.Items.Add(names[i] + " " + age[i] + " " + annualIncome[i]);
            }
        }

        //Method for clearing all text boxs
        private void Clear()
        {
            tbName.Clear();
            tbAge.Clear();
            tbAnnualIncome.Clear();

        }

        //Method for deleting items in the list box
        private void DeleteAt(string[] names, int index)
        {

            for (int i = index; i < numItems - 1; i++)
            {
                names[i] = names[i + 1];
                age[i] = age[i + 1];
                annualIncome[i] = annualIncome[i + 1];
            }
            numItems--;

        }

        //Delete button that calls upon the DeleteAt method
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = lstOutput.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Select an item", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DeleteAt(names, index);

                DisplayGames();
                Clear();
            }
        }

        //Clears all text boxs
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Save button which save data onto a .dat file which we can open later
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var records = new LinkedList<dynamic>();

                // Makes a record
                dynamic record = new ExpandoObject();

                // Adds each row one at a time
                for (int i = 0; i < numItems; i++)
                {
                    record.Name = names[i];
                    record.Age = age[i];
                    record.AnnualIncome = annualIncome[i];

                    records.AddLast(record);
                }

                using (var writer = new StreamWriter("Employees.csv"))
                using (var csv = new CsvWriter(writer))
                {
                    // Writes all data to the csv file assigned above
                    csv.WriteRecords(records);

                    // Confirm saving occured
                    MessageBox.Show("Data was written!");
                }

            }
            catch (IOException x)
            {
                MessageBox.Show("Exception: " + x.Message);
            }
        }

        //Open button which opens data that was saved as a .dat file
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (File.Exists("mygames.dat"))
            {
                try
                {
                    using (BinaryReader reader = new
                        BinaryReader(File.Open("myEmployees.dat", FileMode.Open)))
                    {
                        numItems = reader.ReadInt32();

                        for (int i = 0; i < numItems; i++)
                        {
                            names[i] = reader.ReadString();
                            age[i] = reader.ReadString();
                            annualIncome[i] = reader.ReadString();

                            DisplayGames();
                        }

                    }
                }
                catch (IOException x)
                {
                    MessageBox.Show("Exception: " + x.Message);
                }
            }
            else
            {
                MessageBox.Show("Saved file does not exist", "Error", MessageBoxButtons.OK);
                return;
            }
        }

        //Sorting algorithm which sorts the input in the list box into alphabetical order
        private void Bubblesort(string[] names, string[] platforms, string[] genres)
        {
            //Bubble sort Algorithm
            for (int outer = numItems - 1; outer > 0; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                { ///              . mod there (use a string instead)
                    if (names[inner].CompareTo(names[inner + 1]) > 0)
                    {
                        string tmpnames = names[inner + 1];
                        names[inner + 1] = names[inner];
                        names[inner] = tmpnames;

                        string tmpplatforms = platforms[inner + 1];
                        platforms[inner + 1] = platforms[inner];
                        platforms[inner] = tmpplatforms;

                        string tmpgenres = genres[inner + 1];
                        genres[inner + 1] = genres[inner];
                        genres[inner] = tmpgenres;
                    }

                }
            }
        }

        //Search method that is called with the Search button is clicked
        private int BinarySearch(string[] names, string search)
        {
            //Binary Search Algorithm
            int lowerBound = 0;
            int upperBound = numItems - 1;
            int i;

            while (true)
            {
                i = (lowerBound + upperBound) / 2;
                if (names[i] == search)
                {
                    return i; //found it
                }
                else if (lowerBound > upperBound)
                {
                    return -1; //Can't find it
                }
                else
                {
                    if (names[i].CompareTo(search) < 0)
                    {
                        lowerBound = i + 1;
                    }
                    else
                    {
                        upperBound = i - 1;
                    }
                }
            }
        }

        //Search's items in list box also calling on the Binary Search method
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = tbName.Text;
            int index = BinarySearch(names, search);

            if (index != -1)
            {
                lstOutput.SelectedIndex = index;
                tbName.Text = names[index];
                tbAge.Text = age[index];
                tbAnnualIncome.Text = annualIncome[index];
            }
            else
            {
                MessageBox.Show("Item not found");
            }
        }

        //Clears everything in the list box, but does not delete from the array
        private void BtnReset_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        //Changes selected input in list box to desired entry
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstOutput.SelectedIndex;

            names[index] = tbName.Text;
            age[index] = tbAge.Text;
            annualIncome[index] = tbAnnualIncome.Text;

            DisplayGames();
        }

        private void LstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstOutput.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Please select item");
                return;
            }
            // Select item from Output box
            tbName.Text = names[index];
            tbAge.Text = age[index];
            tbAnnualIncome.Text = annualIncome[index];
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            RefreshData();
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

        private void RefreshData()
        {
            // Create a datatable as we know what data is coming in
            DataTable dt = new DataTable();
            int firstTimeChecker = 0;
            // Open the CSV and start reading
            using (TextReader fileReader = File.OpenText("Employees.csv"))
            {
                // Load in all the data from the .csv file
                var csv = new CsvHelper.CsvReader(fileReader);
                // Set the top row to the column title
                dt.Columns.Add("Name");
                dt.Columns.Add("Age");
                dt.Columns.Add("Annual Income");

                string[] readArray = new string[20];

                while (csv.Read())
                {
                    // If this is the first time everything is being reloaded
                    if (firstTimeChecker < 1)
                    {
                        // Skip and increment the checker by 1 to avoid it being read
                        firstTimeChecker++;
                        // Skip the rest of the code and start adding data
                        continue;
                    }
                    // Reads the data then adds it in as a row
                    //MessageBox.Show(csv.GetField(0) + csv.GetField(1) + csv.GetField(2));
                    readArray[firstTimeChecker - 1] = csv.GetField(0) + " " + csv.GetField(1) + " " + csv.GetField(2);
                    lstShowFiles.Items.Add(readArray[firstTimeChecker - 1]);
                    firstTimeChecker++;

                }
            }

        }
    }
}
