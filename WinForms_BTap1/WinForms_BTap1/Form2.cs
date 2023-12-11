using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_BTap1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += new EventHandler(btn_Click);
            button2.Click += new EventHandler(btn_Click);
            button4.Click += new EventHandler(btn_Click);
            button3.Click += new EventHandler(btn_Click);
        }
        void btn_Click(object sender, EventArgs e)
        {
            float so1, so2;
            if (!float.TryParse(textBox1.Text, out so1))
            {
                so1 = 0;
            }
            if (!float.TryParse(textBox2.Text, out so2))
            {
                so2 = 0;
            }
            switch ((sender as Button).Text)
            {
                case "+":
                    label4.Text = (so1 + so2).ToString();
                    break;
                case "-":
                    label4.Text = (so1 - so2).ToString();
                    break;
                case "x":
                    label4.Text = (so1 * so2).ToString();
                    break;
                case "/":
                    if (so2 == 0)
                    {
                        so2 = 1;
                    }
                    label4.Text = (so1 / so2).ToString();
                    break;
            }

        }
    }
}
