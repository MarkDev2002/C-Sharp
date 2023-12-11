namespace Bai4_Tuan6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblInputSoNguyen = new Label();
            txtSoNguyen = new TextBox();
            btCapnhat = new Button();
            lstKetqua = new ListBox();
            txtListFunc = new TextBox();
            btTang2 = new Button();
            btChonchandau = new Button();
            btLecuoi = new Button();
            btXoaphantudangchon = new Button();
            btXoaphantudau = new Button();
            btXoaphantucuoi = new Button();
            btKetthuc = new Button();
            btnReset = new Button();
            errSoNguyen = new ErrorProvider(components);
            btnLoad = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)errSoNguyen).BeginInit();
            SuspendLayout();
            // 
            // lblInputSoNguyen
            // 
            lblInputSoNguyen.AutoSize = true;
            lblInputSoNguyen.Location = new Point(44, 39);
            lblInputSoNguyen.Name = "lblInputSoNguyen";
            lblInputSoNguyen.Size = new Size(116, 20);
            lblInputSoNguyen.TabIndex = 0;
            lblInputSoNguyen.Text = "Nhập số nguyên";
            // 
            // txtSoNguyen
            // 
            txtSoNguyen.Location = new Point(201, 36);
            txtSoNguyen.Name = "txtSoNguyen";
            txtSoNguyen.Size = new Size(251, 27);
            txtSoNguyen.TabIndex = 1;
            // 
            // btCapnhat
            // 
            btCapnhat.Location = new Point(489, 35);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(94, 29);
            btCapnhat.TabIndex = 2;
            btCapnhat.Text = "Cập Nhật";
            btCapnhat.UseVisualStyleBackColor = true;
            btCapnhat.Click += btCapnhat_Click;
            // 
            // lstKetqua
            // 
            lstKetqua.FormattingEnabled = true;
            lstKetqua.ItemHeight = 20;
            lstKetqua.Location = new Point(54, 84);
            lstKetqua.Name = "lstKetqua";
            lstKetqua.Size = new Size(223, 404);
            lstKetqua.TabIndex = 3;
            // 
            // txtListFunc
            // 
            txtListFunc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtListFunc.Location = new Point(371, 84);
            txtListFunc.Multiline = true;
            txtListFunc.Name = "txtListFunc";
            txtListFunc.Size = new Size(212, 404);
            txtListFunc.TabIndex = 4;
            txtListFunc.Text = "Chức năng";
            txtListFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // btTang2
            // 
            btTang2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btTang2.Location = new Point(383, 137);
            btTang2.Name = "btTang2";
            btTang2.Size = new Size(188, 29);
            btTang2.TabIndex = 5;
            btTang2.Text = "Tăng mỗi phần tử lên 2";
            btTang2.UseVisualStyleBackColor = true;
            btTang2.Click += btTang2_Click;
            // 
            // btChonchandau
            // 
            btChonchandau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btChonchandau.Location = new Point(383, 193);
            btChonchandau.Name = "btChonchandau";
            btChonchandau.Size = new Size(188, 29);
            btChonchandau.TabIndex = 6;
            btChonchandau.Text = "Chọn số chẵn đầu";
            btChonchandau.UseVisualStyleBackColor = true;
            btChonchandau.Click += btChonchandau_Click;
            // 
            // btLecuoi
            // 
            btLecuoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btLecuoi.Location = new Point(383, 252);
            btLecuoi.Name = "btLecuoi";
            btLecuoi.Size = new Size(188, 29);
            btLecuoi.TabIndex = 7;
            btLecuoi.Text = "Chọn số lẻ cuối";
            btLecuoi.UseVisualStyleBackColor = true;
            btLecuoi.Click += btLecuoi_Click;
            // 
            // btXoaphantudangchon
            // 
            btXoaphantudangchon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btXoaphantudangchon.Location = new Point(383, 311);
            btXoaphantudangchon.Name = "btXoaphantudangchon";
            btXoaphantudangchon.Size = new Size(188, 29);
            btXoaphantudangchon.TabIndex = 8;
            btXoaphantudangchon.Text = "Xoá phần tử đang chọn";
            btXoaphantudangchon.UseVisualStyleBackColor = true;
            btXoaphantudangchon.Click += btXoaphantudangchon_Click;
            // 
            // btXoaphantudau
            // 
            btXoaphantudau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btXoaphantudau.Location = new Point(383, 371);
            btXoaphantudau.Name = "btXoaphantudau";
            btXoaphantudau.Size = new Size(188, 29);
            btXoaphantudau.TabIndex = 9;
            btXoaphantudau.Text = "Xoá phần tử đầu";
            btXoaphantudau.UseVisualStyleBackColor = true;
            btXoaphantudau.Click += btXoaphantudau_Click;
            // 
            // btXoaphantucuoi
            // 
            btXoaphantucuoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btXoaphantucuoi.Location = new Point(383, 431);
            btXoaphantucuoi.Name = "btXoaphantucuoi";
            btXoaphantucuoi.Size = new Size(188, 29);
            btXoaphantucuoi.TabIndex = 10;
            btXoaphantucuoi.Text = "Xoá phần tử cuối";
            btXoaphantucuoi.UseVisualStyleBackColor = true;
            btXoaphantucuoi.Click += btXoaphantucuoi_Click;
            // 
            // btKetthuc
            // 
            btKetthuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btKetthuc.Location = new Point(54, 550);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(529, 29);
            btKetthuc.TabIndex = 11;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = true;
            btKetthuc.Click += btKetthuc_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(54, 505);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(529, 29);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // errSoNguyen
            // 
            errSoNguyen.ContainerControl = this;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(54, 649);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(529, 29);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(54, 604);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(529, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 705);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnReset);
            Controls.Add(btKetthuc);
            Controls.Add(btXoaphantucuoi);
            Controls.Add(btXoaphantudau);
            Controls.Add(btXoaphantudangchon);
            Controls.Add(btLecuoi);
            Controls.Add(btChonchandau);
            Controls.Add(btTang2);
            Controls.Add(txtListFunc);
            Controls.Add(lstKetqua);
            Controls.Add(btCapnhat);
            Controls.Add(txtSoNguyen);
            Controls.Add(lblInputSoNguyen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errSoNguyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputSoNguyen;
        private TextBox txtSoNguyen;
        private Button btCapnhat;
        private ListBox lstKetqua;
        private TextBox txtListFunc;
        private Button btTang2;
        private Button btChonchandau;
        private Button btLecuoi;
        private Button btXoaphantudangchon;
        private Button btXoaphantudau;
        private Button btXoaphantucuoi;
        private Button btKetthuc;
        private Button btnReset;
        private ErrorProvider errSoNguyen;
        private Button btnSave;
        private Button btnLoad;
    }
}