﻿/* Program:             Movie Bonanza
 * Programmer:          Mitchell Tracy
 * Date:                November 2013
 * Form Description:    This form allows the user to see a splash screen */

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
    public partial class SplashScreen : Form
    {
    
         public SplashScreen()
        {
            InitializeComponent();        
        }


        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Close the splash form.
            this.Close();
        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        } // end timer1_Tick
    }
}
