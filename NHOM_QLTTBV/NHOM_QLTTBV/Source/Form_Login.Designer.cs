namespace NHOM_QLTTBV
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtbox_usename = new TextBox();
            txtbox_password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(152, 16);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-6, 64);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(392, 2);
            dataGridView1.TabIndex = 1;
            // 
            // txtbox_usename
            // 
            txtbox_usename.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_usename.Location = new Point(51, 118);
            txtbox_usename.Margin = new Padding(3, 2, 3, 2);
            txtbox_usename.Name = "txtbox_usename";
            txtbox_usename.Size = new Size(284, 31);
            txtbox_usename.TabIndex = 2;
            // 
            // txtbox_password
            // 
            txtbox_password.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_password.Location = new Point(51, 209);
            txtbox_password.Margin = new Padding(3, 2, 3, 2);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(284, 31);
            txtbox_password.TabIndex = 3;
            txtbox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(51, 94);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(51, 186);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DodgerBlue;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(113, 274);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(144, 41);
            btn_login.TabIndex = 8;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImageLayout = ImageLayout.Center;
            CancelButton = btn_login;
            ClientSize = new Size(383, 354);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_usename);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtbox_usename;
        private TextBox txtbox_password;
        private Label label2;
        private Label label3;
        private Button btn_login;
    }
}