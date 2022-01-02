﻿using System;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEge.Text = lblEge.Text.Substring(1) + lblEge.Text.Substring(0, 1);
        }

        private void Process_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/universiteege/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/universiteege");
        }

        private void btnEvents_MouseHover(object sender, EventArgs e)
        {
            btnEvents.BackColor = Color.OrangeRed;
        }

        private void btnEvents_MouseLeave(object sender, EventArgs e)
        {
            btnEvents.BackColor = Color.Tomato;
        }

        private void btnSignUpProcess_MouseHover(object sender, EventArgs e)
        {
            btnSignUpProcess.BackColor = Color.OrangeRed;
        }

        private void btnSignUpProcess_MouseLeave(object sender, EventArgs e)
        {
            btnSignUpProcess.BackColor = Color.Tomato;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.OrangeRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Tomato;
        }

        private void btnSignUpProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpEvent signUpEvent = new SignUpEvent();
            signUpEvent.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.Show();
            this.Hide();
        }
    }
}
