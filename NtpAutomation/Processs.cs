using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NtpAutomation
{
    public partial class Processs : Form
    {
        public Processs()
        {
            InitializeComponent();
        }    

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     

        LoginEntities7 db = new LoginEntities7();

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0,1);
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

        
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/universiteege/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/firatresmihesap");
        }


        private void btnSignUpProcess_Click_1(object sender, EventArgs e)
        {
            SignUpEvent signUpEvent = new SignUpEvent();
            signUpEvent.Show();
            this.Hide();
        }

        private void btnEvents_Click_1(object sender, EventArgs e)
        {
            Activitiy activity = new Activitiy();
            activity.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
