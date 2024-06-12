using _2_BUS_QLBH;
using DTO_QLBH;
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

namespace _1_GUI_QLBH
{
    public partial class frmDangNhap : Form
    {

        public int vaitro { get; set; }
        public int trangthai { get; set; }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        BUS_NhanVien busNV = new BUS_NhanVien();
        private void btnDN_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();

            frmMainQLBH.email = nv.EmailNV;
            nv.emailNV = txtEmail.Text;
            nv.matKhau = busNV.encryption(txtMK.Text);
            if (busNV.NhanVienDangNhap(nv))
            {
                if (chknhoEmail.Checked)
                {
                    Properties.Settings.Default.SavedEmail = txtEmail.Text;
                    Properties.Settings.Default.RememberEmail = true; // Lưu trạng thái của checkbox
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.RememberEmail = false;
                }
                frmMainQLBH mainForm = new frmMainQLBH();

                //login = true;

                DataTable dt = busNV.VaiTroNV(nv.emailNV);
                frmMainQLBH.vaiTro = dt.Rows[0]["VaiTro"].ToString();//Lưu vai trò
                frmMainQLBH.session = 1;
                frmMainQLBH.email = nv.EmailNV;

                //frmMainQLBH.profile = vaitro;
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Form form in Application.OpenForms)
                {
                    if (form is frmMainQLBH)
                    {
                        ((frmMainQLBH)form).HienMenu();
                        break;
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMK.Clear();
                txtMK.Focus();
            }
        }
        //Tao chuoi ngau nhien
        
        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            frmMainQLBH.session = 1;
            // Kiểm tra xem có email đã được lưu không
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SavedEmail))
            {
                // Nếu có, gán giá trị của nó vào txtEmail.Text
                txtEmail.Text = Properties.Settings.Default.SavedEmail;
            }
            chknhoEmail.Checked = Properties.Settings.Default.RememberEmail;
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chknhoEmail_CheckedChanged(object sender, EventArgs e)
        {
            //Lưu email
            if (chknhoEmail.Checked)
            {
                Properties.Settings.Default.SavedEmail = txtEmail.Text;
                Properties.Settings.Default.Save();
            }
            // Xóa email khỏi cài đặt nếu hộp kiểm nhớ email không được chọn
            else
            {
                Properties.Settings.Default.SavedEmail = string.Empty;
                Properties.Settings.Default.Save();
            }
        }
    }
}
