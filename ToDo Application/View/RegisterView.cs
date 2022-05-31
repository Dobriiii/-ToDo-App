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
using ToDo_Application.Controller;

namespace ToDo_Application.View
{
    public partial class RegisterView : Form
    {
        RegisterController registerController = new RegisterController();
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
            UserTable userTable = new UserTable();
            if (txtRegUsername.Text == String.Empty)
            {
                MessageBox.Show("Please fill the username!");
            }

            else if (txtRegPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("The password and confirm password are not the same!");
            }

            else if (txtRegPass.Text == String.Empty)
            {
                MessageBox.Show("Please fill the password!");
            }

            else
            {
                userTable.Username = txtRegUsername.Text;
                userTable.Firstname = txtFirstname.Text;
                userTable.Lastname = txtLastname.Text;
                userTable.Password = txtRegPass.Text;
                registerController.AddUser(userTable);
                MessageBox.Show("User is registered");
                LoginView loginView = new LoginView();
                this.Hide();
                loginView.Show();               
            }

        }
        void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtRegUsername.Text = txtRegPass.Text = "";
        }
    }
}
