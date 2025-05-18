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
    public partial class FoodPage : Form
    {
        private static readonly FoodBLL fb = new FoodBLL();
        public FoodPage()
        {
            InitializeComponent();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            String foodName = name_findtextBox.Text;
            ResponseDTO response = fb.GetFoodByName(foodName);
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
        private void addBtn_Click(object sender, EventArgs e)
        {
            String foodName = nametextBox.Text;
            int foodPrice = int.Parse(pricetextBox.Text);
            int foodQuantity = int.Parse(quantitytextBox.Text);
            ResponseDTO response = fb.AddFood(new Food
            {
                FoodName = foodName,
                Price = foodPrice,
                Quantity = foodQuantity
            });
            if (response.success)
            {
                MessageBox.Show(response.message);
                nametextBox.Text = string.Empty;
                pricetextBox.Text = string.Empty;
                quantitytextBox.Text = string.Empty;
                findBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.FormClosed += (s, args) => Application.Exit();
            adminDashboard.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int foodId = int.Parse(id_inftextBox.Text);
            String foodName = name_inftextBox.Text;
            int foodPrice = int.Parse(price_inftextBox.Text);
            int foodQuantity = int.Parse(quantity_inftextBox.Text);

            ResponseDTO response = fb.UpdateFood(new Food
            {
                FoodId = foodId,
                FoodName = foodName,
                Price = foodPrice,
                Quantity = foodQuantity
            });

            if (response.success)
            {
                MessageBox.Show(response.message);
                id_inftextBox.Text = string.Empty;
                name_inftextBox.Text = string.Empty;
                price_inftextBox.Text = string.Empty;
                quantity_inftextBox.Text = string.Empty;
                findBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = foodDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string id = foodDGV.Rows[index].Cells[0].Value.ToString();
                string name = foodDGV.Rows[index].Cells[1].Value.ToString();
                string price = foodDGV.Rows[index].Cells[2].Value.ToString();
                string quantity = foodDGV.Rows[index].Cells[3].Value.ToString();
                ResponseDTO response = fb.DeleteFood(new Food
                {
                    FoodId = int.Parse(id),
                    FoodName = name,
                    Price = int.Parse(price),
                    Quantity = int.Parse(quantity)
                });
                if (response.success)
                {
                    MessageBox.Show(response.message);
                    id_inftextBox.Text = string.Empty;
                    name_inftextBox.Text = string.Empty;
                    price_inftextBox.Text = string.Empty;
                    quantity_inftextBox.Text = string.Empty;
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

        private void foodDGV_SelectionChanged(object sender, EventArgs e)
        {
            int index = foodDGV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                id_inftextBox.Text = foodDGV.Rows[index].Cells[0].Value.ToString();
                name_inftextBox.Text = foodDGV.Rows[index].Cells[1].Value.ToString();
                price_inftextBox.Text = foodDGV.Rows[index].Cells[2].Value.ToString();
                quantity_inftextBox.Text = foodDGV.Rows[index].Cells[3].Value.ToString();
            }

        }

        private void FoodPage_Load(object sender, EventArgs e)
        {

        }
    }
}
