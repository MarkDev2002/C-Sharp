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
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.basicStudentManagementDataSet.KetQua);
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.basicStudentManagementDataSet.Khoa);

            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.basicStudentManagementDataSet.SinhVien);
           

        }
        
        private void BtnXemDiem_Click(object sender, EventArgs e)
        {
            string conn = global::Lab7.Properties.Settings.Default.BasicStudentManagementConnectionString;
            string str;

            str = string.Format("Select TenMH, Diem From KetQua, Mon where [KetQua].MaMH = [Mon].MaMH AND MaSo = {0}", comboBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void khoaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

