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
    public partial class frmThongKeTonKho : Form
    {
        BUS_ThongKe TK = new BUS_ThongKe();
        public frmThongKeTonKho()
        {
            InitializeComponent();
        }

        private void frmThongKeTonKho_Load(object sender, EventArgs e)
        {
            LoadGridView_TonKho();
        }
        private void LoadGridView_TonKho()
        {
            dgvDS.DataSource = TK.SanPhamTonKho();
            dgvDS.Columns[0].HeaderText = "Tên hàng";
            dgvDS.Columns[1].HeaderText = "Số lượng";
        }
    }
}
