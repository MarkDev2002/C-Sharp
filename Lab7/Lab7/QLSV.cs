using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "SinhVien")
                {
                    f.Activate();
                    return;
                }

            frmSinhVien frmsv = new frmSinhVien{ MdiParent = this.MdiParent };
            //sv.MdiParent = this;
            frmsv.Show();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Dispose();
        }

        private void BtnKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Khoa")
                {
                    f.Activate();
                    return;
                }

            frmKhoa frmkh = new frmKhoa { MdiParent = this.MdiParent };
            frmkh.Show();
        }

        private void BtnMon_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
                if (f.Name == "Mon")
                {
                    f.Activate();
                    return;
                }

            frmMon frmm = new frmMon { MdiParent = this.MdiParent };
            frmm.Show();
        }

        private void BtnNhapDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Diem")
                {
                    f.Activate();
                    return;
                }

            frmDiem frm = new frmDiem { MdiParent = this.MdiParent };
            frm.Show();
        }

        private void BtnXemDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "XemDiem")
                {
                    f.Activate();
                    return;
                }

            frmXemDiem frm = new frmXemDiem { MdiParent = this.MdiParent };
            frm.Show();
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "SVTheoKhoa")
                {
                    f.Activate();
                    return;
                }

            frmSVTheoKhoa frm = new frmSVTheoKhoa { MdiParent = this.MdiParent };
            frm.Show();
        }
    }
}
