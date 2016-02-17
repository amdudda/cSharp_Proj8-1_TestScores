using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj8_1_TestScores
{
    public partial class frmScoreCalculator : Form
    {
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        // class variable to store scores
        List<int> allScores = new List<int>();
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidInt(txtScore.Text))
            {
                updateScores();
                updateMinMax();
            }
            else
            {
                MessageBox.Show(
                    "Score must be between 0 and 100, inclusive.",
                    "Invalid Input"
                    );
                txtScore.Focus();
            }
        }

        private void updateMinMax()
        {
            // get highest and lowest scores
            int min, max;
            min = allScores.Min();
            max = allScores.Max();

            // and update the form
            lblMinMax.Text = "Current low score is: " + min + "\nCurrent high score is: " + max;
        }

        private void updateScores()
        {
            // fetch the new score and add it to the list of scores
            int newScore = int.Parse(txtScore.Text);
            allScores.Add(newScore);

            // variables to hold results
            int totalOfScores = 0;
            int countOfScores = allScores.Count();
            decimal averageScore = 0m;

            // TODO - validation that int is >=0 and <= 100

            foreach (int s in allScores)
            {
                // addup all the scores
                totalOfScores += s;
            }

            //then get the average score
            averageScore = totalOfScores / countOfScores;

            // then update the form
            txtScoreTotal.Text = totalOfScores.ToString();
            txtScoreCount.Text = countOfScores.ToString();
            txtAverage.Text = averageScore.ToString("n0");
            // don't forget to clear the input box so that we reduce data entry errors
            txtPreviousScore.Text = txtScore.Text;  // this helps user keep track of where they are in data entry
            txtScore.Text = "";
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            // remove all scores and clear the form
            allScores.Clear();
            txtScore.Text = "";
            txtScoreTotal.Text = "";  
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            lblMinMax.Text = "";
        }

        private void btnDisplaySortedScores_Click(object sender, EventArgs e)
        {
            string output = "";
            // copy the scores to a separate array so we can leave the original data intact
            int[] sortedScores = new int[allScores.Count];
            allScores.CopyTo(sortedScores);
            Array.Sort(sortedScores);

            // loop through to concatenate a string of all scores in List.
            foreach (int s in sortedScores)
            {
                output += s + "\n";
            }
            
            // if there are no scores, let the user know that rather than showing nothing in the box.
            if (output == "") output = "No scores to display!";  

            // and show the info in a messagebox.
            MessageBox.Show(output, "Sorted Scores");
        }

        public bool IsValidInt(string toCheck)
        {
            int myint;
            if ((int.TryParse(toCheck, out myint)))
            {
                // if it's an integer, verify that it's between 0 and 100 inclusive
                return (myint >= 0 && myint <= 100);
            }
            // and if it falls through, it's not a valid input.
            return false;
        }

        private void btnDisplayUnsortedScores_Click(object sender, EventArgs e)
        {
            // concatenates allScores array and displays them in the order they were entered

            // gather the data
            string output = "";
            foreach (int s in allScores)
            {
                output += s + "\n";
            }

            // and send it to a messagebox
            MessageBox.Show(output, "Unsorted Scores");
        }

    }  // end partial class frmScoreCalculator
}
