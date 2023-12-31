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
    public partial class Form_Login : Form
    {
        Thread t;
        String username = "", password = "";
        String owner = "U_AD";
        String nhanvien = "NHANVIEN_";
        String thanhtra = "THANHTRA_";
        String benhnhan = "BENHNHAN_";
        String bacsi = "BACSI_";
        String csyt = "CSYT_";
        String ybacsi = "YBACSI_";
        String nghiencuu = "NGHIENCUU_";

        public Form_Login()
        {
            InitializeComponent();          
        }

        // xử lí mở form main
        public void open_FormMain(object obj)
        {
            
            Application.Run(new Form_Main(username, password, owner));
        }

        public void open_FormMainNV(object obj)
        {
            
            Application.Run(new NHOM_QLTTBV.NhanVien.FormMain_NV(username, owner));
        }

        public void open_FormMainBN(object obj)
        {
            
            Application.Run(new NHOM_QLTTBV.BenhNhan.FormMain_BN(username,owner));
        }
        public void open_FormMainBS(object obj)
        {

            Application.Run(new NHOM_QLTTBV.BacSi.FormMain_BS(username, owner));
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // xử lí login
            username = txtbox_usename.Text.Trim();
            password = txtbox_password.Text.Trim();

            if( Login(username, password) == 0)
            {
                return;
            }
            
            // U_AD thì xử lí mở main
            if (username.Contains(owner))
            {
                this.Close();
                t = new Thread(open_FormMain);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }

            // NV 
            else if (username.Contains(nhanvien) || username.Contains(thanhtra) 
                || username.Contains(csyt)             
                || username.Contains(nghiencuu))
            {
                this.Close();
                t = new Thread(open_FormMainNV);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else if (username.Contains(ybacsi) || username.Contains(bacsi))
            {
                this.Close();
                t = new Thread(open_FormMainBS);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }

            // BN
            else if (username.Contains(benhnhan))
            {
                this.Close();
                t = new Thread(open_FormMainBN);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }


        private int Login(String username, String password)
        {
            try
            {            
                Functions.InitConnection(username, password);
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
                //throw new Exception(ex.Message);
            }
        }
    }
}
