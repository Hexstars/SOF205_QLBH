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
    public partial class frmThongKe : Form
    {
        BUS_ThongKe TK = new BUS_ThongKe();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadGridView_Nhap();
        }
        public void LoadGridView_Nhap()
        {
            dgvDS.DataSource = TK.SanPhamNhap();
            dgvDS.Columns[0].HeaderText = "Mã NV";
            dgvDS.Columns[1].HeaderText = "Tên NV";
            dgvDS.Columns[2].HeaderText = "Số lượng";
        }
    }
}
