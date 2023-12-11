using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductLists : KryptonForm
    {
        private ProductBUS productBUS;
        //private CreateImports _createImport;
        ImportDetailDTO importDetailDTO;
        private CreateImport _createImport;
        public ProductLists()
        {
            InitializeComponent();
            productBUS = new ProductBUS();
        }

        public ProductLists(CreateImport createImport)
        {
            InitializeComponent();
            productBUS = new ProductBUS();
            importDetailDTO = new ImportDetailDTO();
            _createImport = createImport;
        }


        public void DisableColumn()
        {
            //dtgv.Columns["Size"].Visible = false;
            dtgv.Columns["Color"].Visible = false;
            dtgv.Columns["Amount"].Visible = false;
            dtgv.Columns["Description"].Visible = false;
            dtgv.Columns["IDCategory"].Visible = false;
            dtgv.Columns["IDProducer"].Visible = false;
            dtgv.Columns["Image"].Visible = true;
            dtgv.Columns["Status"].Visible = false;
        }
        private void ChangeHeader()
        {

            dtgv.Columns["IDProduct"].HeaderText = "ProductID";
            dtgv.Columns["NameProduct"].HeaderText = "Nam" +
                "eProduct";
            dtgv.Columns["Size"].HeaderText = "Size";
            dtgv.Columns["Image"].HeaderText = "Image";
            dtgv.Columns["Price"].HeaderText = "Price";
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = productBUS.GetALLList();
            dtgv.ReadOnly = true;
            ((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            ChangeHeader();
            DisableColumn();
            dtgv.AutoGenerateColumns = false;
        }


        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            int quantity = 0;
            bool inCart = true;

            DataGridViewRow selectedRows = dtgv.Rows[ind];

            importDetailDTO.ProductID = selectedRows.Cells["IDProduct"].Value.ToString();
            importDetailDTO.UnitPrice = double.Parse(selectedRows.Cells["Price"].Value.ToString());
            importDetailDTO.Quantity = quantity;

            foreach (DataGridViewRow row in _createImport.dtgv.Rows)
            {
                if (row.Cells["ProductID"].Value == null)
                {
                    row.Cells["ProductID"].Value = "";
                }

                if (row.Cells["ProductID"].Value.ToString() == selectedRows.Cells["IDProduct"].Value.ToString())
                {
                    row.Cells["Quantity"].Value = int.Parse(row.Cells["Quantity"].Value.ToString()) + 1;
                    inCart = false;
                }
            }

            if (inCart)
            {
				_createImport.dtgv.Rows.Add(importDetailDTO.ProductID, importDetailDTO.Quantity, importDetailDTO.UnitPrice, importDetailDTO.Quantity * importDetailDTO.UnitPrice);
			}
			//_createImport.dtgv.CurrentCell = _createImport.dtgv.Rows[dtgv.Rows.Count].Cells["Quantity"];
			//_createImport.dtgv.BeginEdit(true);
            this.Hide();
        }

        List<ImportDetailDTO> importDetailList = new List<ImportDetailDTO>();


    }
}
