namespace _1_GUI_QLBH
{
    partial class frmNhanVien
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
            lblEmail = new Label();
            grpTT = new GroupBox();
            rdoNHD = new RadioButton();
            rdoHD = new RadioButton();
            grpVT = new GroupBox();
            rdoQT = new RadioButton();
            rdoNV = new RadioButton();
            lblTen = new Label();
            txtTen = new TextBox();
            lblDiaChi = new Label();
            txtdiaChi = new TextBox();
            dgvDS = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnLamMoi = new Button();
            btnTim = new Button();
            txtTim = new TextBox();
            lblMK = new Label();
            txtMK = new TextBox();
            grpTT.SuspendLayout();
            grpVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.7454548F);
            txtEmail.Location = new Point(214, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 35);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.7454548F);
            lblEmail.Location = new Point(85, 76);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 30);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // grpTT
            // 
            grpTT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpTT.Controls.Add(rdoNHD);
            grpTT.Controls.Add(rdoHD);
            grpTT.Font = new Font("Microsoft Sans Serif", 13.7454548F);
            grpTT.Location = new Point(670, 173);
            grpTT.Name = "grpTT";
            grpTT.Size = new Size(372, 91);
            grpTT.TabIndex = 2;
            grpTT.TabStop = false;
            grpTT.Text = "Tình trạng";
            // 
            // rdoNHD
            // 
            rdoNHD.AutoSize = true;
            rdoNHD.Location = new Point(171, 42);
            rdoNHD.Name = "rdoNHD";
            rdoNHD.Size = new Size(195, 29);
            rdoNHD.TabIndex = 4;
            rdoNHD.TabStop = true;
            rdoNHD.Text = "Ngừng hoạt động";
            rdoNHD.UseVisualStyleBackColor = true;
            // 
            // rdoHD
            // 
            rdoHD.AutoSize = true;
            rdoHD.Location = new Point(36, 42);
            rdoHD.Name = "rdoHD";
            rdoHD.Size = new Size(129, 29);
            rdoHD.TabIndex = 3;
            rdoHD.TabStop = true;
            rdoHD.Text = "Hoạt động";
            rdoHD.UseVisualStyleBackColor = true;
            // 
            // grpVT
            // 
            grpVT.Controls.Add(rdoQT);
            grpVT.Controls.Add(rdoNV);
            grpVT.Font = new Font("Microsoft Sans Serif", 13.7454548F);
            grpVT.Location = new Point(85, 204);
            grpVT.Name = "grpVT";
            grpVT.Size = new Size(380, 60);
            grpVT.TabIndex = 3;
            grpVT.TabStop = false;
            grpVT.Text = "Vai trò";
            // 
            // rdoQT
            // 
            rdoQT.AutoSize = true;
            rdoQT.Location = new Point(190, 25);
            rdoQT.Name = "rdoQT";
            rdoQT.Size = new Size(106, 29);
            rdoQT.TabIndex = 4;
            rdoQT.TabStop = true;
            rdoQT.Text = "Quản trị";
            rdoQT.UseVisualStyleBackColor = true;
            // 
            // rdoNV
            // 
            rdoNV.AutoSize = true;
            rdoNV.Location = new Point(57, 25);
            rdoNV.Name = "rdoNV";
            rdoNV.Size = new Size(127, 29);
            rdoNV.TabIndex = 3;
            rdoNV.TabStop = true;
            rdoNV.Text = "Nhân viên";
            rdoNV.UseVisualStyleBackColor = true;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 13.7454548F);
            lblTen.Location = new Point(85, 158);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(105, 30);
            lblTen.TabIndex = 5;
            lblTen.Text = "Họ và Tên";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 13.7454548F);
            txtTen.Location = new Point(214, 155);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(251, 35);
            txtTen.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Microsoft Sans Serif", 13.7454548F);
            lblDiaChi.Location = new Point(670, 80);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(82, 25);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa Chỉ";
            // 
            // txtdiaChi
            // 
            txtdiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtdiaChi.Location = new Point(758, 73);
            txtdiaChi.Multiline = true;
            txtdiaChi.Name = "txtdiaChi";
            txtdiaChi.Size = new Size(284, 94);
            txtdiaChi.TabIndex = 6;
            // 
            // dgvDS
            // 
            dgvDS.AllowUserToAddRows = false;
            dgvDS.AllowUserToDeleteRows = false;
            dgvDS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(12, 282);
            dgvDS.Name = "dgvDS";
            dgvDS.ReadOnly = true;
            dgvDS.RowHeadersWidth = 47;
            dgvDS.Size = new Size(1109, 251);
            dgvDS.TabIndex = 8;
            dgvDS.Click += dgvDS_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(357, 590);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 41);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.Location = new Point(449, 590);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 41);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.Location = new Point(541, 590);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 41);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnLuu.Location = new Point(633, 590);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 41);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Bottom;
            btnLamMoi.Location = new Point(725, 590);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 41);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Bottom;
            btnTim.Location = new Point(633, 543);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(86, 41);
            btnTim.TabIndex = 14;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.Bottom;
            txtTim.BackColor = Color.LightGray;
            txtTim.Location = new Point(449, 551);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(178, 26);
            txtTim.TabIndex = 15;
            txtTim.Text = "Nhập tên nhân viên";
            txtTim.Click += txtTim_Click;
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Font = new Font("Segoe UI", 13.7454548F);
            lblMK.Location = new Point(85, 117);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(101, 30);
            lblMK.TabIndex = 17;
            lblMK.Text = "Mật khẩu";
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Segoe UI", 13.7454548F);
            txtMK.Location = new Point(214, 114);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(251, 35);
            txtMK.TabIndex = 16;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 643);
            ControlBox = false;
            Controls.Add(lblMK);
            Controls.Add(txtMK);
            Controls.Add(txtTim);
            Controls.Add(btnTim);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvDS);
            Controls.Add(lblDiaChi);
            Controls.Add(grpTT);
            Controls.Add(txtdiaChi);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(grpVT);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNhanVien";
            Text = "Nhân viên";
            WindowState = FormWindowState.Maximized;
            Load += frmNhanVien_Load;
            grpTT.ResumeLayout(false);
            grpTT.PerformLayout();
            grpVT.ResumeLayout(false);
            grpVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private GroupBox grpTT;
        private RadioButton rdoNHD;
        private RadioButton rdoHD;
        private GroupBox grpVT;
        private RadioButton rdoQT;
        private RadioButton rdoNV;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblDiaChi;
        private TextBox txtdiaChi;
        private DataGridView dgvDS;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnLamMoi;
        private Button btnTim;
        private TextBox txtTim;
        private Label lblMK;
        private TextBox txtMK;
    }
}