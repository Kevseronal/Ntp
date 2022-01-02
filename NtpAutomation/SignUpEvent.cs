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
    public partial class SignUpEvent : Form
    {
        public SignUpEvent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Processs processs = new Processs();
            processs.Show();
        }

        LoginEntities7 db = new LoginEntities7();

        private void SignUpEvent_Load(object sender, EventArgs e)
        {
            var Events = (from x in db.Events
                          select new
                          {
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
            dgwGizli.DataSource = Events;
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            ofdAddImage.ShowDialog();
            pbxEventImage.ImageLocation = ofdAddImage.FileName;
            tbxEventImage.Text = ofdAddImage.FileName;
        }

        private void btnEventSignUp_Click_1(object sender, EventArgs e)
        {
            Events events = new Events();
            Processs processs = new Processs();
            events.EventName = tbxEventName.Text;
            events.Date = tbxEventDate.Text;
            events.Free = tbxEventFree.Text;
            events.UnitPrice = tbxEventUnitPrice.Text;
            events.Capacity = Convert.ToInt32(tbxEventCapacity.Text);
            events.Faculty = tbxEventFaculty.Text;
            events.Department = tbxEventDepartment.Text;
            events.Information = tbxEventInformation.Text;
            events.Image = tbxEventImage.Text;
            pbxEventImage.ImageLocation = ofdAddImage.FileName;
            db.Events.Add(events);
            db.SaveChanges();
            MessageBox.Show("Etkinlik Eklendi!");
            this.Hide();
            processs.Show();

            
        }
    }
}
