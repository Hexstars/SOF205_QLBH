using _2_BUS_QLBH;
using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_GUI_QLBH
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Default();
            LoadGridView_NhanVien();
        }
        private void LoadGridView_NhanVien()
        {
            dgvDS.DataSource = busNhanVien.GetNhanVien();
            dgvDS.Columns[0].HeaderText = "Mã NV";
            dgvDS.Columns[1].HeaderText = "Email";
            dgvDS.Columns[2].HeaderText = "Tên NV";
            dgvDS.Columns[3].HeaderText = "Địa chỉ";
            dgvDS.Columns[4].HeaderText = "Vai Trò";
            dgvDS.Columns[5].HeaderText = "Tình Trạng";
            dgvDS.Columns[6].HeaderText = "Mật khẩu";
        }
        private void Default()
        {

            txtTim.Text = "Nhập tên nhân viên";
            txtTim.BackColor = Color.LightGray;
            txtEmail.Clear();
            txtTen.Clear();
            txtdiaChi.Clear();
            txtMK.Clear();

            txtEmail.Enabled = false;
            txtMK.Enabled = false;
            txtTen.Enabled = false;
            txtdiaChi.Enabled = false;

            grpTT.Enabled = false;
            grpVT.Enabled = false;

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtMK.Clear();
            txtTen.Clear();
            txtdiaChi.Clear();

            txtEmail.Enabled = true;
            txtMK.Enabled = true;
            txtTen.Enabled = true;
            txtdiaChi.Enabled = true;

            grpTT.Enabled = true;
            grpVT.Enabled = true;

            rdoHD.Checked = false;
            rdoNHD.Checked = false;
            rdoQT.Checked = false;
            rdoNV.Checked = false;

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtEmail.Focus();
        }
        public bool IsValid(string emailaddress) //kiem tra xem email co hop le khong
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int role = 0; //vai tro nhan vien
            if (rdoQT.Checked)
            {
                role = 1;
            }
            int tinhtrang = 0; //ngung hoat dong
            if (rdoHD.Checked)
            {
                tinhtrang = 1;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }

            else if (txtdiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiaChi.Focus();
                return;
            }

            if (rdoQT.Checked == false && rdoNV.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rdoHD.Checked == false && rdoNHD.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn tình trạng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (busNhanVien.KiemTraEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    // Tạo 1 DTO
                    string matKhau = busNhanVien.encryption(txtMK.Text);
                    DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTen.Text, txtdiaChi.Text, role, tinhtrang, matKhau);
                    if (busNhanVien.InsertNV(nv))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Default();
                        LoadGridView_NhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }


        // Khai báo biến để lưu email hiện tại của nhân viên
        private string currentEmail;

        private void dgvDS_Click(object sender, EventArgs e)
        {
            if (dgvDS.Rows.Count > 1)
            {
                btnLuu.Enabled = false;
                txtEmail.Enabled = true;
                txtMK.Enabled = true;
                txtTen.Enabled = true;
                txtdiaChi.Enabled = true;

                grpTT.Enabled = true;
                grpVT.Enabled = true;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                currentEmail = dgvDS.CurrentRow.Cells["email"].Value.ToString(); // Lưu email hiện tại

                txtEmail.Text = currentEmail;
                txtMK.Text = dgvDS.CurrentRow.Cells["MatKhau"].Value.ToString();
                txtTen.Text = dgvDS.CurrentRow.Cells["TenNV"].Value.ToString();
                txtdiaChi.Text = dgvDS.CurrentRow.Cells["DiaChi"].Value.ToString();
                if (int.Parse(dgvDS.CurrentRow.Cells["VaiTro"].Value.ToString()) == 1)
                {
                    rdoQT.Checked = true;
                }
                else
                {
                    rdoNV.Checked = true;
                }

                if (int.Parse(dgvDS.CurrentRow.Cells["tinhtrang"].Value.ToString()) == 1)
                {
                    rdoHD.Checked = true;
                }
                else
                {
                    rdoNHD.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng ko tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = dgvDS.CurrentRow.Cells["MaNV"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNhanVien.DeleteNV(ma))
                {
                    LoadGridView_NhanVien();
                    Default();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                LoadGridView_NhanVien();
                Default();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (txtMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return;
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            else if (txtdiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiaChi.Focus();
                return;
            }
            else
            {
                //Nếu email mới khác với email hiện tại, kiểm tra xem email mới có tồn tại trong hệ thống hay không
                if (txtEmail.Text != currentEmail && busNhanVien.KiemTraEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    int role = 0;
                    if (rdoQT.Checked)
                    {
                        role = 1;
                    }
                    int tinhtrang = 0;
                    if (rdoHD.Checked)
                    {
                        tinhtrang = 1;
                    }
                    //Tạo DTO
                    string maNV = dgvDS.CurrentRow.Cells["MaNV"].Value.ToString();
                    string matKhau = busNhanVien.encryption(txtMK.Text);
                    DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTen.Text, txtdiaChi.Text, role, tinhtrang, matKhau);
                    if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (busNhanVien.UpdateNV(nv, maNV))
                        {
                            Default();
                            LoadGridView_NhanVien();
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        Default();
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Default();
            LoadGridView_NhanVien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string name = txtTim.Text;
            DataTable ds = busNhanVien.SearchNV(name);
            if (ds.Rows.Count > 0) //founded
            {
                dgvDS.DataSource = ds;
                dgvDS.Columns[0].HeaderText = "Mã NV";
                dgvDS.Columns[1].HeaderText = "Email";
                dgvDS.Columns[2].HeaderText = "Tên NV";
                dgvDS.Columns[3].HeaderText = "Địa chỉ";
                dgvDS.Columns[4].HeaderText = "Vai Trò";
                dgvDS.Columns[5].HeaderText = "Tình Trạng";
                dgvDS.Columns[6].HeaderText = "Mật khẩu";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTim.Text = "Nhập tên nhân viên";
            txtTim.BackColor = Color.LightGray;
            Default();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            txtTim.BackColor = Color.White;
        }
    }
}
