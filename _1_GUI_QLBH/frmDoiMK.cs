using _2_BUS_QLBH;
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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtEmail.Text = frmMainQLBH.email;
            txtMKcu.Focus();
        }
        BUS_NhanVien busNV = new BUS_NhanVien();
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable dt = busNV.LayMK(txtEmail.Text);
            string matKhau = dt.Rows[0]["MatKhau"].ToString();//Lưu mật khẩu
            if (txtMKcu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nhập mật khẩu cũ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKcu.Focus();
                return;
            }
            else if (txtMKmoi1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nhập mật khẩu mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Nhập lại mật khẩu mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi2.Focus();
                return;
            }
            else if (txtMKmoi2.Text != txtMKmoi1.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi1.Focus();
                return;
            }
            else if (busNV.encryption(txtMKcu.Text) != matKhau)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKcu.Focus();
                return;
            }
            else
            {
                if (busNV.CapNhatMK(txtEmail.Text, busNV.encryption(txtMKmoi1.Text)))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMKcu.Clear();
                    txtMKmoi1.Clear();
                    txtMKmoi2.Clear();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
