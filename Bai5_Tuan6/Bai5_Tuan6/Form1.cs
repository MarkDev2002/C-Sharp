namespace Bai5_Tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Không để trống", "Thông báo");
            }
            else
            {
                lstBox1.Items.Add(txtInput.Text);
                txtInput.Text = ""; 
                txtInput.Focus();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int n = lstBox1.SelectedItems.Count;  
            for (int i = 0; i <= n - 1; ++i)
            {
                lstBox2.Items.Add(lstBox1.SelectedItems[i].ToString());
                for (int j = n - 1; j >= 0; --j)
                {
                    lstBox1.Items.RemoveAt(j);
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int n = lstBox2.SelectedItems.Count;  //Tong  so  muc  duoc  chon
            for (int i = 0; i <= n - 1; ++i)
            {
                lstBox1.Items.Add(lstBox2.SelectedItems[i].ToString());
                for (int j = n - 1; j >= 0; --j)
                {
                    lstBox2.Items.RemoveAt(j);
                }
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            int n = lstBox1.Items.Count;
            for (int i = 0; i <= n - 1; ++i)
            {
                lstBox2.Items.Add(lstBox1.Items[i].ToString());
            }
            lstBox1.Items.Clear(); // Xóa tất cả mục trong lstBox1

        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            int n = lstBox2.Items.Count;
            for (int i = 0; i < n; ++i)
            {
                lstBox1.Items.Add(lstBox2.Items[i].ToString());
            }
            lstBox2.Items.Clear(); // Xóa tất cả mục trong lstBox2
        }
        private void btKetthuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Đóng ứng dụng
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Clear();
            lstBox2.Items.Clear();
        }


    }
}