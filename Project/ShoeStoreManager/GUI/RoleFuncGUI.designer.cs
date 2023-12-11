namespace GUI
{
    partial class RoleFuncGUI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleFuncGUI));
			this.pnlRole = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnInsertRole = new Guna.UI2.WinForms.Guna2Button();
			this.dtgvRole = new Guna.UI2.WinForms.Guna2DataGridView();
			this.pnlFunc = new Guna.UI2.WinForms.Guna2Panel();
			this.dtgvFunction = new Guna.UI2.WinForms.Guna2DataGridView();
			this.pnlRoleFunc = new Guna.UI2.WinForms.Guna2Panel();
			this.lblChooseRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblManager = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cmbChooseRole = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pnlChooseFunc = new Guna.UI2.WinForms.Guna2Panel();
			this.btnOK = new Guna.UI2.WinForms.Guna2Button();
			this.messInformation = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.messError = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.messQuestion = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.pnlRole.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).BeginInit();
			this.pnlFunc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvFunction)).BeginInit();
			this.pnlRoleFunc.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlRole
			// 
			this.pnlRole.BackColor = System.Drawing.SystemColors.Control;
			this.pnlRole.Controls.Add(this.guna2HtmlLabel1);
			this.pnlRole.Controls.Add(this.btnInsertRole);
			this.pnlRole.Controls.Add(this.dtgvRole);
			this.pnlRole.Location = new System.Drawing.Point(53, 35);
			this.pnlRole.Margin = new System.Windows.Forms.Padding(2);
			this.pnlRole.Name = "pnlRole";
			this.pnlRole.Size = new System.Drawing.Size(679, 314);
			this.pnlRole.TabIndex = 1;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.AutoSize = false;
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 12);
			this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(351, 32);
			this.guna2HtmlLabel1.TabIndex = 51;
			this.guna2HtmlLabel1.Text = "ROLE MANAGEMENT";
			this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnInsertRole
			// 
			this.btnInsertRole.BorderRadius = 10;
			this.btnInsertRole.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnInsertRole.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
			this.btnInsertRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnInsertRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnInsertRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnInsertRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnInsertRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnInsertRole.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnInsertRole.ForeColor = System.Drawing.Color.White;
			this.btnInsertRole.ImageSize = new System.Drawing.Size(30, 30);
			this.btnInsertRole.Location = new System.Drawing.Point(520, 12);
			this.btnInsertRole.Margin = new System.Windows.Forms.Padding(2);
			this.btnInsertRole.Name = "btnInsertRole";
			this.btnInsertRole.Size = new System.Drawing.Size(135, 37);
			this.btnInsertRole.TabIndex = 48;
			this.btnInsertRole.Text = "Insert Role";
			this.btnInsertRole.Click += new System.EventHandler(this.btnInsertRole_Click);
			// 
			// dtgvRole
			// 
			this.dtgvRole.AllowUserToAddRows = false;
			this.dtgvRole.AllowUserToDeleteRows = false;
			this.dtgvRole.AllowUserToResizeColumns = false;
			this.dtgvRole.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dtgvRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvRole.ColumnHeadersHeight = 40;
			this.dtgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvRole.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtgvRole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgvRole.Location = new System.Drawing.Point(21, 58);
			this.dtgvRole.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvRole.MultiSelect = false;
			this.dtgvRole.Name = "dtgvRole";
			this.dtgvRole.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dtgvRole.RowHeadersVisible = false;
			this.dtgvRole.RowHeadersWidth = 51;
			this.dtgvRole.RowTemplate.Height = 40;
			this.dtgvRole.Size = new System.Drawing.Size(634, 236);
			this.dtgvRole.TabIndex = 0;
			this.dtgvRole.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
			this.dtgvRole.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dtgvRole.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dtgvRole.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dtgvRole.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dtgvRole.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dtgvRole.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dtgvRole.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgvRole.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			this.dtgvRole.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dtgvRole.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvRole.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
			this.dtgvRole.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dtgvRole.ThemeStyle.HeaderStyle.Height = 40;
			this.dtgvRole.ThemeStyle.ReadOnly = true;
			this.dtgvRole.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			this.dtgvRole.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtgvRole.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvRole.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.dtgvRole.ThemeStyle.RowsStyle.Height = 40;
			this.dtgvRole.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			this.dtgvRole.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRole_CellContentClick);
			// 
			// pnlFunc
			// 
			this.pnlFunc.BackColor = System.Drawing.SystemColors.Control;
			this.pnlFunc.Controls.Add(this.dtgvFunction);
			this.pnlFunc.Location = new System.Drawing.Point(53, 382);
			this.pnlFunc.Margin = new System.Windows.Forms.Padding(2);
			this.pnlFunc.Name = "pnlFunc";
			this.pnlFunc.Size = new System.Drawing.Size(679, 379);
			this.pnlFunc.TabIndex = 2;
			// 
			// dtgvFunction
			// 
			this.dtgvFunction.AllowUserToAddRows = false;
			this.dtgvFunction.AllowUserToDeleteRows = false;
			this.dtgvFunction.AllowUserToResizeColumns = false;
			this.dtgvFunction.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dtgvFunction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvFunction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dtgvFunction.ColumnHeadersHeight = 40;
			this.dtgvFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvFunction.DefaultCellStyle = dataGridViewCellStyle7;
			this.dtgvFunction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgvFunction.Location = new System.Drawing.Point(21, 25);
			this.dtgvFunction.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvFunction.MultiSelect = false;
			this.dtgvFunction.Name = "dtgvFunction";
			this.dtgvFunction.ReadOnly = true;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvFunction.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dtgvFunction.RowHeadersVisible = false;
			this.dtgvFunction.RowHeadersWidth = 51;
			this.dtgvFunction.RowTemplate.Height = 40;
			this.dtgvFunction.Size = new System.Drawing.Size(634, 333);
			this.dtgvFunction.TabIndex = 1;
			this.dtgvFunction.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
			this.dtgvFunction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dtgvFunction.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dtgvFunction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dtgvFunction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dtgvFunction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dtgvFunction.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dtgvFunction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgvFunction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			this.dtgvFunction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dtgvFunction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvFunction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
			this.dtgvFunction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dtgvFunction.ThemeStyle.HeaderStyle.Height = 40;
			this.dtgvFunction.ThemeStyle.ReadOnly = true;
			this.dtgvFunction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			this.dtgvFunction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtgvFunction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvFunction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.dtgvFunction.ThemeStyle.RowsStyle.Height = 40;
			this.dtgvFunction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			this.dtgvFunction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgvFunction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFunction_CellContentClick);
			// 
			// pnlRoleFunc
			// 
			this.pnlRoleFunc.BackColor = System.Drawing.SystemColors.Control;
			this.pnlRoleFunc.Controls.Add(this.lblChooseRole);
			this.pnlRoleFunc.Controls.Add(this.lblManager);
			this.pnlRoleFunc.Controls.Add(this.cmbChooseRole);
			this.pnlRoleFunc.Controls.Add(this.pnlChooseFunc);
			this.pnlRoleFunc.Controls.Add(this.btnOK);
			this.pnlRoleFunc.Location = new System.Drawing.Point(787, 35);
			this.pnlRoleFunc.Margin = new System.Windows.Forms.Padding(2);
			this.pnlRoleFunc.Name = "pnlRoleFunc";
			this.pnlRoleFunc.ShadowDecoration.BorderRadius = 0;
			this.pnlRoleFunc.ShadowDecoration.Color = System.Drawing.Color.Transparent;
			this.pnlRoleFunc.ShadowDecoration.Depth = 0;
			this.pnlRoleFunc.Size = new System.Drawing.Size(476, 726);
			this.pnlRoleFunc.TabIndex = 3;
			// 
			// lblChooseRole
			// 
			this.lblChooseRole.BackColor = System.Drawing.Color.Transparent;
			this.lblChooseRole.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChooseRole.Location = new System.Drawing.Point(29, 72);
			this.lblChooseRole.Margin = new System.Windows.Forms.Padding(2);
			this.lblChooseRole.Name = "lblChooseRole";
			this.lblChooseRole.Size = new System.Drawing.Size(36, 24);
			this.lblChooseRole.TabIndex = 51;
			this.lblChooseRole.Text = "Role";
			// 
			// lblManager
			// 
			this.lblManager.AutoSize = false;
			this.lblManager.BackColor = System.Drawing.Color.Transparent;
			this.lblManager.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblManager.Location = new System.Drawing.Point(63, 17);
			this.lblManager.Margin = new System.Windows.Forms.Padding(2);
			this.lblManager.Name = "lblManager";
			this.lblManager.Size = new System.Drawing.Size(351, 32);
			this.lblManager.TabIndex = 50;
			this.lblManager.Text = "ADD FUNCTION FOR ROLE";
			this.lblManager.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbChooseRole
			// 
			this.cmbChooseRole.BackColor = System.Drawing.Color.Transparent;
			this.cmbChooseRole.BorderRadius = 10;
			this.cmbChooseRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbChooseRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbChooseRole.FillColor = System.Drawing.SystemColors.HighlightText;
			this.cmbChooseRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbChooseRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbChooseRole.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbChooseRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cmbChooseRole.ItemHeight = 30;
			this.cmbChooseRole.Location = new System.Drawing.Point(86, 67);
			this.cmbChooseRole.Margin = new System.Windows.Forms.Padding(2);
			this.cmbChooseRole.Name = "cmbChooseRole";
			this.cmbChooseRole.Size = new System.Drawing.Size(347, 36);
			this.cmbChooseRole.TabIndex = 49;
			this.cmbChooseRole.SelectedIndexChanged += new System.EventHandler(this.cmbChooseRole_SelectedIndexChanged);
			// 
			// pnlChooseFunc
			// 
			this.pnlChooseFunc.BackColor = System.Drawing.Color.Transparent;
			this.pnlChooseFunc.Location = new System.Drawing.Point(29, 131);
			this.pnlChooseFunc.Margin = new System.Windows.Forms.Padding(2);
			this.pnlChooseFunc.Name = "pnlChooseFunc";
			this.pnlChooseFunc.Size = new System.Drawing.Size(418, 488);
			this.pnlChooseFunc.TabIndex = 48;
			// 
			// btnOK
			// 
			this.btnOK.BorderRadius = 10;
			this.btnOK.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.ImageSize = new System.Drawing.Size(30, 30);
			this.btnOK.Location = new System.Drawing.Point(181, 641);
			this.btnOK.Margin = new System.Windows.Forms.Padding(2);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(135, 37);
			this.btnOK.TabIndex = 47;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// messInformation
			// 
			this.messInformation.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messInformation.Caption = "";
			this.messInformation.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
			this.messInformation.Parent = null;
			this.messInformation.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messInformation.Text = null;
			// 
			// messError
			// 
			this.messError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messError.Caption = "";
			this.messError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
			this.messError.Parent = null;
			this.messError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messError.Text = null;
			// 
			// messQuestion
			// 
			this.messQuestion.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
			this.messQuestion.Caption = "";
			this.messQuestion.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
			this.messQuestion.Parent = null;
			this.messQuestion.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messQuestion.Text = null;
			// 
			// RoleFuncGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1300, 793);
			this.Controls.Add(this.pnlRoleFunc);
			this.Controls.Add(this.pnlFunc);
			this.Controls.Add(this.pnlRole);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "RoleFuncGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormRoleFunc";
			this.Load += new System.EventHandler(this.FormRole_Load);
			this.pnlRole.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).EndInit();
			this.pnlFunc.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvFunction)).EndInit();
			this.pnlRoleFunc.ResumeLayout(false);
			this.pnlRoleFunc.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlRole;
        private Guna.UI2.WinForms.Guna2Panel pnlFunc;
        private Guna.UI2.WinForms.Guna2Panel pnlRoleFunc;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Panel pnlChooseFunc;
        private Guna.UI2.WinForms.Guna2Button btnInsertRole;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvFunction;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChooseRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChooseRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblManager;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvRole;
        private Guna.UI2.WinForms.Guna2MessageDialog messInformation;
        private Guna.UI2.WinForms.Guna2MessageDialog messError;
        private Guna.UI2.WinForms.Guna2MessageDialog messQuestion;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
	}
}