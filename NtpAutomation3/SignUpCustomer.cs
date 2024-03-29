﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using QRCoder;
using System.Net;


namespace NtpAutomation3
{
   
    public partial class SignUpCustomer : Form
    {
        public SignUpCustomer()
        {
            InitializeComponent();
        }
        LoginEntities3 db = new LoginEntities3();
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.Show();
        }
        
        

        public int x;
        public int y;
        public string z;
        public string t;
        public string w;
        private void SignUpCustomer_Load(object sender, EventArgs e)
        {
            Events events = new Events();
            tbxEventId.Text = Convert.ToString(x);
            tbxEventCapacity.Text = Convert.ToString(y);
            tbxEventInformation.Text = z;
            tbxEventDate.Text = t;
            tbxEventName.Text = w;

            int x1 = Convert.ToInt32(tbxEventId.Text);
            var y1 = db.Events.Find(x1);
            tbxCode.Text = Convert.ToString(y1.EventCode);
           
        }

        //public void GetPublicvoidQR(string infoReserva)
        //{
        //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(infoReserva, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(qrCodeData);

        //    using (Bitmap bitMap = qrCode.GetGraphic(20))
        //    {
        //        bitMap.Save(Server.MapPath("~/Images/qrcode.png"), ImageFormat.Png);
        //    }

        //    MailMessage mm = new MailMessage();
        //    mm.From = new MailAddress("egeuniversitesii1@gmail.com");
        //    mm.Subject = "Bilet";
        //    mm.Body = "<html><body> <p> QR code as below</p> <p> <img src = 'http://localhost:44362//Images/qrcode.png' alt='QR Code' /></p> </body></html> ";
        //    mm.To.Add(tbxCustomerMail.Text);
        //    mm.IsBodyHtml = true;
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.EnableSsl = true;
        //    NetworkCredential NetworkCred = new NetworkCredential();
        //    NetworkCred.UserName = 
        //}

         public string a;
        private void btnCustomerSignUp_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            Activity activity = new Activity();
            Events events = new Events();

            int x = Convert.ToInt32(tbxEventId.Text);
            var y = db.Events.Find(x);
            

            if (y.CapacityControl > Convert.ToInt32(tbxEventCapacity.Text))
            {
                MessageBox.Show("Kapasite Dolu!");
                this.Close();
                activity.Show();
            }
            else
            {
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
                customers.CustomerEvent = tbxEventId.Text;

                db.Customers.Add(customers);

                y.CapacityControl += 1;


                db.SaveChanges();
                MessageBox.Show("Müşteri Eklendi!");




                MailMessage sms = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new System.Net.NetworkCredential("egeuniversitesii1@gmail.com", "EgeUniversitesi44");
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                sms.To.Add(tbxCustomerMail.Text);
                sms.From = new MailAddress("egeuniversitesii1@gmail.com");
                sms.Subject = events.EventName + " etkinliğine kayıt oldunuz!";
                sms.Body = tbxEventInformation.Text + "\nTarih : " + tbxEventDate.Text + "\nEtkinlik Giriş Kodu : " + tbxCode.Text;

                


                smtpClient.Send(sms);


                this.Hide();
                activity.Show();
            }       
            
            
        }

    }
}
