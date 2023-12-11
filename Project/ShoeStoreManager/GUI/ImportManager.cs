using BUS;
using ComponentFactory.Krypton.Toolkit;
using DAO;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class ImportManager : KryptonForm
    {

        public static ImportManager _instance;

        public static ImportManager Instance
        {
            get { if (_instance == null) _instance = new ImportManager(); return _instance; }
            private set { _instance = value; }
        }
        List<ImportDTO> listImport = new List<ImportDTO>();
        private ImportBUS importBUS = new ImportBUS();
        private ImportDetailBUS importDetailBUS = new ImportDetailBUS();
        public ImportManager()
        {
            InitializeComponent();
        }
        private BindingSource bds = new BindingSource();

        public void LoadDtgv()
        {
            listImport = importBUS.GetList();
            bds.DataSource = listImport;
        }
        private void CreateImport_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;

            DataGridViewImageColumn image = new DataGridViewImageColumn();
            DataGridViewImageColumn detail = new DataGridViewImageColumn();
            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            image.Name = "Data";
            image.DataPropertyName = "Data";
            image.HeaderText = "";
            image.ImageLayout = DataGridViewImageCellLayout.Normal;

            detail.Name = "Data1";
            detail.DataPropertyName = "Data1";
			detail.HeaderText = "";
			detail.ImageLayout = DataGridViewImageCellLayout.Normal;
            dtgv.Columns.Add(detail);
			detail.Image = Resources.icons8_view_more_30;


            delete.Name = "Data2";
            delete.DataPropertyName = "Data2";
            delete.HeaderText = "";
            delete.ImageLayout = DataGridViewImageCellLayout.Normal;
            dtgv.Columns.Add(delete);
            delete.Image = Resources.icons8_remove_30;
   //         dtgv.Columns[0].Width = 120; // ImportID
   //         dtgv.Columns[1].Width = 120; // SupplierID
   //         dtgv.Columns[2].Width = 120; //  StaffID
   //         dtgv.Columns[3].Width = 250; // Create time
            dtgv.Columns[3].Visible = false;// Update time
            dtgv.Columns["Data1"].Width = 30;
			dtgv.Columns["Data2"].Width = 30;
			//dtgv.Columns[5].Width = 200;// Total
			ChangeHeader();
            dtgv.AutoGenerateColumns = false;

        }
        public void ChangeHeader()
        {
           
            dtgv.Columns["ImportID"].HeaderText = "ID";
            dtgv.Columns["SupplierID"].HeaderText = "Supplier ID";
            dtgv.Columns["StaffID"].HeaderText = "Staff ID";
            dtgv.Columns["CreateTime"].HeaderText = "Create Time";
            dtgv.Columns["UpdateTime"].HeaderText = "Update Time";
            dtgv.Columns["Total"].HeaderText = "Total";
        }

        private void searchImport_TextChanged(object sender, EventArgs e)
        {
            if (searchImport.Text != "")
            {
                DataTable a = new DataTable();
                a = importBUS.FindImport(searchImport.Text.ToString());
                dtgv.DataSource = a;
            }
            else
            {
                LoadDtgv();
                dtgv.DataSource = bds;
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string colName = dtgv.Columns[e.ColumnIndex].Name;

                if (colName == "Data1")
                {
                    ShowDetail p = new ShowDetail(dtgv.Rows[e.RowIndex].Cells["ImportID"].Value.ToString(),1);
                    p.ShowDialog();
                }

                else if (colName == "Data2")
                {
                    var del = MessageBox.Show("Bạn có muốn xóa đơn nhập hàng này không ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (del == DialogResult.Yes)
                    {
                        if (importDetailBUS.Delete(dtgv.Rows[e.RowIndex].Cells["ImportID"].Value.ToString()) != null)
                        {
                            if (ImportDAO.Instance.Delete(dtgv.Rows[e.RowIndex].Cells["ImportID"].Value.ToString()) != null)
                            {
                                MessageBox.Show("Bạn đã xóa thành công");
                                LoadDtgv();
                            }
                        }
                    }
                }
                else { 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void searchImport_MouseClick(object sender, MouseEventArgs e)
        {
            searchImport.Text = "";
        }

        private void exportProduct_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgv, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý nhập hàng";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount - 2; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ImportDetail p = new ImportDetail();
            DataTable a = importBUS.ChooseImportDetail(dtgv.Rows[e.RowIndex].Cells["ImportID"].Value.ToString());
            p.dtgvDetail.DataSource = a;
            p.ShowDialog();
        }

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.Controls.Clear();
			this.InitializeComponent();
		}
	}

}
