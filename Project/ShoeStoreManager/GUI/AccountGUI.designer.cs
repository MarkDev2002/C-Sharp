namespace GUI
{
    partial class AccountGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountGUI));
			this.pnlList = new Guna.UI2.WinForms.Guna2Panel();
			this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.lblListAcc = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dtgvAccount = new Guna.UI2.WinForms.Guna2DataGridView();
			this.pnlInfo = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.cmbEnable = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnInsert = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.btnOK = new Guna.UI2.WinForms.Guna2Button();
			this.cmbRole = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.messInformation = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.messError = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.messQuestion = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.refresh_btn = new Guna.UI2.WinForms.Guna2Button();
			this.pnlList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
			this.pnlInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlList
			// 
			this.pnlList.BackColor = System.Drawing.SystemColors.Control;
			this.pnlList.Controls.Add(this.txtSearch);
			this.pnlList.Controls.Add(this.lblListAcc);
			this.pnlList.Location = new System.Drawing.Point(646, 35);
			this.pnlList.Margin = new System.Windows.Forms.Padding(2);
			this.pnlList.Name = "pnlList";
			this.pnlList.Size = new System.Drawing.Size(609, 713);
			this.pnlList.TabIndex = 1;
			// 
			// txtSearch
			// 
			this.txtSearch.BorderRadius = 10;
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.DefaultText = "";
			this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearch.IconRight = global::GUI.Properties.Resources.icon_ok;
			this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.txtSearch.IconRightSize = new System.Drawing.Size(30, 30);
			this.txtSearch.Location = new System.Drawing.Point(1035, 24);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PasswordChar = '\0';
			this.txtSearch.PlaceholderText = "Search";
			this.txtSearch.SelectedText = "";
			this.txtSearch.Size = new System.Drawing.Size(225, 28);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.IconRightClick += new System.EventHandler(this.txtSearch_IconRightClick);
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lblListAcc
			// 
			this.lblListAcc.BackColor = System.Drawing.Color.Transparent;
			this.lblListAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.lblListAcc.Location = new System.Drawing.Point(240, 20);
			this.lblListAcc.Margin = new System.Windows.Forms.Padding(2);
			this.lblListAcc.Name = "lblListAcc";
			this.lblListAcc.Size = new System.Drawing.Size(120, 32);
			this.lblListAcc.TabIndex = 1;
			this.lblListAcc.Text = "List Account";
			// 
			// dtgvAccount
			// 
			this.dtgvAccount.AllowUserToAddRows = false;
			this.dtgvAccount.AllowUserToDeleteRows = false;
			this.dtgvAccount.AllowUserToResizeColumns = false;
			this.dtgvAccount.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dtgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvAccount.ColumnHeadersHeight = 40;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgvAccount.Location = new System.Drawing.Point(667, 91);
			this.dtgvAccount.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvAccount.MultiSelect = false;
			this.dtgvAccount.Name = "dtgvAccount";
			this.dtgvAccount.ReadOnly = true;
			this.dtgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dtgvAccount.RowHeadersVisible = false;
			this.dtgvAccount.RowHeadersWidth = 40;
			this.dtgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtgvAccount.RowTemplate.Height = 40;
			this.dtgvAccount.Size = new System.Drawing.Size(570, 642);
			this.dtgvAccount.TabIndex = 0;
			this.dtgvAccount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
			this.dtgvAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dtgvAccount.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dtgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dtgvAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dtgvAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgvAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			this.dtgvAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dtgvAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dtgvAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dtgvAccount.ThemeStyle.HeaderStyle.Height = 40;
			this.dtgvAccount.ThemeStyle.ReadOnly = true;
			this.dtgvAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			this.dtgvAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtgvAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.dtgvAccount.ThemeStyle.RowsStyle.Height = 40;
			this.dtgvAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			this.dtgvAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellClick);
			this.dtgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellContentClick);
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.SystemColors.Control;
			this.pnlInfo.Controls.Add(this.refresh_btn);
			this.pnlInfo.Controls.Add(this.guna2Button1);
			this.pnlInfo.Controls.Add(this.cmbEnable);
			this.pnlInfo.Controls.Add(this.btnInsert);
			this.pnlInfo.Controls.Add(this.btnCancel);
			this.pnlInfo.Controls.Add(this.btnOK);
			this.pnlInfo.Controls.Add(this.cmbRole);
			this.pnlInfo.Controls.Add(this.guna2HtmlLabel6);
			this.pnlInfo.Controls.Add(this.guna2HtmlLabel5);
			this.pnlInfo.Controls.Add(this.txtEmail);
			this.pnlInfo.Controls.Add(this.guna2HtmlLabel4);
			this.pnlInfo.Controls.Add(this.txtPassword);
			this.pnlInfo.Controls.Add(this.guna2HtmlLabel3);
			this.pnlInfo.Controls.Add(this.txtUsername);
			this.pnlInfo.Controls.Add(this.guna2HtmlLabel2);
			this.pnlInfo.Controls.Add(this.txtUserID);
			this.pnlInfo.Controls.Add(this.guna2HtmlLabel1);
			this.pnlInfo.Controls.Add(this.guna2CirclePictureBox1);
			this.pnlInfo.Location = new System.Drawing.Point(58, 35);
			this.pnlInfo.Margin = new System.Windows.Forms.Padding(2);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(541, 713);
			this.pnlInfo.TabIndex = 0;
			// 
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 10;
			this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(15, 14);
			this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(115, 37);
			this.guna2Button1.TabIndex = 37;
			this.guna2Button1.Text = "Choose Staff";
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// cmbEnable
			// 
			this.cmbEnable.BackColor = System.Drawing.Color.Transparent;
			this.cmbEnable.BorderRadius = 10;
			this.cmbEnable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEnable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbEnable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbEnable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cmbEnable.ItemHeight = 30;
			this.cmbEnable.Items.AddRange(new object[] {
            "0",
            "1"});
			this.cmbEnable.Location = new System.Drawing.Point(319, 352);
			this.cmbEnable.Margin = new System.Windows.Forms.Padding(2);
			this.cmbEnable.Name = "cmbEnable";
			this.cmbEnable.Size = new System.Drawing.Size(151, 36);
			this.cmbEnable.TabIndex = 5;
			this.cmbEnable.SelectedIndexChanged += new System.EventHandler(this.cmbEnable_SelectedIndexChanged);
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.Color.Transparent;
			this.btnInsert.BorderRadius = 10;
			this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsert.ForeColor = System.Drawing.Color.White;
			this.btnInsert.Location = new System.Drawing.Point(15, 608);
			this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(135, 37);
			this.btnInsert.TabIndex = 6;
			this.btnInsert.Text = "Insert";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BorderRadius = 10;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancel.Enabled = false;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(390, 608);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(135, 37);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.BorderRadius = 10;
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnOK.Enabled = false;
			this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.Location = new System.Drawing.Point(203, 608);
			this.btnOK.Margin = new System.Windows.Forms.Padding(2);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(135, 37);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// cmbRole
			// 
			this.cmbRole.BackColor = System.Drawing.Color.Transparent;
			this.cmbRole.BorderRadius = 10;
			this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cmbRole.ItemHeight = 30;
			this.cmbRole.Location = new System.Drawing.Point(319, 271);
			this.cmbRole.Margin = new System.Windows.Forms.Padding(2);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(151, 36);
			this.cmbRole.TabIndex = 4;
			this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
			// 
			// guna2HtmlLabel6
			// 
			this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel6.Location = new System.Drawing.Point(320, 333);
			this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
			this.guna2HtmlLabel6.Size = new System.Drawing.Size(41, 21);
			this.guna2HtmlLabel6.TabIndex = 13;
			this.guna2HtmlLabel6.Text = "Status";
			this.guna2HtmlLabel6.Click += new System.EventHandler(this.guna2HtmlLabel6_Click);
			// 
			// guna2HtmlLabel5
			// 
			this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel5.Location = new System.Drawing.Point(320, 253);
			this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
			this.guna2HtmlLabel5.Size = new System.Drawing.Size(29, 21);
			this.guna2HtmlLabel5.TabIndex = 11;
			this.guna2HtmlLabel5.Text = "Role";
			this.guna2HtmlLabel5.Click += new System.EventHandler(this.guna2HtmlLabel5_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.BorderRadius = 10;
			this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmail.DefaultText = "";
			this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Location = new System.Drawing.Point(40, 528);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.PlaceholderText = "Email";
			this.txtEmail.SelectedText = "";
			this.txtEmail.Size = new System.Drawing.Size(236, 29);
			this.txtEmail.TabIndex = 3;
			// 
			// guna2HtmlLabel4
			// 
			this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel4.Location = new System.Drawing.Point(40, 503);
			this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
			this.guna2HtmlLabel4.Size = new System.Drawing.Size(35, 21);
			this.guna2HtmlLabel4.TabIndex = 9;
			this.guna2HtmlLabel4.Text = "Email";
			// 
			// txtPassword
			// 
			this.txtPassword.BorderRadius = 10;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Location = new System.Drawing.Point(41, 441);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '●';
			this.txtPassword.PlaceholderText = "Password";
			this.txtPassword.SelectedText = "";
			this.txtPassword.Size = new System.Drawing.Size(236, 29);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// guna2HtmlLabel3
			// 
			this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel3.Location = new System.Drawing.Point(41, 415);
			this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(61, 21);
			this.guna2HtmlLabel3.TabIndex = 7;
			this.guna2HtmlLabel3.Text = "Password";
			// 
			// txtUsername
			// 
			this.txtUsername.BorderRadius = 10;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.DefaultText = "";
			this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.Location = new System.Drawing.Point(41, 359);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.PlaceholderText = "Username";
			this.txtUsername.SelectedText = "";
			this.txtUsername.Size = new System.Drawing.Size(236, 29);
			this.txtUsername.TabIndex = 1;
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(41, 334);
			this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(65, 21);
			this.guna2HtmlLabel2.TabIndex = 5;
			this.guna2HtmlLabel2.Text = "Username";
			// 
			// txtUserID
			// 
			this.txtUserID.BorderRadius = 10;
			this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUserID.DefaultText = "";
			this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUserID.Location = new System.Drawing.Point(41, 278);
			this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.PasswordChar = '\0';
			this.txtUserID.PlaceholderText = "UserID";
			this.txtUserID.SelectedText = "";
			this.txtUserID.Size = new System.Drawing.Size(236, 29);
			this.txtUserID.TabIndex = 0;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 253);
			this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(17, 21);
			this.guna2HtmlLabel1.TabIndex = 3;
			this.guna2HtmlLabel1.Text = "ID";
			// 
			// guna2CirclePictureBox1
			// 
			this.guna2CirclePictureBox1.Image = global::GUI.Properties.Resources.user;
			this.guna2CirclePictureBox1.ImageRotate = 0F;
			this.guna2CirclePictureBox1.Location = new System.Drawing.Point(203, 72);
			this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new System.Drawing.Size(129, 127);
			this.guna2CirclePictureBox1.TabIndex = 1;
			this.guna2CirclePictureBox1.TabStop = false;
			this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
			// 
			// messInformation
			// 
			this.messInformation.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messInformation.Caption = "";
			this.messInformation.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
			this.messInformation.Parent = null;
			this.messInformation.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messInformation.Text = "";
			// 
			// messError
			// 
			this.messError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messError.Caption = "";
			this.messError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
			this.messError.Parent = null;
			this.messError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messError.Text = "";
			// 
			// messQuestion
			// 
			this.messQuestion.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
			this.messQuestion.Caption = "";
			this.messQuestion.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
			this.messQuestion.Parent = null;
			this.messQuestion.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messQuestion.Text = null;
			// 
			// refresh_btn
			// 
			this.refresh_btn.BackColor = System.Drawing.Color.Transparent;
			this.refresh_btn.BorderRadius = 10;
			this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.refresh_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.refresh_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.refresh_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.refresh_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.refresh_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.refresh_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refresh_btn.ForeColor = System.Drawing.Color.White;
			this.refresh_btn.Location = new System.Drawing.Point(410, 14);
			this.refresh_btn.Margin = new System.Windows.Forms.Padding(2);
			this.refresh_btn.Name = "refresh_btn";
			this.refresh_btn.Size = new System.Drawing.Size(115, 37);
			this.refresh_btn.TabIndex = 39;
			this.refresh_btn.Text = "Refresh";
			this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
			// 
			// AccountGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1300, 793);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.dtgvAccount);
			this.Controls.Add(this.pnlList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AccountGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AccountGUI";
			this.Load += new System.EventHandler(this.AccountGUI_Load);
			this.pnlList.ResumeLayout(false);
			this.pnlList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlList;
        private Guna.UI2.WinForms.Guna2Panel pnlInfo;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblListAcc;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2Button btnInsert;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEnable;
        private Guna.UI2.WinForms.Guna2MessageDialog messInformation;
        private Guna.UI2.WinForms.Guna2MessageDialog messError;
        private Guna.UI2.WinForms.Guna2MessageDialog messQuestion;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2Button refresh_btn;
	}
}