using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
	public partial class ShowDetail : Form
	{
		private bool is_import = false;
		private ProductBUS productBUS = new ProductBUS();
		private string ID;
		public ShowDetail()
		{
			InitializeComponent();
		}
		public ShowDetail(string ID, int check)
		{
			InitializeComponent();
			if (check == 1)
			{
				is_import = true;
			}
			else
			{
				is_import = false;
			}
			this.ID = ID;
		}
		private void ShowDetail_Load(object sender, EventArgs e)
		{
			if(is_import)
			{
				dtgv.DataSource = productBUS.GetProductByImportId(ID);
			}
			else
			{
				dtgv.DataSource = productBUS.GetProductByBillId(ID);
			}
			dtgv.AutoGenerateColumns = false;
			dtgv.ReadOnly = true;
			((DataGridViewImageColumn)dtgv.Columns["IMG"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
			dtgv.Columns["IMG"].Width = 70;
			ChangeHeader();
		}
		private void ChangeHeader()
		{
			
			dtgv.Columns["ProductID"].HeaderText = "ID";
			dtgv.Columns["ProductName"].HeaderText = "Name";
			dtgv.Columns["Size"].HeaderText = "Size";
			dtgv.Columns["IMG"].HeaderText = "Image";
			dtgv.Columns["UnitPrice"].HeaderText = "Unit Price";
		}
	}
}
