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

namespace FastFood.GUI
{
    public partial class RevenuePage: Form
    {
        private static readonly OrderBLL ob = new OrderBLL();
        public RevenuePage()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            DateTime start = startDate.Value.Date;
            DateTime end = endDate.Value.Date;
            ResponseDTO responseDTO = ob.GetOrderByDateTime(-1, start, end);
            if (responseDTO.success )
            {
                List<FindOrder> orders = (List<FindOrder>)responseDTO.data;
                revenueDGV.DataSource = null;
                revenueDGV.DataSource = orders;
                total_ordertextBox.Text = orders.Count.ToString();
                total_revenuetextBox.Text = orders.Sum(o => o.TotalPrice).ToString();
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.FormClosed += (s, args) => Application.Exit();
            adminDashboard.Show();
        }

        private void revenueDGV_SelectionChanged(object sender, EventArgs e)
        {
            int index = revenueDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                idtextBox.Text = revenueDGV.Rows[index].Cells[0].Value.ToString();
                customer_nametextBox.Text = revenueDGV.Rows[index].Cells[2].Value.ToString();
                customer_phonetextBox.Text = revenueDGV.Rows[index].Cells[3].Value.ToString();
                statuscomboBox.Text = revenueDGV.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string status = statuscomboBox.Text;
            int orderId = int.Parse(idtextBox.Text);
            ResponseDTO responseDTO = ob.UpdateOrderStatus(orderId, status);
            if (!responseDTO.success)
            {
                MessageBox.Show(responseDTO.message);
            }
            else
            {
                MessageBox.Show("Update order status successfully");
                idtextBox.Text = string.Empty;
                customer_nametextBox.Text = string.Empty;
                customer_phonetextBox.Text = string.Empty;
                statuscomboBox.Text = string.Empty;
                viewBtn_Click(sender, e);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = revenueDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string id = revenueDGV.Rows[index].Cells[0].Value.ToString();
                string name = revenueDGV.Rows[index].Cells[1].Value.ToString();
                string phone = revenueDGV.Rows[index].Cells[2].Value.ToString();
                string status = revenueDGV.Rows[index].Cells[3].Value.ToString();
                ResponseDTO response = ob.DeleteOrder(new Order
                {
                    OrderId = int.Parse(id),
                    CustomerName = name,
                    CustomerPhoneNumber = phone,
                    Status = status
                });
                if (response.success)
                {
                    MessageBox.Show(response.message);
                    idtextBox.Text = string.Empty;
                    customer_nametextBox.Text = string.Empty;
                    customer_phonetextBox.Text = string.Empty;
                    statuscomboBox.Text = string.Empty;
                    viewBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(response.message);
                }
            }
            else
            {
                MessageBox.Show("Please select order");
            }
        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            int index = revenueDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                int orderId = Convert.ToInt32(revenueDGV.Rows[index].Cells[0].Value);
                string Name = revenueDGV.Rows[index].Cells[2].Value.ToString();
                string PhoneNumber = revenueDGV.Rows[index].Cells[3].Value.ToString();
                DetailOrder detailOrder = new DetailOrder(orderId, Name, PhoneNumber);
                detailOrder.FormClosed += (s, args) => this.Show();
                this.Hide();
                detailOrder.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to view detail");
            }
        }
    }
}
