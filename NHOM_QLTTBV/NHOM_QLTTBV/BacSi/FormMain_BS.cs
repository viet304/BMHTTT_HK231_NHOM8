﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM_QLTTBV.BacSi
{
    public partial class FormMain_BS : Form
    {
        String username = "", dbname = "";
        Thread t;
        public FormMain_BS(String username, String dbname)
        {
            InitializeComponent();
            this.username = username;
            this.dbname = dbname;
            label_username.Text = username;
        }


        // xử lí đăng xuất + đăng nhập lại
        public void open_FormLogin(object obj)
        {
            Application.Run(new Form_Login());
        }

        private void FormMain_NV_Load(object sender, EventArgs e)
        {
            Set_Center_Username();
        }
        private void Set_Center_Username()
        {
            int y = (panel_username.Height / 2) - (label_username.Height / 2);
            int x = (panel_username.Width / 2) - (label_username.Width / 2);
            label_username.Location = new Point(x, y - 15);
            // label_welcome.Location = new Point(x,y-40);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //openChildForm(new NHOM_QLTTBV.BacSi.Form_xemTT());
            // ActivateButton(sender);

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormLogin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
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

        private void btn_hsba_Click_1(object sender, EventArgs e)
        {
            openChildForm(new NHOM_QLTTBV.BacSi.Form_HSBA(username, dbname));
            ActivateButton(sender);
        }

        private void btn_hsba_Click(object sender, EventArgs e)
        {
            openChildForm(new NHOM_QLTTBV.BacSi.Form_HSBA(username, dbname));
            ActivateButton(sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new NHOM_QLTTBV.BacSi.Form_HSBA_DV(username, dbname));
            ActivateButton(sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new NHOM_QLTTBV.BacSi.Form_HSBA_DV(username, dbname));
            ActivateButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NHOM_QLTTBV.BacSi.Form_TTBN(username, dbname));
            ActivateButton(sender);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new NHOM_QLTTBV.BacSi.Form_Profile(username, dbname));
            ActivateButton(sender);
        }

        private void FormMain_BS_Load(object sender, EventArgs e)
        {
            Set_Center_Username();
        }
    }
}

