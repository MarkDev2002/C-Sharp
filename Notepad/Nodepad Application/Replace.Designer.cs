namespace Nodepad_Application
{
    partial class Replace
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Findwhat = new System.Windows.Forms.TextBox();
            this.txt_Replacewith = new System.Windows.Forms.TextBox();
            this.btn_Findnext = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_Replaceall = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.chk_Matchcase = new System.Windows.Forms.CheckBox();
            this.chk_Wraparound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace with:";
            // 
            // txt_Findwhat
            // 
            this.txt_Findwhat.Location = new System.Drawing.Point(90, 11);
            this.txt_Findwhat.Name = "txt_Findwhat";
            this.txt_Findwhat.Size = new System.Drawing.Size(211, 20);
            this.txt_Findwhat.TabIndex = 2;
            this.txt_Findwhat.TextChanged += new System.EventHandler(this.txt_Findwhat_TextChanged);
            // 
            // txt_Replacewith
            // 
            this.txt_Replacewith.Location = new System.Drawing.Point(90, 41);
            this.txt_Replacewith.Name = "txt_Replacewith";
            this.txt_Replacewith.Size = new System.Drawing.Size(211, 20);
            this.txt_Replacewith.TabIndex = 3;
            // 
            // btn_Findnext
            // 
            this.btn_Findnext.Enabled = false;
            this.btn_Findnext.Location = new System.Drawing.Point(313, 9);
            this.btn_Findnext.Name = "btn_Findnext";
            this.btn_Findnext.Size = new System.Drawing.Size(75, 23);
            this.btn_Findnext.TabIndex = 4;
            this.btn_Findnext.Text = "Find Next";
            this.btn_Findnext.UseVisualStyleBackColor = true;
            this.btn_Findnext.Click += new System.EventHandler(this.btn_Findnext_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Enabled = false;
            this.btn_Replace.Location = new System.Drawing.Point(313, 39);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(75, 23);
            this.btn_Replace.TabIndex = 5;
            this.btn_Replace.Text = "Replace";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_Replaceall
            // 
            this.btn_Replaceall.Enabled = false;
            this.btn_Replaceall.Location = new System.Drawing.Point(313, 68);
            this.btn_Replaceall.Name = "btn_Replaceall";
            this.btn_Replaceall.Size = new System.Drawing.Size(75, 23);
            this.btn_Replaceall.TabIndex = 6;
            this.btn_Replaceall.Text = "Replace All";
            this.btn_Replaceall.UseVisualStyleBackColor = true;
            this.btn_Replaceall.Click += new System.EventHandler(this.btn_Replaceall_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(313, 97);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // chk_Matchcase
            // 
            this.chk_Matchcase.AutoSize = true;
            this.chk_Matchcase.Checked = true;
            this.chk_Matchcase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Matchcase.Location = new System.Drawing.Point(12, 109);
            this.chk_Matchcase.Name = "chk_Matchcase";
            this.chk_Matchcase.Size = new System.Drawing.Size(82, 17);
            this.chk_Matchcase.TabIndex = 8;
            this.chk_Matchcase.Text = "Match case";
            this.chk_Matchcase.UseVisualStyleBackColor = true;
            this.chk_Matchcase.CheckedChanged += new System.EventHandler(this.chk_Matchcase_CheckedChanged);
            // 
            // chk_Wraparound
            // 
            this.chk_Wraparound.AutoSize = true;
            this.chk_Wraparound.Location = new System.Drawing.Point(12, 138);
            this.chk_Wraparound.Name = "chk_Wraparound";
            this.chk_Wraparound.Size = new System.Drawing.Size(88, 17);
            this.chk_Wraparound.TabIndex = 9;
            this.chk_Wraparound.Text = "Wrap around";
            this.chk_Wraparound.UseVisualStyleBackColor = true;
            this.chk_Wraparound.CheckedChanged += new System.EventHandler(this.chk_Wraparound_CheckedChanged);
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 162);
            this.Controls.Add(this.chk_Wraparound);
            this.Controls.Add(this.chk_Matchcase);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Replaceall);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.btn_Findnext);
            this.Controls.Add(this.txt_Replacewith);
            this.Controls.Add(this.txt_Findwhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Replace";
            this.ShowIcon = false;
            this.Text = "Replace";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Findwhat;
        private System.Windows.Forms.TextBox txt_Replacewith;
        private System.Windows.Forms.Button btn_Findnext;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_Replaceall;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox chk_Matchcase;
        private System.Windows.Forms.CheckBox chk_Wraparound;
    }
}