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
    public partial class AdminDashboard: Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void foodBtn_Click(object sender, EventArgs e)
        {
            FoodPage foodPage = new FoodPage();
            foodPage.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            foodPage.Show();
        }

       
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Application.Exit();
            loginForm.Show();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffPage staffPage = new StaffPage();
            staffPage.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            staffPage.Show();
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
