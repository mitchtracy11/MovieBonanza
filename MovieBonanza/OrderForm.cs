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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Totallabel_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Begin the process for print preview of all items
            printPreviewDialog1.Document = PrintAllPrintDocument;
            printPreviewDialog1.ShowDialog();

        } // end PreviewAllToolStripMenuItem_Click
    }
}
