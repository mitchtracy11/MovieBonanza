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
        // Declare Form information     
        public OrderForm nextForm = new OrderForm();
       
       

        // declare accessor methods
        string[] movies = new string[3];

        public MovieBonanza()
        {
          
            InitializeComponent();
        string[] movies = new string[3];

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


            int movieSelected = MovieListBox.SelectedIndex;

            if (movieSelected == 0)
            {


                //  movies[0] = TitleTextBox.Text;
               //   movies[0] = PriceTextBox.Text;
               //   movies[0] = CategoryTextBox.Text;
                  
                TitleTextBox.Text = "Cedar Rapids"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Comedy";
                pictureBox1.Image = Properties.Resources.cedarrapids;// set picture


            }
            else if (movieSelected == 1)
            {
               // movies[1] = TitleTextBox.Text;
               // movies[1] = PriceTextBox.Text;
               // movies[1] = CategoryTextBox.Text;
                TitleTextBox.Text = "Company Of Man"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Drama";
                pictureBox1.Image = Properties.Resources.companymen;// set picture
            }
            else if (movieSelected == 2)
            {
                //movies[2] = TitleTextBox.Text;
               // movies[2] = PriceTextBox.Text;
               // movies[2] = CategoryTextBox.Text;
                TitleTextBox.Text = "Death Race 2"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.deathrace2;// set picture
            }
            else if (movieSelected == 3)
            {
                //movies[3] = TitleTextBox.Text;
               // movies[3] = PriceTextBox.Text;
               // movies[3] = CategoryTextBox.Text;
                TitleTextBox.Text = "Footloose"; //put movie title in string
                PriceTextBox.Text = "4.99"; //put cost 
                CategoryTextBox.Text = "New Release";
                pictureBox1.Image = Properties.Resources.footloose;// set picture
            }
            else if (movieSelected == 4)
            {
             //   movies[4] = TitleTextBox.Text;
             //   movies[4] = PriceTextBox.Text;
             //   movies[4] = CategoryTextBox.Text;
                TitleTextBox.Text = "Gnomeo And Juliet"; //put movie title in string
                PriceTextBox.Text = "0.99"; //put cost 
                CategoryTextBox.Text = "Family";
                pictureBox1.Image = Properties.Resources.gnomeoandjuliet;// set picture

            }
            else if (movieSelected == 5)
            {
                //movies[5] = TitleTextBox.Text;
               // movies[5] = PriceTextBox.Text;
               // movies[5] = CategoryTextBox.Text;
                TitleTextBox.Text = "I Am Number Four"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.iamnumberfour;// set picture
            }
            else if (movieSelected == 6)
            {
                //movies[6] = TitleTextBox.Text;
               // movies[6] = PriceTextBox.Text;
               // movies[6] = CategoryTextBox.Text;
                TitleTextBox.Text = "Just Go With It"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Comedy";
                pictureBox1.Image = Properties.Resources.justgowithit;// set picture
            }
            else if (movieSelected == 7)
            {
              //  movies[7] = TitleTextBox.Text;
              //  movies[7] = PriceTextBox.Text;
               // movies[7] = CategoryTextBox.Text;
                TitleTextBox.Text = "No Strings Attached"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Comedy";
                pictureBox1.Image = Properties.Resources.nostringsattached;// set picture
            }
            else if (movieSelected == 8)
            {
               // movies[8] = TitleTextBox.Text;
              //  movies[8] = PriceTextBox.Text;
             //   movies[8] = CategoryTextBox.Text;
                TitleTextBox.Text = "Real Steel"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.realsteel;// set picture
            }
            else if (movieSelected == 9)
            {
             //   movies[9] = TitleTextBox.Text;
             //   movies[9] = PriceTextBox.Text;
             //   movies[9] = CategoryTextBox.Text;
                TitleTextBox.Text = "Sanctum"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.sanctum;// set picture
            }
            else if (movieSelected == 10)
            {
               // movies[10] = TitleTextBox.Text;
               // movies[10] = PriceTextBox.Text;
              //  movies[10] = CategoryTextBox.Text;
                TitleTextBox.Text = "Season Of The Witch"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Sci-Fi";
                pictureBox1.Image = Properties.Resources.seasonofthewitch;// set picture
            }
            
            else if (movieSelected == 11)
            {
              //  movies[11] = TitleTextBox.Text;
             //   movies[11] = PriceTextBox.Text;
             //   movies[11] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Dilemma"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Comedy";
                pictureBox1.Image = Properties.Resources.thedilemma;// set picture
            }
            else if (movieSelected == 12)
            {
              //  movies[12] = TitleTextBox.Text;
             //   movies[12] = PriceTextBox.Text;
             //   movies[12] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Eagle"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.theeagle;// set picture
            }
            else if (movieSelected == 13)
            {
              //  movies[13] = TitleTextBox.Text;
              //  movies[13] = PriceTextBox.Text;
              //  movies[13] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Green Hornet"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.thegreenhornet;// set picture
            }
           else if (movieSelected == 14)
            {
               // movies[14] = TitleTextBox.Text;
              //  movies[14] = PriceTextBox.Text;
              //  movies[14] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Mechanic"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.themechanic;// set picture
            }
           else if (movieSelected == 15)
            {
              //  movies[15] = TitleTextBox.Text;
              //  movies[15] = PriceTextBox.Text;
               // movies[15] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Other Woman"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Action";
                pictureBox1.Image = Properties.Resources.theotherwoman;// set picture
            }
            else if (movieSelected == 16)
            {
              //  movies[16] = TitleTextBox.Text;
               // movies[16] = PriceTextBox.Text;
               // movies[16] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Rite"; //put movie title in string
                PriceTextBox.Text = "2.99"; //put cost 
                CategoryTextBox.Text = "Horror";
                pictureBox1.Image = Properties.Resources.therite;// set picture
            }
                        else if (movieSelected == 17)
            {
               // movies[17] = TitleTextBox.Text;
               // movies[17] = PriceTextBox.Text;
               // movies[17] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Roommate"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Thriller";
                pictureBox1.Image = Properties.Resources.theroommate;// set picture
            }
                        else if (movieSelected == 18)
            {
               // movies[18] = TitleTextBox.Text;
               // movies[18] = PriceTextBox.Text;
               // movies[18] = CategoryTextBox.Text;
                TitleTextBox.Text = "The Way Back"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Drama";
                pictureBox1.Image = Properties.Resources.thewayback;// set picture
            }

                        else if (movieSelected == 19)
            {
               // movies[19] = TitleTextBox.Text;
               // movies[19] = PriceTextBox.Text;
              //  movies[19] = CategoryTextBox.Text;
                TitleTextBox.Text = "Waiting for Forever"; //put movie title in string
                PriceTextBox.Text = "1.99"; //put cost 
                CategoryTextBox.Text = "Drama";
                pictureBox1.Image = Properties.Resources.waitingforever;// set picture
            }
        }

        private void MovieBonanza_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            nextForm.MoviePrice = PriceTextBox.Text;
            nextForm.MovieSelected = TitleTextBox.Text;
            nextForm.MovieCategory = CategoryTextBox.Text;
            

            new OrderForm().Show();//start job form
            Hide();// hides form

        }

    }
}
