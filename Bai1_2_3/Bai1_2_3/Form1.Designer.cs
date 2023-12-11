using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai1_2_3
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
            lblTitle = new Label();
            lblName = new Label();
            lblCleanCost = new Label();
            lblWhiteningCost = new Label();
            lblXRayCost = new Label();
            chkClean = new CheckBox();
            chkWhitening = new CheckBox();
            chkXRay = new CheckBox();
            txtName = new TextBox();
            lblFilling = new Label();
            numFilling = new NumericUpDown();
            lblFillingCost = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnExit = new Button();
            btnCalc = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            btnSetting = new Button();
            btnXmlSave = new Button();
            btnXmlLoad = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(63, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(33, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(124, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Tên khách hàng: ";
            // 
            // lblCleanCost
            // 
            lblCleanCost.AutoSize = true;
            lblCleanCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCleanCost.Location = new Point(244, 96);
            lblCleanCost.Name = "lblCleanCost";
            lblCleanCost.Size = new Size(73, 21);
            lblCleanCost.TabIndex = 4;
            lblCleanCost.Text = "$100000";
            // 
            // lblWhiteningCost
            // 
            lblWhiteningCost.AutoSize = true;
            lblWhiteningCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWhiteningCost.Location = new Point(238, 134);
            lblWhiteningCost.Name = "lblWhiteningCost";
            lblWhiteningCost.Size = new Size(82, 21);
            lblWhiteningCost.TabIndex = 6;
            lblWhiteningCost.Text = "$1200000";
            // 
            // lblXRayCost
            // 
            lblXRayCost.AutoSize = true;
            lblXRayCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblXRayCost.Location = new Point(244, 172);
            lblXRayCost.Name = "lblXRayCost";
            lblXRayCost.Size = new Size(73, 21);
            lblXRayCost.TabIndex = 8;
            lblXRayCost.Text = "$200000";
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkClean.Location = new Point(33, 95);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(81, 25);
            chkClean.TabIndex = 3;
            chkClean.Text = "Cạo vôi";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkWhitening.Location = new Point(33, 133);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(94, 25);
            chkWhitening.TabIndex = 5;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkXRay.Location = new Point(33, 171);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(137, 25);
            chkXRay.TabIndex = 7;
            chkXRay.Text = "Chụp hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(163, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 29);
            txtName.TabIndex = 2;
            // 
            // lblFilling
            // 
            lblFilling.AutoSize = true;
            lblFilling.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilling.Location = new Point(33, 218);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(84, 21);
            lblFilling.TabIndex = 9;
            lblFilling.Text = "Trám răng:";
            // 
            // numFilling
            // 
            numFilling.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numFilling.Location = new Point(123, 210);
            numFilling.Name = "numFilling";
            numFilling.Size = new Size(73, 29);
            numFilling.TabIndex = 10;
            numFilling.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFillingCost
            // 
            lblFillingCost.AutoSize = true;
            lblFillingCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFillingCost.Location = new Point(230, 218);
            lblFillingCost.Name = "lblFillingCost";
            lblFillingCost.Size = new Size(89, 21);
            lblFillingCost.TabIndex = 11;
            lblFillingCost.Text = "$80000/cái";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(151, 269);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 21);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.Blue;
            txtTotal.Location = new Point(199, 261);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(118, 29);
            txtTotal.TabIndex = 13;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(33, 308);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 33);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalc.Location = new Point(218, 308);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(86, 33);
            btnCalc.TabIndex = 15;
            btnCalc.Text = "Tính tiền";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Navy;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(462, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(266, 244);
            listBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(474, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 17;
            label1.Text = "Thông Tin";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(349, 59);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 33);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.Location = new Point(349, 98);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 33);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSetting
            // 
            btnSetting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.Location = new Point(334, 308);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(121, 33);
            btnSetting.TabIndex = 20;
            btnSetting.Text = "Cost Setting";
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnXmlSave
            // 
            btnXmlSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXmlSave.Location = new Point(349, 196);
            btnXmlSave.Name = "btnXmlSave";
            btnXmlSave.Size = new Size(86, 33);
            btnXmlSave.TabIndex = 21;
            btnXmlSave.Text = "Xml Save";
            btnXmlSave.UseVisualStyleBackColor = true;
            btnXmlSave.Click += btnXmlSave_Click;
            // 
            // btnXmlLoad
            // 
            btnXmlLoad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXmlLoad.Location = new Point(349, 235);
            btnXmlLoad.Name = "btnXmlLoad";
            btnXmlLoad.Size = new Size(86, 33);
            btnXmlLoad.TabIndex = 22;
            btnXmlLoad.Text = "Xml Load";
            btnXmlLoad.UseVisualStyleBackColor = true;
            btnXmlLoad.Click += btnXmlLoad_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(642, 308);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 33);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(743, 349);
            Controls.Add(btnClear);
            Controls.Add(btnXmlLoad);
            Controls.Add(btnXmlSave);
            Controls.Add(btnSetting);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblFillingCost);
            Controls.Add(numFilling);
            Controls.Add(lblFilling);
            Controls.Add(txtName);
            Controls.Add(chkXRay);
            Controls.Add(chkWhitening);
            Controls.Add(chkClean);
            Controls.Add(lblXRayCost);
            Controls.Add(lblWhiteningCost);
            Controls.Add(lblCleanCost);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Bai1_2_Load;
            ((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblCleanCost;
        private Label lblWhiteningCost;
        private Label lblXRayCost;
        private CheckBox chkClean;
        private CheckBox chkWhitening;
        private CheckBox chkXRay;
        private TextBox txtName;
        private Label lblFilling;
        private NumericUpDown numFilling;
        private Label lblFillingCost;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnExit;
        private Button btnCalc;
        private ListBox listBox1;
        private Label label1;
        private Button btnSave;
        private Button btnLoad;
        private Button btnSetting;
        private Button btnXmlSave;
        private Button btnXmlLoad;
        private Button btnClear;
    }
}