using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Bai1_2_3;
using static System.Net.Mime.MediaTypeNames;

namespace Bai1_2_3
{
    public partial class HieuChinhGia : Form
    {
        Form1 form;
        public HieuChinhGia(string clean_cost, string white_cost, string xray_cost, string fill_cost, Form1 Mainform)
        {
            InitializeComponent();
            txtCleanCost.Text = clean_cost.Split('$')[1];
            txtWhiteningCost.Text = white_cost.Split('$')[1];
            txtXRayCost.Text = xray_cost.Split('$')[1];
            txtFillingCost.Text = (fill_cost.Split('/')[0]).Split('$')[1];
            form = Mainform;
        }
        string filePath = "C:\\Users\\DELL\\source\\repos\\Bai1_2_3\\Bai1_2_3\\files\\";
        private bool checkEmptyString(string[] list)
        {
            foreach (string item in list)
            {
                if (item == null || item.All(c => c == ' '))
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkRightType()
        {
            foreach (Control control in this.Controls)
            {
                int temp;
                if (control is TextBox && !int.TryParse(control.Text, out temp))
                {
                    control.Text = null;
                    return false;
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";
            try
            {
                string[] txtList = { txtCleanCost.Text, txtWhiteningCost.Text, txtXRayCost.Text, txtFillingCost.Text };
                using (StreamWriter writer = new StreamWriter(filePath + "setting_cost.txt"))
                {
                    if (!checkEmptyString(txtList) && checkRightType())
                    {
                        writer.Write($"{txtCleanCost.Text}\n");
                        writer.Write($"{txtWhiteningCost.Text}\n");
                        writer.Write($"{txtXRayCost.Text}\n");
                        writer.Write($"{txtFillingCost.Text}\n");
                        MessageBox.Show("Lưu vào tệp thành công.", "Thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xuất hiện Textbox bỏ trống hoặc nhập sai định dạng.", "Lỗi");
                    }
                }
                form.ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message, "Lỗi");
            }
        }

        private void btnXmlSave_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement rootElement = xmlDoc.CreateElement("cost");
            xmlDoc.AppendChild(rootElement);

            XmlElement clean_cost = xmlDoc.CreateElement("clean");
            clean_cost.InnerText = txtCleanCost.Text;
            rootElement.AppendChild(clean_cost);

            XmlElement fill_cost = xmlDoc.CreateElement("fill");
            fill_cost.InnerText = txtFillingCost.Text;
            rootElement.AppendChild(fill_cost);

            XmlElement white_cost = xmlDoc.CreateElement("white");
            white_cost.InnerText = txtWhiteningCost.Text;
            rootElement.AppendChild(white_cost);

            XmlElement xray_cost = xmlDoc.CreateElement("xray");
            xray_cost.InnerText = txtXRayCost.Text;
            rootElement.AppendChild(xray_cost);
            try
            {
                xmlDoc.Save(filePath + "cost.xml");
                MessageBox.Show("Tệp XML đã được lưu thành công!");
                form.ReLoad_XML();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp XML: " + ex.Message);
            }
        }
    }
}
