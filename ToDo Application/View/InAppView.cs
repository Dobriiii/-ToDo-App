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
    public partial class InAppView : Form
    {
        ShowTasksController showTasksController = new ShowTasksController();
        public InAppView()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            dgvTask.DataSource = showTasksController.GetAllTasks();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TaskTable taskTable = new TaskTable();
            taskTable.Tasks = txtTsk.Text;
            taskTable.Date = dtpTsk.Value;
            showTasksController.CreateTask(taskTable);
            RefreshTable();
           
        }

        private void InAppView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toDoAppDbDataSet.TaskTable' table. You can move, or remove it, as needed.
            this.taskTableTableAdapter.Fill(this.toDoAppDbDataSet.TaskTable);

        }

        private void txtTsk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTask.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            TaskTable t = new TaskTable();
            t.Id = id;
            t.Tasks = txtTsk.Text;
            t.Date = dtpTsk.Value;
            showTasksController.UpdateTask(id, t);
            RefreshTable();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTask.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            showTasksController.DeleteTask(id);
            RefreshTable();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {

        }

        private void btnUMV_Click(object sender, EventArgs e)
        {
            UserManagementView umv = new UserManagementView();
            umv.Show();
            this.Hide();
        }
    }
}
