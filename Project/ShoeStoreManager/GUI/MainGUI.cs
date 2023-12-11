using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainGUI : Form
    {
        Form activeForm;
        StaffDTO staffDTO1 = new StaffDTO();



        public MainGUI()
        {
            InitializeComponent();


        }

        public MainGUI(StaffDTO staffDTO)
        {
            InitializeComponent();

            staffDTO1 = staffDTO;
			int flag = UserBUS.Instance.checkRoleID(staffDTO1.UserId);
			if (flag == 1)
			{
				OpenChildForm(new Dashboard());
				setAllButtonOn();
			}
			else if (flag == 2)
			{
				setAllButtonOff();
				checkFunctionOfRole(flag);
				guna2Button1.Visible = true;
				OpenChildForm(new Dashboard());
			}
			else
			{
				setAllButtonOff();
				checkFunctionOfRole(flag);
				guna2Button1.Visible = true;
				OpenChildForm(new Dashboard());
			}
		}

        int IntListImg = 0;

        private void Form1_Load(object sender, EventArgs e)
        {   
		}
        private void setAllButtonOff()
        {
            btnAccount.Visible = false;
            btnBill.Visible = false;
            btnCreateBill.Visible = false;
            btnCreateImport.Visible = false;
            btnCustomer.Visible = false;
            btnImport.Visible = false;
            btnProduct.Visible = false;
            btnRoleFunc.Visible = false;
            btnStaff.Visible = false;
            btnStatistic.Visible = false;
            btnSupplier.Visible = false;
            guna2Button1.Visible = false;
        }
		private void setAllButtonOn()
		{
			btnAccount.Visible = true;
			btnBill.Visible = true;
			btnCreateBill.Visible = true;
			btnCreateImport.Visible = true;
			btnCustomer.Visible = true;
			btnImport.Visible = true;
			btnProduct.Visible = true;
			btnRoleFunc.Visible = true;
			btnStaff.Visible = true;
			btnStatistic.Visible = true;
			btnSupplier.Visible = true;
            guna2Button1.Visible = true;
		}
		private void checkFunctionOfRole(int flag)
        {
			List<RoleDetailDTO> list = new List<RoleDetailDTO>();

			if (flag == 2)
            {
                list = RoleDetailBUS.Instance.GetListBy("ROL002");
            }
            else
            {
				list = RoleDetailBUS.Instance.GetListBy("ROL003");
			}
			foreach (RoleDetailDTO roleDetailDTO in list)
			{
                switch(roleDetailDTO.FunctionID)
                {
                    case "FUC001":
                        btnCreateBill.Visible = true;
                        break;
					case "FUC002":
                        btnCreateImport.Visible = true;
						break;
					case "FUC003":
                        btnBill.Visible = true;
						break;
					case "FUC004":
                        btnImport.Visible = true;
                        break;
					case "FUC005":
                        btnProduct.Visible = true;
						break;
					case "FUC006":
                        btnCustomer.Visible = true;
						break;
					case "FUC007":
                        btnStaff.Visible = true;
						break;
					case "FUC008":
                        btnSupplier.Visible = true;
						break;
					case "FUC009":
                        btnAccount.Visible = true;
						break;
					case "FUC010":
                        btnRoleFunc.Visible = true;
						break;
					case "FUC011":
                        btnStatistic.Visible = true;
						break;
				}
			}
		}
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer_Date_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss tt");

            if (IntListImg == 0)
            {
                IntListImg = 1;
            }
            else
            {

                IntListImg = 0;
            }
        }

        private void timerLine_Tick(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = messQuestion.Show("Are you sure exit?");
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Dashboard());
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Sale(staffDTO1));
        }

        private void btnCreateImport_Click(object sender, EventArgs e)
        {

            OpenChildForm(new CreateImport(staffDTO1));
        }

        private void btnBill_Click(object sender, EventArgs e)
        {

            OpenChildForm(new BillManagerGUI());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            OpenChildForm(new ImportManager());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Product());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            OpenChildForm(new CustomerGUI());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            OpenChildForm(new StaffGUI());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierGUI());

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            OpenChildForm(new AccountGUI());
        }

        private void btnRoleFunc_Click(object sender, EventArgs e)
        {

            OpenChildForm(new RoleFuncGUI());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {

            OpenChildForm(new StatisticGUI());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(staffDTO1));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
			
		}
		private void txtDate_Click(object sender, EventArgs e)
        {

        }

		private void panelMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnZoom_Click(object sender, EventArgs e)
		{

		}

		private void guna2CircleButton3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btn_SignOut_Click_1(object sender, EventArgs e)
		{	
			DialogResult rs = messQuestion.Show("Are you sure to logout?");
			if (rs == DialogResult.Yes)
			{
				this.Hide();
				LoginGUI logout = new LoginGUI();
				logout.Show();
			}
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Dashboard());
		}
	}
}
