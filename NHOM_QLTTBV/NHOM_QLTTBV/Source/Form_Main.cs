﻿using NHOM_QLTTBV.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NHOM_QLTTBV
{
    public partial class Form_Main : Form
    {
        Thread t;
        String username = "", password = "", dbname = "";
        public Form_Main(String un, String pw, String dn)
        {
            this.username = un;
            this.password = pw;
            this.dbname = dn;

            InitializeComponent();

            label_username.Text = username;
        }

        // mở 1 form con
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_KH.Controls.Add(childForm);
            panelChildForm_KH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        // xử lí đăng xuất + đăng nhập lại
        public void open_FormLogin(object obj)
        {
            Application.Run(new Form_Login());
        }

        private void Set_Center_Username()
        {
            int y = (panel_username.Height / 2) - (label_username.Height / 2);
            int x = (panel_username.Width / 2) - (label_username.Width / 2);
            label_username.Location = new Point(x, y-15);
           // label_welcome.Location = new Point(x,y-40);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //ScrollBar vScrollBar1 = new VScrollBar();
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) =>
            //{ panelMenu.VerticalScroll.Value = vScrollBar1.Value; };
            //panelMenu.Controls.Add(vScrollBar1);
            Set_Center_Username();
        }

        private void btn_grantPrivileges_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GrantPrivileges(username, dbname));
            ActivateButton(sender);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormLogin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.Disconnect();
        }

        private void btn_revokePrivileges_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_RevokeRolecs());
            ActivateButton(sender);
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_AddUser(dbname));
            ActivateButton(sender);
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DeleteUser());
            ActivateButton(sender);
        }
        
        private void btn_addrole_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_AddRole());
            ActivateButton(sender);
        }

        private void btn_deleteRole_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DeleteRole());
            ActivateButton(sender);
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_EditUser());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GrantRoleToUser());
            ActivateButton(sender);
        }

        private void button_Form_ShowUsers(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowUsers());
            ActivateButton(sender);
        }

        private void btn_themdulieu_CSYT_NV_Click(object sender, EventArgs e)
        {
            
            openChildForm(new NHOM_QLTTBV.Source.ThemDuLieu_CSYT_NV());
            ActivateButton(sender);
        }

        private void btn_xemaudit_Click(object sender, EventArgs e)
        {
            openChildForm(new NHOM_QLTTBV.Source.Form_xem_audit());
            ActivateButton(sender);
        }

        private void button_To_FormCheckPrivileges(object sender, EventArgs e)
        {
            openChildForm(new Form_CheckPrivilege());
            ActivateButton(sender);
        }

        private void btn_grantRole_toUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GrantRoleToUser());
            ActivateButton(sender);
        }

       
    }
}
