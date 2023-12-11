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
    public partial class AddCus : KryptonForm
    {
        public AddCus()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtID.Text = CustomerBUS.Instance.SetAutoID();
            txtSurname.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }


        private void btnCreateCus_Click(object sender, EventArgs e)
        {

            CustomerDTO cus = new CustomerDTO();

            cus.CustomerID1 = txtID.Text;
            cus.CustomerSurname1 = txtSurname.Text;
            cus.CustomerName1 = txtName.Text;
            cus.PhoneNumber1 = txtPhone.Text;
            cus.Address1 = txtAddress.Text;

            if (radMan.Checked == true)
            {
                cus.Gender1 = "Male";
            }
            else
            {
                cus.Gender1 = "Female";
            }

            CustomerBUS cusbus = new CustomerBUS();
            string kq = cusbus.AddCus(cus.CustomerID1, cus.CustomerSurname1, cus.CustomerName1, cus.Gender1, cus.PhoneNumber1, cus.Address1);
            if (kq == "success")
            {
               
                MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            if (kq == "saidinhdang")
            {
                MessageBox.Show("Sai định dạng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_CusId_isNull" || kq == "error_surname" || kq == "error_Cusname" || kq == "error_Address" || kq == "error_Phonenull")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_phone")
            {
                MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_CusId")
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
