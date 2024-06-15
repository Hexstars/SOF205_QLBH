using _2_BUS_QLBH;
using System.Diagnostics;
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
        private void CloseAllChildForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng các form trước
            CloseAllChildForms();

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
                    nhânViênToolStripMenuItem.Visible = true;
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
        private void frmDoiMK_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            frmMainQLBH_Load(sender, e);
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
                frm.FormClosed += new FormClosedEventHandler(frmDoiMK_FormClosed);
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
            // Đóng các form trước
            CloseAllChildForms();

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
            // Đóng các form trước
            CloseAllChildForms();

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
            if (!CheckExistForm("frmDangNhap"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmDangNhap");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng các form trước
            CloseAllChildForms();

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
            // Đóng các form trước
            CloseAllChildForms();

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
            // Đóng các form trước
            CloseAllChildForms();

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

        private void hướngDẫnSửDụngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var fileName = "HDSD.pdf";

                //Thuộc tính này trả về đường dẫn đến thư mục cơ sở của ứng dụng đang chạy.
                //Trong trường hợp của bạn, nó sẽ trỏ đến thư mục bin\Debug\net8.0-windows.
                var currentDirectory = Application.StartupPath;

                //Phương thức này kết hợp đường dẫn thư mục hiện tại với tên file
                //để tạo ra đường dẫn đầy đủ đến file.
                //Sử dụng Path.Combine thay vì nối chuỗi trực tiếp giúp tránh
                //các vấn đề liên quan đến dấu phân cách đường dẫn (\)
                //và làm cho code hoạt động tốt trên nhiều hệ điều hành.
                var filePath = Path.Combine(currentDirectory, fileName);

                if (File.Exists(filePath))
                {
                    //đảm bảo file được mở bằng ứng dụng mặc định của hệ thống.
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("File không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng các form trước
            CloseAllChildForms();

            frmGioiThieu frm = new frmGioiThieu();
            if (!CheckExistForm("frmGioiThieu"))
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Set the form to open maximized
                frm.Dock = DockStyle.Fill; // Make sure the form fills the parent container
                frm.Show();
                frm.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                ActiveChildForm("frmGioiThieu");
            }
        }
    }
}
