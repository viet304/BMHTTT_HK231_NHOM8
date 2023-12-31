namespace NHOM_QLTTBV.BenhNhan
{
    partial class FormMain_BN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BN));
            panelChildForm_KH = new Panel();
            panelMenu = new Panel();
            button1 = new Button();
            panel_username = new Panel();
            label1 = new Label();
            btn_logout = new Button();
            label_username = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panel_username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelChildForm_KH
            // 
            panelChildForm_KH.BackgroundImage = Properties.Resources._360_F_216472247_cT66WDoS0fp1s3wC7eaykMJNDGVbOBPq;
            panelChildForm_KH.BackgroundImageLayout = ImageLayout.Zoom;
            panelChildForm_KH.BorderStyle = BorderStyle.Fixed3D;
            panelChildForm_KH.Dock = DockStyle.Fill;
            panelChildForm_KH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelChildForm_KH.Location = new Point(158, 0);
            panelChildForm_KH.Margin = new Padding(3, 2, 3, 2);
            panelChildForm_KH.Name = "panelChildForm_KH";
            panelChildForm_KH.Size = new Size(788, 630);
            panelChildForm_KH.TabIndex = 3;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 39, 58);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panel_username);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(158, 630);
            panelMenu.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 39, 58);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 125);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(158, 44);
            button1.TabIndex = 24;
            button1.Text = "Xem thông tin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel_username.Margin = new Padding(3, 2, 3, 2);
            panel_username.Name = "panel_username";
            panel_username.Size = new Size(158, 125);
            panel_username.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 10;
            label1.Text = "Bệnh Nhân";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(86, 187, 241);
            btn_logout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.Location = new Point(27, 86);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(104, 28);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label_username
            // 
            label_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.Location = new Point(10, 57);
            label_username.Name = "label_username";
            label_username.Size = new Size(143, 21);
            label_username.TabIndex = 1;
            label_username.Text = "No User";
            label_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormMain_BN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 630);
            Controls.Add(panelChildForm_KH);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain_BN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain_BN";
            panelMenu.ResumeLayout(false);
            panel_username.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildForm_KH;
        private Panel panelMenu;
        private Button button1;
        private Panel panel_username;
        private Button btn_logout;
        private Label label_username;
        private Label label1;
        private PictureBox pictureBox1;
    }
}