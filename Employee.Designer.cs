namespace WinFormsApp2
{
    partial class Employee
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
            txtContact = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnClear = new Button();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNic = new TextBox();
            dataGridEmployee = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label4 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            SuspendLayout();
            // 
            // txtContact
            // 
            txtContact.Location = new Point(198, 250);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(264, 27);
            txtContact.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 292);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 23;
            label7.Text = "NIC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 292);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 208);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(294, 372);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(195, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(198, 150);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 27);
            txtName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 157);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 15;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 255);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 14;
            label2.Text = "Contact";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 20F);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 13;
            label1.Text = "Employee";
            // 
            // txtNic
            // 
            txtNic.Location = new Point(198, 292);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(264, 27);
            txtNic.TabIndex = 25;
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployee.Location = new Point(518, 50);
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.RowHeadersWidth = 51;
            dataGridEmployee.Size = new Size(430, 379);
            dataGridEmployee.TabIndex = 26;
            dataGridEmployee.CellClick += dataGridEmployee_CellClick;
            dataGridEmployee.CellContentClick += dataGridEmployee_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(144, 372);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(144, 419);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(294, 419);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 101);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 30;
            label4.Text = "id";
            label4.Click += label4_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(195, 94);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(264, 27);
            txtId.TabIndex = 31;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 463);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridEmployee);
            Controls.Add(txtNic);
            Controls.Add(txtContact);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContact;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnClear;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNic;
        private DataGridView dataGridEmployee;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
        private TextBox txtId;
    }
}