using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai1_2_3
{
    partial class HieuChinhGia
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
            lblTitle = new Label();
            lblName = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCleanCost = new TextBox();
            txtWhiteningCost = new TextBox();
            txtXRayCost = new TextBox();
            txtFillingCost = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnXmlSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(89, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Cost Setting";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(12, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Cạo vôi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 3;
            label1.Text = "Tẩy trắng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 4;
            label2.Text = "Chụp hình răng";
            // 
            // txtCleanCost
            // 
            txtCleanCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCleanCost.Location = new Point(131, 68);
            txtCleanCost.Name = "txtCleanCost";
            txtCleanCost.Size = new Size(154, 29);
            txtCleanCost.TabIndex = 5;
            // 
            // txtWhiteningCost
            // 
            txtWhiteningCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtWhiteningCost.Location = new Point(131, 124);
            txtWhiteningCost.Name = "txtWhiteningCost";
            txtWhiteningCost.Size = new Size(154, 29);
            txtWhiteningCost.TabIndex = 6;
            // 
            // txtXRayCost
            // 
            txtXRayCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtXRayCost.Location = new Point(131, 177);
            txtXRayCost.Name = "txtXRayCost";
            txtXRayCost.Size = new Size(154, 29);
            txtXRayCost.TabIndex = 7;
            // 
            // txtFillingCost
            // 
            txtFillingCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFillingCost.Location = new Point(131, 231);
            txtFillingCost.Name = "txtFillingCost";
            txtFillingCost.Size = new Size(154, 29);
            txtFillingCost.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 8;
            label3.Text = "Trám răng";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(210, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnXmlSave
            // 
            btnXmlSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXmlSave.ForeColor = Color.Blue;
            btnXmlSave.Location = new Point(12, 282);
            btnXmlSave.Name = "btnXmlSave";
            btnXmlSave.Size = new Size(96, 40);
            btnXmlSave.TabIndex = 11;
            btnXmlSave.Text = "XML Save";
            btnXmlSave.UseVisualStyleBackColor = true;
            btnXmlSave.Click += btnXmlSave_Click;
            // 
            // HieuChinhGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(310, 343);
            Controls.Add(btnXmlSave);
            Controls.Add(btnSave);
            Controls.Add(txtFillingCost);
            Controls.Add(label3);
            Controls.Add(txtXRayCost);
            Controls.Add(txtWhiteningCost);
            Controls.Add(txtCleanCost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "HieuChinhGia";
            Text = "HieuChinhGia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label label1;
        private Label label2;
        private TextBox txtCleanCost;
        private TextBox txtWhiteningCost;
        private TextBox txtXRayCost;
        private TextBox txtFillingCost;
        private Label label3;
        private Button btnSave;
        private Button btnXmlSave;
    }
}