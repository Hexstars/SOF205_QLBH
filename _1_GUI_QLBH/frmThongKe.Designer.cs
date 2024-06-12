namespace _1_GUI_QLBH
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // dgvDS
            // 
            dgvDS.AllowUserToAddRows = false;
            dgvDS.AllowUserToDeleteRows = false;
            dgvDS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(38, 34);
            dgvDS.Name = "dgvDS";
            dgvDS.ReadOnly = true;
            dgvDS.RowHeadersWidth = 47;
            dgvDS.Size = new Size(1057, 567);
            dgvDS.TabIndex = 1;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 643);
            ControlBox = false;
            Controls.Add(dgvDS);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongKe";
            Text = "Sản phẩm nhập";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDS;
    }
}