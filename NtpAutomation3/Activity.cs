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

namespace NtpAutomation3
{
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }

        LoginEntities3 db = new LoginEntities3();
        private void EventLoad()
        {
            var Events = (from x in db.Events
                          select new
                          {
                              x.EventId,
                              x.EventName,
                              x.Free,
                              x.UnitPrice,
                              x.Capacity,
                              x.Faculty,
                              x.Department,
                              x.Date,
                              x.Information,
                              x.Image,       
                              x.CapacityControl,
                              x.EventCode
                          }).ToList();
            dgwEvents.DataSource = Events;

        }

        SqlConnection _connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Login; Integrated Security = True");

        private void dgwEvents_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            EventProcess eventProcess = new EventProcess();

            eventProcess.a = dgwEvents.CurrentRow.Cells[0].Value.ToString();
            eventProcess.b = dgwEvents.CurrentRow.Cells[1].Value.ToString();
            eventProcess.c = dgwEvents.CurrentRow.Cells[2].Value.ToString();
            eventProcess.d = dgwEvents.CurrentRow.Cells[3].Value.ToString();
            eventProcess.e = dgwEvents.CurrentRow.Cells[4].Value.ToString();
            eventProcess.f = dgwEvents.CurrentRow.Cells[5].Value.ToString();
            eventProcess.g = dgwEvents.CurrentRow.Cells[6].Value.ToString();
            eventProcess.h = dgwEvents.CurrentRow.Cells[7].Value.ToString();
            eventProcess.i = dgwEvents.CurrentRow.Cells[8].Value.ToString();
            eventProcess.k = dgwEvents.CurrentRow.Cells[9].Value.ToString();
            this.Hide();
            eventProcess.Show();
        }

        private void Activity_Load(object sender, EventArgs e)
        {

            System.Windows.Forms.DataGridViewCellStyle dgwEventsCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgwEventsCellStyle.Font = new System.Drawing.Font("Corbel", 12F);
            dgwEvents.DefaultCellStyle = dgwEventsCellStyle;

            EventLoad();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.Show();
        }

        private void btnCbxRemove_Click(object sender, EventArgs e)
        {
            
            cbxFree.Text = "";
            cbxFaculty.Text = "";
            cbxDepartment.Text = "";
            EventLoad();
        }
    

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
            EventLoad();
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

       

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _connection.Open();

           
            SqlCommand command = new SqlCommand("Select * from Events where Free like '%" + cbxFree.Text + "%'", _connection);
            SqlCommand command2 = new SqlCommand("Select * from Events where Faculty like '%" + cbxFaculty.Text + "%'", _connection);
            SqlCommand command3 = new SqlCommand("Select * from Events where Department like '%" + cbxDepartment.Text + "%'", _connection);

            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlDataAdapter da2 = new SqlDataAdapter(command2);
            SqlDataAdapter da3 = new SqlDataAdapter(command3);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwEvents.DataSource = ds.Tables[0];
            _connection.Close();


        }

        private void cbxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFaculty.Text == "Hemşirelik Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Hemşirelik");
            }
            else if(cbxFaculty.Text == "Edebiyat Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Alman Dili ve Edebiyatı");
                cbxDepartment.Items.Add("Amerikan Kültürü ve Edebiyatı");
                cbxDepartment.Items.Add("Felsefe");
                cbxDepartment.Items.Add("Psikoloji");
                cbxDepartment.Items.Add("Sanat Tarihi");
                cbxDepartment.Items.Add("Sosyoloji");
                cbxDepartment.Items.Add("Tarih");
                cbxDepartment.Items.Add("Klasik Arkeoloji");
                cbxDepartment.Items.Add("Protohistorya ve Ön Asya Arkeolojisi");
                cbxDepartment.Items.Add("Felsefe");
                cbxDepartment.Items.Add("Almanca Mütercim ve Tercümanlık");
                cbxDepartment.Items.Add("İngilizce Mütercim ve Tercümanlık");
            }
            else if(cbxFaculty.Text == "Eczacılık Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Eczacılık");
            }
            else if (cbxFaculty.Text == "Eğitim Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Bilgisayar ve Öğretim Teknolojileri Öğretmenliği");
                cbxDepartment.Items.Add("Okul Öncesi Öğretmenliği");
                cbxDepartment.Items.Add("Sınıf Öğretmenliği");
                cbxDepartment.Items.Add("Fen Bilgisi Öğretmenliği");
                cbxDepartment.Items.Add("Özel Eğitim Öğretmenliği");
            }
            else if(cbxFaculty.Text == "Fen Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Astronomi ve Uzay Bilimleri");
                cbxDepartment.Items.Add("Biyoloji");
                cbxDepartment.Items.Add("İstatistik");
                cbxDepartment.Items.Add("Fizik");
                cbxDepartment.Items.Add("Kimya");
                cbxDepartment.Items.Add("Matematik");
                cbxDepartment.Items.Add("Felsefe");             
            }
            else if (cbxFaculty.Text == "İletişim Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Gazetecilik");
                cbxDepartment.Items.Add("Halkla İlişkiler ve Tanıtım");
                cbxDepartment.Items.Add("Radyo, Televizyon ve Sinema");
                cbxDepartment.Items.Add("Reklamcılık");
            }
            else if (cbxFaculty.Text == "Mühendislik Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Bilgisayar Mühendisliği");
                cbxDepartment.Items.Add("Biyomühendislik");
                cbxDepartment.Items.Add("Deri Mühendisliği");
                cbxDepartment.Items.Add("Elektrik Elektronik Mühendisliği");
                cbxDepartment.Items.Add("Gıda Mühendisliği");
                cbxDepartment.Items.Add("İnşaat Mühendisliği");
                cbxDepartment.Items.Add("Kimya Mühendisliği");
                cbxDepartment.Items.Add("Tekstil Mühendisliği");
                cbxDepartment.Items.Add("Makine Mühendisliği");
            }
            else if (cbxFaculty.Text == "Spor Bilimleri Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Antrenörlük Eğitimi");
                cbxDepartment.Items.Add("Beden Eğitimi ve Spor");
                cbxDepartment.Items.Add("Spor Yöneticiliği");
            }
            else if (cbxFaculty.Text == "Tıp Fakültesi")
            {
                cbxDepartment.Items.Clear();
                cbxDepartment.Items.Add("Tıp");
            }
        }

    
    }
}
