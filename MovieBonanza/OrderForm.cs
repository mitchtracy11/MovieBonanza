/* Program:             Order Form
 * Programmer:          Mitchell Tracy
 * Date:                November 2013
 * Form Description:    This form allows the user to see the entire total and all the order info also able to select a dvd option */

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
    //private int Price = PriceTextBox;
    public partial class OrderForm : Form
    {

        // Declare other Forms associated with this form
        public Form previousForm;
        AboutBox myAboutForm = new AboutBox();

        private String Price;
        private String Title;
        private String Category;

        public string MovieCategory
        {
            set
            {
                Category = value;
            }
        }

        public string MovieSelected
        {
            set
            {
                Title = value;
            }
        }

        public string MoviePrice
        {
            set
            {
                Price = value;
            }
        } 
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Totallabel_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Produce a print preview of the form
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Terminate the Application
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            // Display user data in the form labels every time the form is activated
            CostTextBox2.Text = Price;
            TitletextBox2.Text = Title;
            CategorytextBox2.Text = Category;
        }

        private void Streambutton_Click(object sender, EventArgs e)
        {
            new CheckOut().Show();//start job form
            Hide();// hides form
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            // Show the previous form and hide this form
            previousForm.Show();
            this.Hide();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            // Terminate the Application
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the About Form Dialog
            myAboutForm.ShowDialog();
        }
    }
}
