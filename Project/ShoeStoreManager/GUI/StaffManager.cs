﻿using BUS;
using ComponentFactory.Krypton.Toolkit;
using DAO;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class StaffManager : KryptonForm
    {
        private StaffBUS STAFFBUS = new StaffBUS();
        private StaffDTO staffDTO;
        private StaffGUI _staff;
        private AccountBUS accountBUS = new AccountBUS();

        public StaffManager()
        {
            InitializeComponent();
            LoadComboBoxUserID();
            // Insert when update button disable
            btnUpdateStaff.Enabled = false;
        }

        public StaffManager(StaffGUI staff)
        {
            InitializeComponent();
            _staff = staff;
            LoadComboBoxUserID();
            // Insert when update button disable
            btnUpdateStaff.Enabled = false;
        }

        public StaffManager(BindingSource bds, StaffGUI staff)
        {
            InitializeComponent();
            _bds = bds;
            //txtID.Visible = false;
            cbxUserID.Enabled = false;
            _staff = staff;
        }
        public void LoadComboBoxUserID()
        {
            cbxUserID.DataSource = AccountBUS.Instance.GetListNotInStaff();
            cbxUserID.DisplayMember = "UserID";
            cbxUserID.ValueMember = "UserID";
            cbxUserID.SelectedItem = null;
        }
        private BindingSource _bds;

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();
            openPicture.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                pictureAvatar.Image = Image.FromFile(openPicture.FileName);
            }
            openPicture.Dispose();

        }

        public void LoadDtgv()
        {
            //_bds.DataSource = StaffDAO.Instance.GetAll();
            _staff.dtgv.DataSource = STAFFBUS.GetList();
        }

        private void StaffManager_Load(object sender, EventArgs e)
        {
            if (_bds != null)
            {
                LoadDtgv();
                StaffGUI.Instance.dtgv.DataSource = _bds;
                AddBinding();
            }
        }


        public void AddBinding()
        {
            //txtID.DataBindings.Add("Text", Staff.Instance.dtgv.DataSource, "IDStaff");
            //txtFirstName.DataBindings.Add("Text", Staff.Instance.dtgv.DataSource, "FirstName");
            //txtLastName.DataBindings.Add("Text", Staff.Instance.dtgv.DataSource, "LastName");
            //pictureAvatar.DataBindings.Add("Image", Staff.Instance.dtgv.DataSource, "Image", true);
            //cbxGender.DataBindings.Add("SelectedItem", Staff.Instance.dtgv.DataSource, "Gender");
            //txtYear.DataBindings.Add("Text", Staff.Instance.dtgv.DataSource, "Year");
            //txtPhone.DataBindings.Add("Text", Staff.Instance.dtgv.DataSource, "Phone");
            //txtSalary.DataBindings.Add("Text", Staff.Instance.dtgv.DataSource, "Salary");
            //txtAddress.DataBindings.Add("Text", Staff.Instance.dtgv.DataSource, "Address");
        }

        private void bunifuTextBoxProduct_TextChanged(object sender, EventArgs e)
        {

        }

        //public bool IsNumeric(this string s)
        //{
        //    float output;
        //    return float.TryParse(s, out output);
        //}

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureAvatar.Image.Save(ms, pictureAvatar.Image.RawFormat);
            byte[] img = ms.ToArray();

            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtYear.Text) ||
                string.IsNullOrEmpty(cbxGender.Text) ||
                //string.IsNullOrEmpty(cbxUserID.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtSalary.Text)
                )
            {
                MessageBox.Show("Trường dữ liệu không được để trống");
                return;
            }

            //if (IsNumeric(txtYear.Text.ToString()) ||
            //    IsNumeric(txtSalary.Text.ToString())) {
            //    MessageBox.Show("Ban da nhap sai dinh dang so trong truong Year hoac Salary");
            //    return;
            //}

            staffDTO = new StaffDTO(txtID.Text.ToString(),
                cbxUserID.Text.ToString(),
                txtFirstName.Text.ToString(),
                txtLastName.Text.ToString(),
                int.Parse(txtYear.Text.ToString()),
                cbxGender.SelectedItem.ToString(),
                txtPhone.Text.ToString(),
                txtAddress.Text.ToString(),
                double.Parse(txtSalary.Text.ToString()),
                img
                );

            if (StaffDAO.Instance.Update(staffDTO))
            {
                MessageBox.Show("Update successfull!");
            }
            else
            {
                MessageBox.Show("Xu ly hoa don truoc");
            }
            LoadDtgv();
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureAvatar.Image.Save(ms, pictureAvatar.Image.RawFormat);
            byte[] img = ms.ToArray();

            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtYear.Text) ||
                string.IsNullOrEmpty(cbxGender.Text) ||
                //string.IsNullOrEmpty(cbxUserID.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtSalary.Text)
    )
            {
                MessageBox.Show("Trường dữ liệu không được để trống");
                return;
            }

            //if (IsNumeric(txtYear.Text.ToString()) ||
            //    IsNumeric(txtSalary.Text.ToString()))
            //{
            //    MessageBox.Show("Ban da nhap sai dinh dang so trong truong Year hoac Salary");
            //    return;
            //}
            string idAccount;
            string username = accountBUS.SetAutoUsername();

			if (string.IsNullOrEmpty(cbxUserID.Text))
            {
                idAccount = accountBUS.SetAutoUserID();
                accountBUS.Insert(idAccount, username, "123456789", "ROL000", null, "1");
            }
            else
            {
                idAccount = cbxUserID.Text.ToString();
            }
            staffDTO = new StaffDTO(STAFFBUS.getIDStaff(),
                idAccount,
                txtFirstName.Text.ToString(),
                txtLastName.Text.ToString(),
                int.Parse(txtYear.Text.ToString()),
                cbxGender.SelectedItem.ToString(),
                txtPhone.Text.ToString(),
                txtAddress.Text.ToString(),
                double.Parse(txtSalary.Text.ToString()),
                img
            );

            if (StaffDAO.Instance.Insert(staffDTO))
            {
                MessageBox.Show("Insert successfull!\nUser ID: "+idAccount+"\nUsername: "+username+" \nPassword: 123456789");
                this.Dispose();
                LoadDtgv();
            }
            else
            {
                MessageBox.Show("Xu ly hoa don truoc");
            }
        }
    }
}
