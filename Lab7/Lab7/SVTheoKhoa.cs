using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class frmSVTheoKhoa : Form
    {
        public frmSVTheoKhoa()
        {
            InitializeComponent();
        }

        private void FrmSVTheoKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.basicStudentManagementDataSet.SinhVien);
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.basicStudentManagementDataSet.Khoa);

            
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string conn = global::Lab7.Properties.Settings.Default.BasicStudentManagementConnectionString;
            string str;

            str = string.Format("Select MaSo as [Mã Số], HoTen as [Họ và Tên], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính] From SinhVien, Khoa where [SinhVien].MaKhoa = [Khoa].MaKhoa and TenKhoa like N'{0}'", comboBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
