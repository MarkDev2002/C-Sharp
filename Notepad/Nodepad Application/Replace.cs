using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nodepad_Application
{
    public partial class Replace : Form
    {
        private RichTextBox temp;
        private int lastIndex;
        public Replace(RichTextBox richTextBox)
        {
            InitializeComponent();
            temp = richTextBox;
        }

        private void btn_Findnext_Click(object sender, EventArgs e)
        {
            findNext();
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            String_Replace();
        }
        public void String_Replace()
        {
            StringComparison comparison;
            if (chk_Matchcase.Checked)
            {
                comparison = StringComparison.Ordinal;
                if (chk_Wraparound.Checked)
                {
                    replace_WrapAround(comparison);
                }
                else
                    replace_Normal(comparison);
            }
            else
            {
                comparison = StringComparison.OrdinalIgnoreCase;
                if (chk_Wraparound.Checked)
                {
                    replace_WrapAround(comparison);
                }
                else
                    replace_Normal(comparison);
            }
        }
        public void replace_Normal(StringComparison comparison)
        {
            string searchText = txt_Findwhat.Text;
            string textToSearch = temp.Text;
            string replaceText = txt_Replacewith.Text;
            string selectedText = temp.SelectedText;
            if (selectedText.Contains(searchText))
            {
                selectedText = selectedText.Replace(searchText, replaceText);
                temp.SelectedText = selectedText;
            }
            else
                find_Down(comparison);
            
        }
        public void replace_WrapAround(StringComparison comparison)
        {
            string searchText = txt_Findwhat.Text;
            string textToSearch = temp.Text;
            string replaceText = txt_Replacewith.Text;
            string selectedText = temp.SelectedText;
            if (selectedText.Contains(searchText))
            {
                selectedText = selectedText.Replace(searchText, replaceText);
                temp.SelectedText = selectedText;
            }
            else
                find_Down_WrapAround(comparison);

        }
        private void btn_Replaceall_Click(object sender, EventArgs e)
        {
            string searchText = txt_Findwhat.Text;
            string textToSearch = temp.Text;
            string replaceText = txt_Replacewith.Text;
            textToSearch = textToSearch.Replace(searchText, replaceText);
            temp.Text = textToSearch;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_Matchcase_CheckedChanged(object sender, EventArgs e)
        {
            btn_Findnext.Focus();
        }

        private void chk_Wraparound_CheckedChanged(object sender, EventArgs e)
        {
            btn_Findnext.Focus();
        }
        public void findNext()
        {
            StringComparison comparison;
            if (chk_Matchcase.Checked)
            {
                comparison = StringComparison.Ordinal;
                if (chk_Wraparound.Checked)
                {
                    find_Down_WrapAround(comparison);
                }
                else
                    find_Down(comparison);
            }
            else
            {
                comparison = StringComparison.OrdinalIgnoreCase;
                if (chk_Wraparound.Checked)
                {
                    find_Down_WrapAround(comparison);
                }
                else
                    find_Down(comparison);
            }
        }
        public void find_Down_WrapAround(StringComparison comparison)
        {
            string searchText = txt_Findwhat.Text;
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
        public void find_Down(StringComparison comparison)
        {
            string searchText = txt_Findwhat.Text;
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

        private void txt_Findwhat_TextChanged(object sender, EventArgs e)
        {
            btn_Findnext.Focus();
            string findText = txt_Findwhat.Text;
            if (findText.Length > 0)
            {
                btn_Findnext.Enabled = true;
                btn_Replace.Enabled = true;
                btn_Replaceall.Enabled = true;
            }
            else
            {
                btn_Findnext.Enabled = false;
                btn_Replace.Enabled = false;
                btn_Replaceall.Enabled = false;
            }
        }
    }
}
