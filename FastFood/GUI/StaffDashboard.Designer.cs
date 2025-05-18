using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFood.GUI
{
    partial class StaffDashboard
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
            this.orderBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.revenueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.Cyan;
            this.orderBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.orderBtn.Location = new System.Drawing.Point(256, 88);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(236, 38);
            this.orderBtn.TabIndex = 8;
            this.orderBtn.Text = "ORDER";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Red;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutBtn.Location = new System.Drawing.Point(256, 171);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(236, 36);
            this.logoutBtn.TabIndex = 12;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(335, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Staff";
            // 
            // revenueBtn
            // 
            this.revenueBtn.BackColor = System.Drawing.Color.Cyan;
            this.revenueBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.revenueBtn.Location = new System.Drawing.Point(256, 131);
            this.revenueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revenueBtn.Name = "revenueBtn";
            this.revenueBtn.Size = new System.Drawing.Size(236, 36);
            this.revenueBtn.TabIndex = 11;
            this.revenueBtn.Text = "REVENUE";
            this.revenueBtn.UseVisualStyleBackColor = false;
            this.revenueBtn.Click += new System.EventHandler(this.revenueBtn_Click);
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.revenueBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button orderBtn;
        private Button logoutBtn;
        private Label label1;
        private Button revenueBtn;
    }
}