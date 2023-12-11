using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;


namespace GUI
{
    public partial class BillManagerGUI : KryptonForm
    {
        public static BillManagerGUI _instance;

        public static BillManagerGUI Instance
        {
            get { if (_instance == null) _instance = new BillManagerGUI(); return _instance; }
            private set { _instance = value; }
        }
        List<BillDTO> listBill = new List<BillDTO>();
        private BillBUS billBUS = new BillBUS();
        private BillDetailBUS billDetailBUS = new BillDetailBUS();
        public BillManagerGUI()
        {
            InitializeComponent();
        }
        private BindingSource bds;
        public void LoadDtgv()
        {
            bds = new BindingSource();
            bds.DataSource = billBUS.GetList();
            dtgv.DataSource = bds;
        }
        private void Bills_Load(object sender, EventArgs e)
        {
            LoadDtgv();


            DataGridViewImageColumn image = new DataGridViewImageColumn();
            DataGridViewImageColumn update = new DataGridViewImageColumn();
			DataGridViewImageColumn detail = new DataGridViewImageColumn();
			DataGridViewImageColumn delete = new DataGridViewImageColumn();
            image.Name = "Data";
            image.DataPropertyName = "Data";
            image.HeaderText = "";
            image.ImageLayout = DataGridViewImageCellLayout.Normal;


            update.Name = "Data1";
            update.DataPropertyName = "Data1";
            update.HeaderText = "";
            update.ImageLayout = DataGridViewImageCellLayout.Normal;
            dtgv.Columns.Add(update);
            update.Image = Resources.icons8_pencil_drawing_30;

			detail.Name = "Data0";
			detail.DataPropertyName = "Data0";
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
			dtgv.Columns["Data1"].Width = 30;
			dtgv.Columns["Data2"].Width = 30;
			dtgv.Columns["Data0"].Width = 30;
			//dtgv.Columns[0].Width = 150; // billid
			//dtgv.Columns[1].Width = 150; // cusid
			//dtgv.Columns[2].Width = 150; //  stafid
			//dtgv.Columns[3].Width = 170; //createtime
			dtgv.Columns[4].Visible = false;//updatetime
			//dtgv.Columns[5].Width = 150;//total
			//dtgv.Columns[6].Width = 150;//delivery
			ChangeHeader();

        }
        public void ChangeHeader()
        {
            dtgv.Columns["BillID"].HeaderText = "ID";
            dtgv.Columns["CustomerID"].HeaderText = "ID Customer";
            dtgv.Columns["StaffID"].HeaderText = "ID Staff";
            dtgv.Columns["CreateTime"].HeaderText = "Create Time";
            dtgv.Columns["UpdateTime"].HeaderText = "Update Time";
            dtgv.Columns["Total"].HeaderText = "Total";
            dtgv.Columns["delivery"].HeaderText = "Place Of Delivery";
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dtgv.Columns[e.ColumnIndex].Name;

            if (colName == "Data1")
            {
                BillUpdate p = new BillUpdate();
                //this.Hide();
                p.txtBillID.Text = dtgv.Rows[e.RowIndex].Cells["BillID"].Value.ToString();
                p.txtCustomerID.Text = dtgv.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                p.txtStaffID.Text = dtgv.Rows[e.RowIndex].Cells["StaffID"].Value.ToString();
                p.txtTotal.Text = dtgv.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                p.bunifuTextBox1.Text = dtgv.Rows[e.RowIndex].Cells["delivery"].Value.ToString();
                p.ShowDialog();
                LoadDtgv();
                //this.Show();
            }
            else if (colName == "Data2")
            {
                if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (billDetailBUS.Delete(dtgv.Rows[e.RowIndex].Cells["BillID"].Value.ToString()) != null)
                    {
                        if (billBUS.Delete(dtgv.Rows[e.RowIndex].Cells["BillID"].Value.ToString()) != null)
                        {
                            MessageBox.Show("Bạn đã xóa thành công!");
                            LoadDtgv();
                        }


                    }
                    else
                    {
                        MessageBox.Show(" Xóa không thành công!");
                    }

                }
            }
            else
            {
                ShowDetail detail = new ShowDetail(dtgv.Rows[e.RowIndex].Cells["BillID"].Value.ToString(), 2);
                detail.ShowDialog();
            }
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BillDetail p = new BillDetail();
            DataTable a = billBUS.ChooseBillDetail(dtgv.Rows[e.RowIndex].Cells["BillID"].Value.ToString());
            p.dtgv.DataSource = a;
            p.ShowDialog();


        }

        private void searchBill_TextChanged(object sender, EventArgs e)
        {

            if (searchBill.Text != "")
            {
                DataTable a = new DataTable();
                a = billBUS.FindBill(searchBill.Text.ToString());
                dtgv.DataSource = a;
            }
            else
            {
                LoadDtgv();
				dtgv.DataSource = bds;


			}
		}

        private void searchBill_MouseClick(object sender, MouseEventArgs e)
        {
            searchBill.Text = "";
        }

        private void exportBill_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ToExcel(dtgv, saveFileDialog1.FileName);
            }
            //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
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
                worksheet.Name = "Quản lý Bill";

                // export header trong DataGridView
                for (int i = 1; i < dataGridView1.ColumnCount-2; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i+2].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 1; j < dataGridView1.ColumnCount-2; j++)
                    {
                        worksheet.Cells[i + 2, j] = dataGridView1.Rows[i].Cells[j+2].Value.ToString();
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




    }
}
