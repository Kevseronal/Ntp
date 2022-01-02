using NtpAutomation;
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

namespace NtpAutomation2
{
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Login; Integrated Security = True");


        LoginEntities1 db = new LoginEntities1();
        private void Activity_Load(object sender, EventArgs e)
        {
            EventLoad();

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

        private void btncbxRemove_Click(object sender, EventArgs e)
        {
            cbxFree.Text = "";
            cbxFaculty.Text = "";
            cbxDepartment.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgwEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            EventProcesss eventProcesss = new EventProcesss();
            eventProcesss.Show();

            eventProcesss.a = dgwEvents.CurrentRow.Cells[1].Value.ToString();
            eventProcesss.b = dgwEvents.CurrentRow.Cells[2].Value.ToString();
            eventProcesss.c = dgwEvents.CurrentRow.Cells[3].Value.ToString();
            eventProcesss.d = dgwEvents.CurrentRow.Cells[4].Value.ToString();
            eventProcesss.e = dgwEvents.CurrentRow.Cells[5].Value.ToString();
            eventProcesss.f = dgwEvents.CurrentRow.Cells[6].Value.ToString();
            eventProcesss.g = dgwEvents.CurrentRow.Cells[7].Value.ToString();
            eventProcesss.h = dgwEvents.CurrentRow.Cells[8].Value.ToString();
            eventProcesss.i = dgwEvents.CurrentRow.Cells[9].Value.ToString();
            //tbxEventImage.Text = dgwEvents.CurrentRow.Cells[9].Value.ToString();

            //pbxEventImage.ImageLocation = dgwEvents.CurrentRow.Cells[9].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Processs processs = new Processs();
            processs.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            btnTemizle.Text = "";
            EventLoad();
        }
    }
}
