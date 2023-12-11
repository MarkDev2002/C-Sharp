namespace GUI
{
    partial class LoginGUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
			this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.panelLogin = new Guna.UI2.WinForms.Guna2Panel();
			this.btnShow = new Guna.UI2.WinForms.Guna2Button();
			this.chbRemember = new Guna.UI2.WinForms.Guna2CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.messInformation = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.messError = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.messQuestion = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.messWarning = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.animateForm = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.panelLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2DragControl4
			// 
			this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl4.UseTransparentDrag = true;
			// 
			// guna2DragControl2
			// 
			this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl2.TargetControl = this.panelLogin;
			this.guna2DragControl2.UseTransparentDrag = true;
			// 
			// panelLogin
			// 
			this.panelLogin.Controls.Add(this.btnShow);
			this.panelLogin.Controls.Add(this.chbRemember);
			this.panelLogin.Controls.Add(this.label7);
			this.panelLogin.Controls.Add(this.label6);
			this.panelLogin.Controls.Add(this.btnLogin);
			this.panelLogin.Controls.Add(this.txtPassword);
			this.panelLogin.Controls.Add(this.txtUser);
			this.panelLogin.Controls.Add(this.label4);
			this.panelLogin.Location = new System.Drawing.Point(329, 122);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.ShadowDecoration.Depth = 6;
			this.panelLogin.ShadowDecoration.Enabled = true;
			this.panelLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(6);
			this.panelLogin.Size = new System.Drawing.Size(451, 488);
			this.panelLogin.TabIndex = 20;
			this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
			// 
			// btnShow
			// 
			this.btnShow.BackColor = System.Drawing.Color.Transparent;
			this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
			this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnShow.BorderRadius = 5;
			this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnShow.FillColor = System.Drawing.Color.Transparent;
			this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnShow.ForeColor = System.Drawing.Color.White;
			this.btnShow.ImageSize = new System.Drawing.Size(10, 10);
			this.btnShow.Location = new System.Drawing.Point(371, 242);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(33, 25);
			this.btnShow.TabIndex = 8;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			this.btnShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseDown);
			this.btnShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseUp);
			// 
			// chbRemember
			// 
			this.chbRemember.AutoSize = true;
			this.chbRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.chbRemember.CheckedState.BorderRadius = 0;
			this.chbRemember.CheckedState.BorderThickness = 0;
			this.chbRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.chbRemember.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbRemember.ForeColor = System.Drawing.Color.DimGray;
			this.chbRemember.Location = new System.Drawing.Point(55, 321);
			this.chbRemember.Name = "chbRemember";
			this.chbRemember.Size = new System.Drawing.Size(137, 19);
			this.chbRemember.TabIndex = 2;
			this.chbRemember.Text = "Remember Password";
			this.chbRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.chbRemember.UncheckedState.BorderRadius = 0;
			this.chbRemember.UncheckedState.BorderThickness = 0;
			this.chbRemember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(22, 204);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Password";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(22, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Username";
			// 
			// btnLogin
			// 
			this.btnLogin.BorderRadius = 20;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.FillColor = System.Drawing.Color.Gray;
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(210, 371);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(180, 45);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.BorderColor = System.Drawing.Color.Black;
			this.txtPassword.BorderRadius = 20;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Lime;
			this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Location = new System.Drawing.Point(55, 234);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PlaceholderText = "";
			this.txtPassword.SelectedText = "";
			this.txtPassword.Size = new System.Drawing.Size(360, 41);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// txtUser
			// 
			this.txtUser.BorderColor = System.Drawing.Color.Black;
			this.txtUser.BorderRadius = 20;
			this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUser.DefaultText = "";
			this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUser.FocusedState.BorderColor = System.Drawing.Color.Lime;
			this.txtUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.txtUser.ForeColor = System.Drawing.Color.DimGray;
			this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUser.Location = new System.Drawing.Point(55, 134);
			this.txtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtUser.Name = "txtUser";
			this.txtUser.PasswordChar = '\0';
			this.txtUser.PlaceholderText = "";
			this.txtUser.SelectedText = "";
			this.txtUser.Size = new System.Drawing.Size(360, 41);
			this.txtUser.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(95, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(266, 32);
			this.label4.TabIndex = 0;
			this.label4.Text = "Login your account";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// guna2CircleButton3
			// 
			this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2CircleButton3.FillColor = System.Drawing.Color.Lime;
			this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
			this.guna2CircleButton3.Location = new System.Drawing.Point(1046, 8);
			this.guna2CircleButton3.Name = "guna2CircleButton3";
			this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton3.Size = new System.Drawing.Size(20, 19);
			this.guna2CircleButton3.TabIndex = 24;
			this.guna2CircleButton3.Click += new System.EventHandler(this.guna2CircleButton3_Click);
			// 
			// guna2CircleButton2
			// 
			this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2CircleButton2.FillColor = System.Drawing.Color.Yellow;
			this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
			this.guna2CircleButton2.Location = new System.Drawing.Point(1072, 8);
			this.guna2CircleButton2.Name = "guna2CircleButton2";
			this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton2.Size = new System.Drawing.Size(20, 19);
			this.guna2CircleButton2.TabIndex = 23;
			this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
			// 
			// guna2CircleButton1
			// 
			this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
			this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
			this.guna2CircleButton1.Location = new System.Drawing.Point(1098, 8);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.Size = new System.Drawing.Size(20, 19);
			this.guna2CircleButton1.TabIndex = 22;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// guna2DragControl3
			// 
			this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl3.UseTransparentDrag = true;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 30;
			this.guna2Elipse1.TargetControl = this;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			// 
			// messInformation
			// 
			this.messInformation.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messInformation.Caption = "";
			this.messInformation.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
			this.messInformation.Parent = this;
			this.messInformation.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messInformation.Text = null;
			// 
			// messError
			// 
			this.messError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messError.Caption = "";
			this.messError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
			this.messError.Parent = this;
			this.messError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messError.Text = null;
			// 
			// messQuestion
			// 
			this.messQuestion.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
			this.messQuestion.Caption = "";
			this.messQuestion.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
			this.messQuestion.Parent = this;
			this.messQuestion.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messQuestion.Text = null;
			// 
			// messWarning
			// 
			this.messWarning.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messWarning.Caption = "";
			this.messWarning.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
			this.messWarning.Parent = this;
			this.messWarning.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.messWarning.Text = null;
			// 
			// animateForm
			// 
			this.animateForm.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
			this.animateForm.Interval = 200;
			this.animateForm.TargetForm = this;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(76, -73);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(300, 300);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.pictureBox2);
			this.guna2Panel1.FillColor = System.Drawing.Color.DarkGray;
			this.guna2Panel1.Location = new System.Drawing.Point(329, 22);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(451, 132);
			this.guna2Panel1.TabIndex = 25;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.FillColor = System.Drawing.Color.White;
			this.guna2Panel2.Location = new System.Drawing.Point(-34, 665);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(1209, 52);
			this.guna2Panel2.TabIndex = 26;
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.Controls.Add(this.guna2CircleButton1);
			this.guna2Panel3.Controls.Add(this.guna2CircleButton3);
			this.guna2Panel3.Controls.Add(this.guna2CircleButton2);
			this.guna2Panel3.FillColor = System.Drawing.Color.White;
			this.guna2Panel3.Location = new System.Drawing.Point(-24, -3);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new System.Drawing.Size(1163, 33);
			this.guna2Panel3.TabIndex = 27;
			// 
			// LoginGUI
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1116, 689);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.panelLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Panel panelLogin;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2CheckBox chbRemember;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2MessageDialog messInformation;
        public Guna.UI2.WinForms.Guna2MessageDialog messError;
        public Guna.UI2.WinForms.Guna2MessageDialog messQuestion;
        public Guna.UI2.WinForms.Guna2MessageDialog messWarning;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateForm;
        public Guna.UI2.WinForms.Guna2TextBox txtUser;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
	}
}