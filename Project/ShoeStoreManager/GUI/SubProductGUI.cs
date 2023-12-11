using BUS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class SubProductGUI : Form
    {
        private StatisticGUI statisticGUI;
        private int check_type;
        BindingSource bindingSource;
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

        public SubProductGUI(StatisticGUI statisticGUI, int type)
        {
            InitializeComponent();
            this.statisticGUI = statisticGUI;
            check_type= type;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void SubStaffGUI_Load(object sender, EventArgs e)
        {
			bindingSource = new BindingSource();
			if (check_type == 1)
            {
				bindingSource.DataSource = ProductBUS.Instance.GetList();
				dtgvProduct.DataSource = bindingSource;
				((DataGridViewImageColumn)dtgvProduct.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
			}else if (check_type == 2)
            {
				bindingSource.DataSource = StaffBUS.Instance.GetList();
				dtgvProduct.DataSource = bindingSource;
            }
            else
            {
				bindingSource.DataSource = CustomerBUS.Instance.GetList();
				dtgvProduct.DataSource = bindingSource;
			}
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (check_type == 1)
            {
				statisticGUI.txtID.Text = dtgvProduct.CurrentRow.Cells["idProduct"].Value.ToString();
			}
			else if (check_type == 2)
            {
				statisticGUI.txtID.Text = dtgvProduct.CurrentRow.Cells["IdStaff"].Value.ToString();
			}
			else
            {
				statisticGUI.txtID.Text = dtgvProduct.CurrentRow.Cells["CustomerID1"].Value.ToString();
			}
			this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
