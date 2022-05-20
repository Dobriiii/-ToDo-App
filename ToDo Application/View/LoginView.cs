using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo_Application.Controller;

namespace ToDo_Application.View
{
    public partial class LoginView : Form
    {
        LoginController loginController = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var message = loginController.ShowMessage(txtUsername.Text, txtPassword.Text);
            if (message != null)
            {
                MessageBox.Show(message);
            }
            else
            {
                LoginView lv = new LoginView();
                this.Hide();
                lv.Show();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblGoToReg_Click(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show();
            this.Hide();
        }
    }
}
