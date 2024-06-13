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
            cboMaNV = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_anh).BeginInit();
            SuspendLayout();
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.Bottom;
            txtTim.BackColor = Color.LightGray;
            txtTim.Location = new Point(523, 657);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(178, 26);
            txtTim.TabIndex = 23;
            txtTim.Text = "Nhập tên sản phẩm";
            txtTim.Click += txtTim_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Bottom;
            btnTim.Location = new Point(707, 649);
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
            btnLamMoi.Location = new Point(799, 696);
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
            btnLuu.Location = new Point(707, 696);
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
            btnSua.Location = new Point(615, 696);
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
            btnXoa.Location = new Point(523, 696);
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
            btnThem.Location = new Point(431, 696);
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
            dgvDS.Location = new Point(12, 298);
            dgvDS.Name = "dgvDS";
            dgvDS.ReadOnly = true;
            dgvDS.RowHeadersWidth = 47;
            dgvDS.Size = new Size(1271, 329);
            dgvDS.TabIndex = 16;
            dgvDS.Click += dgvDS_Click;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 13.7454548F);
            lblGhiChu.Location = new Point(616, 186);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(84, 30);
            lblGhiChu.TabIndex = 29;
            lblGhiChu.Text = "Ghi chú";
            // 
            // txtghiChu
            // 
            txtghiChu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtghiChu.Font = new Font("Segoe UI", 13.7454548F);
            txtghiChu.Location = new Point(710, 186);
            txtghiChu.Multiline = true;
            txtghiChu.Name = "txtghiChu";
            txtghiChu.Size = new Size(330, 85);
            txtghiChu.TabIndex = 28;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 13.7454548F);
            lblTen.Location = new Point(85, 69);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(98, 30);
            lblTen.TabIndex = 27;
            lblTen.Text = "Tên hàng";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 13.7454548F);
            txtTen.Location = new Point(231, 66);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(271, 35);
            txtTen.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7454548F);
            label1.Location = new Point(85, 151);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 33;
            label1.Text = "Đơn giá nhập";
            // 
            // txtgiaNhap
            // 
            txtgiaNhap.Font = new Font("Segoe UI", 13.7454548F);
            txtgiaNhap.Location = new Point(231, 148);
            txtgiaNhap.Name = "txtgiaNhap";
            txtgiaNhap.Size = new Size(271, 35);
            txtgiaNhap.TabIndex = 32;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 13.7454548F);
            lblSoLuong.Location = new Point(85, 110);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(96, 30);
            lblSoLuong.TabIndex = 31;
            lblSoLuong.Text = "Số lượng";
            // 
            // txtSL
            // 
            txtSL.Font = new Font("Segoe UI", 13.7454548F);
            txtSL.Location = new Point(231, 107);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(271, 35);
            txtSL.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.7454548F);
            label3.Location = new Point(85, 192);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 35;
            label3.Text = "Đơn giá bán";
            // 
            // txtgiaBan
            // 
            txtgiaBan.Font = new Font("Segoe UI", 13.7454548F);
            txtgiaBan.Location = new Point(231, 189);
            txtgiaBan.Name = "txtgiaBan";
            txtgiaBan.Size = new Size(271, 35);
            txtgiaBan.TabIndex = 34;
            // 
            // picbox_anh
            // 
            picbox_anh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picbox_anh.Location = new Point(1055, 66);
            picbox_anh.Name = "picbox_anh";
            picbox_anh.Size = new Size(158, 208);
            picbox_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_anh.TabIndex = 36;
            picbox_anh.TabStop = false;
            // 
            // lblHinh
            // 
            lblHinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHinh.AutoSize = true;
            lblHinh.Font = new Font("Segoe UI", 13.7454548F);
            lblHinh.Location = new Point(616, 66);
            lblHinh.Name = "lblHinh";
            lblHinh.Size = new Size(57, 30);
            lblHinh.TabIndex = 38;
            lblHinh.Text = "Hình";
            // 
            // txtHinh
            // 
            txtHinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtHinh.Font = new Font("Segoe UI", 13.7454548F);
            txtHinh.Location = new Point(710, 63);
            txtHinh.Multiline = true;
            txtHinh.Name = "txtHinh";
            txtHinh.Size = new Size(253, 117);
            txtHinh.TabIndex = 37;
            // 
            // btnMoHinh
            // 
            btnMoHinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoHinh.Location = new Point(969, 63);
            btnMoHinh.Name = "btnMoHinh";
            btnMoHinh.Size = new Size(71, 61);
            btnMoHinh.TabIndex = 39;
            btnMoHinh.Text = "Mở hình";
            btnMoHinh.UseVisualStyleBackColor = true;
            btnMoHinh.Click += btnMoHinh_Click;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 13.7454548F);
            lblMaNV.Location = new Point(85, 239);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(78, 30);
            lblMaNV.TabIndex = 41;
            lblMaNV.Text = "Mã NV";
            // 
            // cboMaNV
            // 
            cboMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaNV.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMaNV.FormattingEnabled = true;
            cboMaNV.Location = new Point(231, 236);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(139, 38);
            cboMaNV.TabIndex = 42;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 773);
            ControlBox = false;
            Controls.Add(cboMaNV);
            Controls.Add(lblMaNV);
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
        private ComboBox cboMaNV;
    }
}