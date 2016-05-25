using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 13
// Date: 02/21/2015 12:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab13
{
    public partial class frmMain : Form
    {
        // a class level reference to a token machine
        private TokenMachine tm;

        public frmMain()
        {
            InitializeComponent();

            // create a token machine object
            tm = new TokenMachine();
        }

        /// <summary>
        /// About handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box that displays the programmers name and class
            MessageBox.Show("Matthew Vaughan\nCS 1400 Sec 003");
        }

        /// <summary>
        /// Exit handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes program when activated
            this.Close();
        }

        /// <summary>
        /// Reset handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Declare some constants
            const int ZERO = 0;
            const int HUNDRED = 100;

            //Set the quarters and tokens back to original values
            tm.SetTokens(HUNDRED);
            tm.SetQuarters(ZERO);

            //Get the values
            int valueTokens = tm.GetNumTokens();
            int valueQuarters = tm.GetNumQuarters();

            //Display the values int the text boxes
            txtNumTokens.Text = ($"{valueTokens:N0}");
            txtNumQuarters.Text = ($"{valueQuarters:N0}");
        }

        /// <summary>
        /// Get Token Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetToken_Click(object sender, EventArgs e)
        {

            //Calculate how many tokens and quarters are in the machine
            int valueQuarters = tm.TakeQuarter();
            int valueTokens = tm.GiveToken();

            //Display the value of tokens and quarters in the machine
            txtNumQuarters.Text = ($"{valueQuarters:N0}");
            txtNumTokens.Text = ($"{valueTokens:N0}");
        }
        }
    }
