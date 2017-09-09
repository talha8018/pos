namespace POS
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.btn_user_delete = new System.Windows.Forms.Button();
            this.btn_editUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_user
            // 
            this.btn_add_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_user.Location = new System.Drawing.Point(520, 274);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(75, 23);
            this.btn_add_user.TabIndex = 2;
            this.btn_add_user.Text = "Add User";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // dgv_users
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgv_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(12, 12);
            this.dgv_users.MultiSelect = false;
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(583, 245);
            this.dgv_users.TabIndex = 3;
            // 
            // btn_user_delete
            // 
            this.btn_user_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_user_delete.Location = new System.Drawing.Point(12, 274);
            this.btn_user_delete.Name = "btn_user_delete";
            this.btn_user_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_user_delete.TabIndex = 4;
            this.btn_user_delete.Text = "Delete";
            this.btn_user_delete.UseVisualStyleBackColor = true;
            this.btn_user_delete.Click += new System.EventHandler(this.btn_user_delete_Click);
            // 
            // btn_editUser
            // 
            this.btn_editUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editUser.Location = new System.Drawing.Point(93, 274);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(75, 23);
            this.btn_editUser.TabIndex = 5;
            this.btn_editUser.Text = "Edit";
            this.btn_editUser.UseVisualStyleBackColor = true;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 309);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.btn_user_delete);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.btn_add_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Button btn_user_delete;
        private System.Windows.Forms.Button btn_editUser;
    }
}