using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_BT
{
    public partial class Form2 : Form
    { 
        public Form2(int dong, int cot)
        {
            int sodem = 0;
            int x = 5;
            int y = 5;
            int width = 50;
            int height = 50;
            InitializeComponent();
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Button newbtn = new Button();
                    newbtn.Text = (sodem++).ToString();
                    newbtn.Location = new Point(x, y);
                    newbtn.Width = width;
                    newbtn.Height = height;
                    newbtn.Tag = "Dòng " + (i + 1) + ", Cột " + (j + 1);
                    x += (width + 5);
                    newbtn.Click += btn_Click;
                    this.Controls.Add(newbtn);
                }
                y += height + 5;
                x = 5;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Tag.ToString(), "Nhóm 4");
        }
    }
}
