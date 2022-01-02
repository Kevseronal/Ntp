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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; initial catalog = Login; integrated security = true");

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbxUserName2.Text.Length > 3 && tbxPassword2.Text.Length > 3)
            {


                if (tbxPassword2.Text == tbxPassword3.Text)
                {
                    _connection.Open();
                    SqlCommand command = new SqlCommand("Insert into LoginTable values(@_userName,@_password)", _connection);
                    command.Parameters.AddWithValue("@_userName", tbxUserName2.Text);
                    command.Parameters.AddWithValue("@_password", tbxPassword2.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt olundu!");
                    _connection.Close();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler uyuşmuyor!");
                }
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre 4 karakterden az olamaz!");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
