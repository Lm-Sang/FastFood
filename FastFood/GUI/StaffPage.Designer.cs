using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFood.GUI
{
    partial class StaffPage
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
            this.staffDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.change_passwordBtn = new System.Windows.Forms.Button();
            this.confirm_passwordtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.new_passwordtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phone_inftextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.username_inftextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name_inftextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id_inftextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.name_findtextBox = new System.Windows.Forms.TextBox();
            this.phone_findtextBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffDGV
            // 
            this.staffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDGV.Location = new System.Drawing.Point(229, 63);
            this.staffDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffDGV.Name = "staffDGV";
            this.staffDGV.RowHeadersWidth = 51;
            this.staffDGV.Size = new System.Drawing.Size(630, 316);
            this.staffDGV.TabIndex = 0;
            this.staffDGV.SelectionChanged += new System.EventHandler(this.staffDGV_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.phonetextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usernametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(221, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(0, 234);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(221, 32);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(5, 186);
            this.phonetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(210, 22);
            this.phonetextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone number";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(5, 142);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(210, 22);
            this.passwordtextBox.TabIndex = 6;
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(5, 99);
            this.usernametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(210, 22);
            this.usernametextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(5, 54);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(210, 22);
            this.nametextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.updateBtn);
            this.groupBox2.Controls.Add(this.change_passwordBtn);
            this.groupBox2.Controls.Add(this.confirm_passwordtextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.new_passwordtextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.phone_inftextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.username_inftextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.name_inftextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.id_inftextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(865, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(221, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Staff\'s Information";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(116, 213);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 34);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(6, 213);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 34);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // change_passwordBtn
            // 
            this.change_passwordBtn.Location = new System.Drawing.Point(-5, 338);
            this.change_passwordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_passwordBtn.Name = "change_passwordBtn";
            this.change_passwordBtn.Size = new System.Drawing.Size(221, 32);
            this.change_passwordBtn.TabIndex = 17;
            this.change_passwordBtn.Text = "Change password";
            this.change_passwordBtn.UseVisualStyleBackColor = true;
            this.change_passwordBtn.Click += new System.EventHandler(this.change_passwordBtn_Click);
            // 
            // confirm_passwordtextBox
            // 
            this.confirm_passwordtextBox.Location = new System.Drawing.Point(0, 311);
            this.confirm_passwordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_passwordtextBox.Name = "confirm_passwordtextBox";
            this.confirm_passwordtextBox.Size = new System.Drawing.Size(210, 22);
            this.confirm_passwordtextBox.TabIndex = 14;
            this.confirm_passwordtextBox.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Confirm password";
            // 
            // new_passwordtextBox
            // 
            this.new_passwordtextBox.Location = new System.Drawing.Point(1, 268);
            this.new_passwordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_passwordtextBox.Name = "new_passwordtextBox";
            this.new_passwordtextBox.Size = new System.Drawing.Size(210, 22);
            this.new_passwordtextBox.TabIndex = 12;
            this.new_passwordtextBox.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "New password";
            // 
            // phone_inftextBox
            // 
            this.phone_inftextBox.Location = new System.Drawing.Point(6, 186);
            this.phone_inftextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_inftextBox.Name = "phone_inftextBox";
            this.phone_inftextBox.Size = new System.Drawing.Size(210, 22);
            this.phone_inftextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Phone number";
            // 
            // username_inftextBox
            // 
            this.username_inftextBox.Location = new System.Drawing.Point(6, 142);
            this.username_inftextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_inftextBox.Name = "username_inftextBox";
            this.username_inftextBox.Size = new System.Drawing.Size(210, 22);
            this.username_inftextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Username";
            // 
            // name_inftextBox
            // 
            this.name_inftextBox.Location = new System.Drawing.Point(6, 99);
            this.name_inftextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_inftextBox.Name = "name_inftextBox";
            this.name_inftextBox.Size = new System.Drawing.Size(210, 22);
            this.name_inftextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name";
            // 
            // id_inftextBox
            // 
            this.id_inftextBox.Location = new System.Drawing.Point(6, 54);
            this.id_inftextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_inftextBox.Name = "id_inftextBox";
            this.id_inftextBox.ReadOnly = true;
            this.id_inftextBox.Size = new System.Drawing.Size(210, 22);
            this.id_inftextBox.TabIndex = 4;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(441, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Phone Number";
            // 
            // name_findtextBox
            // 
            this.name_findtextBox.Location = new System.Drawing.Point(284, 39);
            this.name_findtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_findtextBox.Name = "name_findtextBox";
            this.name_findtextBox.Size = new System.Drawing.Size(151, 22);
            this.name_findtextBox.TabIndex = 5;
            // 
            // phone_findtextBox
            // 
            this.phone_findtextBox.Location = new System.Drawing.Point(555, 39);
            this.phone_findtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_findtextBox.Name = "phone_findtextBox";
            this.phone_findtextBox.Size = new System.Drawing.Size(157, 22);
            this.phone_findtextBox.TabIndex = 6;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(746, 38);
            this.findBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(94, 23);
            this.findBtn.TabIndex = 7;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(746, 10);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 396);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.phone_findtextBox);
            this.Controls.Add(this.name_findtextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.staffDGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffPage";
            ((System.ComponentModel.ISupportInitialize)(this.staffDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView staffDGV;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox phonetextBox;
        private Label label5;
        private TextBox confirm_passwordtextBox;
        private Label label4;
        private TextBox passwordtextBox;
        private Label label3;
        private TextBox usernametextBox;
        private Label label2;
        private TextBox nametextBox;
        private Label label1;
        private TextBox confirm_passwortextBox;
        private Label label11;
        private TextBox new_passwordtextBox;
        private Label label10;
        private TextBox phone_inftextBox;
        private Label label9;
        private TextBox username_inftextBox;
        private Label label8;
        private TextBox name_inftextBox;
        private Label label7;
        private TextBox id_inftextBox;
        private Label label6;
        private Button addBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button change_passwordBtn;
        private Label label12;
        private Label label13;
        private TextBox name_findtextBox;
        private TextBox phone_findtextBox;
        private Label label14;
        private Button findBtn;
        private Button backBtn;
    }
}