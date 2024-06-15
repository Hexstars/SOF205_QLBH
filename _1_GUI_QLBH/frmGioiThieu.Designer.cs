namespace _1_GUI_QLBH
{
    partial class frmGioiThieu
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
            lblTen = new Label();
            lbltenPM = new Label();
            lblcongTy = new Label();
            lbllienHe = new Label();
            lblThongTin = new Label();
            lbldiaChi = new Label();
            lblEmail = new Label();
            grpgioiThieu = new GroupBox();
            grpgioiThieu.SuspendLayout();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.Anchor = AnchorStyles.Top;
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold);
            lblTen.Location = new Point(44, 460);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(663, 50);
            lblTen.TabIndex = 0;
            lblTen.Text = "HỌ VÀ TÊN: TRẦN NGUYỄN CHÍ BẢO";
            // 
            // lbltenPM
            // 
            lbltenPM.Anchor = AnchorStyles.Top;
            lbltenPM.AutoSize = true;
            lbltenPM.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltenPM.Location = new Point(196, 100);
            lbltenPM.Name = "lbltenPM";
            lbltenPM.Size = new Size(636, 74);
            lbltenPM.TabIndex = 1;
            lbltenPM.Text = "QUẢN LÝ BÁN HÀNG™ ";
            // 
            // lblcongTy
            // 
            lblcongTy.Anchor = AnchorStyles.Top;
            lblcongTy.AutoSize = true;
            lblcongTy.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold);
            lblcongTy.Location = new Point(44, 325);
            lblcongTy.Name = "lblcongTy";
            lblcongTy.Size = new Size(495, 50);
            lblcongTy.TabIndex = 2;
            lblcongTy.Text = "ĐƠN VỊ: FPT POLYTECHNIC";
            // 
            // lbllienHe
            // 
            lbllienHe.Anchor = AnchorStyles.Top;
            lbllienHe.AutoSize = true;
            lbllienHe.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold);
            lbllienHe.Location = new Point(44, 527);
            lbllienHe.Name = "lbllienHe";
            lbllienHe.Size = new Size(487, 50);
            lbllienHe.TabIndex = 3;
            lbllienHe.Text = "ĐIỆN THOẠI: 02873088800";
            // 
            // lblThongTin
            // 
            lblThongTin.Anchor = AnchorStyles.Top;
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 36F);
            lblThongTin.Location = new Point(44, 233);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(527, 74);
            lblThongTin.TabIndex = 4;
            lblThongTin.Text = "THÔNG TIN LIÊN HỆ";
            // 
            // lbldiaChi
            // 
            lbldiaChi.Anchor = AnchorStyles.Top;
            lbldiaChi.AutoSize = true;
            lbldiaChi.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold);
            lbldiaChi.Location = new Point(44, 392);
            lbldiaChi.Name = "lbldiaChi";
            lbldiaChi.Size = new Size(434, 50);
            lbldiaChi.TabIndex = 5;
            lbldiaChi.Text = "ĐỊA CHỈ: Q.12, TP. HCM.";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold);
            lblEmail.Location = new Point(44, 591);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(619, 50);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "EMAIL: baotnps40789@gmail.com";
            // 
            // grpgioiThieu
            // 
            grpgioiThieu.Anchor = AnchorStyles.Top;
            grpgioiThieu.Controls.Add(lblThongTin);
            grpgioiThieu.Controls.Add(lblEmail);
            grpgioiThieu.Controls.Add(lblTen);
            grpgioiThieu.Controls.Add(lbldiaChi);
            grpgioiThieu.Controls.Add(lbltenPM);
            grpgioiThieu.Controls.Add(lblcongTy);
            grpgioiThieu.Controls.Add(lbllienHe);
            grpgioiThieu.Font = new Font("Segoe UI", 20.2909088F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpgioiThieu.Location = new Point(115, 53);
            grpgioiThieu.Name = "grpgioiThieu";
            grpgioiThieu.Size = new Size(957, 680);
            grpgioiThieu.TabIndex = 0;
            grpgioiThieu.TabStop = false;
            grpgioiThieu.Text = "GIỚI THIỆU";
            // 
            // frmGioiThieu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 822);
            ControlBox = false;
            Controls.Add(grpgioiThieu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGioiThieu";
            Text = "Giới thiệu phần mềm";
            grpgioiThieu.ResumeLayout(false);
            grpgioiThieu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTen;
        private Label lbltenPM;
        private Label lblcongTy;
        private Label lbllienHe;
        private Label lblThongTin;
        private Label lbldiaChi;
        private Label lblEmail;
        private GroupBox grpgioiThieu;
    }
}