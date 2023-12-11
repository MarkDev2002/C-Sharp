using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bai1_2_3
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
            if (txtName.Text == null || txtName.Text.All(c => c == ' '))
            {
                MessageBox.Show("Hãy nhập đầy đủ họ tên!", "Lỗi hệ thống");
                txtTotal.Text = string.Empty;
                txtName.Text = string.Empty;
            }
            else
            {
                int Total = 0;
                if (chkClean.Checked)
                {
                    Total += int.Parse(lblCleanCost.Text.Split('$')[1]);
                }
                if (chkWhitening.Checked)
                {
                    Total += int.Parse(lblWhiteningCost.Text.Split('$')[1]);
                }
                if (chkXRay.Checked)
                {
                    Total += int.Parse(lblXRayCost.Text.Split('$')[1]);
                }
                Total += (int)numFilling.Value * int.Parse((lblFillingCost.Text.Split('/')[0]).Split('$')[1]);

                txtTotal.Text = Total.ToString();
            }
        }
        public void AddCusInfo()
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                Customer cus = new Customer(txtName.Text, int.Parse(txtTotal.Text));
                listBox1.Items.Add(cus);
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
            chkClean.Checked = false;
            chkWhitening.Checked = false;
            chkXRay.Checked = false;
            numFilling.Value = 0;
            AddCusInfo();
            txtName.Text = null;
            txtTotal.Text = null;
        }
        public class Customer
        {
            private List<int> number = new List<int>();
            public Customer(List<int> number) 
            {
                
            }
            
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
            //}       
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
            //}
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            HieuChinhGia settingForm = new HieuChinhGia(lblCleanCost.Text, lblWhiteningCost.Text, lblXRayCost.Text, lblFillingCost.Text, this);
            settingForm.Show();
        }

        private void Bai1_2_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";
            try
            {
                string fileContent = File.ReadAllText("C:\\Users\\DELL\\source\\repos\\Bai1_2_3\\Bai1_2_3\\files\\setting_cost.txt");
                string[] splitContent = fileContent.Split('\n');
                for (int i = 0; i < splitContent.Length - 1; i++)
                {
                    lblCleanCost.Text = "$" + splitContent[0];
                    lblWhiteningCost.Text = "$" + splitContent[1];
                    lblXRayCost.Text = "$" + splitContent[2];
                    lblFillingCost.Text = "$" + splitContent[3] + "/cái";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp: " + ex.Message, "Lỗi");
            }
        }
        public void ReLoad_XML()
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load("C:\\Users\\DELL\\source\\repos\\Bai1_2_3\\Bai1_2_3\\files\\cost.xml");

                XmlNodeList nodes = xmlDoc.SelectSingleNode("/cost").ChildNodes;
                lblCleanCost.Text = "$" + nodes[0].InnerText;
                lblFillingCost.Text = "$" + nodes[1].InnerText + "/cái";
                lblWhiteningCost.Text = "$" + nodes[2].InnerText;
                lblXRayCost.Text = "$" + nodes[3].InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp XML: " + ex.Message);
            }

        }

        private void btnXmlSave_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement rootElement = xmlDoc.CreateElement("customers");
            xmlDoc.AppendChild(rootElement);

            foreach (Customer item in listBox1.Items)
            {
                XmlElement element = xmlDoc.CreateElement("customer");
                rootElement.AppendChild(element);

                XmlElement element_name = xmlDoc.CreateElement("name");
                element_name.InnerText = item.Name;

                XmlElement element_cost = xmlDoc.CreateElement("cost");
                element_cost.InnerText = (item.Cost).ToString();

                element.AppendChild(element_name);
                element.AppendChild(element_cost);
            }
            try
            {
                xmlDoc.Save(filePath + "cus_info.xml");
                MessageBox.Show("Tệp XML đã được lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp XML: " + ex.Message);
            }
        }

        private void btnXmlLoad_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(filePath + "cus_info.xml");

                XmlNodeList nodes = xmlDoc.SelectNodes("/customers/customer");
                listBox1.Items.Clear();
                foreach (XmlNode node in nodes)
                {
                    XmlNodeList customer = node.ChildNodes;
                    Customer newCus = new Customer(customer[0].InnerText, int.Parse(customer[1].InnerText));
                    listBox1.Items.Add(newCus);
                }
                MessageBox.Show("Đọc tệp xml thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp XML: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }

}