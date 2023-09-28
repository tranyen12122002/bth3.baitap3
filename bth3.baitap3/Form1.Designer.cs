namespace bth3.baitap3
{
    partial class Dinhdang
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
            this.lbnhapten = new System.Windows.Forms.Label();
            this.tbnhapten = new System.Windows.Forms.TextBox();
            this.gbcolor = new System.Windows.Forms.GroupBox();
            this.rbblack = new System.Windows.Forms.RadioButton();
            this.rbblue = new System.Windows.Forms.RadioButton();
            this.rbgreen = new System.Windows.Forms.RadioButton();
            this.rbred = new System.Windows.Forms.RadioButton();
            this.gbfont = new System.Windows.Forms.GroupBox();
            this.cbgach = new System.Windows.Forms.CheckBox();
            this.cbnghieng = new System.Windows.Forms.CheckBox();
            this.cbdam = new System.Windows.Forms.CheckBox();
            this.lbketqua = new System.Windows.Forms.Label();
            this.tbketqua = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.gbcolor.SuspendLayout();
            this.gbfont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnhapten
            // 
            this.lbnhapten.AutoSize = true;
            this.lbnhapten.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnhapten.ForeColor = System.Drawing.Color.Lime;
            this.lbnhapten.Location = new System.Drawing.Point(55, 39);
            this.lbnhapten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbnhapten.Name = "lbnhapten";
            this.lbnhapten.Size = new System.Drawing.Size(96, 26);
            this.lbnhapten.TabIndex = 0;
            this.lbnhapten.Text = "Nhập tên";
            // 
            // tbnhapten
            // 
            this.tbnhapten.Location = new System.Drawing.Point(168, 36);
            this.tbnhapten.Margin = new System.Windows.Forms.Padding(4);
            this.tbnhapten.Name = "tbnhapten";
            this.tbnhapten.Size = new System.Drawing.Size(129, 34);
            this.tbnhapten.TabIndex = 1;
            this.tbnhapten.TextChanged += new System.EventHandler(this.tbnhapten_TextChanged);
            // 
            // gbcolor
            // 
            this.gbcolor.Controls.Add(this.rbblack);
            this.gbcolor.Controls.Add(this.rbblue);
            this.gbcolor.Controls.Add(this.rbgreen);
            this.gbcolor.Controls.Add(this.rbred);
            this.gbcolor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcolor.Location = new System.Drawing.Point(47, 78);
            this.gbcolor.Margin = new System.Windows.Forms.Padding(4);
            this.gbcolor.Name = "gbcolor";
            this.gbcolor.Padding = new System.Windows.Forms.Padding(4);
            this.gbcolor.Size = new System.Drawing.Size(153, 204);
            this.gbcolor.TabIndex = 2;
            this.gbcolor.TabStop = false;
            this.gbcolor.Text = "Color";
            // 
            // rbblack
            // 
            this.rbblack.AutoSize = true;
            this.rbblack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbblack.ForeColor = System.Drawing.Color.Black;
            this.rbblack.Location = new System.Drawing.Point(8, 147);
            this.rbblack.Margin = new System.Windows.Forms.Padding(4);
            this.rbblack.Name = "rbblack";
            this.rbblack.Size = new System.Drawing.Size(89, 29);
            this.rbblack.TabIndex = 4;
            this.rbblack.Text = "Black";
            this.rbblack.UseVisualStyleBackColor = true;
            this.rbblack.CheckedChanged += new System.EventHandler(this.rbblack_CheckedChanged);
            // 
            // rbblue
            // 
            this.rbblue.AutoSize = true;
            this.rbblue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbblue.ForeColor = System.Drawing.Color.Blue;
            this.rbblue.Location = new System.Drawing.Point(8, 109);
            this.rbblue.Margin = new System.Windows.Forms.Padding(4);
            this.rbblue.Name = "rbblue";
            this.rbblue.Size = new System.Drawing.Size(78, 29);
            this.rbblue.TabIndex = 2;
            this.rbblue.Text = "Blue";
            this.rbblue.UseVisualStyleBackColor = true;
            this.rbblue.CheckedChanged += new System.EventHandler(this.rbblue_CheckedChanged);
            // 
            // rbgreen
            // 
            this.rbgreen.AutoSize = true;
            this.rbgreen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbgreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.rbgreen.Location = new System.Drawing.Point(8, 72);
            this.rbgreen.Margin = new System.Windows.Forms.Padding(4);
            this.rbgreen.Name = "rbgreen";
            this.rbgreen.Size = new System.Drawing.Size(96, 29);
            this.rbgreen.TabIndex = 1;
            this.rbgreen.Text = "Green";
            this.rbgreen.UseVisualStyleBackColor = true;
            this.rbgreen.CheckedChanged += new System.EventHandler(this.rbgreen_CheckedChanged);
            // 
            // rbred
            // 
            this.rbred.AutoSize = true;
            this.rbred.Checked = true;
            this.rbred.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbred.ForeColor = System.Drawing.Color.Red;
            this.rbred.Location = new System.Drawing.Point(8, 32);
            this.rbred.Margin = new System.Windows.Forms.Padding(4);
            this.rbred.Name = "rbred";
            this.rbred.Size = new System.Drawing.Size(74, 29);
            this.rbred.TabIndex = 0;
            this.rbred.TabStop = true;
            this.rbred.Text = "Red";
            this.rbred.UseVisualStyleBackColor = true;
            this.rbred.CheckedChanged += new System.EventHandler(this.rbred_CheckedChanged);
            // 
            // gbfont
            // 
            this.gbfont.Controls.Add(this.cbgach);
            this.gbfont.Controls.Add(this.cbnghieng);
            this.gbfont.Controls.Add(this.cbdam);
            this.gbfont.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfont.Location = new System.Drawing.Point(224, 78);
            this.gbfont.Margin = new System.Windows.Forms.Padding(4);
            this.gbfont.Name = "gbfont";
            this.gbfont.Padding = new System.Windows.Forms.Padding(4);
            this.gbfont.Size = new System.Drawing.Size(180, 204);
            this.gbfont.TabIndex = 3;
            this.gbfont.TabStop = false;
            this.gbfont.Text = "Font";
            // 
            // cbgach
            // 
            this.cbgach.AutoSize = true;
            this.cbgach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgach.ForeColor = System.Drawing.Color.Blue;
            this.cbgach.Location = new System.Drawing.Point(8, 122);
            this.cbgach.Margin = new System.Windows.Forms.Padding(4);
            this.cbgach.Name = "cbgach";
            this.cbgach.Size = new System.Drawing.Size(132, 30);
            this.cbgach.TabIndex = 2;
            this.cbgach.Text = "Gạch chân";
            this.cbgach.UseVisualStyleBackColor = true;
            this.cbgach.CheckedChanged += new System.EventHandler(this.cbgach_CheckedChanged);
            // 
            // cbnghieng
            // 
            this.cbnghieng.AutoSize = true;
            this.cbnghieng.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnghieng.ForeColor = System.Drawing.Color.Blue;
            this.cbnghieng.Location = new System.Drawing.Point(8, 84);
            this.cbnghieng.Margin = new System.Windows.Forms.Padding(4);
            this.cbnghieng.Name = "cbnghieng";
            this.cbnghieng.Size = new System.Drawing.Size(169, 30);
            this.cbnghieng.TabIndex = 1;
            this.cbnghieng.Text = "Nghiêng Italic";
            this.cbnghieng.UseVisualStyleBackColor = true;
            this.cbnghieng.CheckedChanged += new System.EventHandler(this.cbnghieng_CheckedChanged);
            // 
            // cbdam
            // 
            this.cbdam.AutoSize = true;
            this.cbdam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdam.ForeColor = System.Drawing.Color.Blue;
            this.cbdam.Location = new System.Drawing.Point(8, 46);
            this.cbdam.Margin = new System.Windows.Forms.Padding(4);
            this.cbdam.Name = "cbdam";
            this.cbdam.Size = new System.Drawing.Size(134, 29);
            this.cbdam.TabIndex = 0;
            this.cbdam.Text = "Đậm Bold";
            this.cbdam.UseVisualStyleBackColor = true;
            this.cbdam.CheckedChanged += new System.EventHandler(this.cbdam_CheckedChanged);
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbketqua.Location = new System.Drawing.Point(67, 309);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(133, 26);
            this.lbketqua.TabIndex = 4;
            this.lbketqua.Text = "Lập trình bởi";
            // 
            // tbketqua
            // 
            this.tbketqua.BackColor = System.Drawing.SystemColors.GrayText;
            this.tbketqua.Location = new System.Drawing.Point(209, 306);
            this.tbketqua.Name = "tbketqua";
            this.tbketqua.Size = new System.Drawing.Size(152, 34);
            this.tbketqua.TabIndex = 5;
            // 
            // btnthoat
            // 
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnthoat.Location = new System.Drawing.Point(320, 352);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 41);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Dinhdang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(417, 405);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.tbketqua);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.gbfont);
            this.Controls.Add(this.gbcolor);
            this.Controls.Add(this.tbnhapten);
            this.Controls.Add(this.lbnhapten);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dinhdang";
            this.Text = "Định dạng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dinhdang_FormClosing);
            this.Load += new System.EventHandler(this.Dinhdang_Load);
            this.gbcolor.ResumeLayout(false);
            this.gbcolor.PerformLayout();
            this.gbfont.ResumeLayout(false);
            this.gbfont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnhapten;
        private System.Windows.Forms.TextBox tbnhapten;
        private System.Windows.Forms.GroupBox gbcolor;
        private System.Windows.Forms.RadioButton rbblack;
        private System.Windows.Forms.RadioButton rbblue;
        private System.Windows.Forms.RadioButton rbgreen;
        private System.Windows.Forms.RadioButton rbred;
        private System.Windows.Forms.GroupBox gbfont;
        private System.Windows.Forms.CheckBox cbgach;
        private System.Windows.Forms.CheckBox cbnghieng;
        private System.Windows.Forms.CheckBox cbdam;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.TextBox tbketqua;
        private System.Windows.Forms.Button btnthoat;
    }
}

