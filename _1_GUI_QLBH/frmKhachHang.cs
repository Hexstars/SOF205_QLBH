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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1_GUI_QLBH
{
    public partial class frmKhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void LoadGridView_KhachHang()
        {
            dgvDS.DataSource = busKH.getKhachHang();
            dgvDS.Columns[0].HeaderText = "Điện thoại";
            dgvDS.Columns[1].HeaderText = "Họ tên";
            dgvDS.Columns[2].HeaderText = "Địa chỉ";
            dgvDS.Columns[3].HeaderText = "Phái";
            dgvDS.Columns[4].HeaderText = "Mã NV";
        }
        private void Default()
        {
            txtTim.Text = "Nhập tên khách hàng";
            txtTim.BackColor = Color.LightGray;
            LoadCboMaNV();
            txtDienThoai.Clear();
            txtTen.Clear();
            txtdiaChi.Clear();
            cboMaNV.Text = null;

            txtDienThoai.Enabled = false;
            txtTen.Enabled = false;
            txtdiaChi.Enabled = false;
            cboMaNV.Enabled = false;

            grpGT.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnLamMoi.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDienThoai.Clear();
            txtTen.Clear();
            txtdiaChi.Clear();
            cboMaNV.Text= null;

            txtDienThoai.Enabled = true;
            txtTen.Enabled = true;
            txtdiaChi.Enabled = true;
            cboMaNV.Enabled = true;

            grpGT.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtDienThoai.Focus();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Default();
            LoadGridView_KhachHang();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private void LoadCboMaNV()
        {
            DataTable dtMaNV = busNhanVien.LayMaNV();
            cboMaNV.DataSource = dtMaNV;
            cboMaNV.DisplayMember = "manv";
            cboMaNV.ValueMember = "manv";
        }
        private void dgvDS_Click(object sender, EventArgs e)
        {
            if (dgvDS.Rows.Count > 0)
            {
                btnLuu.Enabled = false;
                txtTen.Enabled = true;
                txtdiaChi.Enabled = true;
                cboMaNV.Enabled = true;

                grpGT.Enabled = true;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //Show data from selected row to controls
                txtDienThoai.Text = dgvDS.CurrentRow.Cells["dienthoai"].Value.ToString();
                txtTen.Text = dgvDS.CurrentRow.Cells["tenkhach"].Value.ToString();
                txtdiaChi.Text = dgvDS.CurrentRow.Cells["DiaChi"].Value.ToString();
                cboMaNV.SelectedValue = dgvDS.CurrentRow.Cells["MaNV"].Value.ToString();
                if (dgvDS.CurrentRow.Cells["phai"].Value.ToString() == rdoNam.Text)
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng ko tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (cboMaNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (busKH.KiemTraSDT(txtDienThoai.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienThoai.Focus();
                    return;
                }
                else
                {
                    int intDienThoai;
                    bool isInt = int.TryParse(txtDienThoai.Text.Trim().ToString(), out intDienThoai);
                    string phai = "Nam";
                    if (rdoNu.Checked == true)
                    {
                        phai = "Nữ";
                    }

                    if (!isInt || int.Parse(txtDienThoai.Text) < 0) //kiem tra so dien thoai
                    {
                        MessageBox.Show("Vui lòng nhập đúng đinh dạng số điện thoai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDienThoai.Clear();
                        txtDienThoai.Focus();
                        return;
                    }
                    else
                    {
                        DTO_KhachHang kh = new DTO_KhachHang(txtDienThoai.Text, txtTen.Text, txtdiaChi.Text, phai, cboMaNV.SelectedValue.ToString());
                        if (busKH.InsertKH(kh))
                        {
                            Default();
                            LoadGridView_KhachHang();
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sdt = txtDienThoai.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busKH.DeleteKH(sdt))
                {
                    Default();
                    LoadGridView_KhachHang();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Default();
                    LoadGridView_KhachHang();
                    MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Default();
                LoadGridView_KhachHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (cboMaNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            else if (txtdiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiaChi.Focus();
                return;
            }
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (busKH.KiemTraSDT(txtDienThoai.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienThoai.Focus();
                    return;
                }
                else
                {
                    int intDienThoai;
                    bool isInt = int.TryParse(txtDienThoai.Text.Trim().ToString(), out intDienThoai);
                    string phai = "Nam";
                    if (rdoNu.Checked == true)
                    {
                        phai = "Nữ";
                    }

                    if (!isInt || int.Parse(txtDienThoai.Text) < 0) //kiem tra so dien thoai
                    {
                        MessageBox.Show("Vui lòng nhập đúng đinh dạng số điện thoai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDienThoai.Clear();
                        txtDienThoai.Focus();
                        return;
                    }
                    else
                    {
                        DTO_KhachHang kh = new DTO_KhachHang(txtDienThoai.Text, txtTen.Text, txtdiaChi.Text, phai, cboMaNV.SelectedValue.ToString());
                        if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (busKH.UpdateKH(kh))
                            {
                                Default();
                                LoadGridView_KhachHang();
                                MessageBox.Show("Sửa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Sửa ko thành công!");
                            }
                        }
                        else
                        {
                            Default();
                            LoadGridView_KhachHang();
                        }
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Default();
            LoadGridView_KhachHang();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string name = txtTim.Text;
            DataTable ds = busKH.SearchKH(name);
            if (ds.Rows.Count > 0) //founded
            {
                dgvDS.DataSource = ds;
                dgvDS.Columns[0].HeaderText = "Điện thoại";
                dgvDS.Columns[0].HeaderText = "Họ tên";
                dgvDS.Columns[0].HeaderText = "Địa chỉ";
                dgvDS.Columns[0].HeaderText = "Phái";
                dgvDS.Columns[0].HeaderText = "Mã NV";
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTim.Text = "Nhập tên khách hàng";
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
