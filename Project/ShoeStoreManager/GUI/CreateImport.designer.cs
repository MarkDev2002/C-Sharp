namespace GUI
{
    partial class CreateImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateImport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.headingProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dtgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbProduct = new System.Windows.Forms.Label();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnImportSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.lbPhoneStaff = new System.Windows.Forms.Label();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.orderCustomer = new Bunifu.UI.WinForms.BunifuPanel();
            this.labSupplier = new System.Windows.Forms.Label();
            this.lbSupplierPhone = new System.Windows.Forms.Label();
            this.lbSuppID = new System.Windows.Forms.Label();
            this.lbSuppilerName = new System.Windows.Forms.Label();
            this.btnAddSub = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).BeginInit();
            this.orderCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headingProduct
            // 
            this.headingProduct.AutoSize = true;
            this.headingProduct.BackColor = System.Drawing.Color.Transparent;
            this.headingProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.headingProduct.Location = new System.Drawing.Point(17, -39);
            this.headingProduct.Name = "headingProduct";
            this.headingProduct.Size = new System.Drawing.Size(157, 31);
            this.headingProduct.TabIndex = 10;
            this.headingProduct.Text = "CreateImport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(415, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create Import";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuPanel2.BorderRadius = 1;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.dtgv);
            this.bunifuPanel2.Controls.Add(this.btnClear);
            this.bunifuPanel2.Controls.Add(this.lbProduct);
            this.bunifuPanel2.Controls.Add(this.bunifuPanel4);
            this.bunifuPanel2.Controls.Add(this.label1);
            this.bunifuPanel2.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel2.Controls.Add(this.orderCustomer);
            this.bunifuPanel2.Location = new System.Drawing.Point(12, 11);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1258, 751);
            this.bunifuPanel2.TabIndex = 11;
            // 
            // dtgv
            // 
            this.dtgv.AllowCustomTheming = false;
            this.dtgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.ColumnHeadersHeight = 40;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Quantity,
            this.UnitPrice,
            this.Total});
            this.dtgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dtgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dtgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtgv.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dtgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dtgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dtgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dtgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv.CurrentTheme.Name = null;
            this.dtgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dtgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dtgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dtgv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dtgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgv.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv.Location = new System.Drawing.Point(3, 350);
            this.dtgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 40;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(801, 400);
            this.dtgv.TabIndex = 8;
            this.dtgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dtgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellEndEdit);
            this.dtgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgv_RowsAdded);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // btnClear
            // 
            this.btnClear.AllowAnimations = true;
            this.btnClear.AllowMouseEffects = true;
            this.btnClear.AllowToggling = false;
            this.btnClear.AnimationSpeed = 200;
            this.btnClear.AutoGenerateColors = false;
            this.btnClear.AutoRoundBorders = false;
            this.btnClear.AutoSizeLeftIcon = true;
            this.btnClear.AutoSizeRightIcon = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackColor1 = System.Drawing.Color.SteelBlue;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.ButtonText = "Refresh";
            this.btnClear.ButtonTextMarginLeft = 0;
            this.btnClear.ColorContrastOnClick = 45;
            this.btnClear.ColorContrastOnHover = 45;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClear.CustomizableEdges = borderEdges1;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClear.IconMarginLeft = 11;
            this.btnClear.IconPadding = 10;
            this.btnClear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClear.IconSize = 25;
            this.btnClear.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.IdleBorderRadius = 1;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnClear.IdleIconLeftImage = null;
            this.btnClear.IdleIconRightImage = null;
            this.btnClear.IndicateFocus = false;
            this.btnClear.Location = new System.Drawing.Point(1088, 2);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.OnDisabledState.BorderRadius = 1;
            this.btnClear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnDisabledState.BorderThickness = 1;
            this.btnClear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClear.OnDisabledState.IconLeftImage = null;
            this.btnClear.OnDisabledState.IconRightImage = null;
            this.btnClear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClear.onHoverState.BorderRadius = 1;
            this.btnClear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.onHoverState.BorderThickness = 1;
            this.btnClear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.onHoverState.IconLeftImage = null;
            this.btnClear.onHoverState.IconRightImage = null;
            this.btnClear.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.OnIdleState.BorderRadius = 1;
            this.btnClear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnIdleState.BorderThickness = 1;
            this.btnClear.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnClear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnIdleState.IconLeftImage = null;
            this.btnClear.OnIdleState.IconRightImage = null;
            this.btnClear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClear.OnPressedState.BorderRadius = 1;
            this.btnClear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnPressedState.BorderThickness = 1;
            this.btnClear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnPressedState.IconLeftImage = null;
            this.btnClear.OnPressedState.IconRightImage = null;
            this.btnClear.Size = new System.Drawing.Size(148, 38);
            this.btnClear.TabIndex = 23;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.TextMarginLeft = 0;
            this.btnClear.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClear.UseDefaultRadiusAndThickness = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbProduct.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbProduct.ForeColor = System.Drawing.Color.Gray;
            this.lbProduct.Location = new System.Drawing.Point(576, 300);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(228, 34);
            this.lbProduct.TabIndex = 6;
            this.lbProduct.Text = "Choose Products";
            this.lbProduct.Click += new System.EventHandler(this.lbProduct_Click);
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.btnImportSave);
            this.bunifuPanel4.Controls.Add(this.label4);
            this.bunifuPanel4.Controls.Add(this.lbSubTotal);
            this.bunifuPanel4.Controls.Add(this.a);
            this.bunifuPanel4.Controls.Add(this.label8);
            this.bunifuPanel4.Controls.Add(this.b);
            this.bunifuPanel4.Controls.Add(this.lblTotal);
            this.bunifuPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel4.Location = new System.Drawing.Point(878, 526);
            this.bunifuPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(319, 224);
            this.bunifuPanel4.TabIndex = 7;
            // 
            // btnImportSave
            // 
            this.btnImportSave.AllowAnimations = true;
            this.btnImportSave.AllowMouseEffects = true;
            this.btnImportSave.AllowToggling = false;
            this.btnImportSave.AnimationSpeed = 200;
            this.btnImportSave.AutoGenerateColors = false;
            this.btnImportSave.AutoRoundBorders = false;
            this.btnImportSave.AutoSizeLeftIcon = true;
            this.btnImportSave.AutoSizeRightIcon = true;
            this.btnImportSave.BackColor = System.Drawing.Color.Transparent;
            this.btnImportSave.BackColor1 = System.Drawing.Color.SteelBlue;
            this.btnImportSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportSave.BackgroundImage")));
            this.btnImportSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImportSave.ButtonText = "Save";
            this.btnImportSave.ButtonTextMarginLeft = 0;
            this.btnImportSave.ColorContrastOnClick = 45;
            this.btnImportSave.ColorContrastOnHover = 45;
            this.btnImportSave.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnImportSave.CustomizableEdges = borderEdges2;
            this.btnImportSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImportSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImportSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImportSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImportSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnImportSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportSave.ForeColor = System.Drawing.Color.White;
            this.btnImportSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnImportSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnImportSave.IconMarginLeft = 11;
            this.btnImportSave.IconPadding = 10;
            this.btnImportSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnImportSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnImportSave.IconSize = 25;
            this.btnImportSave.IdleBorderColor = System.Drawing.Color.MidnightBlue;
            this.btnImportSave.IdleBorderRadius = 5;
            this.btnImportSave.IdleBorderThickness = 1;
            this.btnImportSave.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnImportSave.IdleIconLeftImage = null;
            this.btnImportSave.IdleIconRightImage = null;
            this.btnImportSave.IndicateFocus = false;
            this.btnImportSave.Location = new System.Drawing.Point(124, 164);
            this.btnImportSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportSave.Name = "btnImportSave";
            this.btnImportSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImportSave.OnDisabledState.BorderRadius = 5;
            this.btnImportSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImportSave.OnDisabledState.BorderThickness = 1;
            this.btnImportSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImportSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImportSave.OnDisabledState.IconLeftImage = null;
            this.btnImportSave.OnDisabledState.IconRightImage = null;
            this.btnImportSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImportSave.onHoverState.BorderRadius = 5;
            this.btnImportSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImportSave.onHoverState.BorderThickness = 1;
            this.btnImportSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImportSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnImportSave.onHoverState.IconLeftImage = null;
            this.btnImportSave.onHoverState.IconRightImage = null;
            this.btnImportSave.OnIdleState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnImportSave.OnIdleState.BorderRadius = 5;
            this.btnImportSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImportSave.OnIdleState.BorderThickness = 1;
            this.btnImportSave.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnImportSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnImportSave.OnIdleState.IconLeftImage = null;
            this.btnImportSave.OnIdleState.IconRightImage = null;
            this.btnImportSave.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImportSave.OnPressedState.BorderRadius = 5;
            this.btnImportSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImportSave.OnPressedState.BorderThickness = 1;
            this.btnImportSave.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImportSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnImportSave.OnPressedState.IconLeftImage = null;
            this.btnImportSave.OnPressedState.IconRightImage = null;
            this.btnImportSave.Size = new System.Drawing.Size(79, 39);
            this.btnImportSave.TabIndex = 28;
            this.btnImportSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImportSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImportSave.TextMarginLeft = 0;
            this.btnImportSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnImportSave.UseDefaultRadiusAndThickness = true;
            this.btnImportSave.Click += new System.EventHandler(this.btnImportSave_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(180, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "5%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lbSubTotal.Location = new System.Drawing.Point(183, 58);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(89, 23);
            this.lbSubTotal.TabIndex = 12;
            this.lbSubTotal.Text = "0.00";
            this.lbSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.a.Location = new System.Drawing.Point(49, 59);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(62, 18);
            this.a.TabIndex = 9;
            this.a.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.label8.Location = new System.Drawing.Point(52, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "VAT";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.b.Location = new System.Drawing.Point(49, 106);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(41, 18);
            this.b.TabIndex = 11;
            this.b.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lblTotal.Location = new System.Drawing.Point(101, 105);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(171, 28);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.lbStaffID);
            this.bunifuPanel3.Controls.Add(this.lbPhoneStaff);
            this.bunifuPanel3.Controls.Add(this.lbNameStaff);
            this.bunifuPanel3.Controls.Add(this.label16);
            this.bunifuPanel3.Controls.Add(this.bunifuPictureBox3);
            this.bunifuPanel3.Location = new System.Drawing.Point(878, 126);
            this.bunifuPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(314, 174);
            this.bunifuPanel3.TabIndex = 6;
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.BackColor = System.Drawing.Color.Transparent;
            this.lbStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lbStaffID.Location = new System.Drawing.Point(61, 48);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(40, 16);
            this.lbStaffID.TabIndex = 6;
            this.lbStaffID.Text = "VN01";
            // 
            // lbPhoneStaff
            // 
            this.lbPhoneStaff.AutoSize = true;
            this.lbPhoneStaff.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoneStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lbPhoneStaff.Location = new System.Drawing.Point(60, 91);
            this.lbPhoneStaff.Name = "lbPhoneStaff";
            this.lbPhoneStaff.Size = new System.Drawing.Size(102, 16);
            this.lbPhoneStaff.TabIndex = 4;
            this.lbPhoneStaff.Text = "(+84) 987654321";
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.BackColor = System.Drawing.Color.Transparent;
            this.lbNameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lbNameStaff.Location = new System.Drawing.Point(60, 64);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(92, 16);
            this.lbNameStaff.TabIndex = 2;
            this.lbNameStaff.Text = "Standard Lord";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.label16.Location = new System.Drawing.Point(60, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 28);
            this.label16.TabIndex = 1;
            this.label16.Text = "Staff";
            // 
            // bunifuPictureBox3
            // 
            this.bunifuPictureBox3.AllowFocused = false;
            this.bunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox3.AutoSizeHeight = true;
            this.bunifuPictureBox3.BorderRadius = 0;
            this.bunifuPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox3.Image")));
            this.bunifuPictureBox3.IsCircle = true;
            this.bunifuPictureBox3.Location = new System.Drawing.Point(21, 15);
            this.bunifuPictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPictureBox3.Name = "bunifuPictureBox3";
            this.bunifuPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.bunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox3.TabIndex = 0;
            this.bunifuPictureBox3.TabStop = false;
            this.bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // orderCustomer
            // 
            this.orderCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.orderCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderCustomer.BackgroundImage")));
            this.orderCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderCustomer.BorderColor = System.Drawing.Color.Transparent;
            this.orderCustomer.BorderRadius = 3;
            this.orderCustomer.BorderThickness = 1;
            this.orderCustomer.Controls.Add(this.labSupplier);
            this.orderCustomer.Controls.Add(this.lbSupplierPhone);
            this.orderCustomer.Controls.Add(this.lbSuppID);
            this.orderCustomer.Controls.Add(this.lbSuppilerName);
            this.orderCustomer.Controls.Add(this.btnAddSub);
            this.orderCustomer.Controls.Add(this.label2);
            this.orderCustomer.Controls.Add(this.bunifuPictureBox1);
            this.orderCustomer.Location = new System.Drawing.Point(878, 330);
            this.orderCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderCustomer.Name = "orderCustomer";
            this.orderCustomer.ShowBorders = true;
            this.orderCustomer.Size = new System.Drawing.Size(319, 174);
            this.orderCustomer.TabIndex = 2;
            // 
            // labSupplier
            // 
            this.labSupplier.AutoSize = true;
            this.labSupplier.BackColor = System.Drawing.Color.Transparent;
            this.labSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSupplier.Location = new System.Drawing.Point(60, 126);
            this.labSupplier.Name = "labSupplier";
            this.labSupplier.Size = new System.Drawing.Size(101, 20);
            this.labSupplier.TabIndex = 5;
            this.labSupplier.Text = "View supplier";
            this.labSupplier.Click += new System.EventHandler(this.labSupplier_Click);
            // 
            // lbSupplierPhone
            // 
            this.lbSupplierPhone.AutoSize = true;
            this.lbSupplierPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplierPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lbSupplierPhone.Location = new System.Drawing.Point(61, 96);
            this.lbSupplierPhone.Name = "lbSupplierPhone";
            this.lbSupplierPhone.Size = new System.Drawing.Size(0, 16);
            this.lbSupplierPhone.TabIndex = 4;
            // 
            // lbSuppID
            // 
            this.lbSuppID.AutoSize = true;
            this.lbSuppID.BackColor = System.Drawing.Color.Transparent;
            this.lbSuppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuppID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lbSuppID.Location = new System.Drawing.Point(60, 53);
            this.lbSuppID.Name = "lbSuppID";
            this.lbSuppID.Size = new System.Drawing.Size(0, 16);
            this.lbSuppID.TabIndex = 3;
            // 
            // lbSuppilerName
            // 
            this.lbSuppilerName.AutoSize = true;
            this.lbSuppilerName.BackColor = System.Drawing.Color.Transparent;
            this.lbSuppilerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuppilerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.lbSuppilerName.Location = new System.Drawing.Point(61, 69);
            this.lbSuppilerName.Name = "lbSuppilerName";
            this.lbSuppilerName.Size = new System.Drawing.Size(0, 16);
            this.lbSuppilerName.TabIndex = 2;
            // 
            // btnAddSub
            // 
            this.btnAddSub.AllowAnimations = true;
            this.btnAddSub.AllowMouseEffects = true;
            this.btnAddSub.AllowToggling = false;
            this.btnAddSub.AnimationSpeed = 200;
            this.btnAddSub.AutoGenerateColors = false;
            this.btnAddSub.AutoRoundBorders = false;
            this.btnAddSub.AutoSizeLeftIcon = true;
            this.btnAddSub.AutoSizeRightIcon = true;
            this.btnAddSub.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSub.BackColor1 = System.Drawing.Color.SteelBlue;
            this.btnAddSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSub.BackgroundImage")));
            this.btnAddSub.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSub.ButtonText = "Add Supplier";
            this.btnAddSub.ButtonTextMarginLeft = 0;
            this.btnAddSub.ColorContrastOnClick = 45;
            this.btnAddSub.ColorContrastOnHover = 45;
            this.btnAddSub.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddSub.CustomizableEdges = borderEdges3;
            this.btnAddSub.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSub.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSub.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddSub.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddSub.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddSub.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSub.ForeColor = System.Drawing.Color.White;
            this.btnAddSub.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSub.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddSub.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddSub.IconMarginLeft = 11;
            this.btnAddSub.IconPadding = 10;
            this.btnAddSub.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSub.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddSub.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddSub.IconSize = 25;
            this.btnAddSub.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSub.IdleBorderRadius = 1;
            this.btnAddSub.IdleBorderThickness = 1;
            this.btnAddSub.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnAddSub.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAddSub.IdleIconLeftImage")));
            this.btnAddSub.IdleIconRightImage = null;
            this.btnAddSub.IndicateFocus = false;
            this.btnAddSub.Location = new System.Drawing.Point(166, 15);
            this.btnAddSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSub.OnDisabledState.BorderRadius = 1;
            this.btnAddSub.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSub.OnDisabledState.BorderThickness = 1;
            this.btnAddSub.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddSub.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddSub.OnDisabledState.IconLeftImage = null;
            this.btnAddSub.OnDisabledState.IconRightImage = null;
            this.btnAddSub.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddSub.onHoverState.BorderRadius = 1;
            this.btnAddSub.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSub.onHoverState.BorderThickness = 1;
            this.btnAddSub.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddSub.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddSub.onHoverState.IconLeftImage = null;
            this.btnAddSub.onHoverState.IconRightImage = null;
            this.btnAddSub.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSub.OnIdleState.BorderRadius = 1;
            this.btnAddSub.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSub.OnIdleState.BorderThickness = 1;
            this.btnAddSub.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAddSub.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddSub.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAddSub.OnIdleState.IconLeftImage")));
            this.btnAddSub.OnIdleState.IconRightImage = null;
            this.btnAddSub.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddSub.OnPressedState.BorderRadius = 1;
            this.btnAddSub.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSub.OnPressedState.BorderThickness = 1;
            this.btnAddSub.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddSub.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddSub.OnPressedState.IconLeftImage = null;
            this.btnAddSub.OnPressedState.IconRightImage = null;
            this.btnAddSub.Size = new System.Drawing.Size(150, 39);
            this.btnAddSub.TabIndex = 21;
            this.btnAddSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSub.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSub.TextMarginLeft = 0;
            this.btnAddSub.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAddSub.UseDefaultRadiusAndThickness = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(53, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(16, 22);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // CreateImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 773);
            this.Controls.Add(this.headingProduct);
            this.Controls.Add(this.bunifuPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateImport";
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Load += new System.EventHandler(this.CreateImport_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).EndInit();
            this.orderCustomer.ResumeLayout(false);
            this.orderCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        public System.Windows.Forms.Label lbStaffID;
        public System.Windows.Forms.Label lbPhoneStaff;
        public System.Windows.Forms.Label lbNameStaff;
        private System.Windows.Forms.Label label16;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private Bunifu.UI.WinForms.BunifuPanel orderCustomer;
        private System.Windows.Forms.Label labSupplier;
        public System.Windows.Forms.Label lbSupplierPhone;
        public System.Windows.Forms.Label lbSuppID;
        public System.Windows.Forms.Label lbSuppilerName;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label headingProduct;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnImportSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddSub;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClear;
		public Bunifu.UI.WinForms.BunifuDataGridView dtgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.Label lbProduct;
	}
}