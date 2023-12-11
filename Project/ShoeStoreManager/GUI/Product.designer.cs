
namespace GUI
{
    partial class Product
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.headingProduct = new System.Windows.Forms.Label();
			this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
			this.dtgv = new Guna.UI2.WinForms.Guna2DataGridView();
			this.priceProduct = new Bunifu.UI.WinForms.BunifuDropdown();
			this.searchProduct = new Bunifu.UI.WinForms.BunifuTextBox();
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
			this.headingProduct.Location = new System.Drawing.Point(15, 20);
			this.headingProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.headingProduct.Name = "headingProduct";
			this.headingProduct.Size = new System.Drawing.Size(383, 46);
			this.headingProduct.TabIndex = 13;
			this.headingProduct.Text = "Products Management";
			// 
			// bunifuPanel2
			// 
			this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
			this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
			this.bunifuPanel2.BorderRadius = 5;
			this.bunifuPanel2.BorderThickness = 1;
			this.bunifuPanel2.Controls.Add(this.dtgv);
			this.bunifuPanel2.Controls.Add(this.createNewProduct);
			this.bunifuPanel2.Controls.Add(this.headingProduct);
			this.bunifuPanel2.Controls.Add(this.exportProduct);
			this.bunifuPanel2.Controls.Add(this.priceProduct);
			this.bunifuPanel2.Controls.Add(this.searchProduct);
			this.bunifuPanel2.Location = new System.Drawing.Point(65, 57);
			this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bunifuPanel2.Name = "bunifuPanel2";
			this.bunifuPanel2.ShowBorders = true;
			this.bunifuPanel2.Size = new System.Drawing.Size(1167, 676);
			this.bunifuPanel2.TabIndex = 14;
			// 
			// dtgv
			// 
			this.dtgv.AllowUserToAddRows = false;
			this.dtgv.AllowUserToResizeColumns = false;
			this.dtgv.AllowUserToResizeRows = false;
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
			this.dtgv.Location = new System.Drawing.Point(23, 129);
			this.dtgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtgv.Name = "dtgv";
			this.dtgv.ReadOnly = true;
			this.dtgv.RowHeadersVisible = false;
			this.dtgv.RowHeadersWidth = 51;
			this.dtgv.RowTemplate.Height = 50;
			this.dtgv.Size = new System.Drawing.Size(1121, 521);
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
			// priceProduct
			// 
			this.priceProduct.BackColor = System.Drawing.Color.Transparent;
			this.priceProduct.BackgroundColor = System.Drawing.Color.White;
			this.priceProduct.BorderColor = System.Drawing.Color.Silver;
			this.priceProduct.BorderRadius = 5;
			this.priceProduct.Color = System.Drawing.Color.Silver;
			this.priceProduct.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.priceProduct.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.priceProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.priceProduct.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.priceProduct.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.priceProduct.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.priceProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.priceProduct.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.priceProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priceProduct.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.priceProduct.FillDropDown = true;
			this.priceProduct.FillIndicator = false;
			this.priceProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.priceProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
			this.priceProduct.FormattingEnabled = true;
			this.priceProduct.Icon = null;
			this.priceProduct.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.priceProduct.IndicatorColor = System.Drawing.Color.Gray;
			this.priceProduct.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.priceProduct.ItemBackColor = System.Drawing.Color.White;
			this.priceProduct.ItemBorderColor = System.Drawing.Color.White;
			this.priceProduct.ItemForeColor = System.Drawing.Color.Black;
			this.priceProduct.ItemHeight = 26;
			this.priceProduct.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.priceProduct.ItemHighLightForeColor = System.Drawing.Color.White;
			this.priceProduct.Items.AddRange(new object[] {
            "All",
            "< 5000",
            "5000 - 10000",
            "> 10000"});
			this.priceProduct.ItemTopMargin = 3;
			this.priceProduct.Location = new System.Drawing.Point(994, 93);
			this.priceProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.priceProduct.Name = "priceProduct";
			this.priceProduct.Size = new System.Drawing.Size(150, 32);
			this.priceProduct.TabIndex = 5;
			this.priceProduct.Text = "Price";
			this.priceProduct.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.priceProduct.TextLeftMargin = 5;
			this.priceProduct.SelectedIndexChanged += new System.EventHandler(this.priceProduct_SelectedIndexChanged);
			// 
			// searchProduct
			// 
			this.searchProduct.AcceptsReturn = false;
			this.searchProduct.AcceptsTab = false;
			this.searchProduct.AnimationSpeed = 200;
			this.searchProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.searchProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.searchProduct.BackColor = System.Drawing.Color.Transparent;
			this.searchProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchProduct.BackgroundImage")));
			this.searchProduct.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.searchProduct.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.searchProduct.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.searchProduct.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
			this.searchProduct.BorderRadius = 5;
			this.searchProduct.BorderThickness = 1;
			this.searchProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchProduct.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchProduct.DefaultText = "";
			this.searchProduct.FillColor = System.Drawing.Color.White;
			this.searchProduct.HideSelection = true;
			this.searchProduct.IconLeft = null;
			this.searchProduct.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchProduct.IconPadding = 10;
			this.searchProduct.IconRight = null;
			this.searchProduct.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchProduct.Lines = new string[0];
			this.searchProduct.Location = new System.Drawing.Point(23, 83);
			this.searchProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchProduct.MaxLength = 32767;
			this.searchProduct.MinimumSize = new System.Drawing.Size(1, 1);
			this.searchProduct.Modified = false;
			this.searchProduct.Multiline = false;
			this.searchProduct.Name = "searchProduct";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchProduct.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.searchProduct.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchProduct.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchProduct.OnIdleState = stateProperties4;
			this.searchProduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchProduct.PasswordChar = '\0';
			this.searchProduct.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchProduct.PlaceholderText = "Search by name";
			this.searchProduct.ReadOnly = false;
			this.searchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchProduct.SelectedText = "";
			this.searchProduct.SelectionLength = 0;
			this.searchProduct.SelectionStart = 0;
			this.searchProduct.ShortcutsEnabled = true;
			this.searchProduct.Size = new System.Drawing.Size(967, 42);
			this.searchProduct.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.searchProduct.TabIndex = 3;
			this.searchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.searchProduct.TextMarginBottom = 0;
			this.searchProduct.TextMarginLeft = 20;
			this.searchProduct.TextMarginTop = 0;
			this.searchProduct.TextPlaceholder = "Search by name";
			this.searchProduct.UseSystemPasswordChar = false;
			this.searchProduct.WordWrap = true;
			this.searchProduct.TextChanged += new System.EventHandler(this.searchProduct_TextChanged);
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
			this.createNewProduct.Location = new System.Drawing.Point(402, 20);
			this.createNewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.createNewProduct.TabIndex = 16;
			this.createNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.createNewProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.createNewProduct.TextMarginLeft = 0;
			this.createNewProduct.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.createNewProduct.UseDefaultRadiusAndThickness = true;
			this.createNewProduct.Click += new System.EventHandler(this.createNewProduct_Click_1);
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
			this.exportProduct.Location = new System.Drawing.Point(994, 20);
			this.exportProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.exportProduct.Size = new System.Drawing.Size(150, 46);
			this.exportProduct.TabIndex = 15;
			this.exportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.exportProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.exportProduct.TextMarginLeft = 0;
			this.exportProduct.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.exportProduct.UseDefaultRadiusAndThickness = true;
			this.exportProduct.Click += new System.EventHandler(this.exportProduct_Click);
			// 
			// Product
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1300, 793);
			this.Controls.Add(this.bunifuPanel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Product";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Product_Load);
			this.bunifuPanel2.ResumeLayout(false);
			this.bunifuPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv;
        private Bunifu.UI.WinForms.BunifuDropdown priceProduct;
        private Bunifu.UI.WinForms.BunifuTextBox searchProduct;
        private System.Windows.Forms.Label headingProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton createNewProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exportProduct;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}