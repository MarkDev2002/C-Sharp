using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Nodepad_Application
{
    public partial class Find : Form
    {
        private RichTextBox temp;
        public Find(RichTextBox mainrichTextBox)
        {           
            InitializeComponent();
            temp = mainrichTextBox;
            textBox1.Text = temp.SelectedText;
            if (textBox1.Text != "") 
            {
                
                findNext_btn.Enabled = true;
            }
            else
            {
                if(temp.Tag == null)
                {
                    textBox1.Text = "";
                    findNext_btn.Enabled = false;
                }
                else
                {
                    textBox1.Text = temp.Tag.ToString();
                    findNext_btn.Enabled = true;
                }
                
            }
        }
        private void findNext_btn_Click(object sender, EventArgs e)
        {
            findNext();
            SaveCheckBoxState();
        }
        private int lastIndex;
        public void findNext()
        {
            StringComparison comparison;
            if (down_rd.Checked)
            {
                if (matchCase_chk.Checked)
                {
                    comparison = StringComparison.Ordinal;
                    if (wrapAround_chk.Checked)
                    {
                        find_Down_WrapAround(comparison);
                    }
                    else
                        find_Down(comparison);
                }
                else
                {
                    comparison = StringComparison.OrdinalIgnoreCase;
                    if (wrapAround_chk.Checked)
                    {
                        find_Down_WrapAround(comparison);
                    }
                    else
                        find_Down(comparison);
                }
            }
            else if (up_rd.Checked)
            {
                if (matchCase_chk.Checked)
                {
                    comparison = StringComparison.Ordinal;
                    if (wrapAround_chk.Checked)
                    {
                        find_Up_WrapAround(comparison);
                    }
                    else
                        find_Up(comparison);
                }
                else
                {
                    comparison = StringComparison.OrdinalIgnoreCase;
                    if (wrapAround_chk.Checked)
                    {
                        find_Up_WrapAround(comparison);
                    }
                    else
                        find_Up(comparison);
                }
                
            }
            SaveCheckBoxState();

        }
        public void find_Down_WrapAround(StringComparison comparison)
        {
            string searchText = textBox1.Text;
            string textToSearch = temp.Text;
            
            if (mainForm.startIndex < 0)
            {
                mainForm.startIndex = 0;
            }           
            int index = textToSearch.IndexOf(searchText, mainForm.startIndex, comparison);
            if (!textToSearch.Contains(searchText))
            {
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }
            else 
            if (index != -1)
            {
                temp.Tag = searchText;
                temp.Select(index, searchText.Length);
                temp.Focus();
                mainForm.startIndex = index + searchText.Length;
            }
            else
            {
                mainForm.startIndex = 0;
                index = textToSearch.IndexOf(searchText, mainForm.startIndex, comparison);
                temp.Tag = searchText;
                temp.Select(index, searchText.Length);
                temp.Focus();
                mainForm.startIndex = index + searchText.Length;
            }
        }
        public void find_Up_WrapAround(StringComparison comparison)
        {
            string searchText = textBox1.Text;
            string textToSearch = temp.Text;
            int index = 0;
            bool check_index = (mainForm.startIndex < 0) ? false : true;
            if (!textToSearch.Contains(searchText))
            {
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }else
            if (!check_index)
            {
                mainForm.startIndex = temp.Text.Length;
                index = textToSearch.LastIndexOf(searchText, mainForm.startIndex, comparison);
                temp.Tag = searchText;
                temp.Select(index, searchText.Length);
                temp.Focus();
                mainForm.startIndex = index - searchText.Length;
            }
            else
            {

                index = textToSearch.LastIndexOf(searchText, mainForm.startIndex, comparison);

                if (index != -1)
                {
                    temp.Tag = searchText;
                    temp.Select(index, searchText.Length);
                    temp.Focus();
                    mainForm.startIndex = index - searchText.Length;
                }
                else
                {
                    mainForm.startIndex = temp.Text.Length;
                    index = textToSearch.LastIndexOf(searchText, mainForm.startIndex, comparison);
                    temp.Tag = searchText;
                    temp.Select(index, searchText.Length);
                    temp.Focus();
                    mainForm.startIndex = index - searchText.Length;
                }
            }
        }
        public void find_Down(StringComparison comparison)
        {
            string searchText = textBox1.Text;
            string textToSearch = temp.Text;
            if (mainForm.startIndex < 0)
            {
                mainForm.startIndex = 0;
            }

            int index = textToSearch.IndexOf(searchText, mainForm.startIndex, comparison);

            if (index != -1)
            {
                temp.Tag = searchText;
                temp.Select(index, searchText.Length);
                temp.Focus();
                lastIndex = index;
                mainForm.startIndex = index + searchText.Length;
            }
            else
            {
                if (lastIndex == 0)
                {
                    lastIndex = textToSearch.Length;
                }
                temp.Select(lastIndex, searchText.Length);
                temp.Focus();
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }
        }
        public void find_Up(StringComparison comparison)
        {
            string searchText = textBox1.Text;
            string textToSearch = temp.Text;
            bool check_index = (mainForm.startIndex < 0) ? false : true;
            if (!check_index)
            {
                temp.Select(lastIndex, searchText.Length);
                temp.Focus();
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }
            else
            {

                int index = textToSearch.LastIndexOf(searchText, mainForm.startIndex, comparison);

                if (index != -1)
                {
                    temp.Tag = searchText;
                    temp.Select(index, searchText.Length);
                    temp.Focus();
                    lastIndex = index;
                    mainForm.startIndex = index - searchText.Length;
                }
                else
                {
                    temp.Select(lastIndex, searchText.Length);
                    temp.Focus();
                    MessageBox.Show("Cannot find \"" + searchText + lastIndex.ToString() + "\"", "Notepad");
                }
            }            
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string settingsFilePath = "C:\\Users\\DELL\\source\\repos\\Nodepad\\Nodepad Application\\Data\\settingsFindForm.txt";
        public void SaveCheckBoxState()
        {
            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.Write($"{matchCase_chk.Checked.ToString()}\n");
                writer.Write($"{wrapAround_chk.Checked.ToString()}\n");
                writer.Write($"{up_rd.Checked.ToString()}\n");
                writer.Write($"{down_rd.Checked.ToString()}\n");
                writer.Write($"{textBox1.Text}\n");
            }
        }
        public void LoadCheckBoxState()
        {
            string fileContent = File.ReadAllText(settingsFilePath);
            string[] splitContent = fileContent.Split('\n');
            matchCase_chk.Checked = bool.Parse(splitContent[0].ToString());
            wrapAround_chk.Checked = bool.Parse(splitContent[1].ToString());
            up_rd.Checked = bool.Parse(splitContent[2].ToString());
            down_rd.Checked = bool.Parse(splitContent[3].ToString());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            findNext_btn.Focus();
            string findText = textBox1.Text;
            if (findText.Length > 0)
            {
                findNext_btn.Enabled = true;
            } else 
            {
                findNext_btn.Enabled = false;
            }
        }

        private void matchCase_chk_CheckedChanged(object sender, EventArgs e)
        {
            findNext_btn.Focus();
        }

        private void wrapAround_chk_CheckedChanged(object sender, EventArgs e)
        {
            findNext_btn.Focus();
        }

        private void Find_Load(object sender, EventArgs e)
        {
            findNext_btn.Focus();
            LoadCheckBoxState();
        }

        private void down_rd_CheckedChanged(object sender, EventArgs e)
        {
            findNext_btn.Focus();
        }

        private void up_rd_CheckedChanged(object sender, EventArgs e)
        {
            findNext_btn.Focus();
        }
    }
}
