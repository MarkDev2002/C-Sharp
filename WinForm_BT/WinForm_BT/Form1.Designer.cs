namespace WinForm_BT
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
            label1 = new Label();
            label2 = new Label();
            txtDong = new TextBox();
            txtCot = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Số dòng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 11);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Số cột: ";
            // 
            // txtDong
            // 
            txtDong.Location = new Point(57, 8);
            txtDong.Name = "txtDong";
            txtDong.Size = new Size(100, 23);
            txtDong.TabIndex = 2;
            txtDong.TextChanged += txtDong_TextChanged;
            // 
            // txtCot
            // 
            txtCot.Location = new Point(214, 8);
            txtCot.Name = "txtCot";
            txtCot.Size = new Size(100, 23);
            txtCot.TabIndex = 3;
            txtCot.TextChanged += textBox2_TextChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(125, 52);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Tạo Form";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 87);
            Controls.Add(btnCreate);
            Controls.Add(txtCot);
            Controls.Add(txtDong);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDong;
        private TextBox txtCot;
        private Button btnCreate;
    }
}