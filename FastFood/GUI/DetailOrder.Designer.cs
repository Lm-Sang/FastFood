using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFood.GUI
{
    partial class DetailOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.detail_orderDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detail_orderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(244, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label3.Location = new System.Drawing.Point(40, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer phone number:";
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nametextBox.Location = new System.Drawing.Point(258, 47);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(256, 30);
            this.nametextBox.TabIndex = 3;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.phonetextBox.Location = new System.Drawing.Point(258, 76);
            this.phonetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(256, 30);
            this.phonetextBox.TabIndex = 4;
            // 
            // detail_orderDGV
            // 
            this.detail_orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail_orderDGV.Location = new System.Drawing.Point(-2, 105);
            this.detail_orderDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detail_orderDGV.Name = "detail_orderDGV";
            this.detail_orderDGV.RowHeadersWidth = 51;
            this.detail_orderDGV.Size = new System.Drawing.Size(676, 218);
            this.detail_orderDGV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(328, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity:";
            // 
            // totaltextBox
            // 
            this.totaltextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.totaltextBox.Location = new System.Drawing.Point(60, 334);
            this.totaltextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(256, 30);
            this.totaltextBox.TabIndex = 8;
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quantitytextBox.Location = new System.Drawing.Point(410, 334);
            this.quantitytextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(256, 30);
            this.quantitytextBox.TabIndex = 9;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(580, 10);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 34);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // DetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 360);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.quantitytextBox);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detail_orderDGV);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DetailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailOrder";
            this.Load += new System.EventHandler(this.DetailOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detail_orderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nametextBox;
        private TextBox phonetextBox;
        private DataGridView detail_orderDGV;
        private Label label4;
        private Label label5;
        private TextBox totaltextBox;
        private TextBox quantitytextBox;
        private Button backBtn;
    }
}