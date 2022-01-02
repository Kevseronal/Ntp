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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection _connection = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; initial catalog = Login; integrated security = true");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _connection.Open();

            string sql = "Select * from LoginTable where UserName = @_userName and Password = @_password";

            SqlParameter prm1 = new SqlParameter("_userName", tbxUserName.Text.Trim());
            SqlParameter prm2 = new SqlParameter("_password", tbxPassword.Text.Trim());

            SqlCommand command = new SqlCommand(sql, _connection);
            command.Parameters.Add(prm1);
            command.Parameters.Add(prm2);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                Process process = new Process();
                process.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }

        private void btnSignUp_MouseHover(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.Cyan;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.LightSeaGreen;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Cyan;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightSeaGreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
