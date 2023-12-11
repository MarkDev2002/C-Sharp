using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUS;
using DTO;
namespace GUI
{
    public partial class AddSup : KryptonForm
    {

        public AddSup()
        {
            InitializeComponent();
            txtID.Enabled = false;
            txtID.Text = SupplierBUS.Instance.SetAutoID();
        }
        private void Clear()
        {
            txtFax.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void btnCreateSub_Click(object sender, EventArgs e)
        {
            SupplierDTO sup = new SupplierDTO();

            sup.SuppierID1 = txtID.Text;

            sup.Suppiername1 = txtName.Text;
            sup.PhoneNumber1 = txtPhone.Text;
            sup.Address1 = txtAddress.Text;
            sup.FaxNumber1 = txtFax.Text;

            SupplierBUS supbus = new SupplierBUS();
            string kq = supbus.AddSup(sup.SuppierID1, sup.Suppiername1, sup.PhoneNumber1, sup.Address1, sup.FaxNumber1);
            if (kq == "success")
            {
              
                MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
				txtID.Text = SupplierBUS.Instance.SetAutoID();
			}
            if (kq == "saidinhdang")
            {
                MessageBox.Show("Sai định dạng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_SupId_isNull" || kq == "error_Supname" || kq == "error_Phonenull" || kq == "error_Faxnull" || kq == "error_Address")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_phone")
            {
                MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_fax")
            {
                MessageBox.Show("Sai định dạng số Fax", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_SupId")
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
