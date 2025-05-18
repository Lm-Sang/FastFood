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
using System.Xml.Linq;

namespace FastFood.GUI
{
    public partial class DetailOrder: Form
    {
        private int OrderId;
        private static readonly OrderItemBLL oib = new OrderItemBLL();

        public DetailOrder(int orderId, string name, string phone)
        {
            InitializeComponent();
            OrderId = orderId;
            ResponseDTO responseDTO = oib.GetOrderItemByOrderId(orderId);
            if (responseDTO.success)
            {
                List<DetailOrderItem> orderItems = (List<DetailOrderItem>)responseDTO.data;
                detail_orderDGV.DataSource = orderItems;
                nametextBox.Text = name;
                phonetextBox.Text = phone;
                totaltextBox.Text = orderItems.Sum(x => x.TotalPrice).ToString();
                quantitytextBox.Text = orderItems.Sum(x => x.Quantity).ToString();
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }

        private void DetailOrder_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            RevenuePage revenuePage = new RevenuePage();
            revenuePage.FormClosed += (s, args) => Application.Exit();
            revenuePage.Show();
        }
    }
}
