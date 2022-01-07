using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpAutomation3
{
    public partial class Process : Form
    {
        public Process()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEge.Text = lblEge.Text.Substring(1) + lblEge.Text.Substring(0, 1);
        }

        private void Process_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }     

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/universiteege");
        }

        private void btnEvents_Click_1(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.Show();
            this.Hide();
        }

        private void btnSignUpProcess_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUpEvent signUpEvent = new SignUpEvent();
            signUpEvent.Show();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/universiteege/");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEvents_MouseHover_1(object sender, EventArgs e)
        {
            btnEvents.BackColor = Color.PaleVioletRed;
        }

        private void btnEvents_MouseLeave_1(object sender, EventArgs e)
        {
            btnEvents.BackColor = Color.MediumVioletRed;
        }

        private void btnSignUpProcess_MouseHover_1(object sender, EventArgs e)
        {
            btnSignUpProcess.BackColor = Color.PaleVioletRed;
        }

        private void btnSignUpProcess_MouseLeave_1(object sender, EventArgs e)
        {
            btnSignUpProcess.BackColor = Color.MediumVioletRed;
        }

        private void btnExit_MouseHover_1(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.PaleVioletRed;
        }

        private void btnExit_MouseLeave_1(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.MediumVioletRed;
        }
    }
}
