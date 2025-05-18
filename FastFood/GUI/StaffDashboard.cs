using FastFood.Config;
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
    public partial class StaffDashboard: Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderPage orderPage = new OrderPage();
            orderPage.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            orderPage.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Application.Exit();
            loginForm.Show();
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            RevenuePage revenuePage = new RevenuePage();
            revenuePage.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            revenuePage.Show();
        }
    }
}
