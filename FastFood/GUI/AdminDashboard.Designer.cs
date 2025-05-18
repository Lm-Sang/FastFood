using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFood.GUI
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.staffBtn = new System.Windows.Forms.Button();
            this.revenueBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodBtn
            // 
            this.foodBtn.BackColor = System.Drawing.Color.Cyan;
            this.foodBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foodBtn.Location = new System.Drawing.Point(203, 89);
            this.foodBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(236, 38);
            this.foodBtn.TabIndex = 0;
            this.foodBtn.Text = "FOOD";
            this.foodBtn.UseVisualStyleBackColor = false;
            this.foodBtn.Click += new System.EventHandler(this.foodBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(272, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin";
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.Cyan;
            this.staffBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.staffBtn.Location = new System.Drawing.Point(203, 131);
            this.staffBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(236, 35);
            this.staffBtn.TabIndex = 5;
            this.staffBtn.Text = "STAFF";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // revenueBtn
            // 
            this.revenueBtn.BackColor = System.Drawing.Color.Cyan;
            this.revenueBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.revenueBtn.Location = new System.Drawing.Point(203, 172);
            this.revenueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revenueBtn.Name = "revenueBtn";
            this.revenueBtn.Size = new System.Drawing.Size(236, 36);
            this.revenueBtn.TabIndex = 6;
            this.revenueBtn.Text = "REVENUE";
            this.revenueBtn.UseVisualStyleBackColor = false;
            this.revenueBtn.Click += new System.EventHandler(this.revenueBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Red;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutBtn.Location = new System.Drawing.Point(203, 212);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(236, 36);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 364);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.revenueBtn);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button foodBtn;
        private Label label1;
        private Button staffBtn;
        private Button revenueBtn;
        private Button logoutBtn;
    }
}