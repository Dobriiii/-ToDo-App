using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_Application.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainViewHeadText_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerProgBar.Enabled = true;
            ProgBarLoad.Increment(2);
            if (ProgBarLoad.Value == 100)
            {
                TimerProgBar.Enabled = false;
                LoginView loginView = new LoginView();
                loginView.Show();
                this.Hide();
            }
        }
    }
}
