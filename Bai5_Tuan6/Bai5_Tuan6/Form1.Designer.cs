namespace Bai5_Tuan6
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
            lblInputHovaTen = new Label();
            txtInput = new TextBox();
            btCapnhat = new Button();
            btKetthuc = new Button();
            lstBox1 = new ListBox();
            labelTitle = new Label();
            lstBox2 = new ListBox();
            btnReset = new Button();
            btnRight = new Button();
            btnAllRight = new Button();
            btnAllLeft = new Button();
            btnLeft = new Button();
            lblA = new Label();
            lblB = new Label();
            SuspendLayout();
            // 
            // lblInputHovaTen
            // 
            lblInputHovaTen.AutoSize = true;
            lblInputHovaTen.Location = new Point(65, 104);
            lblInputHovaTen.Name = "lblInputHovaTen";
            lblInputHovaTen.Size = new Size(75, 20);
            lblInputHovaTen.TabIndex = 0;
            lblInputHovaTen.Text = "Họ và Tên";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(211, 101);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(251, 27);
            txtInput.TabIndex = 1;
            // 
            // btCapnhat
            // 
            btCapnhat.Location = new Point(489, 99);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(94, 29);
            btCapnhat.TabIndex = 2;
            btCapnhat.Text = "Cập Nhật";
            btCapnhat.UseVisualStyleBackColor = true;
            btCapnhat.Click += btCapnhat_Click;
            // 
            // btKetthuc
            // 
            btKetthuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btKetthuc.Location = new Point(525, 426);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(89, 29);
            btKetthuc.TabIndex = 11;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = true;
            btKetthuc.Click += btKetthuc_Click;
            // 
            // lstBox1
            // 
            lstBox1.FormattingEnabled = true;
            lstBox1.ItemHeight = 20;
            lstBox1.Location = new Point(12, 166);
            lstBox1.Name = "lstBox1";
            lstBox1.Size = new Size(223, 224);
            lstBox1.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = SystemColors.Highlight;
            labelTitle.Location = new Point(211, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(235, 31);
            labelTitle.TabIndex = 12;
            labelTitle.Text = "Danh Sách Sinh Viên";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstBox2
            // 
            lstBox2.FormattingEnabled = true;
            lstBox2.ItemHeight = 20;
            lstBox2.Location = new Point(445, 166);
            lstBox2.Name = "lstBox2";
            lstBox2.Size = new Size(223, 224);
            lstBox2.TabIndex = 4;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(65, 426);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 29);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(264, 221);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(67, 29);
            btnRight.TabIndex = 15;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnAllRight
            // 
            btnAllRight.Location = new Point(264, 269);
            btnAllRight.Name = "btnAllRight";
            btnAllRight.Size = new Size(67, 29);
            btnAllRight.TabIndex = 16;
            btnAllRight.Text = ">>";
            btnAllRight.UseVisualStyleBackColor = true;
            btnAllRight.Click += btnAllRight_Click;
            // 
            // btnAllLeft
            // 
            btnAllLeft.Location = new Point(353, 269);
            btnAllLeft.Name = "btnAllLeft";
            btnAllLeft.Size = new Size(67, 29);
            btnAllLeft.TabIndex = 17;
            btnAllLeft.Text = "<<";
            btnAllLeft.UseVisualStyleBackColor = true;
            btnAllLeft.Click += btnAllLeft_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(353, 221);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(67, 29);
            btnLeft.TabIndex = 18;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(185, 166);
            lblA.Name = "lblA";
            lblA.Size = new Size(48, 20);
            lblA.TabIndex = 19;
            lblA.Text = "Lớp A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(618, 166);
            lblB.Name = "lblB";
            lblB.Size = new Size(47, 20);
            lblB.TabIndex = 20;
            lblB.Text = "Lớp B";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 541);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnLeft);
            Controls.Add(btnAllLeft);
            Controls.Add(btnAllRight);
            Controls.Add(btnRight);
            Controls.Add(btnReset);
            Controls.Add(lstBox2);
            Controls.Add(labelTitle);
            Controls.Add(btKetthuc);
            Controls.Add(lstBox1);
            Controls.Add(btCapnhat);
            Controls.Add(txtInput);
            Controls.Add(lblInputHovaTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputHovaTen;
        private TextBox txtInput;
        private Button btCapnhat;
        private Button btKetthuc;
        private ListBox lstBox1;
        private Label labelTitle;
        private Button btnReset;
        private ListBox lstBox2;
        private Button btnLeft;
        private Button btnAllLeft;
        private Button btnAllRight;
        private Button btnRight;
        private Label lblB;
        private Label lblA;
    }
}
