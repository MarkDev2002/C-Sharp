using BUS;
using DAO;
using DTO;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class StatisticGUI : Form
    {
        private BindingSource bindingSource;
        List<BillDTO> listBill = new List<BillDTO>();
        List<ProductDTO> listProduct = new List<ProductDTO>();
        List<CustomerDTO> listCustomer = new List<CustomerDTO>();
        List<StaffDTO> listStaff = new List<StaffDTO>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        public StatisticGUI()
        {
            InitializeComponent();
			
			this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            chartDefault.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chartDefault.Width, chartDefault.Height, 20, 20));
            chartStatistic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chartStatistic.Width, chartStatistic.Height, 20, 20));
            txtAll.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtAll.Width, txtAll.Height, 20, 20));
            dtgvTop.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtgvTop.Width, dtgvTop.Height, 20, 20));

            listBill = BillBUS.Instance.GetList();
            listProduct = ProductBUS.Instance.GetList();
            listCustomer = CustomerBUS.Instance.GetList();
            listStaff = StaffBUS.Instance.GetList();
        }

        private void StatisticGUI_Load(object sender, EventArgs e)
        {
            DefaultDisplay();
			guna2Panel3.Enabled = false;
			dateTimePicker1.Enabled = false;
			lblBill.Text = listBill.Count.ToString();
            lblProduct.Text = listProduct.Count.ToString();
            lblCustomer.Text = listCustomer.Count.ToString();
            lblStaff.Text = listStaff.Count.ToString();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton2.Checked)
            {
				if (rbNormal.Checked)
				{

					if (rbProduct.Checked)
					{
						if (string.IsNullOrEmpty(txtID.Text))
						{
							MessageBox.Show("Bạn chưa chọn ID sản phẩm");
							return;
						}
						StatisticNormalProduct();
					}
					if (rbStaff.Checked)
					{
						if (string.IsNullOrEmpty(txtID.Text))
						{
							MessageBox.Show("Bạn chưa chọn ID nhân viên");
							return;
						}
						StatisticNormalStaff();
					}
					if (rbCustomer.Checked)
					{
						if (string.IsNullOrEmpty(txtID.Text))
						{
							MessageBox.Show("Bạn chưa chọn ID khách hàng");
							return;
						}
						StatisticNormalCustomer();
					}
				}
				if (rbAll.Checked)
				{
					if (rbProduct.Checked)
					{
						StatisticAllProduct();
					}
					if (rbStaff.Checked)
					{
						StatisticAllStaff();
					}
					if (rbCustomer.Checked)
					{
						StatisticAllCustomer();
					}
				}
				if (rbTop.Checked)
				{
					if (rbProduct.Checked)
					{
						StatisticTopProduct();
					}
					if (rbStaff.Checked)
					{
						StatisticTopStaff();
					}
					if (rbCustomer.Checked)
					{
						StatisticTopCustomer();
					}
				}
			}
            else
            {
				LoadChart(dateTimePicker1.Value.Year.ToString());
			}

		}

        private void btnView_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DefaultDisplay();
			guna2Panel3.Enabled = false;
			dateTimePicker1.Enabled = false;
		}

        private void btnChooseStaff_Click(object sender, EventArgs e)
        {
			if (rbNormal.Checked)
			{
				if (rbProduct.Checked)
				{
					SubProductGUI form = new SubProductGUI(this,1);
					if (!form.IsDisposed)
					{
						this.Opacity = 0.5;
					}
					form.ShowDialog();
					if (form.IsDisposed)
					{
						this.Opacity = 1;
					}
				}
				if (rbStaff.Checked)
				{
					SubProductGUI form = new SubProductGUI(this,2);
					if (!form.IsDisposed)
					{
						this.Opacity = 0.5;
					}
					form.ShowDialog();
					if (form.IsDisposed)
					{
						this.Opacity = 1;
					}
				}
				if (rbCustomer.Checked)
				{
					SubProductGUI form = new SubProductGUI(this,3);
					if (!form.IsDisposed)
					{
						this.Opacity = 0.5;
					}
					form.ShowDialog();
					if (form.IsDisposed)
					{
						this.Opacity = 1;
					}
				}
			}
			
        }
		private void DefaultDisplay()
		{
			lblID.Text = "ID";
			txtID.Text = "";

            guna2CustomRadioButton1.Checked = false;
            guna2CustomRadioButton2.Checked = false;
            radioButton1.Checked = false;
            radioButton3.Checked = false;
			rbNormal.Checked = false;
			rbAll.Checked = false;
			rbTop.Checked = false;
			rbProduct.Checked = false;
			rbStaff.Checked = false;
			rbCustomer.Checked = false;

			chartDefault.Show();
			chartStatistic.Hide();
			txtAll.Hide();
			dtgvTop.Hide();
			dateTo.Value = DateTime.Now;
			dateFrom.Value = DateTime.Now.AddDays(-1);

			LoadDefaultChart("2023");
			ActiveStatistic(false);
		}
		private void LoadDefaultChart(string year)
		{
			DataTable dt = StatisticDAO.Instance.StatisticAmountProductEachMonthByChart(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList(),year);
			chartDefault.DataSource = dt;
			chartDefault.Series.Clear();
			string seryName = "";
			for (int i = 1; i < dt.Columns.Count; i++)
			{
				seryName = dt.Columns[i].ColumnName;
				chartDefault.Series.Add(seryName);
				chartDefault.Series[seryName].XValueMember = dt.Columns[0].ColumnName;
				chartDefault.Series[seryName].YValueMembers = seryName;
				chartDefault.Series[seryName].IsValueShownAsLabel = true;
			}
			chartDefault.Series[0].Name = "Amount Out";
			chartDefault.Series[1].Name = "Amount In";
			chartDefault.ChartAreas[0].AxisX.Interval = 1;
			chartDefault.DataBind();
		}
		private void StatisticNormalProduct()
        {
            DataTable dt = StatisticDAO.Instance.StatisticEachProductByChart(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList(), txtID.Text.ToString(), dateFrom.Value.ToString("yyyy/MM/dd"), dateTo.Value.ToString("yyyy/MM/dd"));
            dt.Columns.Add("Product");
            List<ProductDTO> prdList = ProductBUS.Instance.GetList();
            int size = prdList.Count;
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < size; i++)
                {
                    if (prdList[i].IdProduct.ToString() == txtID.Text.ToString())
                    {
                        row["Product"] = prdList[i].NameProduct.ToString();
                        break;
                    }
                }
            }
            dt.AcceptChanges();
            chartStatistic.DataSource = dt;
			chartStatistic.Titles.Clear();
			chartStatistic.Titles.Add("Product Out-In Statistic (" + dateFrom.Value.ToString("dd/MM/yyyy") + "-" + dateTo.Value.ToString("dd/MM/yyyy") + ")");
			chartStatistic.Series.Clear();
            string seryName = "";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i != 1 && i != 3 && i != 4)
                {
                    seryName = dt.Columns[i].ColumnName;
                    chartStatistic.Series.Add(seryName);
                    chartStatistic.Series[seryName].XValueMember = dt.Columns[4].ColumnName;
                    chartStatistic.Series[seryName].YValueMembers = seryName;
                    chartStatistic.Series[seryName].IsValueShownAsLabel = true;
                }
            }
            chartStatistic.Series[0].Name = "Amount Out";
            chartStatistic.Series[1].Name = "Amount In";
            chartStatistic.DataBind();
        }

        private void StatisticNormalStaff()
        {
            DataTable dt = StatisticDAO.Instance.StatisticEachStaffByChart(txtID.Text.ToString(), dateTo.Value.ToString("yyyy/MM/dd"), dateFrom.Value.ToString("yyyy/MM/dd"));
            chartStatistic.DataSource = dt;
            chartStatistic.Titles.Clear();
			chartStatistic.Titles.Add("Staff Sales Amount Statistic (" + dateFrom.Value.ToString("dd/MM/yyyy") + "-" + dateTo.Value.ToString("dd/MM/yyyy") + ")");
			chartStatistic.Series.Clear();
            string seryName = "";
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                seryName = dt.Columns[i].ColumnName;
                chartStatistic.Series.Add(seryName);
                chartStatistic.Series[seryName].XValueMember = dt.Columns[0].ColumnName;
                chartStatistic.Series[seryName].YValueMembers = seryName;
                chartStatistic.Series[seryName].IsValueShownAsLabel = true;
            }
            chartStatistic.Series[0].Name = "Amount Out";
            chartStatistic.ChartAreas[0].AxisX.Interval = 1;
            chartStatistic.DataBind();
        }

        private void StatisticNormalCustomer()
        {
            DataTable dt = StatisticDAO.Instance.StatisticEachCustomerByChart(txtID.Text.ToString(), dateTo.Value.ToString("yyyy/MM/dd"), dateFrom.Value.ToString("yyyy/MM/dd"));
            chartStatistic.DataSource = dt;
			chartStatistic.Titles.Clear();
			chartStatistic.Titles.Add("Customer Purchase Amount Statistic (" + dateFrom.Value.ToString("dd/MM/yyyy") + "-" + dateTo.Value.ToString("dd/MM/yyyy") + ")");
            chartStatistic.Series.Clear();
            string seryName = "";
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                seryName = dt.Columns[i].ColumnName;
                chartStatistic.Series.Add(seryName);
                chartStatistic.Series[seryName].XValueMember = dt.Columns[0].ColumnName;
                chartStatistic.Series[seryName].YValueMembers = seryName;
                chartStatistic.Series[seryName].IsValueShownAsLabel = true;
            }
            chartStatistic.Series[0].Name = "Bought Quantity";
            chartStatistic.ChartAreas[0].AxisX.Interval = 1;
            chartStatistic.DataBind();
        }

        private void StatisticAllProduct()
        {
            txtAll.Clear();
            txtAll.Text = StatisticDAO.Instance.StatisticAllProduct(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList());
        }

        private void StatisticAllStaff()
        {
            txtAll.Clear();
            txtAll.Text = StatisticDAO.Instance.StatisticAllStaff(BillBUS.Instance.GetList());
        }

        private void StatisticAllCustomer()
        {
            txtAll.Clear();
            txtAll.Text = StatisticDAO.Instance.StatisticAllCustomer(BillBUS.Instance.GetList());
        }

        private void StatisticTopProduct()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = StatisticDAO.Instance.StatisticTopProduct(BillBUS.Instance.GetList());
            dtgvTop.DataSource = bindingSource;
        }

        private void StatisticTopStaff()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = StatisticDAO.Instance.StatisticTopStaff(BillBUS.Instance.GetList());
            dtgvTop.DataSource = bindingSource;
        }

        private void StatisticTopCustomer()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = StatisticDAO.Instance.StatisticTopCustomer(BillBUS.Instance.GetList());
            dtgvTop.DataSource = bindingSource;
        }

        

        private void ActiveStatistic(bool active)
        {
            
            pnl1.Enabled = active;
            pnl2.Enabled = active;
            txtID.Enabled = false;
            btnChooseStaff.Enabled = false;
            dateFrom.Enabled = active;
            dateTo.Enabled = active;
            btnStatistic.Enabled = active;
            //btnView.Enabled = active;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                chartDefault.Hide();
                chartStatistic.Show();
                txtAll.Hide();
                dtgvTop.Hide();
                ActiveStatistic(true);
				btnStatistic.Enabled = false;
				//btnView.Enabled = false;
                rbCustomer.Checked = false;
                rbProduct.Checked = false;
                rbStaff.Checked = false;
				txtID.Enabled = true;
                btnChooseStaff.Enabled = true;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
				rbStaff.Enabled = true;
				rbCustomer.Enabled = true;
				chartDefault.Hide();
                chartStatistic.Hide();
                txtAll.Show();
                dtgvTop.Hide();
                ActiveStatistic(true);
				btnStatistic.Enabled = false;
				//btnView.Enabled = false;
				rbCustomer.Checked = false;
				rbProduct.Checked = false;
				rbStaff.Checked = false;
			}
        }

        private void rbTop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTop.Checked)
            {
				rbStaff.Enabled = true;
				rbCustomer.Enabled = true;
				chartDefault.Hide();
                chartStatistic.Hide();
                txtAll.Hide();
                dtgvTop.Show();
                ActiveStatistic(true);
				btnStatistic.Enabled = false;
				//btnView.Enabled = false;
				rbCustomer.Checked = false;
				rbProduct.Checked = false;
				rbStaff.Checked = false;
			}
        }

        private void rbProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                lblID.Text = "Product ID";
                txtID.Text = "";
				btnStatistic.Enabled = true;
				//btnView.Enabled = true;
			}
        }

        private void rbStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStaff.Checked)
            {
                lblID.Text = "Staff ID";
				txtID.Text = "";
				btnStatistic.Enabled = true;
				//btnView.Enabled = true;
			}
		}

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                lblID.Text = "Customer ID";
				txtID.Text = "";
				btnStatistic.Enabled = true;
				//btnView.Enabled = true;
			}
		}

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 190;
            int starty = 40;
            int offset = 30;

            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("WELCOME TO OUR STORE", new Font("Courier New", 20), new SolidBrush(Color.Black), startx, starty);
            offset = offset + (int)FontHeight;
            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 50;
            graphics.DrawString("ProductID\t\tProductName\t\t\t\tAmout", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;

            foreach (DataGridViewRow row in dtgvTop.Rows)
            {
                graphics.DrawString(row.Cells["ProductID"].Value.ToString() + "\t\t" + row.Cells["ProductName"].Value.ToString() + "\t" + row.Cells["Amount"].Value.ToString(), new Font("Courier New", 14), new SolidBrush(Color.Black), 20, starty + offset);
                offset = offset + 35;
            }

            offset = offset + (int)FontHeight + 5;
            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;


            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;
            graphics.DrawString("Thank you buying!", font, new SolidBrush(Color.Black), 20, starty + offset);
        }

		private void dateFrom_ValueChanged(object sender, EventArgs e)
		{
            if (DateTime.Compare(dateFrom.Value, dateTo.Value)<=0)
            {
				
            }
            else
            {
				MessageBox.Show("Start date is later than end date!");
                dateFrom.Value = dateTo.Value;
			}
		}

		private void dateTo_ValueChanged(object sender, EventArgs e)
		{
			if (DateTime.Compare(dateFrom.Value, dateTo.Value) <= 0)
			{

			}
			else
			{
				MessageBox.Show("Start date is later than end date!");
                dateTo.Value = dateFrom.Value;
			}
		}

		private void dtgvTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
        private void setAllOffCustom(bool active)
        {
            rbAll.Checked = active;
            rbNormal.Checked = active;
            rbTop.Checked = active;
            rbProduct.Checked = active;
            rbCustomer.Checked = active;
            rbStaff.Checked = active;
            txtID.Text = "";

            pnl1.Enabled = active;
            pnl2.Enabled = active;
            btnChooseStaff.Enabled = active;
            txtID.Enabled = active;
            dateTo.Enabled = active;
            dateFrom.Enabled = active;
        }

		private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
            guna2Panel3.Enabled = true;
            setAllOffCustom(false);
			btnStatistic.Enabled = false;
			//btnView.Enabled = false;

		}
        private int opt_default;
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePicker1.Enabled = true;
			btnStatistic.Enabled = true;
			//btnView.Enabled = true;
			opt_default = 1;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePicker1.Enabled = true;
			btnStatistic.Enabled = true;
			//btnView.Enabled = true;
			opt_default = 2;
		}

		private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
		{
            radioButton1.Checked = false;
            radioButton3.Checked = false;

            guna2Panel3.Enabled = false;
            dateTimePicker1.Enabled = false;

			btnStatistic.Enabled = false;
			//btnView.Enabled = false;

			pnl1.Enabled = true;
		}
		private void LoadChart(string year) {
            DataTable dt;
			chartStatistic.Hide();
			dtgvTop.Hide();
			chartDefault.Show();
			if (opt_default == 1)
            {
				dt = StatisticDAO.Instance.StatisticAmountProductEachMonthByChart(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList(), year);
			}
			else
            {
				dt = StatisticDAO.Instance.StatisticMoneyProductEachMonthByChart(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList(), year);
			}
			chartDefault.DataSource = dt;
			chartDefault.Series.Clear();
			string seryName = "";
			for (int i = 1; i < dt.Columns.Count; i++)
			{
				seryName = dt.Columns[i].ColumnName;
				chartDefault.Series.Add(seryName);
				chartDefault.Series[seryName].XValueMember = dt.Columns[0].ColumnName;
				chartDefault.Series[seryName].YValueMembers = seryName;
				chartDefault.Series[seryName].IsValueShownAsLabel = true;
			}
			chartDefault.Series[0].Name = "Amount Out";
			chartDefault.Series[1].Name = "Amount In";
			chartDefault.ChartAreas[0].AxisX.Interval = 1;
			chartDefault.DataBind();
		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
            
		}

        private void chartDefault_Click(object sender, EventArgs e)
        {

        }
    }
}
