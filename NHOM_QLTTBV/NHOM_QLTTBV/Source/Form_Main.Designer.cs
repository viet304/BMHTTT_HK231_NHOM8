using System.Windows.Forms;

namespace NHOM_QLTTBV
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            panelMenu = new Panel();
            btn_xemaudit = new Button();
            btn_themdulieu_CSYT_NV = new Button();
            btn_revokePrivileges = new Button();
            btn_grantRole_toUser = new Button();
            btn_grantPrivileges = new Button();
            btn_deleteRole = new Button();
            btn_addrole = new Button();
            btn_EditUser = new Button();
            btn_deleteUser = new Button();
            btn_adduser = new Button();
            button2 = new Button();
            button1 = new Button();
            panel_username = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_logout = new Button();
            label_username = new Label();
            panelChildForm_KH = new Panel();
            panelMenu.SuspendLayout();
            panel_username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(39, 39, 58);
            panelMenu.Controls.Add(btn_xemaudit);
            panelMenu.Controls.Add(btn_themdulieu_CSYT_NV);
            panelMenu.Controls.Add(btn_revokePrivileges);
            panelMenu.Controls.Add(btn_grantRole_toUser);
            panelMenu.Controls.Add(btn_grantPrivileges);
            panelMenu.Controls.Add(btn_deleteRole);
            panelMenu.Controls.Add(btn_addrole);
            panelMenu.Controls.Add(btn_EditUser);
            panelMenu.Controls.Add(btn_deleteUser);
            panelMenu.Controls.Add(btn_adduser);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panel_username);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(240, 900);
            panelMenu.TabIndex = 0;
            // 
            // btn_xemaudit
            // 
            btn_xemaudit.BackColor = Color.FromArgb(39, 39, 58);
            btn_xemaudit.Dock = DockStyle.Top;
            btn_xemaudit.FlatAppearance.BorderSize = 0;
            btn_xemaudit.FlatStyle = FlatStyle.Flat;
            btn_xemaudit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xemaudit.ForeColor = Color.White;
            btn_xemaudit.Location = new Point(0, 831);
            btn_xemaudit.Name = "btn_xemaudit";
            btn_xemaudit.Size = new Size(240, 59);
            btn_xemaudit.TabIndex = 35;
            btn_xemaudit.Text = "Xem AUDIT";
            btn_xemaudit.UseVisualStyleBackColor = false;
            btn_xemaudit.Click += btn_xemaudit_Click;
            // 
            // btn_themdulieu_CSYT_NV
            // 
            btn_themdulieu_CSYT_NV.BackColor = Color.FromArgb(39, 39, 58);
            btn_themdulieu_CSYT_NV.Dock = DockStyle.Top;
            btn_themdulieu_CSYT_NV.FlatAppearance.BorderSize = 0;
            btn_themdulieu_CSYT_NV.FlatStyle = FlatStyle.Flat;
            btn_themdulieu_CSYT_NV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_themdulieu_CSYT_NV.ForeColor = Color.White;
            btn_themdulieu_CSYT_NV.Location = new Point(0, 772);
            btn_themdulieu_CSYT_NV.Name = "btn_themdulieu_CSYT_NV";
            btn_themdulieu_CSYT_NV.Size = new Size(240, 59);
            btn_themdulieu_CSYT_NV.TabIndex = 34;
            btn_themdulieu_CSYT_NV.Text = "Thêm dữ liệu CSYT, NHANVIEN";
            btn_themdulieu_CSYT_NV.UseVisualStyleBackColor = false;
            btn_themdulieu_CSYT_NV.Click += btn_themdulieu_CSYT_NV_Click;
            // 
            // btn_revokePrivileges
            // 
            btn_revokePrivileges.BackColor = Color.FromArgb(39, 39, 58);
            btn_revokePrivileges.Dock = DockStyle.Top;
            btn_revokePrivileges.FlatAppearance.BorderSize = 0;
            btn_revokePrivileges.FlatStyle = FlatStyle.Flat;
            btn_revokePrivileges.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_revokePrivileges.ForeColor = Color.White;
            btn_revokePrivileges.Location = new Point(0, 713);
            btn_revokePrivileges.Name = "btn_revokePrivileges";
            btn_revokePrivileges.Size = new Size(240, 59);
            btn_revokePrivileges.TabIndex = 33;
            btn_revokePrivileges.Text = "Revoke Privileges";
            btn_revokePrivileges.UseVisualStyleBackColor = false;
            btn_revokePrivileges.Click += btn_revokePrivileges_Click;
            // 
            // btn_grantRole_toUser
            // 
            btn_grantRole_toUser.BackColor = Color.FromArgb(39, 39, 58);
            btn_grantRole_toUser.Dock = DockStyle.Top;
            btn_grantRole_toUser.FlatAppearance.BorderSize = 0;
            btn_grantRole_toUser.FlatStyle = FlatStyle.Flat;
            btn_grantRole_toUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_grantRole_toUser.ForeColor = Color.White;
            btn_grantRole_toUser.Location = new Point(0, 654);
            btn_grantRole_toUser.Name = "btn_grantRole_toUser";
            btn_grantRole_toUser.Size = new Size(240, 59);
            btn_grantRole_toUser.TabIndex = 32;
            btn_grantRole_toUser.Text = "Grant Role To User";
            btn_grantRole_toUser.UseVisualStyleBackColor = false;
            btn_grantRole_toUser.Click += btn_grantRole_toUser_Click;
            // 
            // btn_grantPrivileges
            // 
            btn_grantPrivileges.BackColor = Color.FromArgb(39, 39, 58);
            btn_grantPrivileges.Dock = DockStyle.Top;
            btn_grantPrivileges.FlatAppearance.BorderSize = 0;
            btn_grantPrivileges.FlatStyle = FlatStyle.Flat;
            btn_grantPrivileges.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_grantPrivileges.ForeColor = Color.White;
            btn_grantPrivileges.Location = new Point(0, 579);
            btn_grantPrivileges.Name = "btn_grantPrivileges";
            btn_grantPrivileges.Size = new Size(240, 75);
            btn_grantPrivileges.TabIndex = 31;
            btn_grantPrivileges.Text = "Grant Privileges To User/Role";
            btn_grantPrivileges.UseVisualStyleBackColor = false;
            btn_grantPrivileges.Click += btn_grantPrivileges_Click;
            // 
            // btn_deleteRole
            // 
            btn_deleteRole.BackColor = Color.FromArgb(39, 39, 58);
            btn_deleteRole.Dock = DockStyle.Top;
            btn_deleteRole.FlatAppearance.BorderSize = 0;
            btn_deleteRole.FlatStyle = FlatStyle.Flat;
            btn_deleteRole.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deleteRole.ForeColor = Color.White;
            btn_deleteRole.Location = new Point(0, 520);
            btn_deleteRole.Name = "btn_deleteRole";
            btn_deleteRole.Size = new Size(240, 59);
            btn_deleteRole.TabIndex = 30;
            btn_deleteRole.Text = "Delete Role";
            btn_deleteRole.UseVisualStyleBackColor = false;
            btn_deleteRole.Click += btn_deleteRole_Click;
            // 
            // btn_addrole
            // 
            btn_addrole.BackColor = Color.FromArgb(39, 39, 58);
            btn_addrole.Dock = DockStyle.Top;
            btn_addrole.FlatAppearance.BorderSize = 0;
            btn_addrole.FlatStyle = FlatStyle.Flat;
            btn_addrole.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addrole.ForeColor = Color.White;
            btn_addrole.Location = new Point(0, 461);
            btn_addrole.Name = "btn_addrole";
            btn_addrole.Size = new Size(240, 59);
            btn_addrole.TabIndex = 29;
            btn_addrole.Text = "Add Role";
            btn_addrole.UseVisualStyleBackColor = false;
            btn_addrole.Click += btn_addrole_Click;
            // 
            // btn_EditUser
            // 
            btn_EditUser.BackColor = Color.FromArgb(39, 39, 58);
            btn_EditUser.Dock = DockStyle.Top;
            btn_EditUser.FlatAppearance.BorderSize = 0;
            btn_EditUser.FlatStyle = FlatStyle.Flat;
            btn_EditUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_EditUser.ForeColor = Color.White;
            btn_EditUser.Location = new Point(0, 402);
            btn_EditUser.Name = "btn_EditUser";
            btn_EditUser.Size = new Size(240, 59);
            btn_EditUser.TabIndex = 28;
            btn_EditUser.Text = "Edit User";
            btn_EditUser.UseVisualStyleBackColor = false;
            btn_EditUser.Click += btn_EditUser_Click;
            // 
            // btn_deleteUser
            // 
            btn_deleteUser.BackColor = Color.FromArgb(39, 39, 58);
            btn_deleteUser.Dock = DockStyle.Top;
            btn_deleteUser.FlatAppearance.BorderSize = 0;
            btn_deleteUser.FlatStyle = FlatStyle.Flat;
            btn_deleteUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deleteUser.ForeColor = Color.White;
            btn_deleteUser.Location = new Point(0, 343);
            btn_deleteUser.Name = "btn_deleteUser";
            btn_deleteUser.Size = new Size(240, 59);
            btn_deleteUser.TabIndex = 27;
            btn_deleteUser.Text = "Delete User";
            btn_deleteUser.UseVisualStyleBackColor = false;
            btn_deleteUser.Click += btn_deleteUser_Click;
            // 
            // btn_adduser
            // 
            btn_adduser.BackColor = Color.FromArgb(39, 39, 58);
            btn_adduser.Dock = DockStyle.Top;
            btn_adduser.FlatAppearance.BorderSize = 0;
            btn_adduser.FlatStyle = FlatStyle.Flat;
            btn_adduser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_adduser.ForeColor = Color.White;
            btn_adduser.Location = new Point(0, 284);
            btn_adduser.Name = "btn_adduser";
            btn_adduser.Size = new Size(240, 59);
            btn_adduser.TabIndex = 26;
            btn_adduser.Text = "Add User";
            btn_adduser.UseVisualStyleBackColor = false;
            btn_adduser.Click += btn_adduser_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(39, 39, 58);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 225);
            button2.Name = "button2";
            button2.Size = new Size(240, 59);
            button2.TabIndex = 25;
            button2.Text = "Check Privileges ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_To_FormCheckPrivileges;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 39, 58);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 166);
            button1.Name = "button1";
            button1.Size = new Size(240, 59);
            button1.TabIndex = 24;
            button1.Text = "Users List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Form_ShowUsers;
            // 
            // panel_username
            // 
            panel_username.BackColor = Color.Gainsboro;
            panel_username.Controls.Add(pictureBox1);
            panel_username.Controls.Add(label1);
            panel_username.Controls.Add(btn_logout);
            panel_username.Controls.Add(label_username);
            panel_username.Dock = DockStyle.Top;
            panel_username.Location = new Point(0, 0);
            panel_username.Name = "panel_username";
            panel_username.Size = new Size(240, 166);
            panel_username.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 10;
            label1.Text = "DBA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(86, 187, 241);
            btn_logout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.Location = new Point(61, 115);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(118, 37);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label_username
            // 
            label_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.Location = new Point(2, 76);
            label_username.Name = "label_username";
            label_username.Size = new Size(237, 28);
            label_username.TabIndex = 1;
            label_username.Text = "No User";
            label_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelChildForm_KH
            // 
            panelChildForm_KH.BackColor = Color.Gainsboro;
            panelChildForm_KH.BackgroundImage = (Image)resources.GetObject("panelChildForm_KH.BackgroundImage");
            panelChildForm_KH.BackgroundImageLayout = ImageLayout.Stretch;
            panelChildForm_KH.BorderStyle = BorderStyle.Fixed3D;
            panelChildForm_KH.Dock = DockStyle.Fill;
            panelChildForm_KH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelChildForm_KH.Location = new Point(240, 0);
            panelChildForm_KH.Name = "panelChildForm_KH";
            panelChildForm_KH.Size = new Size(842, 900);
            panelChildForm_KH.TabIndex = 1;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1082, 900);
            Controls.Add(panelChildForm_KH);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form_Main_FormClosing;
            Load += Form_Main_Load;
            panelMenu.ResumeLayout(false);
            panel_username.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel_username;
        private Label label_username;
        private Button btn_deleteRole;
        private Button btn_addrole;
        private Button btn_EditUser;
        private Button btn_deleteUser;
        private Button btn_adduser;
        private Button button2;
        private Button button1;
        private Button btn_revokePrivileges;
        private Button btn_grantRole_toUser;
        private Button btn_grantPrivileges;
        private Panel panelChildForm_KH;
        private Button btn_logout;
        private Label label1;
        private Button btn_themdulieu_CSYT_NV;
        private Button btn_xemaudit;
        private PictureBox pictureBox1;
    }
}