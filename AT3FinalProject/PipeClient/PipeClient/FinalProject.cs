using System;
using System.IO;
using System.Windows.Forms;

namespace PipeClient
{
    public partial class FinalProject : Form
    {
        public FinalProject()
        {
            InitializeComponent();
        }

        //number of Items is set to zero
        int numItems = 0;

        //3 string arrays set to 20
        string[] names = new string[20];
        string[] platforms = new string[20];
        string[] genres = new string[20];

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
                platforms[numItems] = tbAge.Text;
                genres[numItems] = tbAnnualIncome.Text;

                numItems++;
                Bubblesort(names, platforms, genres);
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
                lstOutput.Items.Add(names[i] + " " + platforms[i] + " " + genres[i]);
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
                platforms[i] = platforms[i + 1];
                genres[i] = genres[i + 1];
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
                using (BinaryWriter writer =
                    new BinaryWriter(File.Open("mygames.dat", FileMode.Create)))
                {
                    writer.Write(numItems);

                    for (int i = 0; i < numItems; i++)
                    {
                        writer.Write(names[i]);
                        writer.Write(platforms[i]);
                        writer.Write(genres[i]);
                    }
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
                        BinaryReader(File.Open("mygames.dat", FileMode.Open)))
                    {
                        numItems = reader.ReadInt32();

                        for (int i = 0; i < numItems; i++)
                        {
                            names[i] = reader.ReadString();
                            platforms[i] = reader.ReadString();
                            genres[i] = reader.ReadString();

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
                tbAge.Text = platforms[index];
                tbAnnualIncome.Text = genres[index];
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
            platforms[index] = tbAge.Text;
            genres[index] = tbAnnualIncome.Text;

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
            tbAge.Text = platforms[index];
            tbAnnualIncome.Text = genres[index];
        }
    
    }
}
