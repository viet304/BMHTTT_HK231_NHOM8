﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM_QLTTBV
{
    public partial class Form_GrantPrivileges : Form
    {
        DataTable DT_AllPrivileges = new DataTable(); // bảng chứa dữ liệu tất cả các quyền của 1 user
        String username = "", dbname = "";

        DataGridViewTextBoxColumn dgvc_TableName = new DataGridViewTextBoxColumn();
        string[] columnName = new string[] { "Select", "Select (WITH GRANT OPTION)",
                "Insert", "Insert (WITH GRANT OPTION)"
            ,"Update", "Update (WITH GRANT OPTION)"
            ,"Delete", "Delete (WITH GRANT OPTION)" , ""};


        DataTable all_TableName;
        DataTable all_privilegesOnTable;

        string checkUserOrRole;

        public Form_GrantPrivileges(String un, String dn)
        {
            this.username = un;
            this.dbname = dn;
            InitializeComponent();
        }

        private void init_Data()
        {
            // set font 
            dgv_privileges.Font = new Font("Segoe UI", 12);

            // tạo các cột

            dgvc_TableName.HeaderText = "Table Name";
            dgv_privileges.Columns.Add(dgvc_TableName);


            for (int i = 0; i < columnName.Length; i++)
            {
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.HeaderText = columnName[i];
                dgv_privileges.Columns.Add(dgvCmb);
            }

            // lấy tên tất cả bảng
            all_TableName = Functions.GetAll_TableName(dbname);


            for (int i = 0; i < all_TableName.Rows.Count; i++)
            {
                dgv_privileges.Rows.Add(all_TableName.Rows[i].Field<string>(0), false, false,
                false, false,
                false, false,
                false, false);
            }

            // set kích thước cột
            dgv_privileges.Columns[0].Width = 200;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_privileges.AllowUserToAddRows = false;
            
        }

        private void btn_checkUserOrRole_Click(object sender, EventArgs e)
        {
            // kiem tra co phai owner
            if (dbname.Equals(tb_userOrRoleName.Text.Trim()))
            {
                dgv_privileges.Rows.Clear();
                for (int i = 0; i < all_TableName.Rows.Count; i++)
                {
                    dgv_privileges.Rows.Add(all_TableName.Rows[i].Field<string>(0), true, true,
                    true, true,
                    true, true,
                    true, true);
                }
                return;
            }

            dgv_privileges.Rows.Clear();

            // Ktra xem user/role co ton tai hay khong
            String userOrRole_name = tb_userOrRoleName.Text.Trim().ToUpper();
            String res = Functions.CheckIfUserOrRoleExist(userOrRole_name);
            checkUserOrRole = res;
            if (res == "NoExist")
            {
                MessageBox.Show("User hoac Role khong ton tai trong he thong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hien thi cac quyen ma user/role dang co
            all_privilegesOnTable = Functions.GetPrivilegeOnTable(userOrRole_name);

            for (int i = 0; i < all_TableName.Rows.Count; i++)
            {
                bool select = false, select_withGrantOption = false,
                    insert = false, insert_withGrantOption = false,
                    update = false, update_withGrantOption = false,
                    delete = false, delete_withGrantOption = false;


                foreach (DataRow row in all_privilegesOnTable.Rows)
                {
                    String table_name = row["TABLE_NAME"].ToString();
                    String privilege = row["PRIVILEGE"].ToString();
                    String grantable = row["GRANTABLE"].ToString();
                    if (table_name.Equals(all_TableName.Rows[i].Field<string>(0)))
                    {
                        if (privilege == "SELECT")
                        {
                            select = true;
                            if (grantable == "YES")
                                select_withGrantOption = true;
                        }
                        if (privilege == "INSERT")
                        {
                            insert = true;
                            if (grantable == "YES")
                                insert_withGrantOption = true;
                        }
                        if (privilege == "UPDATE")
                        {
                            update = true;
                            if (grantable == "YES")
                                update_withGrantOption = true;
                        }
                        if (privilege == "DELETE")
                        {
                            delete = true;
                            if (grantable == "YES")
                                delete_withGrantOption = true;
                        }
                    }
                }

                dgv_privileges.Rows.Add(all_TableName.Rows[i].Field<string>(0), select, select_withGrantOption,
                    insert, insert_withGrantOption,
                    update, update_withGrantOption,
                    delete, delete_withGrantOption);
            }

            // set kích thước cột
            dgv_privileges.Columns[0].Width = 200;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_privileges.AllowUserToAddRows = false;


        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // kiem tra co phai owner
            if (dbname.Equals(tb_userOrRoleName.Text.Trim()))
            {
                MessageBox.Show("Khong the cap nhat vi user nay la Owner cua cac bang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

                //Ktra xem nguoi dung co nhap ten user/role vao chua?
            if (tb_userOrRoleName.Text.Trim() == "")
            {
                MessageBox.Show("Hay nhap ten cua user/role", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string userOrRole_name = tb_userOrRoleName.Text.Trim();

            //Cap nhat lai quyen cua user/role
            string[] privName = new string[] { "A", "SELECT", "SELECT",
                "INSERT", "INSERT"
            ,"UPDATE", "UPDATE"
            ,"DELETE", "DELETE"};


            for (int i = 0; i < dgv_privileges.Rows.Count; i++)
            {

                string table_name = (string)dgv_privileges.Rows[i].Cells[0].Value;
                for (int j = 1; j < columnName.Length; j++)
                {
                    //Neu la quyen WITH GRANT OPTION va dang xet la Role thi bo qua
                    if (j % 2 == 0 && checkUserOrRole == "Role")
                        continue;

                    string priv = privName[j];

                    bool isChecked = (bool)dgv_privileges.Rows[i].Cells[j].Value;

                    //Ktra xem quyen nay co thuoc ve user/role dang xet hay khong
                    string privIsExist;
                    string grant_opt;
                    if (checkUserOrRole == "Role")
                        grant_opt = "NO";
                    else if (j % 2 == 0)
                        grant_opt = "YES";
                    else
                        grant_opt = "NO";

                    if (checkUserOrRole == "User")
                    {
                        privIsExist = Functions.CheckIfPrivilegeBelongToUser(userOrRole_name, table_name, priv, grant_opt);
                    }
                    else
                    {
                        privIsExist = Functions.CheckIfPrivilegeBelongToRole(userOrRole_name, table_name, priv, grant_opt);
                    }

                    //Ktra xem neu nguoi dung bo tick quyen nay thi tien hanh revoke quyen khoi user/role
                    if (isChecked == false && privIsExist == "Yes")
                    {
                        Functions.RevokePrivilegeOnTable(table_name, userOrRole_name, priv);
                        continue;
                    }

                    //Ktra neu nguoi dung tick quyen nay va quyen nay chua dc grant cho user/role thi tien hanh grant quyen vao
                    if (isChecked == true && privIsExist == "No")
                    {
                        if (checkUserOrRole == "Role")
                        {
                            Functions.GrantPrivilegeOnTable(table_name, userOrRole_name, priv, "");
                        }
                        else if (j % 2 == 0)
                        {
                            Functions.GrantPrivilegeOnTable(table_name, userOrRole_name, priv, "WITH GRANT OPTION");
                        }
                        else
                        {
                            Functions.GrantPrivilegeOnTable(table_name, userOrRole_name, priv, "");
                        }

                    }
                }
            }

            MessageBox.Show("Cap nhat quyen thanh cong !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form_GrantPrivileges_Load(object sender, EventArgs e)
        {
            init_Data();
           
        }

    }
}
