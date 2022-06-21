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
    public partial class UserManagementView : Form
    {
        ShowUsersController showUsersController = new ShowUsersController();
        public UserManagementView()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            Usersdgv.DataSource = showUsersController.GetAllUsers();
        }

        private void UserManagementView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toDoAppDbDataSet1.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.toDoAppDbDataSet1.UserTable);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserTable userTable = new UserTable();
            userTable.Firstname = txtFirstName.Text;
            userTable.Lastname = txtLastName.Text;
            userTable.Username = txtUsername.Text;
            userTable.Password = txtPass.Text;
            userTable.Id = int.Parse(txtId.Text);
            showUsersController.CreateUser(userTable);
            RefreshTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Usersdgv.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            showUsersController.DeleteUser(id);
            RefreshTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Usersdgv.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            UserTable u = new UserTable();
            u.Firstname = txtFirstName.Text;
            u.Lastname = txtLastName.Text;
            u.Username = txtUsername.Text;
            u.Password = txtPass.Text;
            u.Id = int.Parse(txtId.Text);
            showUsersController.UpdateUser(id, u);
            RefreshTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
