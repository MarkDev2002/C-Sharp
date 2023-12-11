namespace GUI
{
    partial class StaffGUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffGUI));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.headingProduct = new System.Windows.Forms.Label();
			this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
			this.btnAddAccToStaff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.dtgv = new Guna.UI2.WinForms.Guna2DataGridView();
			this.searchStaff = new Bunifu.UI.WinForms.BunifuTextBox();
			this.createNewProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.exportProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.bunifuPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
			this.SuspendLayout();
			// 
			// headingProduct
			// 
			this.headingProduct.AutoSize = true;
			this.headingProduct.BackColor = System.Drawing.Color.Transparent;
			this.headingProduct.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
			this.headingProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
			this.headingProduct.Location = new System.Drawing.Point(18, 21);
			this.headingProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.headingProduct.Name = "headingProduct";
			this.headingProduct.Size = new System.Drawing.Size(95, 46);
			this.headingProduct.TabIndex = 5;
			this.headingProduct.Text = "Staff";
			// 
			// bunifuPanel2
			// 
			this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
			this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
			this.bunifuPanel2.BorderRadius = 5;
			this.bunifuPanel2.BorderThickness = 1;
			this.bunifuPanel2.Controls.Add(this.createNewProduct);
			this.bunifuPanel2.Controls.Add(this.dtgv);
			this.bunifuPanel2.Controls.Add(this.exportProduct);
			this.bunifuPanel2.Controls.Add(this.btnAddAccToStaff);
			this.bunifuPanel2.Controls.Add(this.searchStaff);
			this.bunifuPanel2.Controls.Add(this.headingProduct);
			this.bunifuPanel2.Location = new System.Drawing.Point(72, 47);
			this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuPanel2.Name = "bunifuPanel2";
			this.bunifuPanel2.ShowBorders = true;
			this.bunifuPanel2.Size = new System.Drawing.Size(1164, 696);
			this.bunifuPanel2.TabIndex = 6;
			// 
			// btnAddAccToStaff
			// 
			this.btnAddAccToStaff.AllowAnimations = true;
			this.btnAddAccToStaff.AllowMouseEffects = true;
			this.btnAddAccToStaff.AllowToggling = false;
			this.btnAddAccToStaff.AnimationSpeed = 200;
			this.btnAddAccToStaff.AutoGenerateColors = false;
			this.btnAddAccToStaff.AutoRoundBorders = false;
			this.btnAddAccToStaff.AutoSizeLeftIcon = true;
			this.btnAddAccToStaff.AutoSizeRightIcon = true;
			this.btnAddAccToStaff.BackColor = System.Drawing.Color.Transparent;
			this.btnAddAccToStaff.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnAddAccToStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccToStaff.BackgroundImage")));
			this.btnAddAccToStaff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAddAccToStaff.ButtonText = "Choose Account";
			this.btnAddAccToStaff.ButtonTextMarginLeft = 0;
			this.btnAddAccToStaff.ColorContrastOnClick = 45;
			this.btnAddAccToStaff.ColorContrastOnHover = 45;
			this.btnAddAccToStaff.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges3.BottomLeft = true;
			borderEdges3.BottomRight = true;
			borderEdges3.TopLeft = true;
			borderEdges3.TopRight = true;
			this.btnAddAccToStaff.CustomizableEdges = borderEdges3;
			this.btnAddAccToStaff.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnAddAccToStaff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnAddAccToStaff.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnAddAccToStaff.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnAddAccToStaff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnAddAccToStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddAccToStaff.ForeColor = System.Drawing.Color.White;
			this.btnAddAccToStaff.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddAccToStaff.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnAddAccToStaff.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnAddAccToStaff.IconMarginLeft = 11;
			this.btnAddAccToStaff.IconPadding = 10;
			this.btnAddAccToStaff.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddAccToStaff.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnAddAccToStaff.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnAddAccToStaff.IconSize = 25;
			this.btnAddAccToStaff.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.btnAddAccToStaff.IdleBorderRadius = 5;
			this.btnAddAccToStaff.IdleBorderThickness = 1;
			this.btnAddAccToStaff.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnAddAccToStaff.IdleIconLeftImage = null;
			this.btnAddAccToStaff.IdleIconRightImage = null;
			this.btnAddAccToStaff.IndicateFocus = false;
			this.btnAddAccToStaff.Location = new System.Drawing.Point(1021, 87);
			this.btnAddAccToStaff.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddAccToStaff.Name = "btnAddAccToStaff";
			this.btnAddAccToStaff.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnAddAccToStaff.OnDisabledState.BorderRadius = 5;
			this.btnAddAccToStaff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAddAccToStaff.OnDisabledState.BorderThickness = 1;
			this.btnAddAccToStaff.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnAddAccToStaff.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnAddAccToStaff.OnDisabledState.IconLeftImage = null;
			this.btnAddAccToStaff.OnDisabledState.IconRightImage = null;
			this.btnAddAccToStaff.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnAddAccToStaff.onHoverState.BorderRadius = 5;
			this.btnAddAccToStaff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAddAccToStaff.onHoverState.BorderThickness = 1;
			this.btnAddAccToStaff.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnAddAccToStaff.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnAddAccToStaff.onHoverState.IconLeftImage = null;
			this.btnAddAccToStaff.onHoverState.IconRightImage = null;
			this.btnAddAccToStaff.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnAddAccToStaff.OnIdleState.BorderRadius = 5;
			this.btnAddAccToStaff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAddAccToStaff.OnIdleState.BorderThickness = 1;
			this.btnAddAccToStaff.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnAddAccToStaff.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnAddAccToStaff.OnIdleState.IconLeftImage = null;
			this.btnAddAccToStaff.OnIdleState.IconRightImage = null;
			this.btnAddAccToStaff.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnAddAccToStaff.OnPressedState.BorderRadius = 5;
			this.btnAddAccToStaff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAddAccToStaff.OnPressedState.BorderThickness = 1;
			this.btnAddAccToStaff.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnAddAccToStaff.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnAddAccToStaff.OnPressedState.IconLeftImage = null;
			this.btnAddAccToStaff.OnPressedState.IconRightImage = null;
			this.btnAddAccToStaff.Size = new System.Drawing.Size(125, 42);
			this.btnAddAccToStaff.TabIndex = 35;
			this.btnAddAccToStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAddAccToStaff.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnAddAccToStaff.TextMarginLeft = 0;
			this.btnAddAccToStaff.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnAddAccToStaff.UseDefaultRadiusAndThickness = true;
			this.btnAddAccToStaff.Click += new System.EventHandler(this.btnAddAccToStaff_Click);
			// 
			// dtgv
			// 
			this.dtgv.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgv.ColumnHeadersHeight = 54;
			this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgv.Location = new System.Drawing.Point(23, 133);
			this.dtgv.Margin = new System.Windows.Forms.Padding(2);
			this.dtgv.Name = "dtgv";
			this.dtgv.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dtgv.RowHeadersVisible = false;
			this.dtgv.RowHeadersWidth = 51;
			this.dtgv.RowTemplate.Height = 50;
			this.dtgv.Size = new System.Drawing.Size(1123, 543);
			this.dtgv.TabIndex = 0;
			this.dtgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
			this.dtgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dtgv.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dtgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dtgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dtgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dtgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.dtgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dtgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			this.dtgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dtgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
			this.dtgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dtgv.ThemeStyle.HeaderStyle.Height = 54;
			this.dtgv.ThemeStyle.ReadOnly = true;
			this.dtgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			this.dtgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.dtgv.ThemeStyle.RowsStyle.Height = 50;
			this.dtgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			this.dtgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
			this.dtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellDoubleClick);
			// 
			// searchStaff
			// 
			this.searchStaff.AcceptsReturn = false;
			this.searchStaff.AcceptsTab = false;
			this.searchStaff.AnimationSpeed = 200;
			this.searchStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.searchStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.searchStaff.BackColor = System.Drawing.Color.Transparent;
			this.searchStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchStaff.BackgroundImage")));
			this.searchStaff.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.searchStaff.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.searchStaff.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.searchStaff.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
			this.searchStaff.BorderRadius = 5;
			this.searchStaff.BorderThickness = 1;
			this.searchStaff.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchStaff.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchStaff.DefaultText = "";
			this.searchStaff.FillColor = System.Drawing.Color.White;
			this.searchStaff.HideSelection = true;
			this.searchStaff.IconLeft = null;
			this.searchStaff.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchStaff.IconPadding = 10;
			this.searchStaff.IconRight = null;
			this.searchStaff.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchStaff.Lines = new string[0];
			this.searchStaff.Location = new System.Drawing.Point(23, 87);
			this.searchStaff.Margin = new System.Windows.Forms.Padding(2);
			this.searchStaff.MaxLength = 32767;
			this.searchStaff.MinimumSize = new System.Drawing.Size(1, 1);
			this.searchStaff.Modified = false;
			this.searchStaff.Multiline = false;
			this.searchStaff.Name = "searchStaff";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchStaff.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.searchStaff.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchStaff.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchStaff.OnIdleState = stateProperties4;
			this.searchStaff.Padding = new System.Windows.Forms.Padding(2);
			this.searchStaff.PasswordChar = '\0';
			this.searchStaff.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchStaff.PlaceholderText = "Search Name";
			this.searchStaff.ReadOnly = false;
			this.searchStaff.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchStaff.SelectedText = "";
			this.searchStaff.SelectionLength = 0;
			this.searchStaff.SelectionStart = 0;
			this.searchStaff.ShortcutsEnabled = true;
			this.searchStaff.Size = new System.Drawing.Size(992, 42);
			this.searchStaff.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.searchStaff.TabIndex = 3;
			this.searchStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.searchStaff.TextMarginBottom = 0;
			this.searchStaff.TextMarginLeft = 20;
			this.searchStaff.TextMarginTop = 0;
			this.searchStaff.TextPlaceholder = "Search Name";
			this.searchStaff.UseSystemPasswordChar = false;
			this.searchStaff.WordWrap = true;
			this.searchStaff.TextChanged += new System.EventHandler(this.searchStaff_TextChanged);
			// 
			// createNewProduct
			// 
			this.createNewProduct.AllowAnimations = true;
			this.createNewProduct.AllowMouseEffects = true;
			this.createNewProduct.AllowToggling = false;
			this.createNewProduct.AnimationSpeed = 200;
			this.createNewProduct.AutoGenerateColors = false;
			this.createNewProduct.AutoRoundBorders = false;
			this.createNewProduct.AutoSizeLeftIcon = true;
			this.createNewProduct.AutoSizeRightIcon = true;
			this.createNewProduct.BackColor = System.Drawing.Color.Transparent;
			this.createNewProduct.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.createNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createNewProduct.BackgroundImage")));
			this.createNewProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.createNewProduct.ButtonText = "Create new";
			this.createNewProduct.ButtonTextMarginLeft = 0;
			this.createNewProduct.ColorContrastOnClick = 45;
			this.createNewProduct.ColorContrastOnHover = 45;
			this.createNewProduct.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.createNewProduct.CustomizableEdges = borderEdges1;
			this.createNewProduct.DialogResult = System.Windows.Forms.DialogResult.None;
			this.createNewProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.createNewProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.createNewProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.createNewProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.createNewProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createNewProduct.ForeColor = System.Drawing.Color.White;
			this.createNewProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.createNewProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.createNewProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.createNewProduct.IconMarginLeft = 11;
			this.createNewProduct.IconPadding = 10;
			this.createNewProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.createNewProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.createNewProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.createNewProduct.IconSize = 25;
			this.createNewProduct.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.createNewProduct.IdleBorderRadius = 1;
			this.createNewProduct.IdleBorderThickness = 1;
			this.createNewProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.createNewProduct.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("createNewProduct.IdleIconLeftImage")));
			this.createNewProduct.IdleIconRightImage = null;
			this.createNewProduct.IndicateFocus = false;
			this.createNewProduct.Location = new System.Drawing.Point(117, 21);
			this.createNewProduct.Margin = new System.Windows.Forms.Padding(2);
			this.createNewProduct.Name = "createNewProduct";
			this.createNewProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.createNewProduct.OnDisabledState.BorderRadius = 1;
			this.createNewProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.createNewProduct.OnDisabledState.BorderThickness = 1;
			this.createNewProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.createNewProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.createNewProduct.OnDisabledState.IconLeftImage = null;
			this.createNewProduct.OnDisabledState.IconRightImage = null;
			this.createNewProduct.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.createNewProduct.onHoverState.BorderRadius = 1;
			this.createNewProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.createNewProduct.onHoverState.BorderThickness = 1;
			this.createNewProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.createNewProduct.onHoverState.ForeColor = System.Drawing.Color.White;
			this.createNewProduct.onHoverState.IconLeftImage = null;
			this.createNewProduct.onHoverState.IconRightImage = null;
			this.createNewProduct.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.createNewProduct.OnIdleState.BorderRadius = 1;
			this.createNewProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.createNewProduct.OnIdleState.BorderThickness = 1;
			this.createNewProduct.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.createNewProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.createNewProduct.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("createNewProduct.OnIdleState.IconLeftImage")));
			this.createNewProduct.OnIdleState.IconRightImage = null;
			this.createNewProduct.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.createNewProduct.OnPressedState.BorderRadius = 1;
			this.createNewProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.createNewProduct.OnPressedState.BorderThickness = 1;
			this.createNewProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.createNewProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.createNewProduct.OnPressedState.IconLeftImage = null;
			this.createNewProduct.OnPressedState.IconRightImage = null;
			this.createNewProduct.Size = new System.Drawing.Size(137, 46);
			this.createNewProduct.TabIndex = 12;
			this.createNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.createNewProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.createNewProduct.TextMarginLeft = 0;
			this.createNewProduct.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.createNewProduct.UseDefaultRadiusAndThickness = true;
			this.createNewProduct.Click += new System.EventHandler(this.createNewProduct_Click);
			// 
			// exportProduct
			// 
			this.exportProduct.AllowAnimations = true;
			this.exportProduct.AllowMouseEffects = true;
			this.exportProduct.AllowToggling = false;
			this.exportProduct.AnimationSpeed = 200;
			this.exportProduct.AutoGenerateColors = false;
			this.exportProduct.AutoRoundBorders = false;
			this.exportProduct.AutoSizeLeftIcon = true;
			this.exportProduct.AutoSizeRightIcon = true;
			this.exportProduct.BackColor = System.Drawing.Color.Transparent;
			this.exportProduct.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.exportProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportProduct.BackgroundImage")));
			this.exportProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.exportProduct.ButtonText = "Export";
			this.exportProduct.ButtonTextMarginLeft = 0;
			this.exportProduct.ColorContrastOnClick = 45;
			this.exportProduct.ColorContrastOnHover = 45;
			this.exportProduct.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges2.BottomLeft = true;
			borderEdges2.BottomRight = true;
			borderEdges2.TopLeft = true;
			borderEdges2.TopRight = true;
			this.exportProduct.CustomizableEdges = borderEdges2;
			this.exportProduct.DialogResult = System.Windows.Forms.DialogResult.None;
			this.exportProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.exportProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.exportProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.exportProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.exportProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exportProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
			this.exportProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.exportProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.exportProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.exportProduct.IconMarginLeft = 11;
			this.exportProduct.IconPadding = 10;
			this.exportProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.exportProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.exportProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.exportProduct.IconSize = 25;
			this.exportProduct.IdleBorderColor = System.Drawing.Color.LightGray;
			this.exportProduct.IdleBorderRadius = 5;
			this.exportProduct.IdleBorderThickness = 1;
			this.exportProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.exportProduct.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("exportProduct.IdleIconLeftImage")));
			this.exportProduct.IdleIconRightImage = null;
			this.exportProduct.IndicateFocus = false;
			this.exportProduct.Location = new System.Drawing.Point(1019, 21);
			this.exportProduct.Margin = new System.Windows.Forms.Padding(2);
			this.exportProduct.Name = "exportProduct";
			this.exportProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.exportProduct.OnDisabledState.BorderRadius = 5;
			this.exportProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.exportProduct.OnDisabledState.BorderThickness = 1;
			this.exportProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.exportProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.exportProduct.OnDisabledState.IconLeftImage = null;
			this.exportProduct.OnDisabledState.IconRightImage = null;
			this.exportProduct.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.exportProduct.onHoverState.BorderRadius = 5;
			this.exportProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.exportProduct.onHoverState.BorderThickness = 1;
			this.exportProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.exportProduct.onHoverState.ForeColor = System.Drawing.Color.White;
			this.exportProduct.onHoverState.IconLeftImage = null;
			this.exportProduct.onHoverState.IconRightImage = null;
			this.exportProduct.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
			this.exportProduct.OnIdleState.BorderRadius = 5;
			this.exportProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.exportProduct.OnIdleState.BorderThickness = 1;
			this.exportProduct.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.exportProduct.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
			this.exportProduct.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("exportProduct.OnIdleState.IconLeftImage")));
			this.exportProduct.OnIdleState.IconRightImage = null;
			this.exportProduct.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.exportProduct.OnPressedState.BorderRadius = 5;
			this.exportProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.exportProduct.OnPressedState.BorderThickness = 1;
			this.exportProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.exportProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.exportProduct.OnPressedState.IconLeftImage = null;
			this.exportProduct.OnPressedState.IconRightImage = null;
			this.exportProduct.Size = new System.Drawing.Size(127, 46);
			this.exportProduct.TabIndex = 11;
			this.exportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.exportProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.exportProduct.TextMarginLeft = 0;
			this.exportProduct.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.exportProduct.UseDefaultRadiusAndThickness = true;
			this.exportProduct.Click += new System.EventHandler(this.exportProduct_Click);
			// 
			// StaffGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1300, 793);
			this.Controls.Add(this.bunifuPanel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "StaffGUI";
			this.Text = "Staff";
			this.Load += new System.EventHandler(this.Staff_Load);
			this.bunifuPanel2.ResumeLayout(false);
			this.bunifuPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuTextBox searchStaff;
        private System.Windows.Forms.Label headingProduct;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton createNewProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exportProduct;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddAccToStaff;
	}
}