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
using ComponentFactory.Krypton.Toolkit;
using DAO;
using DTO;

namespace GUI
{
	public partial class LinkAcc : KryptonForm
	{
		private StaffBUS STAFFBUS = new StaffBUS();
		private StaffDTO staffDTO;
		public LinkAcc()
		{
			InitializeComponent();
			LoadComboBoxUserID();
			LoadComboBoxStaffID();
		}
		public void LoadComboBoxUserID()
		{
			cbxUserID.DataSource = AccountBUS.Instance.GetListNotInStaff();
			cbxUserID.DisplayMember = "UserID";
			cbxUserID.ValueMember = "UserID";
			cbxUserID.SelectedItem = null;
		}
		public void LoadComboBoxStaffID()
		{
			cbxStaffID.DataSource = StaffBUS.Instance.GetList();
			cbxStaffID.DisplayMember = "IdStaff";
			cbxStaffID.ValueMember = "IdStaff";
			cbxStaffID.SelectedItem = null;
		}
		private void AddAccToStaff_Load(object sender, EventArgs e)
		{

		}

		private void btnAddAccToStaff_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbxStaffID.Text) ||
				string.IsNullOrEmpty(cbxUserID.Text))
			{
				MessageBox.Show("Trường dữ liệu không được để trống");
				return;
			}
			staffDTO = new StaffDTO(cbxStaffID.Text, cbxUserID.Text);
			if (StaffDAO.Instance.UpdateAddAccount(staffDTO))
			{
				MessageBox.Show("Link Account Successfully!");
				LoadComboBoxStaffID();
				LoadComboBoxUserID();
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra!");
			}
		}
	}
}
