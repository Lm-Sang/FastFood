using FastFood.BLL;
using FastFood.Config;
using FastFood.DAL;
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
using System.Xml.Linq;

namespace FastFood.GUI
{
    public partial class StaffPage : Form
    {
        private static readonly AccountBLL ab = new AccountBLL();
        public StaffPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.FormClosed += (s, args) => Application.Exit();
            adminDashboard.Show();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string name = name_findtextBox.Text;
            string phone = phone_findtextBox.Text;

            ResponseDTO response = ab.GetAccountByNameAndPhoneNumber(name, phone);
            if (response.success)
            {
                List<FindAccount> accounts = (List<FindAccount>)response.data;
                staffDGV.DataSource = accounts;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string username = usernametextBox.Text;
            string phone = phonetextBox.Text;
            string password = passwordtextBox.Text;
            ResponseDTO responseDTO = ab.AddNewAccount(new Account
            {
                Name = name,
                Username = username,
                PhoneNumber = phone,
                Password = password
            }, password);
            if (responseDTO.success)
            {
                MessageBox.Show(responseDTO.message);
                nametextBox.Text = string.Empty;
                phonetextBox.Text = string.Empty;
                passwordtextBox.Text = string.Empty;
                findBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {   
            string id = id_inftextBox.Text;
            string name = name_inftextBox.Text;
            string username = username_inftextBox.Text;
            string phone = phone_inftextBox.Text;
            ResponseDTO responseDTO = ab.UpdateAccount(new Account
            {
                AccountId = int.Parse(id),
                Name = name,
                Username = username,
                PhoneNumber = phone,
            });
            if (responseDTO.success)
            {
                MessageBox.Show(responseDTO.message);
                nametextBox.Text = string.Empty;
                phonetextBox.Text = string.Empty;
                findBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = staffDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string id = staffDGV.Rows[index].Cells[0].Value.ToString();
                string name = staffDGV.Rows[index].Cells[2].Value.ToString();
                string username = staffDGV.Rows[index].Cells[1].Value.ToString();
                string phone = staffDGV.Rows[index].Cells[3].Value.ToString();
                ResponseDTO response = ab.DeleteAccount(new Account
                {
                    AccountId = int.Parse(id),
                    Name = name,
                    Username = username,
                    PhoneNumber = phone,
                });
                if (response.success)
                {
                    MessageBox.Show(response.message);
                    id_inftextBox.Text = string.Empty;
                    name_inftextBox.Text = string.Empty;
                    usernametextBox.Text = string.Empty;
                    phonetextBox.Text = string.Empty;
                    findBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(response.message);
                }
            }
            else
            {
                MessageBox.Show("Please select food item");
            }
        }

        private void change_passwordBtn_Click(object sender, EventArgs e)
        {
            ResponseDTO response = ab.ChangePassword(new Account()
            {
                Password = new_passwordtextBox.Text
            }, confirm_passwordtextBox.Text);
            if (response.success)
            {
                MessageBox.Show("Change password successfully");
                new_passwordtextBox.Text = string.Empty;
                confirm_passwordtextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private void staffDGV_SelectionChanged(object sender, EventArgs e)
        {
            int index = staffDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                id_inftextBox.Text = staffDGV.Rows[index].Cells[0].Value.ToString();
                name_inftextBox.Text = staffDGV.Rows[index].Cells[2].Value.ToString();
                username_inftextBox.Text = staffDGV.Rows[index].Cells[1].Value.ToString();
                if (staffDGV.Rows[index].Cells[3].Value != null)
                {
                    phone_inftextBox.Text = staffDGV.Rows[index].Cells[3].Value.ToString();
                }
                else
                {
                    phone_inftextBox.Text = string.Empty; // Or handle appropriately
                }
            }
        }
    }
}
