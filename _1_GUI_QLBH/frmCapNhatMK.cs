using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using _2_BUS_QLBH;

namespace _1_GUI_QLBH
{
    public partial class frmCapNhatMK : Form
    {
        public frmCapNhatMK()
        {
            InitializeComponent();
        }
        frmDangNhap quenMk = new frmDangNhap();

        private void frmCapNhatMK_Load(object sender, EventArgs e)
        {
            frmMainQLBH.session = 0;
            txtEmail.Text = Properties.Settings.Default.SavedEmail;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtMaXN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập mã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaXN.Focus();
                return;
            }
            else if (txtMKmoi1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi1.Focus();
                return;
            }
            else if (txtMKmoi1.Text.Trim().Length < 7)
            {
                MessageBox.Show("Mật khẩu mới phải dài hơn 7 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi1.Focus();
                return;
            }
            else if (txtMKmoi2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi2.Focus();
                return;
            }
            else
            {
                if (txtMaXN.Text != maXacNhan)
                {
                    MessageBox.Show("Mã xác nhận không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaXN.Focus();
                    return;
                }
                else if (txtMKmoi2.Text != txtMKmoi1.Text)
                {
                    MessageBox.Show("Mật khẩu không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKmoi2.Focus();
                    return;
                }
                else
                {
                    BUS_NhanVien busNhanVien = new BUS_NhanVien();
                    string EmailNV = txtEmail.Text;
                    string MatKhauMoi = busNhanVien.encryption(txtMKmoi1.Text);

                    if (busNhanVien.CapNhatMK(EmailNV, MatKhauMoi))//cap nhat mat khau thanh cong
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        maXacNhan = null;

                        txtEmail.Clear();
                        txtMaXN.Clear();
                        txtMKmoi1.Clear();
                        txtMKmoi2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        BUS_NhanVien busNV = new BUS_NhanVien();

        string maXacNhan;
        GUI_NhanVien guiNV = new GUI_NhanVien();
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (busNV.NhanVienQuenMK(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(guiNV.RandomString(4, true));
                    builder.Append(guiNV.RandomNumber(1000, 9999));
                    builder.Append(guiNV.RandomString(2, false));

                    maXacNhan = builder.ToString();

                    guiNV.SendMail(txtEmail.Text, maXacNhan);

                    MessageBox.Show($"Mã xác nhận đã được gửi về {txtEmail.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaXN.Focus();
                }
                else
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
