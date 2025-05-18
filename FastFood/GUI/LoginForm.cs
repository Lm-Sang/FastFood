using FastFood.BLL;
using FastFood.Config;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.GUI
{
    public partial class LoginForm: Form
    {
        private static readonly AccountBLL ab = new AccountBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernametextBox.Text;
            string password = passwordtextBox.Text;
            ResponseDTO response = ab.Login(username, password);
            if (response.success)
            {
                if (Session.UserRole == "ADMIN")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    adminDashboard.Show();
                }
                else if (Session.UserRole == "STAFF")
                {
                    StaffDashboard staffDashboard = new StaffDashboard();
                    staffDashboard.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    staffDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }
    }
}
