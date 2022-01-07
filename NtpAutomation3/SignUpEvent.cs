using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpAutomation3
{
    public partial class SignUpEvent : Form
    {
        public SignUpEvent()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.Show();
            this.Hide();
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            openFileDialogImage.ShowDialog();
            pbxEventImage.ImageLocation = openFileDialogImage.FileName;
            tbxEventImage.Text = openFileDialogImage.FileName;
        }

        private void btnEventSignUp_MouseHover(object sender, EventArgs e)
        {
            btnEventSignUp.BackColor = Color.OrangeRed;
        }

        private void btnEventSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnEventSignUp.BackColor = Color.Tomato;
        }

        LoginEntities3 db = new LoginEntities3();
        SqlConnection _connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Login; Integrated Security = True");
        LoginDataSetTableAdapters.CustomersTableAdapter x = new LoginDataSetTableAdapters.CustomersTableAdapter(); 

        //private void SendMail()
        //{
        //    MailMessage message = new MailMessage();
        //    message.Subject = "Yeni Etkinlik ! ";
        //    message.Body = tbxEventInformation.Text + "                                     Tarih : " + tbxEventDate.Text;
        //    message.From = new MailAddress("egeuniversitesii1@gmail.com");

        //    var fromAdres = "egeuniversitesii1@gmail.com";

        //    const string fromPassword = "EgeUniversitesi44";

        //    var smtp = new System.Net.Mail.SmtpClient();
        //    {
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.EnableSsl = true;
        //        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                
        //        smtp.Credentials = new System.Net.NetworkCredential("egeuniversitesii1@gmail.com", "EgeUniversitesi44");
        //        smtp.Timeout = 20000;

        //    }

        //    SqlCommand cmd = null;
        //    string connectionString = configurationManager
        //}

        private void btnEventSignUp_Click(object sender, EventArgs e)
        {
            Events events = new Events();
            Process process = new Process();
            Customers customers = new Customers();
            Random random = new Random();
            int min = 000000;
            int max = 999999;
            string code = random.Next(min, max).ToString();
            tbxCode.Text = code;
            events.EventName = tbxEventName.Text;
            events.Date = tbxEventDate.Text;
            events.Free = tbxEventFree.Text;
            events.UnitPrice = tbxEventUnitPrice.Text;
            events.Capacity = tbxEventCapacity.Text;
            events.Faculty = tbxEventFaculty.Text;
            events.Department = tbxEventDepartment.Text;
            events.Information = tbxEventInformation.Text;
            events.Image = tbxEventImage.Text;
            pbxEventImage.ImageLocation = openFileDialogImage.FileName;



            events.EventCode = tbxCode.Text;

            db.Events.Add(events);
            db.SaveChanges();
            MessageBox.Show("Etkinlik Eklendi!");
            this.Hide();
            process.Show();
                
            

            //MailMessage sms = new MailMessage();
            //SmtpClient smtpClient = new SmtpClient();
            //smtpClient.Credentials = new System.Net.NetworkCredential("egeuniversitesii1@gmail.com", "EgeUniversitesi44");
            //smtpClient.Port = 587;
            //smtpClient.Host = "smtp.gmail.com";
            //smtpClient.EnableSsl = true;
            //sms.To.Add(a.ToString());
            //sms.From = new MailAddress("egeuniversitesii1@gmail.com");
            //sms.Subject = events.EventName + " Yeni Etkinlik! ";
            //sms.Body = tbxEventInformation.Text + "                                     Tarih : " + tbxEventDate.Text;
            //smtpClient.Send(sms);


            //this.Hide();
            //process.Show();
        }

        private void SignUpEvent_Load(object sender, EventArgs e)
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
                              x.Image,
                              x.CapacityControl,
                              x.EventCode
                          }).ToList();
            dgwGizli.DataSource = Events;
            
        }
    }
}
