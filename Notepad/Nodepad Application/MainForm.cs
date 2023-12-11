using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nodepad_Application
{
    public partial class mainForm : Form
    {
        int stateChange = 0;
        private bool fileAreadySave;
        private bool fileUpdated;
        private string currentFileName;
        private  FontDialog fontDialog = new FontDialog();
        public static int startIndex;
        public object UIElement { get; private set; }

        public mainForm()
        {
            InitializeComponent();
            startIndex = MainrichTextBox1.SelectionStart;
        }

        void hienThiLabelCount()
        {
            //lblCountChar.Text = "ln " + MainrichTextBox1.Location.X.ToString()
              //  + ", col " + MainrichTextBox1.Location.Y.ToString(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // fileAreadySave = true;
            fileAreadySave = false;
            fileUpdated = false;
            currentFileName = "";
            stateChange = 0;
            LoadCheckBoxState();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();

        }

        private void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files ( *.txt)| *.txt|Rich Text Files (*.rtf)|*.rtf";

            DialogResult save_result = sfd.ShowDialog();
            if (save_result == DialogResult.OK)
            {
                if (Path.GetExtension(sfd.FileName) == ".txt")
                {
                    MainrichTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(sfd.FileName) == ".rtf")
                {
                    MainrichTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                }

                int position = Path.GetFileName(sfd.FileName).IndexOf(".");
                string name_file = Path.GetFileName(sfd.FileName).Substring(0, position);
                this.Text = name_file + " - Notepad";

                fileAreadySave = true;
                fileUpdated = false;
                currentFileName = sfd.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This Application is developed by Group C# Progamming", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fileUpdated)
            {
                DialogResult dia_res = System.Windows.Forms.MessageBox.Show("Do you want to save before exit? ",
                                   "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                switch (dia_res)
                {
                    case DialogResult.Yes:

                        SaveFileUpdate();
                        Application.Exit();

                        break;

                    case DialogResult.No:
                        Application.Exit();
                        break;
                }
            }
            else
            {

                Application.Exit();
            }
           
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            LineColumnCount();
            if (!this.Text.Contains("*"))
            {
                this.Text = "*" + this.Text;
            }      
            stateChange = 1;
            fileUpdated = true;
            undoToolStripMenuItem.Enabled = true;
            //undo.Enabled= true;
            undoMenuStrip.Enabled = true;
            hienThiLabelCount();
            lblZoom.Text =(MainrichTextBox1.ZoomFactor * 100).ToString() +"%";
            // Point p = e.GetPositon(UIElement element);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           newAddSection();
        }

        private void newAddSection()
        {
            if (fileUpdated)
            {
                DialogResult dia_res = System.Windows.Forms.MessageBox.Show("Do you want to save your changes? ",
                                   "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                switch (dia_res)
                {
                    case DialogResult.Yes:
                        // SaveFileUpdate();
                        SaveFile();
                        clear_Screen();
                        break;
                    case DialogResult.No:
                        clear_Screen();
                        break;
                }
            }
            else
            {
                clear_Screen();
            }

           
            // have to set timer 3 sec 

            //undo.Enabled = false;
            undoMenuStrip.Enabled = false;

            redoToolStripMenuItem.Enabled = false;
            //redo.Enabled = false;
            redodoMenuStrip.Enabled = false;
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAnFile();

        }
        private string filePath;
        private void openAnFile()
        {
            if (fileUpdated)
            {
                DialogResult dia_res = System.Windows.Forms.MessageBox.Show("Do you want to save before open file? ",
                                   "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                switch (dia_res)
                {
                    case DialogResult.Yes:
                        
                        SaveFileUpdate();
                        openFiles();
                        break;

                    case DialogResult.No:
                        openFiles();
                        break;
                }
            }
            else
            {

                openFiles();
            }
        }

        private void openFiles()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files ( *.txt)| *.txt|Rich Text Files (*.rtf)|*.rtf";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(ofd.FileName) == ".txt")
                {
                    MainrichTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(ofd.FileName) == ".rtf")
                {
                    MainrichTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
                filePath = ofd.FileName;
                int position = Path.GetFileName(ofd.FileName).IndexOf(".");
                string name_file = Path.GetFileName(ofd.FileName).Substring(0, position);
                this.Text = name_file + " - Notepad";
                
                fileAreadySave = true;
                fileUpdated = false;
                currentFileName = ofd.FileName;

                //1 new task is: if open in loaded and after updaded if again open is called,
                // then it call to the user that he wants to save or not.


            }

          
           // undo.Enabled = false;
            undoMenuStrip.Enabled = false;

            redoToolStripMenuItem.Enabled = false;
            //redo.Enabled = false;
            redodoMenuStrip.Enabled = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileUpdate();
            
        }

        private void SaveFileUpdate()
        {
            if (fileAreadySave)
            {
                if (Path.GetExtension(currentFileName) == ".txt")
                {
                    MainrichTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                }

                if (Path.GetExtension(currentFileName) == ".rtf")
                {
                    MainrichTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.RichText);
                }
                fileUpdated = false;

                
            }

            else
            {
                if (fileUpdated)
                {
                    SaveFile();
                }
                else
                {
                    clear_Screen();
                }

            }
        }

        private void clear_Screen()
        {
            MainrichTextBox1.Clear();
            fileUpdated = false;
            this.Text = "Notepad";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoBtn();
        }

        private void undoBtn()
        {
            MainrichTextBox1.Undo();

            undoToolStripMenuItem.Enabled = false;
           // undo.Enabled = false;
            undoMenuStrip.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
           // redo.Enabled = true;
            redodoMenuStrip.Enabled = true;

            
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoBtn();
        }

        private void redoBtn()
        {
            MainrichTextBox1.Redo();
            undoToolStripMenuItem.Enabled = true;
           // undo.Enabled = true;
            undoMenuStrip.Enabled= true;

            redoToolStripMenuItem.Enabled = false;
            //redo.Enabled = false;
            redodoMenuStrip.Enabled = false;


        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox1.SelectedText = DateTime.Now.ToString();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldBtn();
        }

        private void boldBtn()
        {
            FontStyle_apply(FontStyle.Bold);

            
        }

        private void FontStyle_apply(FontStyle fontStyle)
        {
            MainrichTextBox1.SelectionFont = new Font(MainrichTextBox1.Font, fontStyle);
        }

        //private void FontTextstyle()
        //{
           
        //}

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonteStyleBtn();

        }

        private void fonteStyleBtn()
        {
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;

            fontDialog.Apply += new System.EventHandler(font_apply_dialog);
            fontDialog.Font = MainrichTextBox1.Font;

            DialogResult result = fontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                MainrichTextBox1.Font = fontDialog.Font;
                MainrichTextBox1.ForeColor = fontDialog.Color;
            }
        }

        private void font_apply_dialog(object sender, EventArgs e)
        {
            MainrichTextBox1.Font = fontDialog.Font;
            MainrichTextBox1.ForeColor= fontDialog.Color;
        }




        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newAddSection();
        }

        private void open_Click(object sender, EventArgs e)
        {
            openAnFile();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileUpdate();
        }

        private void save_as_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            undoBtn();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            redoBtn();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            fonteStyleBtn();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            pasteText();
        }


        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            FontStyle_apply(FontStyle.Bold);
        }

        //int click ;
        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            FontStyle_apply(FontStyle.Underline);
                    

        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            FontStyle_apply(FontStyle.Italic);
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This Application is developed by group 4 - C# programming Friday afternoon", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear_Screen();
           
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            clear_Screen();
        }


        private void undoMenuStrip_Click(object sender, EventArgs e)
        {
            undoBtn();
        }

        private void redodoMenuStrip_Click(object sender, EventArgs e)
        {
            redoBtn();
        }

        private void backToNormalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontStyle_apply(FontStyle.Regular);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox1.SelectAll();
        }

        private void fonteStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonteStyleBtn();
        }


        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            boldBtn();
        }

        private void underlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontStyle_apply(FontStyle.Underline);
        }

        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontStyle_apply(FontStyle.Italic);
        }

        private void fontGalleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonteStyleBtn();
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontStyle_apply(FontStyle.Regular);
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            
            FontStyle_apply(FontStyle.Regular);
           
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MainrichTextBox1.Copy();

            copyText();
        }

        private void copyText()
        {
            if (MainrichTextBox1.SelectionLength > 0)
            {
                Clipboard.SetText(MainrichTextBox1.SelectedText);

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutText();
        }

        private void cutText()
        {
            if (MainrichTextBox1.SelectionLength > 0)
            {
                Clipboard.SetText(MainrichTextBox1.SelectedText);
                MainrichTextBox1.SelectedText = "";
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteText();
        }

        private void pasteText()
        {
            if (Clipboard.ContainsText())
            {
                MainrichTextBox1.SelectedText = Clipboard.GetText();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            cutText();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cutText();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteText();
        }

       

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            MainrichTextBox1.SelectionAlignment= HorizontalAlignment.Left;
        }

        private void middleAllignment_Click(object sender, EventArgs e)
        {
            MainrichTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightAlllignment_Click(object sender, EventArgs e)
        {
            MainrichTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float x = MainrichTextBox1.ZoomFactor;
            x += 0.1f;

            MainrichTextBox1.ZoomFactor = x;
            lblZoom.Text = (MainrichTextBox1.ZoomFactor * 100).ToString() + "%";
        }

        private void MainrichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            lblZoom.Text = (MainrichTextBox1.ZoomFactor * 100).ToString() + "%";
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float x = MainrichTextBox1.ZoomFactor;
            x -= 0.1f;

            MainrichTextBox1.ZoomFactor = x;
            lblZoom.Text = (x * 100).ToString() + "%";
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (stateChange == 1)
            {
                if (fileUpdated)
                {
                    result = MessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Notepad", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        MainrichTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    }
                    else if (result == DialogResult.No)
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
                
            }
        }

        private void dateTimeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MainrichTextBox1.SelectedText = DateTime.Now.ToString();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This Application is developed by Group C# Progamming", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zoomInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            float x = MainrichTextBox1.ZoomFactor;
            x += 0.1f;
            

            MainrichTextBox1.ZoomFactor = x;
            lblZoom.Text = (MainrichTextBox1.ZoomFactor * 100).ToString() + "%";
        }

        private void zoomOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            float x = MainrichTextBox1.ZoomFactor;
            x -= 0.1f;
            if (x <= 0.1f)
                x = 0.1f;

            MainrichTextBox1.ZoomFactor = x;
            lblZoom.Text = (MainrichTextBox1.ZoomFactor * 100).ToString() + "%";
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isCheck = wordWrapToolStripMenuItem.Checked;
            if (!isCheck)
            {
                isCheck = true;
                MainrichTextBox1.WordWrap = true;
            }
            else
            {
                isCheck = false;
                MainrichTextBox1.WordWrap = false;
            }

        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked == false)
                panel1.Hide();
            else
                panel1.Show();
        }

        private void txt_SelectionChanged(object sender, EventArgs e)
        {
            startIndex = MainrichTextBox1.SelectionStart;
            LineColumnCount();
            if(MainrichTextBox1.Text != null)
            {
                findNextToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                findPreviousToolStripMenuItem.Enabled = true;
            }
            else
            {
                findNextToolStripMenuItem.Enabled = false;
                findPreviousToolStripMenuItem.Enabled = false;
                findToolStripMenuItem.Enabled = false;
            }
            if (MainrichTextBox1.SelectedText.Length > 0)
            {
                copyToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                searchToolStripMenuItem.Enabled = true;
            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                searchToolStripMenuItem.Enabled = false;
            }
            if (Clipboard.ContainsText())
            {
                pasteToolStripMenuItem1.Enabled = true;
            }
            else
            {
                pasteToolStripMenuItem1.Enabled = false;
            }
        }
        public void LineColumnCount()
        {
            int currentLine = MainrichTextBox1.GetLineFromCharIndex(MainrichTextBox1.SelectionStart) + 1;
            int currentColumn = MainrichTextBox1.SelectionStart - MainrichTextBox1.GetFirstCharIndexFromLine(currentLine - 1) + 1;
            lblLineAndColumn.Text = "Ln " + currentLine + ", Col " + currentColumn;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm newForm = new mainForm();
            newForm.Show();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.PageSettings = new PageSettings();
            pageSetupDialog.PrinterSettings = new PrinterSettings();
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                PageSettings pageSettings = pageSetupDialog.PageSettings;
                PrinterSettings printerSettings = pageSetupDialog.PrinterSettings;

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainrichTextBox1.SelectionLength > 0)
            {
                int selectionStart = MainrichTextBox1.SelectionStart;
                int selectionLength = MainrichTextBox1.SelectionLength;

                MainrichTextBox1.Text = MainrichTextBox1.Text.Remove(selectionStart, selectionLength);
                MainrichTextBox1.SelectionStart = selectionStart;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find findDialog = new Find(MainrichTextBox1);
            findDialog.Show();
        }

        private void wordWrapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(wordWrapToolStripMenuItem.Checked)
            {
                MainrichTextBox1.WordWrap = true;
            }
            else
            {
                MainrichTextBox1.WordWrap = false;
            }
        }
        private string settingsFilePath = "C:\\Users\\DELL\\source\\repos\\Nodepad\\Nodepad Application\\Data\\settingsFindForm.txt";
        private bool matchCase;
        private bool wrapAround;
        private string findText;
        private int lastIndex;
        public void LoadCheckBoxState()
        {
            string fileContent = File.ReadAllText(settingsFilePath);
            string[] splitContent = fileContent.Split('\n');
            matchCase = bool.Parse(splitContent[0].ToString());
            wrapAround = bool.Parse(splitContent[1].ToString());
            findText = splitContent[4].ToString();
        }
        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCheckBoxState();
            findNext();
        }

        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCheckBoxState();
            findPrevious();
        }
        public void findNext()
        {
            StringComparison comparison;
            if (matchCase)
            {
                comparison = StringComparison.Ordinal;
                if (wrapAround)
                {
                    find_Down_WrapAround(comparison);
                }
                else
                    find_Down(comparison);
            }
            else
            {
                comparison = StringComparison.OrdinalIgnoreCase;
                if (wrapAround)
                {
                    find_Down_WrapAround(comparison);
                }
                else
                    find_Down(comparison);
            }
        }
        public void findPrevious()
        {
            StringComparison comparison;
            if (matchCase)
            {
                comparison = StringComparison.Ordinal;
                if (wrapAround)
                {
                    find_Up_WrapAround(comparison);
                }
                else
                    find_Up(comparison);
            }
            else
            {
                comparison = StringComparison.OrdinalIgnoreCase;
                if (wrapAround)
                {
                    find_Up_WrapAround(comparison);
                }
                else
                    find_Up(comparison);
            }
        }
        public void find_Down_WrapAround(StringComparison comparison)
        {
            string searchText = findText;
            string textToSearch = MainrichTextBox1.Text;
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            int index = textToSearch.IndexOf(searchText, startIndex, comparison);
            if (!textToSearch.Contains(searchText))
            {
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }else
            if (index != -1)
            {
                MainrichTextBox1.Select(index, searchText.Length);
                MainrichTextBox1.Focus();
                startIndex = index + searchText.Length;
            }
            else
            {
                startIndex = 0;
                index = textToSearch.IndexOf(searchText, startIndex, comparison);
                MainrichTextBox1.Tag = searchText;
                MainrichTextBox1.Select(index, searchText.Length);
                MainrichTextBox1.Focus();
                startIndex = index + searchText.Length;
            }
        }
        public void find_Down(StringComparison comparison)
        {
            string searchText = findText;
            string textToSearch = MainrichTextBox1.Text;
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            int index = textToSearch.IndexOf(searchText, startIndex, comparison);

            if (index != -1)
            {
                MainrichTextBox1.Tag = searchText;
                MainrichTextBox1.Select(index, searchText.Length);
                MainrichTextBox1.Focus();
                lastIndex = index;
                startIndex = index + searchText.Length;
            }
            else
            {
                if (lastIndex == 0)
                {
                    lastIndex = textToSearch.Length;
                }
                MainrichTextBox1.Select(lastIndex, searchText.Length);
                MainrichTextBox1.Focus();
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }
        }
        public void find_Up_WrapAround(StringComparison comparison)
        {
            string searchText = findText;
            string textToSearch = MainrichTextBox1.Text;
            int index = 0;
            bool check_index = (startIndex < 0) ? false : true;
            if (!textToSearch.Contains(searchText))
            {
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }else
            if (!check_index)
            {
                startIndex = MainrichTextBox1.Text.Length;
                index = textToSearch.LastIndexOf(searchText, startIndex, comparison);
                MainrichTextBox1.Tag = searchText;
                MainrichTextBox1.Select(index, searchText.Length);
                MainrichTextBox1.Focus();
                startIndex = index - searchText.Length;
            }
            else
            {

                index = textToSearch.LastIndexOf(searchText, startIndex, comparison);

                if (index != -1)
                {
                    MainrichTextBox1.Tag = searchText;
                    MainrichTextBox1.Select(index, searchText.Length);
                    MainrichTextBox1.Focus();
                    startIndex = index - searchText.Length;
                }
                else
                {
                    startIndex = MainrichTextBox1.Text.Length;
                    index = textToSearch.LastIndexOf(searchText, startIndex, comparison);
                    MainrichTextBox1.Tag = searchText;
                    MainrichTextBox1.Select(index, searchText.Length);
                    MainrichTextBox1.Focus();
                    startIndex = index - searchText.Length;
                }
            }
        }
        public void find_Up(StringComparison comparison)
        {
            string searchText = findText;
            string textToSearch = MainrichTextBox1.Text;
            bool check_index = (startIndex < 0) ? false : true;
            if (!check_index)
            {
                MainrichTextBox1.Select(lastIndex, searchText.Length);
                MainrichTextBox1.Focus();
                MessageBox.Show("Cannot find \"" + searchText + "\"", "Notepad");
            }
            else
            {

                int index = textToSearch.LastIndexOf(searchText, startIndex, comparison);

                if (index != -1)
                {
                    MainrichTextBox1.Tag = searchText;
                    MainrichTextBox1.Select(index, searchText.Length);
                    MainrichTextBox1.Focus();
                    lastIndex = index;
                    startIndex = index - searchText.Length;
                }
                else
                {
                    MainrichTextBox1.Select(lastIndex, searchText.Length);
                    MainrichTextBox1.Focus();
                    MessageBox.Show("Cannot find \"" + searchText + lastIndex.ToString() + "\"", "Notepad");
                }
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace replace = new Replace(MainrichTextBox1);
            replace.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchQuery = MainrichTextBox1.SelectedText;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                string bingSearchUrl = "https://www.bing.com/search?q=" + Uri.EscapeDataString(searchQuery);
                Process.Start(bingSearchUrl);
            }
        }
    }

}
