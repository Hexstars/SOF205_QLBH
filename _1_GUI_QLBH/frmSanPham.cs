using _2_BUS_QLBH;
using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_GUI_QLBH
{
    public partial class frmSanPham : Form
    {
        BUS_SanPham busSanPham = new BUS_SanPham();
        string checkImgUrl; //Kiểm tra ảnh
        string fileName; //tên file
        string fileSavePath; //vị trí lưu
        string fileAddress;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            Default();
            LoadGridView_SanPham();
        }
        private void LoadGridView_SanPham()
        {
            dgvDS.DataSource = busSanPham.GetSP();
            dgvDS.Columns[1].HeaderText = "Tên hàng";
            dgvDS.Columns[2].HeaderText = "Số lượng";
            dgvDS.Columns[3].HeaderText = "Đơn giá nhập";
            dgvDS.Columns[4].HeaderText = "Đơn giá bán";
            dgvDS.Columns[5].HeaderText = "Hình ảnh";
            dgvDS.Columns[6].HeaderText = "Ghi chú";
            dgvDS.Columns[7].HeaderText = "Mã NV";
        }
        private void Default()
        {
            txtTim.Text = "Nhập tên sản phẩm";
            txtTim.BackColor = Color.LightGray;
            txtTen.Clear();
            txtSL.Clear();
            txtgiaNhap.Clear();
            txtgiaBan.Clear();
            txtHinh.Clear();
            txtghiChu.Clear();
            txtMaNV.Clear();
            picbox_anh.Image = null;

            btnMoHinh.Enabled = false;
            txtTen.Enabled = false;
            txtSL.Enabled = false;
            txtgiaNhap.Enabled = false;
            txtgiaBan.Enabled = false;
            txtHinh.Enabled = false;
            txtghiChu.Enabled = false;
            txtMaNV.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "Chọn ảnh của sản phẩm";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAddress = ofd.FileName; // Lấy đường dẫn ảnh
                picbox_anh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(ofd.FileName); // Tên ảnh

                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                /*Path.Combine(Application.StartupPath, "Images");*/

                //// Đảm bảo thư mục tồn tại
                //if (!Directory.Exists(saveDirectory))
                //{
                //    Directory.CreateDirectory(saveDirectory);
                //}

                fileSavePath = saveDirectory + "\\Images\\" + fileName; //combine with file name
                /*Path.Combine(saveDirectory, fileName);*/ // Tạo đường dẫn để lưu file vào thư mục của project
                txtHinh.Text = fileAddress;//"\\Images\\" + fileName;
                //try
                //{
                //    // Lưu vào thư mục trong project
                //    File.Copy(fileAddress, fileSavePath, true);

                //    // Hiển thị ảnh
                //    picbox_anh.Image = Image.FromFile(fileSavePath);

                //    // Hiển thị vị trí ảnh (trong project)
                //    txtHinh.Text = Path.Combine("Images", fileName);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Ảnh lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soLuong;

            bool isInt = int.TryParse(txtSL.Text.Trim(), out soLuong); //ép kiểu để kiểm tra số hay chữ

            float donGiaNhap;

            bool isFloatNhap = float.TryParse(txtgiaNhap.Text.Trim(), out donGiaNhap);

            float donGiaBan;

            bool isFloatBan = float.TryParse(txtgiaBan.Text.Trim(), out donGiaBan);

            if (!isInt || int.Parse(txtSL.Text) < 0) //kiểm số lượng
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(txtgiaNhap.Text) < 0) //kiểm giá nhập
            {
                MessageBox.Show("Vui lòng nhập giá nhập hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgiaNhap.Focus();
                return;
            }
            else if (!isFloatBan || float.Parse(txtgiaBan.Text) < 0) //kiểm giá bán
            {
                MessageBox.Show("Vui lòng nhập giá bán hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgiaBan.Focus();
                return;
            }
            else if (txtHinh.Text.Trim().Length == 0) // phải nhập hình
            {
                MessageBox.Show("Vui lòng chọn hình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHinh.Focus();
                return;
            }
            else
            {
                string relativePath = "\\Images\\" + fileName;
                DTO_SanPham sp = new DTO_SanPham(txtTen.Text, int.Parse(txtSL.Text), float.Parse(txtgiaNhap.Text), float.Parse(txtgiaBan.Text), "\\Images\\" + fileName, txtghiChu.Text, txtMaNV.Text);

                if (busSanPham.InsertSP(sp))
                {
                    Default();
                    LoadGridView_SanPham();
                    string directoryPath = Path.GetDirectoryName(fileSavePath);
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    File.Copy(fileAddress, fileSavePath, true);
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //// Directory to save images
                //string saveDirectory = @"D:\FPT_Polytechnic\SOF205_SD19312_DuAnMau\QLBH\_1_GUI_QLBH\Images";

                //// Ensure the directory exists
                //if (!Directory.Exists(saveDirectory))
                //{
                //    Directory.CreateDirectory(saveDirectory);
                //}

                //// File information
                //string fileAddress = txtHinh.Text; // Assuming txtHinh contains the full path to the selected image
                //string fileName = Path.GetFileName(fileAddress);
                //string fileSavePath = Path.Combine(saveDirectory, fileName);

                // Copy the image to the specified directory
                //try
                //{
                //    File.Copy(fileAddress, Path.Combine(@"D:\FPT_Polytechnic\SOF205_SD19312_DuAnMau\QLBH\_1_GUI_QLBH\Images", Path.GetFileName(fileAddress)), true); // Copy and overwrite if exists

                //    // Update txtHinh to point to the new location
                //    txtHinh.Text = fileSavePath;

                //    int maHang = int.Parse(dgvDS.CurrentRow.Cells["mahang"].Value.ToString());
                //    DTO_SanPham sp = new DTO_SanPham(maHang, txtTen.Text, int.Parse(txtSL.Text), float.Parse(txtgiaNhap.Text), float.Parse(txtgiaBan.Text), txtHinh.Text, txtghiChu.Text, txtMaNV.Text);

                //    if (busSanPham.InsertSP(sp))
                //    {
                //        MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        Default();
                //        LoadGridView_SanPham();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Thêm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void dgvDS_Click(object sender, EventArgs e)
        {
            //// Get the base directory of the project
            //string baseDirectory = Application.StartupPath;

            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgvDS.Rows.Count > 0)
            {
                txtTen.Enabled = true;
                txtSL.Enabled = true;
                txtgiaNhap.Enabled = true;
                txtgiaBan.Enabled = true;
                txtHinh.Enabled = true;
                txtghiChu.Enabled = true;
                txtMaNV.Enabled = true;
                btnMoHinh.Enabled = true;

                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                txtTen.Text = dgvDS.CurrentRow.Cells["tenhang"].Value.ToString();
                txtSL.Text = dgvDS.CurrentRow.Cells["soluong"].Value.ToString();
                txtgiaNhap.Text = dgvDS.CurrentRow.Cells["dongianhap"].Value.ToString();
                txtgiaBan.Text = dgvDS.CurrentRow.Cells["dongiaban"].Value.ToString();
                txtghiChu.Text = dgvDS.CurrentRow.Cells["ghichu"].Value.ToString();
                txtMaNV.Text = dgvDS.CurrentRow.Cells["manv"].Value.ToString();

                string relativePath = dgvDS.CurrentRow.Cells["hinhanh"].Value.ToString();
                string imagePath = Path.Combine(saveDirectory, relativePath.TrimStart('\\')); // Chuyển đổi thành đường dẫn tuyệt đối

                if (File.Exists(imagePath))
                {
                    picbox_anh.Image = Image.FromFile(imagePath);
                    txtHinh.Text = imagePath;
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại: " + imagePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    picbox_anh.Image = null;
                }
            }
            //// Get the relative path of the image from the data grid
            //string relativeImagePath = dgvDS.CurrentRow.Cells["hinhanh"].Value.ToString();

                //// Combine base directory with relative path to get full path
                //string fullImagePath = Path.Combine(baseDirectory, relativeImagePath);

                //// Load and display the image in the PictureBox
                //if (File.Exists(fullImagePath))
                //{
                //    picbox_anh.Image = Image.FromFile(fullImagePath);
                //}
                //else
                //{
                //    MessageBox.Show("Image not found: " + fullImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                //    txtghiChu.Text = dgvDS.CurrentRow.Cells["ghichu"].Value.ToString();
                //    txtMaNV.Text = dgvDS.CurrentRow.Cells["manv"].Value.ToString();
                //}
            else
            {
                MessageBox.Show("Bảng trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            int soLuong;

            bool isInt = int.TryParse(txtSL.Text.Trim().ToString(), out soLuong);//ép kiểu để kiểm tra số hay chữ

            float donGiaNhap;

            bool isFloatNhap = float.TryParse(txtgiaNhap.Text.Trim().ToString(), out donGiaNhap);

            float donGiaBan;

            bool isFloatBan = float.TryParse(txtgiaBan.Text.Trim().ToString(), out donGiaBan);

            if (!isInt || int.Parse(txtSL.Text) < 0) //kiểm số lượng
            {
                MessageBox.Show("Vui lòng số lượng hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(txtgiaNhap.Text) < 0) //kiểm giá nhập
            {
                MessageBox.Show("Vui lòng giá nhập hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgiaNhap.Focus();
                return;
            }
            else if (!isFloatBan || float.Parse(txtgiaBan.Text) < 0) //kiểm giá nhập
            {
                MessageBox.Show("Vui lòng giá bán hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgiaBan.Focus();
                return;
            }
            else if (txtHinh.Text.Trim().Length == 0) // phải nhập hình
            {
                MessageBox.Show("Vui lòng chọn hình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHinh.Focus();
                return;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Chắc chắn sửa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int maHang = int.Parse(dgvDS.CurrentRow.Cells["mahang"].Value.ToString());
                    DTO_SanPham sp = new DTO_SanPham(txtTen.Text, int.Parse(txtSL.Text), float.Parse(txtgiaNhap.Text), float.Parse(txtgiaBan.Text), txtHinh.Text, txtghiChu.Text, txtMaNV.Text);

                    //// Check if the image needs to be updated
                    //bool isImageUpdated = txtHinh.Text != checkImgUrl;

                    //if (isImageUpdated)
                    //{
                    //    // Dispose the current image in PictureBox
                    //    picbox_anh.Image.Dispose();

                    //    // Ensure the file is not locked by the application
                    //    GC.Collect();
                    //    GC.WaitForPendingFinalizers();
                    //}

                    if (busSanPham.UpdateSP(sp, maHang))
                    {
                        //if (isImageUpdated)
                        //{
                        //    File.Copy(fileAddress, fileSavePath, true); // Copy the new image to the project directory
                        //}
                        if (txtHinh.Text != checkImgUrl)
                        {
                            File.Copy(fileAddress, fileSavePath, true); //copy hình vào ứng dụng
                        }
                        Default();
                        LoadGridView_SanPham();
                        MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Default();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maHang = int.Parse(dgvDS.CurrentRow.Cells["mahang"].Value.ToString());
            if (DialogResult.Yes == MessageBox.Show("Chắc chắn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (busSanPham.DeleteSP(maHang))
                {
                    Default();
                    LoadGridView_SanPham();
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Default();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtSL.Clear();
            txtgiaNhap.Clear();
            txtgiaBan.Clear();
            txtHinh.Clear();
            txtghiChu.Clear();
            txtMaNV.Clear();
            picbox_anh.Image = null;

            txtTen.Enabled = true;
            txtSL.Enabled = true;
            txtgiaNhap.Enabled = true;
            txtgiaBan.Enabled = true;
            txtHinh.Enabled = true;
            txtghiChu.Enabled = true;
            txtMaNV.Enabled = true;
            btnMoHinh.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;

            txtTen.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Default();
            LoadGridView_SanPham();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            txtTim.BackColor = Color.White;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string name = txtTim.Text;
            DataTable ds = busSanPham.SearchSP(name);
            if (ds.Rows.Count > 0) //founded
            {
                dgvDS.DataSource = ds;
                dgvDS.Columns[0].HeaderText = "Mã hàng";
                dgvDS.Columns[0].HeaderText = "Tên hàng";
                dgvDS.Columns[0].HeaderText = "Số lượng";
                dgvDS.Columns[0].HeaderText = "Đơn giá nhập";
                dgvDS.Columns[0].HeaderText = "Đơn giá bán";
                dgvDS.Columns[0].HeaderText = "Hình ảnh";
                dgvDS.Columns[0].HeaderText = "Ghi chú";
                dgvDS.Columns[0].HeaderText = "Mã NV";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTim.Text = "Nhập tên sản phẩm";
            txtTim.BackColor = Color.LightGray;
            Default();
        }
    }
}
