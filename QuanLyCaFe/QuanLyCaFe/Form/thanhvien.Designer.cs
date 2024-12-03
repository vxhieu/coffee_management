
namespace QuanLyCaFe
{
    partial class thanhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thanhvien));
            this.btnXoatv = new System.Windows.Forms.Button();
            this.btnThoatDanhMuc = new System.Windows.Forms.Button();
            this.btnLuuTV = new System.Windows.Forms.Button();
            this.txttentv = new System.Windows.Forms.TextBox();
            this.labeldouong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textngaysinh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnXoatv
            // 
            this.btnXoatv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoatv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoatv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoatv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoatv.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoatv.Image = ((System.Drawing.Image)(resources.GetObject("btnXoatv.Image")));
            this.btnXoatv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoatv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoatv.Location = new System.Drawing.Point(402, 208);
            this.btnXoatv.Name = "btnXoatv";
            this.btnXoatv.Size = new System.Drawing.Size(81, 36);
            this.btnXoatv.TabIndex = 25;
            this.btnXoatv.Text = "Xóa";
            this.btnXoatv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoatv.UseVisualStyleBackColor = false;
            // 
            // btnThoatDanhMuc
            // 
            this.btnThoatDanhMuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatDanhMuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoatDanhMuc.Location = new System.Drawing.Point(324, 164);
            this.btnThoatDanhMuc.Name = "btnThoatDanhMuc";
            this.btnThoatDanhMuc.Size = new System.Drawing.Size(110, 23);
            this.btnThoatDanhMuc.TabIndex = 24;
            this.btnThoatDanhMuc.Text = "Thoát";
            this.btnThoatDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnLuuTV
            // 
            this.btnLuuTV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuuTV.Location = new System.Drawing.Point(132, 164);
            this.btnLuuTV.Name = "btnLuuTV";
            this.btnLuuTV.Size = new System.Drawing.Size(110, 23);
            this.btnLuuTV.TabIndex = 23;
            this.btnLuuTV.Text = "Lưu";
            this.btnLuuTV.UseVisualStyleBackColor = true;
            this.btnLuuTV.Click += new System.EventHandler(this.btnLuuTV_Click);
            // 
            // txttentv
            // 
            this.txttentv.Location = new System.Drawing.Point(142, 33);
            this.txttentv.Name = "txttentv";
            this.txttentv.Size = new System.Drawing.Size(341, 22);
            this.txttentv.TabIndex = 22;
            // 
            // labeldouong
            // 
            this.labeldouong.AutoSize = true;
            this.labeldouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labeldouong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldouong.Location = new System.Drawing.Point(25, 33);
            this.labeldouong.Name = "labeldouong";
            this.labeldouong.Size = new System.Drawing.Size(103, 18);
            this.labeldouong.TabIndex = 21;
            this.labeldouong.Text = "Tên thành viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số điện thoại";
            // 
            // textsdt
            // 
            this.textsdt.Location = new System.Drawing.Point(142, 69);
            this.textsdt.Name = "textsdt";
            this.textsdt.Size = new System.Drawing.Size(341, 22);
            this.textsdt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày sinh";
            // 
            // textngaysinh
            // 
            this.textngaysinh.Location = new System.Drawing.Point(142, 106);
            this.textngaysinh.Name = "textngaysinh";
            this.textngaysinh.Size = new System.Drawing.Size(341, 22);
            this.textngaysinh.TabIndex = 29;
            // 
            // thanhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 256);
            this.Controls.Add(this.textngaysinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textsdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoatv);
            this.Controls.Add(this.btnThoatDanhMuc);
            this.Controls.Add(this.btnLuuTV);
            this.Controls.Add(this.txttentv);
            this.Controls.Add(this.labeldouong);
            this.Name = "thanhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thành Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoatv;
        private System.Windows.Forms.Button btnThoatDanhMuc;
        private System.Windows.Forms.Button btnLuuTV;
        private System.Windows.Forms.TextBox txttentv;
        private System.Windows.Forms.Label labeldouong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textngaysinh;
    }
}