using MessagingToolkit.QRCode.Codec;
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
    public partial class EventProcess : Form
    {
        public EventProcess()
        {
            InitializeComponent();
        }

        LoginEntities3 db = new LoginEntities3();
        public string a, b, c, d, e, f, g, h, i, k, l;
 

        private void btnEventUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbxEventId.Text);
            var y = db.Events.Find(x);

            Events events = new Events();

            y.EventName = tbxEventName.Text;
            y.Date = tbxEventDate.Text;
            y.Free = tbxEventFree.Text;
            y.UnitPrice = tbxEventUnitPrice.Text;
            y.Capacity = tbxEventCapacity.Text;
            y.Faculty = tbxEventFaculty.Text;
            y.Department = tbxEventDepartment.Text;
            y.Information = tbxEventInformation.Text;
            y.Image = tbxEventImage.Text;


            db.SaveChanges();
            MessageBox.Show("Etkinlik Güncellendi!");
            Activity activity = new Activity();
            activity.Show();
        }

        private void btnEventRemove_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tbxEventId.Text);
            var b = db.Events.Find(a);
            db.Events.Remove(b);
            db.SaveChanges();
            MessageBox.Show("Etkinlik Silindi!");
            //EventLoad();
            Activity activity = new Activity();
            activity.Show();
        }

        private void btnSignUpCustomerList_Click(object sender, EventArgs e)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.y = Convert.ToInt32(tbxEventId.Text);
            customerProcess.Show();
            //this.Hide();
        }

        private void btnSignUpCustomer_Click(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(tbxCapacityControl.Text) >= Convert.ToInt32(tbxEventCapacity.Text))
            //{
            //    MessageBox.Show("Kapasite Dolu!");

            //} // Bu if hata veriyor..
            //else
            //{
            //}

            SignUpCustomer signUpCustomer = new SignUpCustomer();
            signUpCustomer.x = Convert.ToInt32(tbxEventId.Text);
            signUpCustomer.y = Convert.ToInt32(tbxEventCapacity.Text);
            signUpCustomer.z = tbxEventInformation.Text;
            signUpCustomer.t = tbxEventDate.Text;
            signUpCustomer.w = tbxEventName.Text;
           
            signUpCustomer.a = tbxCapacityControl.Text;
            signUpCustomer.Show();
            this.Hide();
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbxEventImage.ImageLocation = openFileDialog1.FileName;
            tbxEventImage.Text = openFileDialog1.FileName;
        }

        private void EventProcess_Load(object sender, EventArgs e)
        {
            Events events = new Events();
            Customers customers = new Customers();
            tbxEventId.Text = a;
            tbxEventName.Text = b;
            tbxEventFree.Text = c;
            tbxEventUnitPrice.Text = d;
            tbxEventFaculty.Text = f;
            tbxEventDepartment.Text = g;
            tbxEventDate.Text = h;
            tbxEventInformation.Text = i;
            tbxEventImage.Text = k;
            pbxEventImage.ImageLocation = k;

            int x1 = Convert.ToInt32(tbxEventId.Text);
            var y1 = db.Events.Find(x1);
            tbxEventCapacity.Text = Convert.ToString(y1.Capacity);

           /* int x = Convert.ToInt32(tbxEventId.Text);
            var y = db.Events.Find(x);
            tbxCapacityControl.Text = Convert.ToString(y.CapacityControl);*/

            int x = Convert.ToInt32(tbxEventId.Text);
            var y = db.Customers.Where(p => p.CustomerEvent == x.ToString()).ToList();
            tbxCapacityControl.Text = Convert.ToString(y.Count());

            /*if (y.CapacityControl == null)
            {
                y.CapacityControl = 0;
                tbxCapacityControl.Text = "0";
            }*/


            tbxBigEventInformation.Text = tbxEventInformation.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.Show();
        }
    }
}
