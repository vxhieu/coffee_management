
namespace QuanLyCaFe
{
    partial class QuanLys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLys));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admin = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ghichu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.btn_chuyenban = new System.Windows.Forms.Button();
            this.GiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.DanhMuc = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.TienThua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_note = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gopban = new System.Windows.Forms.Button();
            this.cbgop = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.txttienthua = new System.Windows.Forms.TextBox();
            this.txtkhach = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.thongtinhoadon = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.thongtinhoadon1 = new System.Windows.Forms.Label();
            this.TruBill = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textnote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin});
            this.menuStrip1.Location = new System.Drawing.Point(12, 43);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(75, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admin
            // 
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(67, 24);
            this.admin.Text = "Admin";
            this.admin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ma,
            this.NameDrink,
            this.Count,
            this.Price,
            this.TotalPrice,
            this.ghichu});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(438, 88);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 273);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Ma
            // 
            this.Ma.Text = "Mã";
            this.Ma.Width = 0;
            // 
            // NameDrink
            // 
            this.NameDrink.Text = "Tên món";
            this.NameDrink.Width = 189;
            // 
            // Count
            // 
            this.Count.Text = "Số lượng";
            this.Count.Width = 113;
            // 
            // Price
            // 
            this.Price.Text = "Đơn giá";
            this.Price.Width = 115;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Thành tiền";
            this.TotalPrice.Width = 296;
            // 
            // ghichu
            // 
            this.ghichu.Text = "Ghi chú";
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(438, 414);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(125, 24);
            this.cbBan.TabIndex = 14;
            // 
            // btn_chuyenban
            // 
            this.btn_chuyenban.Image = ((System.Drawing.Image)(resources.GetObject("btn_chuyenban.Image")));
            this.btn_chuyenban.Location = new System.Drawing.Point(438, 367);
            this.btn_chuyenban.Name = "btn_chuyenban";
            this.btn_chuyenban.Size = new System.Drawing.Size(125, 42);
            this.btn_chuyenban.TabIndex = 15;
            this.btn_chuyenban.Text = "Chuyển bàn";
            this.btn_chuyenban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_chuyenban.UseVisualStyleBackColor = true;
            this.btn_chuyenban.Click += new System.EventHandler(this.btn_chuyenban_Click);
            // 
            // GiamGia
            // 
            this.GiamGia.Location = new System.Drawing.Point(637, 416);
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Size = new System.Drawing.Size(125, 22);
            this.GiamGia.TabIndex = 3;
            this.GiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiamGia.Image = ((System.Drawing.Image)(resources.GetObject("btnGiamGia.Image")));
            this.btnGiamGia.Location = new System.Drawing.Point(637, 366);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(125, 43);
            this.btnGiamGia.TabIndex = 3;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiamGia.UseVisualStyleBackColor = true;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // DanhMuc
            // 
            this.DanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhMuc.ForeColor = System.Drawing.Color.Black;
            this.DanhMuc.FormattingEnabled = true;
            this.DanhMuc.Location = new System.Drawing.Point(1053, 75);
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Size = new System.Drawing.Size(185, 26);
            this.DanhMuc.TabIndex = 0;
            this.DanhMuc.SelectedIndexChanged += new System.EventHandler(this.DanhMuc_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1446, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 31);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 286);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.TienThua);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.btn_note);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1051, 107);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(417, 393);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // TienThua
            // 
            this.TienThua.Location = new System.Drawing.Point(3, 3);
            this.TienThua.Name = "TienThua";
            this.TienThua.Size = new System.Drawing.Size(75, 23);
            this.TienThua.TabIndex = 20;
            this.TienThua.Text = "button1";
            this.TienThua.UseVisualStyleBackColor = true;
            this.TienThua.Click += new System.EventHandler(this.TienThua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "label5";
            // 
            // btn_note
            // 
            this.btn_note.Location = new System.Drawing.Point(188, 3);
            this.btn_note.Name = "btn_note";
            this.btn_note.Size = new System.Drawing.Size(75, 23);
            this.btn_note.TabIndex = 44;
            this.btn_note.Text = "note";
            this.btn_note.UseVisualStyleBackColor = true;
            this.btn_note.Click += new System.EventHandler(this.btn_note_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1270, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh mục đồ uống";
            // 
            // btn_gopban
            // 
            this.btn_gopban.Image = ((System.Drawing.Image)(resources.GetObject("btn_gopban.Image")));
            this.btn_gopban.Location = new System.Drawing.Point(438, 456);
            this.btn_gopban.Name = "btn_gopban";
            this.btn_gopban.Size = new System.Drawing.Size(125, 42);
            this.btn_gopban.TabIndex = 16;
            this.btn_gopban.Text = "Gộp bàn";
            this.btn_gopban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gopban.UseVisualStyleBackColor = true;
            this.btn_gopban.Click += new System.EventHandler(this.btn_gopban_Click);
            // 
            // cbgop
            // 
            this.cbgop.FormattingEnabled = true;
            this.cbgop.Location = new System.Drawing.Point(438, 504);
            this.cbgop.Name = "cbgop";
            this.cbgop.Size = new System.Drawing.Size(125, 24);
            this.cbgop.TabIndex = 16;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(839, 368);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(39, 31);
            this.btn_xoa.TabIndex = 36;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(805, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tiền thừa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(805, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Khách đưa :";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtongtien.Location = new System.Drawing.Point(805, 418);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(88, 18);
            this.lbtongtien.TabIndex = 33;
            this.lbtongtien.Text = "Tổng tiền : ";
            // 
            // txttienthua
            // 
            this.txttienthua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttienthua.Enabled = false;
            this.txttienthua.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttienthua.ForeColor = System.Drawing.Color.OrangeRed;
            this.txttienthua.Location = new System.Drawing.Point(905, 480);
            this.txttienthua.Name = "txttienthua";
            this.txttienthua.ReadOnly = true;
            this.txttienthua.Size = new System.Drawing.Size(137, 28);
            this.txttienthua.TabIndex = 32;
            this.txttienthua.Text = "0";
            this.txttienthua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtkhach
            // 
            this.txtkhach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkhach.Location = new System.Drawing.Point(905, 447);
            this.txtkhach.Name = "txtkhach";
            this.txtkhach.Size = new System.Drawing.Size(137, 27);
            this.txtkhach.TabIndex = 31;
            this.txtkhach.Text = "0";
            this.txtkhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttotal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.OrangeRed;
            this.txttotal.Location = new System.Drawing.Point(905, 413);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(137, 28);
            this.txttotal.TabIndex = 30;
            this.txttotal.Text = "0";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(905, 368);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(137, 41);
            this.btnThanhToan.TabIndex = 29;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // thongtinhoadon
            // 
            this.thongtinhoadon.AutoSize = true;
            this.thongtinhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinhoadon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thongtinhoadon.Location = new System.Drawing.Point(621, 51);
            this.thongtinhoadon.Name = "thongtinhoadon";
            this.thongtinhoadon.Size = new System.Drawing.Size(171, 20);
            this.thongtinhoadon.TabIndex = 37;
            this.thongtinhoadon.Text = "Thông tin hóa đơn :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // thongtinhoadon1
            // 
            this.thongtinhoadon1.AutoSize = true;
            this.thongtinhoadon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinhoadon1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thongtinhoadon1.Location = new System.Drawing.Point(734, 65);
            this.thongtinhoadon1.Name = "thongtinhoadon1";
            this.thongtinhoadon1.Size = new System.Drawing.Size(0, 20);
            this.thongtinhoadon1.TabIndex = 39;
            // 
            // TruBill
            // 
            this.TruBill.AutoSize = true;
            this.TruBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TruBill.Location = new System.Drawing.Point(637, 451);
            this.TruBill.Name = "TruBill";
            this.TruBill.Size = new System.Drawing.Size(125, 43);
            this.TruBill.TabIndex = 40;
            this.TruBill.Text = "Trừ";
            this.TruBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TruBill.UseVisualStyleBackColor = true;
            this.TruBill.Click += new System.EventHandler(this.TruBill_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(637, 505);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 22);
            this.numericUpDown1.TabIndex = 41;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textnote
            // 
            this.textnote.Location = new System.Drawing.Point(12, 402);
            this.textnote.Multiline = true;
            this.textnote.Name = "textnote";
            this.textnote.Size = new System.Drawing.Size(393, 67);
            this.textnote.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Note:";
            // 
            // QuanLys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1497, 535);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textnote);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TruBill);
            this.Controls.Add(this.thongtinhoadon1);
            this.Controls.Add(this.thongtinhoadon);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtongtien);
            this.Controls.Add(this.txttienthua);
            this.Controls.Add(this.txtkhach);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cbgop);
            this.Controls.Add(this.btn_gopban);
            this.Controls.Add(this.btnGiamGia);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GiamGia);
            this.Controls.Add(this.cbBan);
            this.Controls.Add(this.btn_chuyenban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanhMuc);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.Load += new System.EventHandler(this.QuanLys_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admin;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox DanhMuc;
        private System.Windows.Forms.NumericUpDown GiamGia;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.ColumnHeader NameDrink;
        public System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Button btn_chuyenban;
        private System.Windows.Forms.Button btn_gopban;
        private System.Windows.Forms.ComboBox cbgop;
        private System.Windows.Forms.Button TienThua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.TextBox txttienthua;
        private System.Windows.Forms.TextBox txtkhach;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label thongtinhoadon;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label thongtinhoadon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TruBill;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ColumnHeader Ma;
        private System.Windows.Forms.ColumnHeader ghichu;
        private System.Windows.Forms.TextBox textnote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_note;
    }
}