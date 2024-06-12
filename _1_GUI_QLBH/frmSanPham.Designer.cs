namespace _1_GUI_QLBH
{
    partial class frmSanPham
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
            lblGhiChu = new Label();
            txtghiChu = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            txtgiaNhap = new TextBox();
            lblSoLuong = new Label();
            txtSL = new TextBox();
            label3 = new Label();
            txtgiaBan = new TextBox();
            picbox_anh = new PictureBox();
            lblHinh = new Label();
            txtHinh = new TextBox();
            btnMoHinh = new Button();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_anh).BeginInit();
            SuspendLayout();
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.Bottom;
            txtTim.BackColor = Color.LightGray;
            txtTim.Location = new Point(433, 507);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(178, 26);
            txtTim.TabIndex = 23;
            txtTim.Text = "Nhập tên sản phẩm";
            txtTim.Click += txtTim_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Bottom;
            btnTim.Location = new Point(617, 499);
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
            btnLamMoi.Location = new Point(709, 546);
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
            btnLuu.Location = new Point(617, 546);
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
            btnSua.Location = new Point(525, 546);
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
            btnXoa.Location = new Point(433, 546);
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
            btnThem.Location = new Point(341, 546);
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
            dgvDS.Location = new Point(12, 250);
            dgvDS.Name = "dgvDS";
            dgvDS.ReadOnly = true;
            dgvDS.RowHeadersWidth = 47;
            dgvDS.Size = new Size(1091, 244);
            dgvDS.TabIndex = 16;
            dgvDS.Click += dgvDS_Click;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGhiChu.Location = new Point(635, 152);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(69, 23);
            lblGhiChu.TabIndex = 29;
            lblGhiChu.Text = "Ghi chú";
            // 
            // txtghiChu
            // 
            txtghiChu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtghiChu.Location = new Point(706, 149);
            txtghiChu.Multiline = true;
            txtghiChu.Name = "txtghiChu";
            txtghiChu.Size = new Size(228, 55);
            txtghiChu.TabIndex = 28;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTen.Location = new Point(66, 79);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(80, 23);
            lblTen.TabIndex = 27;
            lblTen.Text = "Tên hàng";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(191, 79);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(183, 26);
            txtTen.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 143);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 33;
            label1.Text = "Đơn giá nhập";
            // 
            // txtgiaNhap
            // 
            txtgiaNhap.Location = new Point(191, 143);
            txtgiaNhap.Name = "txtgiaNhap";
            txtgiaNhap.Size = new Size(183, 26);
            txtgiaNhap.TabIndex = 32;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(66, 111);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(78, 23);
            lblSoLuong.TabIndex = 31;
            lblSoLuong.Text = "Số lượng";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(191, 111);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(183, 26);
            txtSL.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 175);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 35;
            label3.Text = "Đơn giá bán";
            // 
            // txtgiaBan
            // 
            txtgiaBan.Location = new Point(191, 175);
            txtgiaBan.Name = "txtgiaBan";
            txtgiaBan.Size = new Size(183, 26);
            txtgiaBan.TabIndex = 34;
            // 
            // picbox_anh
            // 
            picbox_anh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picbox_anh.Location = new Point(945, 85);
            picbox_anh.Name = "picbox_anh";
            picbox_anh.Size = new Size(115, 148);
            picbox_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_anh.TabIndex = 36;
            picbox_anh.TabStop = false;
            // 
            // lblHinh
            // 
            lblHinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHinh.AutoSize = true;
            lblHinh.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHinh.Location = new Point(635, 88);
            lblHinh.Name = "lblHinh";
            lblHinh.Size = new Size(46, 23);
            lblHinh.TabIndex = 38;
            lblHinh.Text = "Hình";
            // 
            // txtHinh
            // 
            txtHinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtHinh.Location = new Point(706, 85);
            txtHinh.Multiline = true;
            txtHinh.Name = "txtHinh";
            txtHinh.Size = new Size(151, 58);
            txtHinh.TabIndex = 37;
            // 
            // btnMoHinh
            // 
            btnMoHinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoHinh.Location = new Point(863, 85);
            btnMoHinh.Name = "btnMoHinh";
            btnMoHinh.Size = new Size(71, 58);
            btnMoHinh.TabIndex = 39;
            btnMoHinh.Text = "Mở hình";
            btnMoHinh.UseVisualStyleBackColor = true;
            btnMoHinh.Click += btnMoHinh_Click;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNV.Location = new Point(66, 207);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(63, 23);
            lblMaNV.TabIndex = 41;
            lblMaNV.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(191, 207);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(183, 26);
            txtMaNV.TabIndex = 40;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 599);
            ControlBox = false;
            Controls.Add(lblMaNV);
            Controls.Add(txtMaNV);
            Controls.Add(btnMoHinh);
            Controls.Add(lblHinh);
            Controls.Add(txtHinh);
            Controls.Add(picbox_anh);
            Controls.Add(label3);
            Controls.Add(txtgiaBan);
            Controls.Add(label1);
            Controls.Add(txtgiaNhap);
            Controls.Add(lblSoLuong);
            Controls.Add(txtSL);
            Controls.Add(lblGhiChu);
            Controls.Add(txtghiChu);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(txtTim);
            Controls.Add(btnTim);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvDS);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSanPham";
            Text = "frmSanPham";
            WindowState = FormWindowState.Maximized;
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_anh).EndInit();
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
        private Label lblGhiChu;
        private TextBox txtghiChu;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblMaHang;
        private TextBox txtMaHang;
        private Label label1;
        private TextBox txtgiaNhap;
        private Label lblSoLuong;
        private TextBox txtSL;
        private Label label3;
        private TextBox txtgiaBan;
        private PictureBox picbox_anh;
        private Label lblHinh;
        private TextBox txtHinh;
        private Button btnMoHinh;
        private Label lblMaNV;
        private TextBox txtMaNV;
    }
}