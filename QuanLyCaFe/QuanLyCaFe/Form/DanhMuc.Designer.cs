
namespace QuanLyCaFe
{
    partial class DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnThoatDanhMuc = new System.Windows.Forms.Button();
            this.btnLuuDanhMuc = new System.Windows.Forms.Button();
            this.txtDanhMucDoUong = new System.Windows.Forms.TextBox();
            this.labeldouong = new System.Windows.Forms.Label();
            this.labelDM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnXoaDM);
            this.panel1.Controls.Add(this.btnThoatDanhMuc);
            this.panel1.Controls.Add(this.btnLuuDanhMuc);
            this.panel1.Controls.Add(this.txtDanhMucDoUong);
            this.panel1.Controls.Add(this.labeldouong);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btnXoaDM, "btnXoaDM");
            this.btnXoaDM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDM.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.UseVisualStyleBackColor = false;
            // 
            // btnThoatDanhMuc
            // 
            this.btnThoatDanhMuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnThoatDanhMuc, "btnThoatDanhMuc");
            this.btnThoatDanhMuc.Name = "btnThoatDanhMuc";
            this.btnThoatDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnLuuDanhMuc
            // 
            resources.ApplyResources(this.btnLuuDanhMuc, "btnLuuDanhMuc");
            this.btnLuuDanhMuc.Name = "btnLuuDanhMuc";
            this.btnLuuDanhMuc.UseVisualStyleBackColor = true;
            this.btnLuuDanhMuc.Click += new System.EventHandler(this.btnLuuDanhMuc_Click);
            // 
            // txtDanhMucDoUong
            // 
            resources.ApplyResources(this.txtDanhMucDoUong, "txtDanhMucDoUong");
            this.txtDanhMucDoUong.Name = "txtDanhMucDoUong";
            // 
            // labeldouong
            // 
            resources.ApplyResources(this.labeldouong, "labeldouong");
            this.labeldouong.Name = "labeldouong";
            // 
            // labelDM
            // 
            resources.ApplyResources(this.labelDM, "labelDM");
            this.labelDM.Name = "labelDM";
            // 
            // DanhMuc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelDM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoatDanhMuc;
        private System.Windows.Forms.Button btnLuuDanhMuc;
        private System.Windows.Forms.TextBox txtDanhMucDoUong;
        private System.Windows.Forms.Label labeldouong;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Label labelDM;
    }
}