namespace _1_GUI_QLBH
{
    partial class frmDoiMK
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
            button1 = new Button();
            btnCapNhat = new Button();
            txtMKmoi2 = new TextBox();
            txtMKmoi1 = new TextBox();
            txtMaXN = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblMKcu = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 18.3272724F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(291, 346);
            button1.Name = "button1";
            button1.Size = new Size(240, 55);
            button1.TabIndex = 19;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.LimeGreen;
            btnCapNhat.Font = new Font("Segoe UI", 18.3272724F);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(291, 285);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(240, 55);
            btnCapNhat.TabIndex = 18;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // txtMKmoi2
            // 
            txtMKmoi2.Font = new Font("Segoe UI", 11.7818184F);
            txtMKmoi2.Location = new Point(291, 235);
            txtMKmoi2.Name = "txtMKmoi2";
            txtMKmoi2.Size = new Size(240, 31);
            txtMKmoi2.TabIndex = 17;
            // 
            // txtMKmoi1
            // 
            txtMKmoi1.Font = new Font("Segoe UI", 11.7818184F);
            txtMKmoi1.Location = new Point(291, 174);
            txtMKmoi1.Name = "txtMKmoi1";
            txtMKmoi1.Size = new Size(240, 31);
            txtMKmoi1.TabIndex = 16;
            // 
            // txtMaXN
            // 
            txtMaXN.Font = new Font("Segoe UI", 11.7818184F);
            txtMaXN.Location = new Point(291, 109);
            txtMaXN.Name = "txtMaXN";
            txtMaXN.Size = new Size(240, 31);
            txtMaXN.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.7818184F);
            txtEmail.Location = new Point(291, 46);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 31);
            txtEmail.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.7090912F);
            label4.Location = new Point(27, 235);
            label4.Name = "label4";
            label4.Size = new Size(258, 32);
            label4.TabIndex = 13;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.7090912F);
            label3.Location = new Point(27, 172);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 12;
            label3.Text = "Mật khẩu mới";
            // 
            // lblMKcu
            // 
            lblMKcu.AutoSize = true;
            lblMKcu.Font = new Font("Segoe UI", 15.7090912F);
            lblMKcu.Location = new Point(27, 107);
            lblMKcu.Name = "lblMKcu";
            lblMKcu.Size = new Size(147, 32);
            lblMKcu.TabIndex = 11;
            lblMKcu.Text = "Mật khẩu cũ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.7090912F);
            lblEmail.Location = new Point(27, 46);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // frmDoiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnCapNhat);
            Controls.Add(txtMKmoi2);
            Controls.Add(txtMKmoi1);
            Controls.Add(txtMaXN);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMKcu);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDoiMK";
            Text = "Đổi mật khẩu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCapNhat;
        private TextBox txtMKmoi2;
        private TextBox txtMKmoi1;
        private TextBox txtMaXN;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label lblMKcu;
        private Label lblEmail;
    }
}