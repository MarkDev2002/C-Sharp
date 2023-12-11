namespace GUI
{
    partial class BillManagerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillManagerGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBill = new Bunifu.UI.WinForms.BunifuTextBox();
            this.headingProduct = new System.Windows.Forms.Label();
            this.exportBill = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBill
            // 
            this.searchBill.AcceptsReturn = false;
            this.searchBill.AcceptsTab = false;
            this.searchBill.AnimationSpeed = 200;
            this.searchBill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBill.BackColor = System.Drawing.Color.Transparent;
            this.searchBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBill.BackgroundImage")));
            this.searchBill.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchBill.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchBill.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchBill.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.searchBill.BorderRadius = 5;
            this.searchBill.BorderThickness = 1;
            this.searchBill.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBill.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBill.DefaultText = "Search";
            this.searchBill.FillColor = System.Drawing.Color.White;
            this.searchBill.HideSelection = true;
            this.searchBill.IconLeft = null;
            this.searchBill.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBill.IconPadding = 10;
            this.searchBill.IconRight = null;
            this.searchBill.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBill.Lines = new string[] {
        "Search"};
            this.searchBill.Location = new System.Drawing.Point(20, 87);
            this.searchBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBill.MaxLength = 32767;
            this.searchBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBill.Modified = false;
            this.searchBill.Multiline = false;
            this.searchBill.Name = "searchBill";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBill.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBill.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBill.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBill.OnIdleState = stateProperties4;
            this.searchBill.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBill.PasswordChar = '\0';
            this.searchBill.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBill.PlaceholderText = "Enter BillID";
            this.searchBill.ReadOnly = false;
            this.searchBill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBill.SelectedText = "";
            this.searchBill.SelectionLength = 0;
            this.searchBill.SelectionStart = 6;
            this.searchBill.ShortcutsEnabled = true;
            this.searchBill.Size = new System.Drawing.Size(693, 52);
            this.searchBill.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchBill.TabIndex = 3;
            this.searchBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBill.TextMarginBottom = 0;
            this.searchBill.TextMarginLeft = 20;
            this.searchBill.TextMarginTop = 0;
            this.searchBill.TextPlaceholder = "Enter BillID";
            this.searchBill.UseSystemPasswordChar = false;
            this.searchBill.WordWrap = true;
            this.searchBill.TextChanged += new System.EventHandler(this.searchBill_TextChanged);
            this.searchBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBill_MouseClick);
            // 
            // headingProduct
            // 
            this.headingProduct.AutoSize = true;
            this.headingProduct.BackColor = System.Drawing.Color.Transparent;
            this.headingProduct.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.headingProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.headingProduct.Location = new System.Drawing.Point(9, 23);
            this.headingProduct.Name = "headingProduct";
            this.headingProduct.Size = new System.Drawing.Size(362, 57);
            this.headingProduct.TabIndex = 13;
            this.headingProduct.Text = "Bill Management";
            // 
            // exportBill
            // 
            this.exportBill.AllowAnimations = true;
            this.exportBill.AllowMouseEffects = true;
            this.exportBill.AllowToggling = false;
            this.exportBill.AnimationSpeed = 200;
            this.exportBill.AutoGenerateColors = false;
            this.exportBill.AutoRoundBorders = false;
            this.exportBill.AutoSizeLeftIcon = true;
            this.exportBill.AutoSizeRightIcon = true;
            this.exportBill.BackColor = System.Drawing.Color.Transparent;
            this.exportBill.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exportBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportBill.BackgroundImage")));
            this.exportBill.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportBill.ButtonText = "Export";
            this.exportBill.ButtonTextMarginLeft = 0;
            this.exportBill.ColorContrastOnClick = 45;
            this.exportBill.ColorContrastOnHover = 45;
            this.exportBill.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.exportBill.CustomizableEdges = borderEdges1;
            this.exportBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exportBill.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exportBill.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exportBill.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exportBill.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.exportBill.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.exportBill.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportBill.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.exportBill.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.exportBill.IconMarginLeft = 11;
            this.exportBill.IconPadding = 10;
            this.exportBill.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportBill.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.exportBill.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.exportBill.IconSize = 25;
            this.exportBill.IdleBorderColor = System.Drawing.Color.LightGray;
            this.exportBill.IdleBorderRadius = 5;
            this.exportBill.IdleBorderThickness = 1;
            this.exportBill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exportBill.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("exportBill.IdleIconLeftImage")));
            this.exportBill.IdleIconRightImage = null;
            this.exportBill.IndicateFocus = false;
            this.exportBill.Location = new System.Drawing.Point(1257, 2);
            this.exportBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportBill.Name = "exportBill";
            this.exportBill.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exportBill.OnDisabledState.BorderRadius = 5;
            this.exportBill.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportBill.OnDisabledState.BorderThickness = 1;
            this.exportBill.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exportBill.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exportBill.OnDisabledState.IconLeftImage = null;
            this.exportBill.OnDisabledState.IconRightImage = null;
            this.exportBill.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.exportBill.onHoverState.BorderRadius = 5;
            this.exportBill.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportBill.onHoverState.BorderThickness = 1;
            this.exportBill.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.exportBill.onHoverState.ForeColor = System.Drawing.Color.White;
            this.exportBill.onHoverState.IconLeftImage = null;
            this.exportBill.onHoverState.IconRightImage = null;
            this.exportBill.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.exportBill.OnIdleState.BorderRadius = 5;
            this.exportBill.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportBill.OnIdleState.BorderThickness = 1;
            this.exportBill.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exportBill.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.exportBill.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("exportBill.OnIdleState.IconLeftImage")));
            this.exportBill.OnIdleState.IconRightImage = null;
            this.exportBill.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.exportBill.OnPressedState.BorderRadius = 5;
            this.exportBill.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportBill.OnPressedState.BorderThickness = 1;
            this.exportBill.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.exportBill.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.exportBill.OnPressedState.IconLeftImage = null;
            this.exportBill.OnPressedState.IconRightImage = null;
            this.exportBill.Size = new System.Drawing.Size(129, 59);
            this.exportBill.TabIndex = 15;
            this.exportBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportBill.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.exportBill.TextMarginLeft = 0;
            this.exportBill.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.exportBill.UseDefaultRadiusAndThickness = true;
            this.exportBill.Click += new System.EventHandler(this.exportBill_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dtgv);
            this.guna2Panel1.Controls.Add(this.exportBill);
            this.guna2Panel1.Controls.Add(this.headingProduct);
            this.guna2Panel1.Controls.Add(this.searchBill);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.Location = new System.Drawing.Point(13, 13);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1417, 781);
            this.guna2Panel1.TabIndex = 2;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.dtgv.Location = new System.Drawing.Point(20, 134);
            this.dtgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 50;
            this.dtgv.Size = new System.Drawing.Size(1180, 607);
            this.dtgv.TabIndex = 1;
            this.dtgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dtgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            // BillManagerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1733, 976);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BillManagerGUI";
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bills_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox searchBill;
        private System.Windows.Forms.Label headingProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exportBill;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		public Guna.UI2.WinForms.Guna2DataGridView dtgv;
	}
}