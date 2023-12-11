using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bai4_Tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoNguyen.Text))
            {
                MessageBox.Show("Không để trống", "Thông báo");
            }
            else if ((!Int32.TryParse(txtSoNguyen.Text, out _)) || Int32.Parse(txtSoNguyen.Text) < 0)
            {
                MessageBox.Show("Nhập số nguyên dương!!!", "Thông báo");
            }
            else
            {
                lstKetqua.Items.Add(txtSoNguyen.Text);
                txtSoNguyen.Text = "";
                txtSoNguyen.Focus();
            }
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i < n; ++i)
            {
                int tam = int.Parse(lstKetqua.Items[i].ToString()) + 2;
                lstKetqua.Items.RemoveAt(i);
                lstKetqua.Items.Insert(i, tam.ToString());

            }
        }

        private void btChonchandau_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i < n - 1; ++i)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetqua.Items[i].ToString();
                    MessageBox.Show("Số chẵn đầu là : " + s, "Kết quả");
                    break;
                }
            }

        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = n - 1; i >= 0; --i)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetqua.Items[i].ToString();
                    MessageBox.Show("Số lẻ cuối là : " + s, "Kết quả");
                    break;
                }
            }

        }

        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count;
            for (int i = n - 1; i >= 0; --i)
            {
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());
            }
        }

        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Remove(lstKetqua.Items[0].ToString());
        }

        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            lstKetqua.Items.Remove(lstKetqua.Items[n - 1].ToString());
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSoNguyen.Text = "";
            lstKetqua.Items.Clear();
        }
        public class Customer
        {
            

            public Customer(string name, int cost)
            {
                this.name = name;
                this.cost = cost;
            }
            public string Name { set { name = value; } get { return name; } }
            public int Cost { get { return cost; } set { cost = value; } }
            public override string ToString()
            {
                return $"{Name} - {Cost}";
            }
        }
        string filePath = "C:\\Users\\DELL\\source\\repos\\Bai1_2_3\\Bai1_2_3\\files\\";
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath + "test.txt"))
                {
                    foreach (Customer item in listBox1.Items)
                    {
                        writer.Write($"{item.Name},{item.Cost}\n");
                    }
                }

                MessageBox.Show("Danh sách đã được lưu vào tệp thành công.", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message, "Lỗi");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            try
            {
                listBox1.Items.Clear();
                string fileContent = File.ReadAllText(filePath + "test.txt");
                string[] splitContent = fileContent.Split('\n');
                for (int i = 0; i < splitContent.Length - 1; i++)
                {
                    string[] getObj = splitContent[i].Split(",");
                    Customer customer = new Customer(getObj[0], int.Parse(getObj[1]));
                    listBox1.Items.Add(customer);
                }
                listBox1.Text = fileContent;

                MessageBox.Show("Đọc tệp thành công.", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp: " + ex.Message, "Lỗi");
            }
        }
    }
}