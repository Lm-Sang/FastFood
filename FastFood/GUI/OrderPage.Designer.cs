using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFood.GUI
{
    partial class OrderPage
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
            this.foodDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amounttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_phonetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customer_nametextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.name_findtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // foodDGV
            // 
            this.foodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDGV.Location = new System.Drawing.Point(228, 56);
            this.foodDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodDGV.Name = "foodDGV";
            this.foodDGV.RowHeadersWidth = 51;
            this.foodDGV.Size = new System.Drawing.Size(472, 316);
            this.foodDGV.TabIndex = 18;
            this.foodDGV.SelectionChanged += new System.EventHandler(this.foodDGV_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(5, 99);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.ReadOnly = true;
            this.nametextBox.Size = new System.Drawing.Size(210, 22);
            this.nametextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(5, 54);
            this.idtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.ReadOnly = true;
            this.idtextBox.Size = new System.Drawing.Size(210, 22);
            this.idtextBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(103, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Detail Order";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(179, 330);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(146, 34);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(6, 330);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(155, 34);
            this.createBtn.TabIndex = 18;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(0, 267);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(221, 32);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(5, 142);
            this.pricetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.ReadOnly = true;
            this.pricetextBox.Size = new System.Drawing.Size(210, 22);
            this.pricetextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amounttextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.quantitytextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.pricetextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(221, 370);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // amounttextBox
            // 
            this.amounttextBox.Location = new System.Drawing.Point(6, 238);
            this.amounttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amounttextBox.Name = "amounttextBox";
            this.amounttextBox.Size = new System.Drawing.Size(210, 22);
            this.amounttextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amount";
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(6, 192);
            this.quantitytextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.ReadOnly = true;
            this.quantitytextBox.Size = new System.Drawing.Size(210, 22);
            this.quantitytextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food ID";
            // 
            // customer_phonetextBox
            // 
            this.customer_phonetextBox.Location = new System.Drawing.Point(8, 94);
            this.customer_phonetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_phonetextBox.Name = "customer_phonetextBox";
            this.customer_phonetextBox.Size = new System.Drawing.Size(311, 22);
            this.customer_phonetextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Customer phone number";
            // 
            // customer_nametextBox
            // 
            this.customer_nametextBox.Location = new System.Drawing.Point(8, 54);
            this.customer_nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_nametextBox.Name = "customer_nametextBox";
            this.customer_nametextBox.Size = new System.Drawing.Size(311, 22);
            this.customer_nametextBox.TabIndex = 4;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(595, 2);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 23);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(595, 30);
            this.findBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(94, 23);
            this.findBtn.TabIndex = 23;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // name_findtextBox
            // 
            this.name_findtextBox.Location = new System.Drawing.Point(320, 30);
            this.name_findtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_findtextBox.Name = "name_findtextBox";
            this.name_findtextBox.Size = new System.Drawing.Size(232, 22);
            this.name_findtextBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.orderDGV);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.createBtn);
            this.groupBox2.Controls.Add(this.totaltextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.customer_phonetextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.customer_nametextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(706, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(325, 370);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // orderDGV
            // 
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Location = new System.Drawing.Point(8, 124);
            this.orderDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.RowHeadersWidth = 51;
            this.orderDGV.Size = new System.Drawing.Size(311, 175);
            this.orderDGV.TabIndex = 21;
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(70, 304);
            this.totaltextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.ReadOnly = true;
            this.totaltextBox.Size = new System.Drawing.Size(255, 22);
            this.totaltextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total";
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 380);
            this.Controls.Add(this.foodDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.name_findtextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPage";
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView foodDGV;
        private Label label3;
        private TextBox nametextBox;
        private Label label2;
        private TextBox idtextBox;
        private Label label14;
        private Button deleteBtn;
        private Button createBtn;
        private Button addBtn;
        private TextBox pricetextBox;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox customer_phonetextBox;
        private Label label7;
        private TextBox customer_nametextBox;
        private Button backBtn;
        private Button findBtn;
        private TextBox name_findtextBox;
        private Label label12;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox totaltextBox;
        private Label label9;
        private TextBox amounttextBox;
        private Label label4;
        private TextBox quantitytextBox;
        private Label label5;
        private DataGridView orderDGV;
    }
}