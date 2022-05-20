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

namespace ToDo_Application.View
{
    public partial class RegisterView : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public RegisterView()
        {
            InitializeComponent();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtRegUsername.Clear();
            txtRegPass.Clear();
            txtConfirmPass.Clear();
            txtRegUsername.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblGoToLogIn_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Lastname", txtLastname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Username", txtRegUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtRegPass.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registration is successfull");
                
            }
        }
        void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtRegUsername.Text = txtRegPass.Text = "";
        }
    }
}
