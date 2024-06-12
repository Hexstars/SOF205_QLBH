namespace _1_GUI_QLBH
{
    partial class frmCapNhatMK
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
            lblEmail = new Label();
            lblMaXN = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtMaXN = new TextBox();
            txtMKmoi1 = new TextBox();
            txtMKmoi2 = new TextBox();
            btnCapNhat = new Button();
            button1 = new Button();
            btnGuiMa = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.7090912F);
            lblEmail.Location = new Point(227, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblMaXN
            // 
            lblMaXN.Anchor = AnchorStyles.Top;
            lblMaXN.AutoSize = true;
            lblMaXN.Font = new Font("Segoe UI", 15.7090912F);
            lblMaXN.Location = new Point(148, 116);
            lblMaXN.Name = "lblMaXN";
            lblMaXN.Size = new Size(150, 32);
            lblMaXN.TabIndex = 1;
            lblMaXN.Text = "Mã xác nhận";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.7090912F);
            label3.Location = new Point(135, 181);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.7090912F);
            label4.Location = new Point(40, 242);
            label4.Name = "label4";
            label4.Size = new Size(258, 32);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(304, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 26);
            txtEmail.TabIndex = 4;
            // 
            // txtMaXN
            // 
            txtMaXN.Anchor = AnchorStyles.Top;
            txtMaXN.Location = new Point(304, 122);
            txtMaXN.Name = "txtMaXN";
            txtMaXN.Size = new Size(240, 26);
            txtMaXN.TabIndex = 5;
            // 
            // txtMKmoi1
            // 
            txtMKmoi1.Anchor = AnchorStyles.Top;
            txtMKmoi1.Location = new Point(304, 187);
            txtMKmoi1.Name = "txtMKmoi1";
            txtMKmoi1.PasswordChar = '*';
            txtMKmoi1.Size = new Size(240, 26);
            txtMKmoi1.TabIndex = 6;
            // 
            // txtMKmoi2
            // 
            txtMKmoi2.Anchor = AnchorStyles.Top;
            txtMKmoi2.Location = new Point(304, 248);
            txtMKmoi2.Name = "txtMKmoi2";
            txtMKmoi2.PasswordChar = '*';
            txtMKmoi2.Size = new Size(240, 26);
            txtMKmoi2.TabIndex = 7;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top;
            btnCapNhat.BackColor = Color.LimeGreen;
            btnCapNhat.Font = new Font("Segoe UI", 18.3272724F);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(304, 292);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(240, 55);
            btnCapNhat.TabIndex = 8;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 18.3272724F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(304, 353);
            button1.Name = "button1";
            button1.Size = new Size(240, 55);
            button1.TabIndex = 9;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnGuiMa
            // 
            btnGuiMa.Anchor = AnchorStyles.Top;
            btnGuiMa.BackColor = Color.LimeGreen;
            btnGuiMa.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuiMa.ForeColor = Color.White;
            btnGuiMa.Location = new Point(550, 111);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.Size = new Size(120, 45);
            btnGuiMa.TabIndex = 10;
            btnGuiMa.Text = "Gửi";
            btnGuiMa.UseVisualStyleBackColor = false;
            btnGuiMa.Click += btnGuiMa_Click;
            // 
            // frmCapNhatMK
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnGuiMa);
            Controls.Add(button1);
            Controls.Add(btnCapNhat);
            Controls.Add(txtMKmoi2);
            Controls.Add(txtMKmoi1);
            Controls.Add(txtMaXN);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMaXN);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCapNhatMK";
            Text = "Cập nhật mật khẩu";
            WindowState = FormWindowState.Maximized;
            Load += frmCapNhatMK_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblMaXN;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtMaXN;
        private TextBox txtMKmoi1;
        private TextBox txtMKmoi2;
        private Button btnCapNhat;
        private Button button1;
        private Button btnGuiMa;
    }
}