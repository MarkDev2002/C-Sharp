using BUS;
using ComponentFactory.Krypton.Toolkit;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateImport : KryptonForm
    {
        private ImportDTO importDTO = new ImportDTO();
        private ImportDetailDTO importDetailDTO;
        private ImportBUS importBUS = new ImportBUS();
        private ImportDetailBUS importDetailBUS = new ImportDetailBUS();
        private List<ImportDTO> importDTOs = new List<ImportDTO>();
        private List<ImportDetailDTO> importDetailDTOs = new List<ImportDetailDTO>();
        public string supplierID;
        public string staffID;
        private StaffDTO staff;
        public CreateImport(StaffDTO staffDTO)
        {
            InitializeComponent();
            dtgv.Columns["ProductID"].ReadOnly = true;
			dtgv.Columns["UnitPrice"].ReadOnly = true;
			dtgv.Columns["Total"].ReadOnly = true;
            lbStaffID.Text = staffDTO.IdStaff;
            lbNameStaff.Text = staffDTO.LastName + " " +staffDTO.FirstName;
            lbPhoneStaff.Text = staffDTO.Phone;
            staff = staffDTO;
		}
		public CreateImport()
		{
			InitializeComponent();
			dtgv.Columns["ProductID"].ReadOnly = true;
			dtgv.Columns["UnitPrice"].ReadOnly = true;
			dtgv.Columns["Total"].ReadOnly = true;
			
		}
		public static CreateImport _instance;

        public static CreateImport Instance
        {
            get { if (_instance == null) _instance = new CreateImport(); return _instance; }
            private set { _instance = value; }
        }
        private void CreateImport_Load(object sender, EventArgs e)
        {
            dtgv.AutoGenerateColumns = false;
        }

        private void labSupplier_Click(object sender, EventArgs e)
        {
            ShowSupplier sp = new ShowSupplier(this);
            sp.Show();
        }

        private void labStaff_Click(object sender, EventArgs e)
        {
            ShowStaff st = new ShowStaff(this);
            st.Show();

        }

        private void lbProduct_Click(object sender, EventArgs e)
        {
            ProductLists p = new ProductLists(this);
            //this.Hide();
            p.Show();

        }
        private bool check_error = false;
        private void dtgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int n = 0;
			if (dtgv.Rows[e.RowIndex].Cells[1].Value == null)
			{
				MessageBox.Show("Giá trị nhập không hợp lệ!");
				dtgv.Rows[e.RowIndex].Cells[1].Value = "0"; // Fix
				check_error = true;
			}
			else if (dtgv.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                if (!int.TryParse(dtgv.Rows[e.RowIndex].Cells[1].Value.ToString(), out n))
                {
					MessageBox.Show("Giá trị nhập không hợp lệ!");
					dtgv.Rows[e.RowIndex].Cells[1].Value = "0";
					check_error = true;
				}
				else
                {
					double subTotal = 0;
                    check_error = false;
					foreach (DataGridViewRow row in dtgv.Rows)
					{
						row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
							Convert.ToDouble(row.Cells["UnitPrice"].Value);

						subTotal += double.Parse(row.Cells["Total"].Value.ToString());
						lbSubTotal.Text = subTotal.ToString();
					}
					lblTotal.Text = ((subTotal * 1.05) + 10).ToString();
				}
            }

            
        }

        private void dtgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

		}



		private void dtgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            double subTotal = 0;
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["UnitPrice"].Value);

                subTotal += double.Parse(row.Cells["Total"].Value.ToString());
                lbSubTotal.Text = subTotal.ToString();
            }

            lblTotal.Text = ((subTotal * 1.05) + 10).ToString();
        }

        

        private void btnImportSave_Click(object sender, EventArgs e)
        {
            if(check_error)
            {
                MessageBox.Show("Dữ liệu đã nhập chưa hợp lệ","Error");
            }else
            if (String.IsNullOrEmpty(lbSuppID.Text))
            {
                MessageBox.Show("Please choose Supplier first!","Error");
            }else if (dtgv.Rows.Count <= 0)
            {
				MessageBox.Show("Don't have any product in cart!", "Error");
			}
            else
            {
				bool flag = false;
				string importOrder = importBUS.getIDImport();

				importDTO.ImportID = importOrder;
				importDTO.SupplierID = lbSuppID.Text;
				//importDTO.StaffID = staffID;
				importDTO.StaffID = lbStaffID.Text;
				importDTO.Total = double.Parse(lblTotal.Text.ToString());
                
				foreach (DataGridViewRow row in dtgv.Rows)
				{

					importDetailDTOs.Add(new ImportDetailDTO(importOrder,
						row.Cells["ProductID"].Value.ToString(),
						int.Parse(row.Cells["Quantity"].Value.ToString()),
						double.Parse(row.Cells["UnitPrice"].Value.ToString())
					));
				}
				importBUS.Insert(importDTO.ImportID, importDTO.SupplierID, importDTO.StaffID, importDTO.Total);

				foreach (ImportDetailDTO importDetail in importDetailDTOs)
				{
					if (importDetailBUS.Insert(importDetail.ImportID, importDetail.ProductID, importDetail.Quantity, importDetail.UnitPrice))
					{
                        ProductBUS.Instance.UpdateAmount(importDetail.Quantity, importDetail.ProductID);
		                flag = true;
					}
					else
					{
						MessageBox.Show("Xu ly hoa don truoc");
					}
				}

				if (flag)
				{
					MessageBox.Show("Successfully!");
					this.Controls.Clear();
					this.InitializeComponent();
				}
			}
			

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void bunifuPanel6_Click(object sender, EventArgs e)
        {

        }

       

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            AddSup f = new AddSup();
            f.ShowDialog();
        }

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.Controls.Clear();
			this.InitializeComponent();
			lbStaffID.Text = staff.IdStaff;
			lbNameStaff.Text = staff.LastName + " " + staff.FirstName;
			lbPhoneStaff.Text = staff.Phone;
		}
	}
}
