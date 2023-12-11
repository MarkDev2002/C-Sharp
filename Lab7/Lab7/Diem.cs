using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void KetQuaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ketQuaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basicStudentManagementDataSet);

        }

        private void FrmDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.basicStudentManagementDataSet.Mon);
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.basicStudentManagementDataSet.SinhVien);
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.basicStudentManagementDataSet.KetQua);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                var connStr = "Data Source=DESKTOP-OJJ6ENT;Initial Catalog=BasicStudentManagement;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connStr);
                String query = "INSERT INTO KetQua (MaSo,MaMH,Diem) values (" + int.Parse(comboBox1.Text) + ", N'" + comboBox4.Text + "'," + int.Parse(diemTextBox.Text) + ")";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Nhập thành công!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin nhập không hợp lệ!","Error");
            }
            
        }
    }
}
