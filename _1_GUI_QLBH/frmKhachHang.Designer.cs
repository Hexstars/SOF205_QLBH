namespace _1_GUI_QLBH
{
    partial class frmKhachHang
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
            txtTim = new TextBox();
            btnTim = new Button();
            btnLamMoi = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            dgvDS = new DataGridView();
            lblDiaChi = new Label();
            grpGT = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtdiaChi = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            grpGT.SuspendLayout();
            SuspendLayout();
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.Bottom;
            txtTim.BackColor = Color.LightGray;
            txtTim.Location = new Point(283, 361);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(178, 26);
            txtTim.TabIndex = 23;
            txtTim.Text = "Nhập tên khách hàng";
            txtTim.Click += txtTim_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Bottom;
            btnTim.Location = new Point(467, 353);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(86, 41);
            btnTim.TabIndex = 22;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Bottom;
            btnLamMoi.Location = new Point(559, 400);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 41);
            btnLamMoi.TabIndex = 21;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnLuu.Location = new Point(467, 400);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 41);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.Location = new Point(375, 400);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 41);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.Location = new Point(283, 400);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 41);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(191, 400);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 41);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvDS
            // 
            dgvDS.AllowUserToAddRows = false;
            dgvDS.AllowUserToDeleteRows = false;
            dgvDS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(12, 145);
            dgvDS.Name = "dgvDS";
            dgvDS.ReadOnly = true;
            dgvDS.RowHeadersWidth = 47;
            dgvDS.Size = new Size(776, 198);
            dgvDS.TabIndex = 16;
            dgvDS.Click += dgvDS_Click;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(461, 32);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(65, 23);
            lblDiaChi.TabIndex = 30;
            lblDiaChi.Text = "Địa Chỉ";
            // 
            // grpGT
            // 
            grpGT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpGT.Controls.Add(rdoNu);
            grpGT.Controls.Add(rdoNam);
            grpGT.Location = new Point(461, 77);
            grpGT.Name = "grpGT";
            grpGT.Size = new Size(299, 42);
            grpGT.TabIndex = 26;
            grpGT.TabStop = false;
            grpGT.Text = "Phái";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(194, 16);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(45, 23);
            rdoNu.TabIndex = 4;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(80, 16);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(56, 23);
            rdoNam.TabIndex = 3;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtdiaChi
            // 
            txtdiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtdiaChi.Location = new Point(532, 29);
            txtdiaChi.Multiline = true;
            txtdiaChi.Name = "txtdiaChi";
            txtdiaChi.Size = new Size(228, 42);
            txtdiaChi.TabIndex = 29;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTen.Location = new Point(51, 61);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(85, 23);
            lblTen.TabIndex = 28;
            lblTen.Text = "Họ và Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(142, 61);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(251, 26);
            txtTen.TabIndex = 27;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDienThoai.Location = new Point(47, 29);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(89, 23);
            lblDienThoai.TabIndex = 25;
            lblDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(142, 29);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(251, 26);
            txtDienThoai.TabIndex = 24;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNV.Location = new Point(51, 93);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(63, 23);
            lblMaNV.TabIndex = 32;
            lblMaNV.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(142, 93);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(126, 26);
            txtMaNV.TabIndex = 31;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblMaNV);
            Controls.Add(txtMaNV);
            Controls.Add(lblDiaChi);
            Controls.Add(grpGT);
            Controls.Add(txtdiaChi);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(lblDienThoai);
            Controls.Add(txtDienThoai);
            Controls.Add(txtTim);
            Controls.Add(btnTim);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvDS);
            Name = "frmKhachHang";
            Text = "Khách hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            grpGT.ResumeLayout(false);
            grpGT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTim;
        private Button btnTim;
        private Button btnLamMoi;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgvDS;
        private Label lblDiaChi;
        private GroupBox grpGT;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtdiaChi;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblDienThoai;
        private TextBox txtDienThoai;
        private Label lblMaNV;
        private TextBox txtMaNV;
    }
}