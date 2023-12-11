namespace Bai1_Tuan6
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
            txtName = new TextBox();
            chkClean = new CheckBox();
            chkXRay = new CheckBox();
            chkWhitening = new CheckBox();
            lblCleanCost = new Label();
            lblXRayCost = new Label();
            lblWhiteningCost = new Label();
            lblFilling = new Label();
            numFilling = new NumericUpDown();
            lblFillCost = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnExit = new Button();
            btnCalc = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(264, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(118, 94);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Tên Khách Hàng";
            // 
            // txtName
            // 
            txtName.Location = new Point(340, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 27);
            txtName.TabIndex = 2;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(118, 157);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(82, 24);
            chkClean.TabIndex = 3;
            chkClean.Text = "Cạo Vôi";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Location = new Point(118, 250);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(131, 24);
            chkXRay.TabIndex = 4;
            chkXRay.Text = "Chụp hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(118, 204);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(93, 24);
            chkWhitening.TabIndex = 5;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // lblCleanCost
            // 
            lblCleanCost.AutoSize = true;
            lblCleanCost.Location = new Point(576, 157);
            lblCleanCost.Name = "lblCleanCost";
            lblCleanCost.Size = new Size(68, 20);
            lblCleanCost.TabIndex = 6;
            lblCleanCost.Text = "$100,000";
            // 
            // lblXRayCost
            // 
            lblXRayCost.AutoSize = true;
            lblXRayCost.Location = new Point(576, 250);
            lblXRayCost.Name = "lblXRayCost";
            lblXRayCost.Size = new Size(68, 20);
            lblXRayCost.TabIndex = 7;
            lblXRayCost.Text = "$200,000";
            // 
            // lblWhiteningCost
            // 
            lblWhiteningCost.AutoSize = true;
            lblWhiteningCost.Location = new Point(576, 204);
            lblWhiteningCost.Name = "lblWhiteningCost";
            lblWhiteningCost.Size = new Size(79, 20);
            lblWhiteningCost.TabIndex = 8;
            lblWhiteningCost.Text = "$1,200,000";
            // 
            // lblFilling
            // 
            lblFilling.AutoSize = true;
            lblFilling.Location = new Point(118, 298);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(76, 20);
            lblFilling.TabIndex = 9;
            lblFilling.Text = "Trám răng";
            // 
            // numFilling
            // 
            numFilling.Location = new Point(227, 296);
            numFilling.Name = "numFilling";
            numFilling.Size = new Size(76, 27);
            numFilling.TabIndex = 10;
            // 
            // lblFillCost
            // 
            lblFillCost.AutoSize = true;
            lblFillCost.Location = new Point(576, 305);
            lblFillCost.Name = "lblFillCost";
            lblFillCost.Size = new Size(85, 20);
            lblFillCost.TabIndex = 11;
            lblFillCost.Text = "$80,000/cái";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(293, 356);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(576, 349);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(106, 394);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(607, 394);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 29);
            btnCalc.TabIndex = 15;
            btnCalc.Text = "Tính tiền";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(384, 394);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 468);
            Controls.Add(btnReset);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblFillCost);
            Controls.Add(numFilling);
            Controls.Add(lblFilling);
            Controls.Add(lblWhiteningCost);
            Controls.Add(lblXRayCost);
            Controls.Add(lblCleanCost);
            Controls.Add(chkWhitening);
            Controls.Add(chkXRay);
            Controls.Add(chkClean);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private CheckBox chkClean;
        private CheckBox chkXRay;
        private CheckBox chkWhitening;
        private Label lblCleanCost;
        private Label lblXRayCost;
        private Label lblWhiteningCost;
        private Label lblFilling;
        private NumericUpDown numFilling;
        private Label lblFillCost;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnExit;
        private Button btnCalc;
        private Button btnReset;
    }
}