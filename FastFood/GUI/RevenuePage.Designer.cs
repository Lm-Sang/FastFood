using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFood.GUI
{
    partial class RevenuePage
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
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.detailBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.customer_phonetextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customer_nametextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.revenueDGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.total_ordertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.total_revenuetextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(667, 6);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 23);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.statuscomboBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.detailBtn);
            this.groupBox2.Controls.Add(this.updateBtn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.customer_phonetextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.customer_nametextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.idtextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(767, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(221, 370);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(67, 252);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 34);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Items.AddRange(new object[] {
            "PENDING",
            "CANCEL",
            "PAID"});
            this.statuscomboBox.Location = new System.Drawing.Point(6, 186);
            this.statuscomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(209, 24);
            this.statuscomboBox.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Order\'s Information";
            // 
            // detailBtn
            // 
            this.detailBtn.Location = new System.Drawing.Point(116, 213);
            this.detailBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(94, 34);
            this.detailBtn.TabIndex = 19;
            this.detailBtn.Text = "Detail";
            this.detailBtn.UseVisualStyleBackColor = true;
            this.detailBtn.Click += new System.EventHandler(this.detailBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 213);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 34);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Status";
            // 
            // customer_phonetextBox
            // 
            this.customer_phonetextBox.Location = new System.Drawing.Point(6, 142);
            this.customer_phonetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_phonetextBox.Name = "customer_phonetextBox";
            this.customer_phonetextBox.ReadOnly = true;
            this.customer_phonetextBox.Size = new System.Drawing.Size(210, 22);
            this.customer_phonetextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Customer phone number";
            // 
            // customer_nametextBox
            // 
            this.customer_nametextBox.Location = new System.Drawing.Point(6, 99);
            this.customer_nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_nametextBox.Name = "customer_nametextBox";
            this.customer_nametextBox.ReadOnly = true;
            this.customer_nametextBox.Size = new System.Drawing.Size(210, 22);
            this.customer_nametextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Customer name";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(6, 54);
            this.idtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.ReadOnly = true;
            this.idtextBox.Size = new System.Drawing.Size(210, 22);
            this.idtextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID";
            // 
            // revenueDGV
            // 
            this.revenueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenueDGV.Location = new System.Drawing.Point(0, 57);
            this.revenueDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revenueDGV.Name = "revenueDGV";
            this.revenueDGV.RowHeadersWidth = 51;
            this.revenueDGV.Size = new System.Drawing.Size(767, 283);
            this.revenueDGV.TabIndex = 18;
            this.revenueDGV.SelectionChanged += new System.EventHandler(this.revenueDGV_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label12.Location = new System.Drawing.Point(5, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Start Date";
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(667, 30);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(94, 23);
            this.viewBtn.TabIndex = 22;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(85, 30);
            this.startDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(250, 22);
            this.startDate.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(341, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "End Date";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(411, 30);
            this.endDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(250, 22);
            this.endDate.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(3, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total Order:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // total_ordertextBox
            // 
            this.total_ordertextBox.Location = new System.Drawing.Point(85, 351);
            this.total_ordertextBox.Name = "total_ordertextBox";
            this.total_ordertextBox.ReadOnly = true;
            this.total_ordertextBox.Size = new System.Drawing.Size(228, 22);
            this.total_ordertextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(321, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total Revenue:";
            // 
            // total_revenuetextBox
            // 
            this.total_revenuetextBox.Location = new System.Drawing.Point(434, 350);
            this.total_revenuetextBox.Name = "total_revenuetextBox";
            this.total_revenuetextBox.ReadOnly = true;
            this.total_revenuetextBox.Size = new System.Drawing.Size(227, 22);
            this.total_revenuetextBox.TabIndex = 30;
            // 
            // RevenuePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 378);
            this.Controls.Add(this.total_revenuetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_ordertextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.revenueDGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RevenuePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevenuePage";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backBtn;
        private GroupBox groupBox2;
        private Label label14;
        private Button detailBtn;
        private Button updateBtn;
        private Label label9;
        private TextBox customer_phonetextBox;
        private Label label8;
        private TextBox customer_nametextBox;
        private Label label7;
        private TextBox idtextBox;
        private Label label6;
        private DataGridView revenueDGV;
        private Label label12;
        private Button viewBtn;
        private DateTimePicker startDate;
        private Label label1;
        private DateTimePicker endDate;
        private ComboBox statuscomboBox;
        private Button deleteBtn;
        private Label label2;
        private TextBox total_ordertextBox;
        private Label label3;
        private TextBox total_revenuetextBox;
    }
}