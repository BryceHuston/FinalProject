using System;
using System.Windows.Forms;

namespace PipeClient
{
    public partial class FormBST : Form
    {
        public FormBST()
        {
            InitializeComponent();
            // Create 10 names using a string array.  It then adds it to a tree object (strTree) and the trace string
            string[] list = new string[] { "Stewart", "Bryce", "Chrissy", "Tom", "Tim", "Cathy", "George", "Chris", "Keryn", "Richard" };
            // For loop that will loop throught the 10 names and insert into the list
            for (int i = 0; i < 10; i++)
            {
                strTree.Insert(list[i]);
                trace += list[i] + " ";
            }
        }

        // Declaration of  strTree
        BinarySearchTree<string> strTree = new BinarySearchTree<string>();
        // Random Method for initial array data
        Random rand = new Random(DateTime.Now.Millisecond);
        // Trace string to collect input sequence
        string trace = " ";


        // Method to clear all text boxs once a button is clicked and to clear status strip
        public void Clear()
        {
            tbFindMax.Clear();
            tbFindMin.Clear();
            tbInsert.Clear();
            tbRemove.Clear();
            tbSearch.Clear();
        }

        //Button to insert data from tbInsert into the strTree
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            stsDisplay.Items.Clear();
            //if textbox isn't empty
            if (!String.IsNullOrWhiteSpace(tbInsert.Text))
            {
                strTree.Insert(tbInsert.Text);
                // Display string at the bottme left of form (Status Strip)
                stsDisplay.Items.Add("Inserted: " + tbInsert.Text);
            }
            else
            {
                stsDisplay.Items.Add("Error: Please enter a name");
            }
            Clear();
        }


        // Find the first letter in the alphabet from all the names in or added to the list and diplay in the text box to the right
        private void BtnFindMin_Click(object sender, EventArgs e)
        {
            Clear();
            stsDisplay.Items.Clear();
            // Text box is Read Only
            tbFindMin.Text = strTree.FindMin().ToString();
        }

        // Find the last letter in the alphabet from all the names in or added to the list and diplay in the text box to the right
        private void BtnFindMax_Click(object sender, EventArgs e)
        {
            Clear();
            stsDisplay.Items.Clear();
            // Text box is Read Only
            tbFindMax.Text = strTree.FindMax().ToString();
        }

        // Type in a name in the text box to the right of the "Search" button and if its in the tree object part of the list it will display in the status strip
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            stsDisplay.Items.Clear();
            // If name is in textbox is equal to name in the strTree
            if (strTree.Find(tbSearch.Text) == tbSearch.Text)
            {
                stsDisplay.Items.Add("Name: Found");
            }
            else
            {
                stsDisplay.Items.Add("Name: Not Found");
            }
            Clear();
        }

        // Type in a name in the text box and click the remove button.  This will delete the data from the binary tree
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                stsDisplay.Items.Clear();
                // If there is data in the text box
                if (!String.IsNullOrWhiteSpace(tbRemove.Text))
                {
                    strTree.Remove(tbRemove.Text);
                    stsDisplay.Items.Add("Removed: " + tbRemove.Text);
                }
                // else display error message that text box is blank or name does not exist
                else
                {
                    stsDisplay.Items.Add("Error: Text box is blank or name does not exist");
                }
                Clear();
            }
            catch
            {
                stsDisplay.Items.Add("Error: Text box is blank or name does not exist");
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Clear();
            stsDisplay.Items.Clear();
            lstOutput.Items.Add(strTree.ToString());
        }
    }
}
