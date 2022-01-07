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
    public partial class CustomerProcess : Form
    {
        public CustomerProcess()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //EventProcess eventProcess = new EventProcess();
            //eventProcess.Show();
        }

        LoginEntities3 db = new LoginEntities3();

        private void CustomerProcess_Load(object sender, EventArgs e)
        {
            CustomersLoad();

            System.Windows.Forms.DataGridViewCellStyle dgwSignUpCustomerListCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgwSignUpCustomerListCellStyle.Font = new System.Drawing.Font("Corbel", 12F);
            dgwSignUpCustomerList.DefaultCellStyle = dgwSignUpCustomerListCellStyle;
        }

        public int y;
        private void CustomersLoad()
        {
            tbxEventId.Text = Convert.ToString(y);
            Customers customers = new Customers();

            //if (tbxEventId.Text == customers.CustomerEvent)
            //{
            //    var Customers = 
            //}

            Events events = new Events();

            var listelenecekUrunler = db.Customers.Where(p => p.CustomerEvent == tbxEventId.Text).ToList();
            dgwSignUpCustomerList.DataSource = listelenecekUrunler;


            //var Customers = (from x in db.Customers
            //                 select new
            //                 {
            //                     x.CustomerId,
            //                     x.CustomerName,
            //                     x.CustomerLastName,
            //                     x.CustomerTc,
            //                     x.CustomerStudentNumber,
            //                     x.CustomerAge,
            //                     x.CustomerMail,
            //                     x.CustomerFaculty,
            //                     x.CustomerDepartment,
            //                     x.CustomerPhoneNumber,
            //                     x.CustomerCinsiyet,
            //                     x.CustomerEvent
            //                 }).ToList();
            //dgwSignUpCustomerList.DataSource = Customers;


            //foreach (var cus in listelenecekUrunler)
            //{
            //    customers
            //}



            //var Customers = (from x in db.Customers
            //                 select new
            //                 {
            //                     x.CustomerId,
            //                     x.CustomerName,
            //                     x.CustomerLastName,
            //                     x.CustomerTc,
            //                     x.CustomerStudentNumber,
            //                     x.CustomerAge,
            //                     x.CustomerMail,
            //                     x.CustomerFaculty,
            //                     x.CustomerDepartment,
            //                     x.CustomerPhoneNumber,
            //                     x.CustomerCinsiyet,
            //                     x.CustomerEvent
            //                 }).ToList();
            //dgwSignUpCustomerList.DataSource = Customers;
        }

        private void dgwSignUpCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customers customers = new Customers();
            tbxEventId.Text = customers.CustomerEvent;
            tbxCustomerId.Text = dgwSignUpCustomerList.CurrentRow.Cells[0].Value.ToString();
            tbxCustomerName.Text = dgwSignUpCustomerList.CurrentRow.Cells[1].Value.ToString();
            tbxCustomerLastName.Text = dgwSignUpCustomerList.CurrentRow.Cells[2].Value.ToString();
            tbxCustomerAge.Text = dgwSignUpCustomerList.CurrentRow.Cells[5].Value.ToString();
            tbxCustomerCinsiyet.Text = dgwSignUpCustomerList.CurrentRow.Cells[10].Value.ToString();
            tbxCustoemrTc.Text = dgwSignUpCustomerList.CurrentRow.Cells[3].Value.ToString();
            tbxCustomerStudentNumber.Text = dgwSignUpCustomerList.CurrentRow.Cells[4].Value.ToString();
            tbxCustomerPhoneNumber.Text = dgwSignUpCustomerList.CurrentRow.Cells[9].Value.ToString();
            tbxCustomerMail.Text = dgwSignUpCustomerList.CurrentRow.Cells[6].Value.ToString();
            tbxCustomerFaculty.Text = dgwSignUpCustomerList.CurrentRow.Cells[7].Value.ToString();
            tbxCustomerDepartment.Text = dgwSignUpCustomerList.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnCustomerRemove_Click(object sender, EventArgs e)

        {
            int a = Convert.ToInt32(tbxCustomerId.Text);
            var b = db.Customers.Find(a);
            db.Customers.Remove(b);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi!");
            CustomersLoad();

           
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbxCustomerId.Text);
            var y = db.Customers.Find(x);

            Events events = new Events();

            //y.CustomerId = Convert.ToInt32(tbxCustomerId.Text);
            y.CustomerName = tbxCustomerName.Text;
            y.CustomerLastName = tbxCustomerLastName.Text;
            y.CustomerAge = tbxCustomerAge.Text;
            y.CustomerCinsiyet = tbxCustomerCinsiyet.Text;
            y.CustomerTc = tbxCustoemrTc.Text;
            y.CustomerStudentNumber = tbxCustomerStudentNumber.Text;
            y.CustomerPhoneNumber = tbxCustomerPhoneNumber.Text;
            y.CustomerMail = tbxCustomerMail.Text;
            y.CustomerFaculty = tbxCustomerFaculty.Text;
            y.CustomerDepartment = tbxCustomerDepartment.Text;

            


            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi!");
            CustomersLoad();
        }
    }
}
