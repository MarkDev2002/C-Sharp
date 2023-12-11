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
	public partial class RemoveFromStaff : KryptonForm
	{
		private StaffBUS STAFFBUS = new StaffBUS();
		private StaffDTO staffDTO;
		public RemoveFromStaff()
		{
			InitializeComponent();
			LoadComboBoxStaffID();
		}
		public void LoadComboBoxStaffID()
		{
			cbxStaffID.DataSource = StaffBUS.Instance.GetList();
			cbxStaffID.DisplayMember = "IdStaff";
			cbxStaffID.ValueMember = "IdStaff";
			cbxStaffID.SelectedItem = null;
		}
		public void LoadComboBoxUserIDsFromStaff()
		{
			cbxUserID.DataSource = StaffBUS.Instance.GetListUserIDsFromStaff(cbxStaffID.Text);
			cbxUserID.DisplayMember = "UserId";
			cbxUserID.ValueMember = "UserId";
			cbxUserID.SelectedItem = null;
		}

		private void cbxStaffID_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadComboBoxUserIDsFromStaff();
		}
	}
}
