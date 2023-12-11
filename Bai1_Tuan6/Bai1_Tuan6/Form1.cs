using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai1_Tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetPay()
        {

            string name = txtName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên khách hàng không được rỗng");
            }

            int count = Convert.ToInt32(Math.Round(numFilling.Value, 0));
            int total = 0;
            if (chkClean.Checked)
            {
                total += 100000;
            }

            if (chkWhitening.Checked)
            {
                total += 1200000;
            }
            if (chkXRay.Checked)
            {
                total += 200000;
            }
            total += count * 80000;
            string formattedNumber = string.Format("{0:N0}", total);
            txtTotal.Text = formattedNumber;

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtTotal.Text = string.Empty;
            chkClean.Checked = false;
            chkWhitening.Checked = false;
            chkXRay.Checked = false;
            numFilling.Value = 0;
        }
    }
}