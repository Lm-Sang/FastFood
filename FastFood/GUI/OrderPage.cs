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
    public partial class OrderPage: Form
    {
        private static readonly FoodBLL fb = new FoodBLL();
        private List<FindOrderItem> orderItems = new List<FindOrderItem>();
        private static readonly OrderBLL ob = new OrderBLL();
        public OrderPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.FormClosed += (s, args) => Application.Exit();
            staffDashboard.Show();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            String foodname = name_findtextBox.Text;
            ResponseDTO response = fb.GetFoodByName(foodname);
            if (response.success)
            {
                List<FindFood> foods = (List<FindFood>)response.data;
                foodDGV.DataSource = foods;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private int Total()
        {
            int total = 0;
            foreach (var item in orderItems)
            {
                total += item.TotalPrice;
            }
            return total;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string foodIdText = idtextBox.Text;
            string foodName = nametextBox.Text;
            string foodPriceText = pricetextBox.Text;
            string foodQuantityText = quantitytextBox.Text;
            string amountText = amounttextBox.Text;

            if (string.IsNullOrEmpty(foodIdText))
            {
                MessageBox.Show("Please select food item");
                return;
            }
            if (int.Parse(foodQuantityText) <= 0)
            {
                MessageBox.Show("Quantity order must be greater than 0");
                return;
            }

            if (string.IsNullOrEmpty(foodQuantityText))
            {
                MessageBox.Show("Please enter quantity");
                return;
            }


            orderItems.Add(new FindOrderItem
            {
                ID = int.Parse(foodIdText),
                Name = foodName,
                Price = int.Parse(foodPriceText),
                Quantity = int.Parse(amountText),
            });

            orderDGV.DataSource = null;
            orderDGV.DataSource = orderItems;
            totaltextBox.Text = Total().ToString();
            amounttextBox.Text = string.Empty;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string phone = customer_phonetextBox.Text;
            string name = customer_nametextBox.Text;
            ResponseDTO response = ob.AddNewOrder(phone, name, orderItems);
            if (response.success)
            {
                MessageBox.Show("Order created successfully");
                orderItems.Clear();
                orderDGV.DataSource = null;
                totaltextBox.Text = "0";
                customer_phonetextBox.Text = string.Empty;
                customer_nametextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int Index = orderDGV.CurrentCell.RowIndex;
            if (Index >= 0)
            {
                orderItems.RemoveAt(Index);
                orderDGV.DataSource = null;
                orderDGV.DataSource = orderItems;
                totaltextBox.Text = Total().ToString();
            }
            else
            {
                MessageBox.Show("Please select food item");
            }
        }

        private void foodDGV_SelectionChanged(object sender, EventArgs e)
        {
            int index = foodDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                idtextBox.Text = foodDGV.Rows[index].Cells[0].Value.ToString();
                nametextBox.Text = foodDGV.Rows[index].Cells[1].Value.ToString();
                pricetextBox.Text = foodDGV.Rows[index].Cells[2].Value.ToString();
                quantitytextBox.Text = foodDGV.Rows[index].Cells[3].Value.ToString();

            }
        }
    }
}
