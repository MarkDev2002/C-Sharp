namespace GUI
{
    partial class SubFuncGUI
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
			this.components = new System.ComponentModel.Container();
			this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnOK = new Guna.UI2.WinForms.Guna2Button();
			this.animateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = false;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(49, 135);
			this.lblName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(63, 21);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "Name";
			this.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblID
			// 
			this.lblID.AutoSize = false;
			this.lblID.BackColor = System.Drawing.Color.Transparent;
			this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(49, 69);
			this.lblID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(42, 21);
			this.lblID.TabIndex = 10;
			this.lblID.Text = "ID";
			this.lblID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCancel
			// 
			this.btnCancel.BorderRadius = 10;
			this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
			this.btnCancel.Location = new System.Drawing.Point(155, 203);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 41);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtName
			// 
			this.txtName.BorderRadius = 10;
			this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtName.DefaultText = "";
			this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtName.Location = new System.Drawing.Point(49, 160);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = '\0';
			this.txtName.PlaceholderText = "";
			this.txtName.SelectedText = "";
			this.txtName.Size = new System.Drawing.Size(195, 24);
			this.txtName.TabIndex = 8;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtID
			// 
			this.txtID.BorderRadius = 10;
			this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtID.DefaultText = "";
			this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtID.Location = new System.Drawing.Point(49, 95);
			this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtID.Name = "txtID";
			this.txtID.PasswordChar = '\0';
			this.txtID.PlaceholderText = "";
			this.txtID.ReadOnly = true;
			this.txtID.SelectedText = "";
			this.txtID.Size = new System.Drawing.Size(195, 24);
			this.txtID.TabIndex = 7;
			this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnOK
			// 
			this.btnOK.BorderRadius = 10;
			this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.ImageSize = new System.Drawing.Size(30, 30);
			this.btnOK.Location = new System.Drawing.Point(49, 203);
			this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(87, 41);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// animateWindow
			// 
			this.animateWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
			this.animateWindow.TargetForm = this;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.AutoSize = false;
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 20);
			this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(268, 36);
			this.guna2HtmlLabel1.TabIndex = 12;
			this.guna2HtmlLabel1.Text = "Function Editor";
			this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SubFuncGUI
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(296, 280);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "SubFuncGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormSubFunc";
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        internal Guna.UI2.WinForms.Guna2TextBox txtName;
        internal Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateWindow;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
	}
}