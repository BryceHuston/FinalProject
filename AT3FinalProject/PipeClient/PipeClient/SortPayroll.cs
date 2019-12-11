using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

// Bryce Huston
// 30003673
// 10/12/2019
// Programming III
// AT3 Project

namespace PipeClient
{
    public partial class SortPayroll : Form
    {
        public SortPayroll()
        {
            InitializeComponent();
        }

        // Create a list of MAX "rand" numbers
        static int MAX = 1000;
        public bool checkSortAll;
        // Initializes rand to call upon later to generate number between 1M and 10M
        Random rand = new Random();
        int[] payRollList = new int[MAX];


        // Run the sort 10 times using the sort all method
        static int amountRun = 10;

        // Initiate Time Span variables so that time can be stored for radix
        List<TimeSpan> radixData = new List<TimeSpan>();

        // Check if the user  is regenerating data in a AmountRun loop or not
        private void BtnSortAll_Click_1(object sender, EventArgs e)
        {
            // If none of the radio boxes are check display error message
            if (!(rbRadix.Checked || rbNone.Checked))
            {
                MessageBox.Show("Please select one of the outputs", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Stopwatch sortTimer = Stopwatch.StartNew();
                //sortTimer.Reset();
                sortTimer.Start();

                checkSortAll = true;
                // Initilize progress bar
                progressBar.Value = 0;
                // Times 4 because there 4 perform steps
                progressBar.Maximum = amountRun * 2;
                progressBar.Step = 1;
                // For loop that regenerates the array to avoid duplicate data
                for (int i = 0; i < amountRun; i++)
                {
                    RegenerateArray();
                    progressBar.PerformStep();
                    SortRadix();
                    progressBar.PerformStep();
                }

                // Saves all data to one variable that is displayed in the text box
                // Data for Radix
                TimeSpan result = new TimeSpan(0);
                for (int i = 0; i < radixData.Count; i++)
                {
                    result = result.Add(radixData[i]);
                }
                lbRadix.Text = result.TotalMilliseconds.ToString() + " ms";

                checkSortAll = false;

                sortTimer.Stop();


                // Shows the total amount of time taken for the application to complete sorting
                stopWatch.Text = sortTimer.ElapsedMilliseconds.ToString() + " ms";

                // Display a message box once the array is sorted
                MessageBox.Show("Sorting Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Regenerates a new array
        private void RegenerateArray()
        {
            lstDataOutput.Items.Clear();
            lstSortedOutput.Items.Clear();
            int temp;
            for (int i = 0; i < MAX; i++)
            {
                // Random number betwwen 50 Thousand and 100 Thousand
                temp = rand.Next(50000, 100000);
                payRollList[i] = (temp);
                if (!checkSortAll)
                {
                    lstDataOutput.Items.Add(temp);
                } // End if
            } // End for
        } // End RegenerateArray


        // Button that calls upon the SortRadix method
        private void BtnRadixSort_Click_1(object sender, EventArgs e)
        {
            SortRadix();
        }


        // -------------------------------------------------------------------------------------
        // |Radix_Sort|
        // Way better than bubble sort but not as good at the built-in sort
        // Ran very fast up to about 250 thousand numbers but after that started to take a while
        // Recorded Time | Number run 10 times :
        // 1000 Numbers: 7.152 ms
        // 10000 Numbers: 66.016 ms
        // 100000 Numbers: 692.9207 ms
        // 1000000 Numbers: 7029.3489 ms
        // 10000000 Numbers: 68661.5143 ms
        // --------------------------------------------------------------------------------------

        private void SortRadix()
        {
            // The time it takes to get the array
            Stopwatch Radix = Stopwatch.StartNew();

            Radix.Start();
            RadixSort.Sort(payRollList);
            Radix.Stop();
            // If radio button is checked, display sorted data into the list box
            if (rbRadix.Checked)
            {
                lstSortedOutput.Items.Clear();
                foreach (int i in RadixSort.Sort(payRollList))
                {
                    lstSortedOutput.Items.Add(i);
                }
            }
            // Show numbers in text box and add to list
            tbRadix.Text = Radix.ElapsedMilliseconds.ToString();
            radixData.Add(Radix.Elapsed);

        }

        // Button that calls upon the Regenerate Method
        private void BtnRegenerate_Click_1(object sender, EventArgs e)
        {
            RegenerateArray();
        }
    }
}
