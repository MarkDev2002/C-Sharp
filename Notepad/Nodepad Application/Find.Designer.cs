namespace Nodepad_Application
{
    partial class Find
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findNext_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.down_rd = new System.Windows.Forms.RadioButton();
            this.up_rd = new System.Windows.Forms.RadioButton();
            this.matchCase_chk = new System.Windows.Forms.CheckBox();
            this.wrapAround_chk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // findNext_btn
            // 
            this.findNext_btn.Enabled = false;
            this.findNext_btn.Location = new System.Drawing.Point(300, 9);
            this.findNext_btn.Name = "findNext_btn";
            this.findNext_btn.Size = new System.Drawing.Size(75, 23);
            this.findNext_btn.TabIndex = 5;
            this.findNext_btn.Text = "Find Next";
            this.findNext_btn.UseVisualStyleBackColor = true;
            this.findNext_btn.Click += new System.EventHandler(this.findNext_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(300, 38);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.down_rd);
            this.groupBox1.Controls.Add(this.up_rd);
            this.groupBox1.Location = new System.Drawing.Point(175, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // down_rd
            // 
            this.down_rd.AutoSize = true;
            this.down_rd.Checked = true;
            this.down_rd.Location = new System.Drawing.Point(60, 19);
            this.down_rd.Name = "down_rd";
            this.down_rd.Size = new System.Drawing.Size(53, 17);
            this.down_rd.TabIndex = 1;
            this.down_rd.TabStop = true;
            this.down_rd.Text = "Down";
            this.down_rd.UseVisualStyleBackColor = true;
            this.down_rd.CheckedChanged += new System.EventHandler(this.down_rd_CheckedChanged);
            // 
            // up_rd
            // 
            this.up_rd.AutoSize = true;
            this.up_rd.Location = new System.Drawing.Point(6, 19);
            this.up_rd.Name = "up_rd";
            this.up_rd.Size = new System.Drawing.Size(39, 17);
            this.up_rd.TabIndex = 0;
            this.up_rd.Text = "Up";
            this.up_rd.UseVisualStyleBackColor = true;
            this.up_rd.CheckedChanged += new System.EventHandler(this.up_rd_CheckedChanged);
            // 
            // matchCase_chk
            // 
            this.matchCase_chk.AutoSize = true;
            this.matchCase_chk.Checked = true;
            this.matchCase_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.matchCase_chk.Location = new System.Drawing.Point(10, 67);
            this.matchCase_chk.Name = "matchCase_chk";
            this.matchCase_chk.Size = new System.Drawing.Size(82, 17);
            this.matchCase_chk.TabIndex = 2;
            this.matchCase_chk.Text = "Match case";
            this.matchCase_chk.UseVisualStyleBackColor = true;
            this.matchCase_chk.CheckedChanged += new System.EventHandler(this.matchCase_chk_CheckedChanged);
            // 
            // wrapAround_chk
            // 
            this.wrapAround_chk.AutoSize = true;
            this.wrapAround_chk.Location = new System.Drawing.Point(10, 89);
            this.wrapAround_chk.Name = "wrapAround_chk";
            this.wrapAround_chk.Size = new System.Drawing.Size(88, 17);
            this.wrapAround_chk.TabIndex = 3;
            this.wrapAround_chk.Text = "Wrap around";
            this.wrapAround_chk.UseVisualStyleBackColor = true;
            this.wrapAround_chk.CheckedChanged += new System.EventHandler(this.wrapAround_chk_CheckedChanged);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 118);
            this.Controls.Add(this.wrapAround_chk);
            this.Controls.Add(this.matchCase_chk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.findNext_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Find";
            this.ShowIcon = false;
            this.Text = "Find";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Find_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button findNext_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton down_rd;
        private System.Windows.Forms.RadioButton up_rd;
        private System.Windows.Forms.CheckBox matchCase_chk;
        private System.Windows.Forms.CheckBox wrapAround_chk;
    }
}