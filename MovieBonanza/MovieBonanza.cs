/* Program:             Movie Bonanza
 * Programmer:          Mitchell Tracy
 * Date:                November 2013
 * Form Description:    This form allows the user select a movie and see the category price and title along with the picture */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class MovieBonanza : Form
    {
        public MovieBonanza()
        {
            InitializeComponent();

            string movieSelectedArray[];
           // movieSelectedArray[] = new moieselectedarray[3];

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MoviescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the about form.

            // Create a new instance of the AboutBox1 form class
            AboutBox aboutForm = new AboutBox();
            //show the new aboutForm object.
            aboutForm.ShowDialog();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int movieSelected;

            //MovieListBox.SelectedIndexChanged = movieSelected;

            if (movieSelected == 0)
            {
                TitleTextBox.Text = "Cedar Rapids"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost here
                movieSelectedArray[0] = TitleTextBox.Text;
                MessageBox.Show(movieSelectedArray[0]);
                movieSelectedArray[1] = PriceTextBox.Text;


            }
            else if(movieSelected ==1)
            {
                TitleTextBox.Text = ""; //^^
            }
            //else if()         ....etc etc each number is equal to one of the spots on the list.
                

        }

    }
}
