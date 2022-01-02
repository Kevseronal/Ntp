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
    public partial class SignUpCustomer : Form
    {
        public SignUpCustomer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        LoginEntities7 db = new LoginEntities7();

         public string a;
        private void btnCustomerSignUp_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();

            tbxDeneme.Text = a;

            customers.CustomerName = tbxCustomerName.Text;
            customers.CustomerLastName = tbxCustomerLastName.Text;
            customers.CustomerAge = tbxCustomerAge.Text;
            customers.CustomerCinsiyet = tbxCustomerCinsiyet.Text;
            customers.CustomerTc = tbxCustomerTc.Text;
            customers.CustomerStudentNumber = tbxCustomerStudentNumber.Text;
            customers.CustomerPhoneNumber = tbxCustomerPhoneNumber.Text;
            customers.CustomerMail = tbxCustomerMail.Text;
            customers.CustomerFaculty = tbxCustomerFaculty.Text;
            customers.CustomerDepartment = tbxCustomerDepartment.Text;


            db.Customers.Add(customers);
            db.SaveChanges();
            MessageBox.Show("Kişi Kaydedildi!");
            this.Hide();
        }

        private void SignUpCustomer_Load(object sender, EventArgs e)
        {
           // tbx
        }
    }
}
