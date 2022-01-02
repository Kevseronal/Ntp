using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpAutomation
{
    public partial class Activitiy : Form
    {
        public Activitiy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Processs processs = new Processs();
            processs.Show();
        }

        private void btnSignUpCustomer_Click(object sender, EventArgs e)
        {

            //Processs processs = new Processs();
            //processs.Hide();
            SignUpCustomer signUpCustomer = new SignUpCustomer();
            signUpCustomer.a = tbxEventName.Text;

            signUpCustomer.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelEvents.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Processs processs = new Processs();
            processs.Show();
        }
        LoginEntities7 db = new LoginEntities7();

        SqlConnection _connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Login; Integrated Security = True");
        private void Activitiy_Load(object sender, EventArgs e)
        {
            EventLoad();

            CustomerLoad();

            var free = (from x in db.Events
                        select new
                        {
                            x.EventId,
                            x.Free
                        }).ToList();
            cbxFree.ValueMember = "EventId";
            cbxFree.DisplayMember = "Free";
            cbxFree.DataSource = free;

            var faculty = (from x in db.Events
                        select new
                        {
                            x.EventId,
                            x.Faculty
                        }).ToList();
            cbxFaculty.ValueMember = "EventId";
            cbxFaculty.DisplayMember = "Faculty";
            cbxFaculty.DataSource = faculty;

            var department = (from x in db.Events
                        select new
                        {
                            x.EventId,
                            x.Department
                        }).ToList();
            cbxDepartment.ValueMember = "EventId";
            cbxDepartment.DisplayMember = "Department";
            cbxDepartment.DataSource = department;

            
        }

        private void btncbxRemove_Click(object sender, EventArgs e)
        {
            cbxFree.Text = "";
            cbxFaculty.Text = "";
            cbxDepartment.Text = "";
        }

        private void dgwEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            panelEvents.Hide();

            Events events = new Events();
            tbxEventId.Text = dgwEvents.CurrentRow.Cells[0].Value.ToString();
            tbxEventName.Text = dgwEvents.CurrentRow.Cells[1].Value.ToString();
            tbxEventDate.Text = dgwEvents.CurrentRow.Cells[2].Value.ToString();
            tbxEventFree.Text = dgwEvents.CurrentRow.Cells[3].Value.ToString();
            tbxEventUnitPrice.Text = dgwEvents.CurrentRow.Cells[4].Value.ToString();
            tbxEventCapacity.Text = dgwEvents.CurrentRow.Cells[5].Value.ToString();
            tbxEventFaculty.Text = dgwEvents.CurrentRow.Cells[6].Value.ToString();
            tbxEventDepartment.Text = dgwEvents.CurrentRow.Cells[7].Value.ToString();
            tbxEventInformation.Text = dgwEvents.CurrentRow.Cells[8].Value.ToString();
            tbxEventImage.Text = dgwEvents.CurrentRow.Cells[9].Value.ToString();
           

            //tbxBigEventInformation.Text = dgwEvents.CurrentRow.Cells[8].Value.ToString();

            pbxEventImage.ImageLocation = dgwEvents.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnSignUpCustomerList_Click(object sender, EventArgs e)
        {
            panelEventProcess.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelEventProcess.Show();
        }

        private void panelEventProcess_Paint(object sender, PaintEventArgs e)
        {
            tbxBigEventInformation.Text = tbxEventInformation.Text;
        }

        private void btnEventUpdate_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(tbxEventId.Text);
            var b = db.Events.Find(a);
            
            Events events = new Events();

            b.EventName = tbxEventName.Text;
            b.Date = tbxEventDate.Text;
            b.Free = tbxEventFree.Text;
            b.UnitPrice = tbxEventUnitPrice.Text;
            b.Capacity = Convert.ToInt32(tbxEventCapacity.Text);
            b.Faculty = tbxEventFaculty.Text;
            b.Department = tbxEventDepartment.Text;
            b.Information = tbxEventInformation.Text;
            b.Image = tbxEventImage.Text;


            db.SaveChanges();
            MessageBox.Show("Etkinlik Güncellendi!");
            EventLoad();
            panelEvents.Show();
        }

        private void btnEventRemove_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tbxEventId.Text);
            var b = db.Events.Find(a);
            db.Events.Remove(b);
            db.SaveChanges();
            MessageBox.Show("Etkinlik Silindi!");
            EventLoad();
            panelEvents.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Select * from Events where EventName like '%" + tbxSearch.Text + "%'", _connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwEvents.DataSource = ds.Tables[0];
            _connection.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
            EventLoad();
        }

        private void EventLoad()
        {
            var Events = (from x in db.Events
                          select new
                          {
                              x.EventId,
                              x.EventName,
                              x.Date,
                              x.Free,
                              x.UnitPrice,
                              x.Capacity,
                              x.Faculty,
                              x.Department,
                              x.Information,
                              x.Image                           
                          }).ToList();
            dgwEvents.DataSource = Events;
        }

        private void CustomerLoad()
        {
            var Customers = (from x in db.Customers
                            select new
                            {
                                x.CustomerId,
                                x.CustomerName,
                                x.CustomerLastName,
                                x.CustomerTc,
                                x.CustomerStudentNumber,
                                x.CustomerAge,
                                x.CustomerMail,
                                x.CustomerFaculty,
                                x.CustomerDepartment,
                                x.CustomerPhoneNumber,
                                x.CustomerCinsiyet,
                                x.CustomerEvent
                            }).ToList();
            dgwSignUpCustomerList.DataSource = Customers;
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            ofdImageUpdate.ShowDialog();
            pbxEventImage.ImageLocation = ofdImageUpdate.FileName;
            tbxEventImage.Text = ofdImageUpdate.FileName;
        }

   

        private void btnCustomerRemove_Click(object sender, EventArgs e)
        {

        }


        //private void btnCustomerRemove_Click(object sender, EventArgs e)
        //{
        //    int a = Convert.ToInt32(tbxCusTOMER.Text);
        //    var b = db.Events.Find(a);
        //    db.Events.Remove(b);
        //    db.SaveChanges();
        //    MessageBox.Show("Etkinlik Silindi!");
        //    EventLoad();
        //    panelEvents.Show();
        //}
    }
}
