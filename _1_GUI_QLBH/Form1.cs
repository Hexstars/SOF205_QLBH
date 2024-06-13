using _2_BUS_QLBH;
using System.Windows.Forms;

namespace _1_GUI_QLBH
{
    public partial class frmMainQLBH : Form
    {
        public static int session = 0; //tình trạng login
        public static int profile = 0;
        public static string email; //dùng để truyền email từ frmMainQLBH qua các form khác (static)
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        frmDangNhap dn;
        public static string vaiTro { set; get; } //kiểm tra vai trò sau đăng nhập
        // vai trò 0 là nv
        // vai tro 1 là quản trị


        public frmMainQLBH()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        // CheckExistForm để kiẻm tra xem 1 form với tên nào đó đã hiển thị trong 
        // Form Cha (Login) chưa? => Trả về True (đã hiển thị) hoặc False (nếu chưa hiển thị)
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // ActiveChildForm dùng để kích hoạt hiện thị lên trên 
        // cùng các trong số các form con nếu nó đã hiện mà ko phải tạo thể hiện mới
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new frmDangNhap();
            if (!CheckExistForm("frmDangNhap"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                dn.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                dn.FormClosed += new FormClosedEventHandler(frmDangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frmDangNhap");
            }
        }

        public void HienMenu()
        {

            thốngKêToolStripMenuItem.Visible = false;
            danhMụcToolStripMenuItem.Visible = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Visible = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            quênMậtKhẩuToolStripMenuItem.Visible = true;
            if (session == 1)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
                đổiMậtKhẩuToolStripMenuItem.Visible = true;
                quênMậtKhẩuToolStripMenuItem.Visible = false;
                if (vaiTro == "0")
                {
                    danhMụcToolStripMenuItem.Visible = true;
                    sảnPhẩmNhậpToolStripMenuItem.Visible = true;
                    kháchHàngToolStripMenuItem.Visible = true;
                    nhânViênToolStripMenuItem.Visible = false;
                }
                else if (vaiTro == "1")
                {
                    danhMụcToolStripMenuItem.Visible = true;
                    thốngKêToolStripMenuItem.Visible = true;
                }
            }
        }

        private void frmMainQLBH_Load(object sender, EventArgs e)
        {
            HienMenu();
            dn = new frmDangNhap();
            if (!CheckExistForm("frmDangNhap"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                dn.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                dn.FormClosed += new FormClosedEventHandler(frmDangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frmDangNhap");
            }
        }


        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "SOF205_PS40789.docx");
                if (File.Exists(path))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("File không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

            }
        }
        private void ResetValue()
        {
            if (session == 1)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
                if (dn.vaitro == 0) // neu la vn thi chuc nang nhu binh thuong
                {
                    HienMenu();
                }
            }
            else
            {
                quênMậtKhẩuToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Visible = false;
                sảnPhẩmNhậpToolStripMenuItem.Visible = false;
                sảnPhẩmTồnKhoToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
            }
        }
        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            frmMainQLBH_Load(sender, e);
        }

        private void quênMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatMK frm = new frmCapNhatMK();
            if (!CheckExistForm("frmCapNhatMK"))
            {
                frm.MdiParent = this;
                frm.Show();
                frm.FormClosed += new FormClosedEventHandler(frmMainQLBH_FormClosed);
            }
            else
            {
                ActiveChildForm("frmCapNhatMK");
            }
        }

        private void frmMainQLBH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            frmMainQLBH_Load(sender, e);
        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            if (!CheckExistForm("frmSanPham"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmSanPham");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            if (!CheckExistForm("frmNhanVien"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmNhanVien");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng form con hiện đang được hiển thị nếu có
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // Reset
            session = 0; // Assuming 0 means logged out
            profile = 0;
            vaiTro = null;
            HienMenu();
            // Hiện login
            frmDangNhap frm = new frmDangNhap();
            if (!CheckExistForm("frmNhanVien"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmNhanVien");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            if (!CheckExistForm("frmKhachHang"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmKhachHang");
            }
        }

        private void sảnPhẩmNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            if (!CheckExistForm("frmThongKe"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmThongKe");
            }
        }

        private void sảnPhẩmTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeTonKho frm = new frmThongKeTonKho();
            if (!CheckExistForm("frmThongKeTonKho"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
                frm.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                ActiveChildForm("frmThongKeTonKho");
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK frm = new frmDoiMK();
            if (!CheckExistForm("frmDoiMK"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
                frm.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                ActiveChildForm("frmDoiMK");
            }
        }
    }
}
