namespace _1_GUI_QLBH
{
    partial class frmDangNhap
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
            txtEmail = new TextBox();
            lblDN = new Label();
            lblEmail = new Label();
            lblMK = new Label();
            txtMK = new TextBox();
            btnDN = new Button();
            btnThoat = new Button();
            chknhoEmail = new CheckBox();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Font = new Font("Segoe UI", 15.7090912F);
            txtEmail.Location = new Point(206, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(421, 39);
            txtEmail.TabIndex = 0;
            // 
            // lblDN
            // 
            lblDN.Anchor = AnchorStyles.Top;
            lblDN.AutoSize = true;
            lblDN.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDN.Location = new Point(292, 32);
            lblDN.Name = "lblDN";
            lblDN.Size = new Size(246, 50);
            lblDN.TabIndex = 1;
            lblDN.Text = "ĐĂNG NHẬP";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(66, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblMK
            // 
            lblMK.Anchor = AnchorStyles.Top;
            lblMK.AutoSize = true;
            lblMK.Font = new Font("Segoe UI", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMK.Location = new Point(66, 180);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(115, 32);
            lblMK.TabIndex = 3;
            lblMK.Text = "Mật khẩu";
            // 
            // txtMK
            // 
            txtMK.Anchor = AnchorStyles.Top;
            txtMK.Font = new Font("Segoe UI", 15.7090912F);
            txtMK.Location = new Point(206, 180);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(421, 39);
            txtMK.TabIndex = 4;
            // 
            // btnDN
            // 
            btnDN.Anchor = AnchorStyles.Top;
            btnDN.BackColor = Color.LimeGreen;
            btnDN.Font = new Font("Segoe UI", 18.3272724F);
            btnDN.ForeColor = Color.White;
            btnDN.Location = new Point(276, 265);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(276, 56);
            btnDN.TabIndex = 5;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.BackColor = Color.LimeGreen;
            btnThoat.Font = new Font("Segoe UI", 18.3272724F);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(276, 338);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(276, 56);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // chknhoEmail
            // 
            chknhoEmail.Anchor = AnchorStyles.Top;
            chknhoEmail.AutoSize = true;
            chknhoEmail.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chknhoEmail.Location = new Point(206, 225);
            chknhoEmail.Name = "chknhoEmail";
            chknhoEmail.Size = new Size(162, 34);
            chknhoEmail.TabIndex = 7;
            chknhoEmail.Text = "Ghi nhớ Email";
            chknhoEmail.UseVisualStyleBackColor = true;
            chknhoEmail.CheckedChanged += chknhoEmail_CheckedChanged;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(chknhoEmail);
            Controls.Add(btnThoat);
            Controls.Add(btnDN);
            Controls.Add(txtMK);
            Controls.Add(lblMK);
            Controls.Add(lblEmail);
            Controls.Add(lblDN);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmDangNhap_FormClosed;
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblDN;
        private Label lblEmail;
        private Label lblMK;
        private TextBox txtMK;
        private Button btnDN;
        private Button btnThoat;
        private CheckBox chknhoEmail;
    }
}