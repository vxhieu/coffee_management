using QuanLyCaFe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe
{

    public partial class QuanLys : Form
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        public QuanLys(int loaitaikhoan, string ten)
        {
            InitializeComponent();
            if (loaitaikhoan == 1)
            {
                admin.Enabled = true;
            }
            else admin.Enabled = false;
            label4.Text = ten;
            tableload();
            loadCatelogy();
            loadcomboTble(cbBan);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin(null);
            ad.ShowDialog();
        }

        private void QuanLys_Load(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            this.AcceptButton =btn_note;
            listView1.Columns[1].Width = 150;
            listView1.Columns[2].Width = 70;
            listView1.Columns[3].Width = 90;
            listView1.Columns[4].Width = 90;
            //listView1.Columns[0].Width = 25;
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan tt = new ThongTinCaNhan();
            tt.ShowDialog();
        }
        //Thanh toán
        public void checkout(int id, int discount, decimal tongtien)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.Bill SET trangthai = 1,ngayra = GETDATE()," + "discount = " + discount + ",tongtien = " + tongtien + "  where id = " + id);
        }
        //Load Catelogy
        void loadCatelogy()
        {
            List<Catelogy> listcategory = getlistcatelogys();
            DanhMuc.DataSource = listcategory;
            DanhMuc.DisplayMember = "ten";
        }
        //Load các nút menu
        void loadFoodincatelogy(int id)
        {
            List<Drink> listdrink = getlistdrink(id);
            //Mon.DataSource = listdrink;
            //Mon.DisplayMember = "tenmon";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *FROM dbo.Food");
            flowLayoutPanel2.Controls.Clear();
            foreach (Drink item in listdrink)
            {
                Button btn = new Button();
                btn.Width = 70;
                btn.Height = 70;
                btn.Text = item.Tenmon + Environment.NewLine;
                btn.Click += btn_ClickMenu;
                btn.Tag = item;
                flowLayoutPanel2.Controls.Add(btn);
                btn.BackColor = Color.LightGoldenrodYellow;
                btn.Cursor = Cursors.Hand;
            }
        }
        #region Events
        //Thêm món
        void btn_ClickMenu(object sender, EventArgs e)
        {
            //int idmon = ((sender as Button).Tag as Drink).ID;
            //listView1.Tag = (sender as Button).Tag;
            //showbill(tableid);
            Table table = listView1.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn");
            }
            else
            {

                int idbill = getbilltable(table.ID);
                //int iddrink = (Mon.SelectedItem as Drink).ID;
                int iddrink = ((sender as Button).Tag as Drink).ID;
                //int count = (int)SoLuong.Value;
                if (idbill == -1)
                {
                    InsertBill(table.ID);
                    InsertBillinfo(GetMaxid(), iddrink, 1);
                }
                else
                {
                    InsertBillinfo(idbill, iddrink, 1);
                }
                showbill(table.ID);
                tableload();
            }
        }
        //Xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            int idbill = getbilltable(table.ID);
            DataProvider.Instance.ExecuteQuery("DELETE ThongTinBill where idBill=" + idbill);
            DataProvider.Instance.ExecuteQuery("DELETE Bill where id=" + idbill);
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Bill SET trangthai = 1 where idBan=" + table.ID);
            showbill(table.ID);
            btn_xoa.Enabled = false;
        }
        #endregion
        private void DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Catelogy selected = cb.SelectedItem as Catelogy;
            id = selected.ID;
            flowLayoutPanel2.Controls.Clear();
            loadFoodincatelogy(id);
        }



        //Load nút các bàn
        public List<Table> LoadTable()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *FROM dbo.TableFood");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        #region
        void tableload()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> list = LoadTable();
            foreach (Table item in list)
            {
                Button btn = new Button();
                btn.Width = 70;
                btn.Height = 70;
                btn.Text = item.Tenban + Environment.NewLine + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;
                btn.Cursor = Cursors.Hand;
                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.LightBlue;
                        break;
                    default:
                        btn.BackColor = Color.DarkOrange;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
                txtkhach.Text = "0"; txttienthua.Text = "0";
            }

        }
        //Chuyển bàn
        public void ChuyenBan(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public void loadcomboTble(ComboBox cb)
        {
            cbBan.DataSource = LoadTable();
            cbBan.DisplayMember = "tenban";
            cbgop.DataSource = LoadTable();
            cbgop.DisplayMember = "tenban";
        }

        private void btn_chuyenban_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            int id1 = (listView1.Tag as Table).ID;
            int id2 = (cbBan.SelectedItem as Table).ID;
            ChuyenBan(id1, id2);
            showbill(table.ID);
            MessageBox.Show("Chuyển bàn " + table.Tenban + " sang bàn " + (cbBan.SelectedItem as Table).Tenban + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Gộp bàn
        public void GopBan(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_Gopban @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        private void btn_gopban_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            int id1 = (listView1.Tag as Table).ID;
            int id2 = (cbgop.SelectedItem as Table).ID;
            GopBan(id1, id2);
            showbill(table.ID);
        }
        #endregion
        //Load thông tin bill của bàn
        public int getbilltable(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idBan =" + id + " AND trangthai = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int idban)
        {

            DataProvider.Instance.ExecuteQuery("USP_InsertBill @idTable", new object[] { idban });
        }
        public int GetMaxid()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public List<Billinfo> getlistbillinfo(int id)
        {
            List<Billinfo> listbillinfo = new List<Billinfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinBill WHERE idBill = " + id);
            foreach (DataRow item in data.Rows)
            {
                Billinfo info = new Billinfo(item);
                listbillinfo.Add(info);
            }
            return listbillinfo;
        }
        public void InsertBillinfo(int idbill, int idmon, int count)
        {
            DataProvider.Instance.ExecuteQuery("USP_InsertBillInfo @idBill , @idMon , @count", new object[] { idbill, idmon, count });
        }
        public List<Menu> getlistmenu(int id)
        {
            List<Menu> listmenu = new List<Menu>();
            string query = "SELECT bi.id as Ma, f.tenmon, bi.count, f.dongia, f.dongia*bi.count AS totalprice,bi.ghichu as GhiChu FROM dbo.ThongTinBill AS bi,dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idMon = f.id AND b.trangthai = 0 AND b.idBan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }
        //Danh mục
        public List<Catelogy> getlistcatelogys()
        {
            List<Catelogy> list = new List<Catelogy>();
            string query = "SELECT * FROM dbo.FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Catelogy catelogy = new Catelogy(item);
                list.Add(catelogy);
            }
            return list;
        }
        public List<Drink> getlistdrink(int id)
        {
            List<Drink> list = new List<Drink>();
            string query = "SELECT * FROM dbo.Food WHERE idCategory =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink catelogy = new Drink(item);
                list.Add(catelogy);
            }
            return list;
        }
        #region
        //check thông tin billl
        void showbill(int id)
        {
            listView1.Items.Clear();
            List<Menu> listbill = getlistmenu(id);
            decimal tongien = 0;
            foreach (Menu item in listbill)
            {
                ListViewItem lv = new ListViewItem(item.Ma.ToString());
                lv.SubItems.Add(item.Tenmon.ToString());
                lv.SubItems.Add(item.Count.ToString());
                lv.SubItems.Add(item.Dongia.ToString());
                lv.SubItems.Add(item.Totalprice.ToString("0,00"));
                lv.SubItems.Add(item.GhiChu.ToString());
                tongien += item.Totalprice;
                listView1.Items.Add(lv);
            }
            int giamgia = (int)GiamGia.Value;
            int tru = (int)numericUpDown1.Value;
            tongien = tongien - (tongien / 100 * giamgia) - tru;
            txttotal.Text = tongien.ToString("0,00");
            tableload();
        }

        #endregion
        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int tableid = ((sender as Button).Tag as Table).ID;
            listView1.Tag = (sender as Button).Tag;
            thongtinhoadon1.Text = ((sender as Button).Tag as Table).Tenban;
            showbill(tableid);
            btn_xoa.Enabled = true;
        }
        //Thêm món
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            //Table table = listView1.Tag as Table;
            //int idbill = getbilltable(table.ID);
            //int iddrink = (Mon.SelectedItem as Drink).ID;
            //int count = (int)SoLuong.Value;
            //if(idbill == -1)
            //{
            //    InsertBill(table.ID);
            //    InsertBillinfo(GetMaxid(), iddrink, count);
            //}
            //else
            //{
            //    InsertBillinfo(idbill, iddrink, count);
            //}
            //showbill(table.ID);
            //tableload();
        }

        #endregion

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            int idBill = getbilltable(table.ID);
            if (idBill == 0)
            {

            }
            else
            {
                int discount = (int)GiamGia.Value;
                if (idBill != -1)
                {
                    List<Menu> listbill = getlistmenu(table.ID);
                    if (listbill.Count == 0)
                    {
                        MessageBox.Show("Không thể thanh toán bàn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc thanh toán bàn " + table.Tenban + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            int hoadon = GetMaxid() + 1;
                            label5.Text = hoadon.ToString();

                            PaperSize pageSize = new PaperSize();
                            pageSize.Width = 302;
                            printPreviewDialog1.Document = printDocument1;
                            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pz", 302, 600);
                            // printDocument1.DefaultPageSettings.PaperSize = pageSize;
                            printPreviewDialog1.ShowDialog();
                            //printDocument1.Print();
                            decimal tongien = 0;
                            foreach (Menu item in listbill)
                            {
                                ListViewItem lv = new ListViewItem(item.Tenmon.ToString());
                                lv.SubItems.Add(item.Count.ToString());
                                lv.SubItems.Add(item.Dongia.ToString());
                                lv.SubItems.Add(item.Totalprice.ToString("0,00"));
                                tongien += item.Totalprice;
                                listView1.Items.Add(lv);
                            }
                            DataProvider.Instance.ExecuteQuery("UPDATE ThongTinBill set dathanhtoan = 1 where idBill=" + idBill);
                            int giamgia = (int)GiamGia.Value;
                            int tru = (int)numericUpDown1.Value;
                            tongien = tongien - tongien / 100 * giamgia - tru;
                            txttotal.Text = tongien.ToString("0,00");
                            checkout(idBill, discount, tongien);
                            showbill(table.ID);
                            GiamGia.Value = 0;
                            numericUpDown1.Value = 0;
                            tableload();
                            txtkhach.Text = "0";
                            txttienthua.Text = "0";
                            txttotal.Text = "0";
                            hoadon++;
                        }
                    }
                }
            }
            btn_xoa.Enabled = false;
        }
        //giảm giá
        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            showbill(table.ID);
        }

        private void TienThua_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            decimal tienkhach = int.Parse(txtkhach.Text);
            decimal tienthua = int.Parse(txttienthua.Text);
            decimal tongtien = 0;
            List<Menu> listbill = getlistmenu(table.ID);
            foreach (Menu item in listbill)
            {

                ListViewItem lv = new ListViewItem(item.Tenmon.ToString());
                lv.SubItems.Add(item.Count.ToString());
                lv.SubItems.Add(item.Dongia.ToString());
                lv.SubItems.Add(item.Totalprice.ToString("0,00"));
                tongtien += item.Totalprice;
            }
            int giamgia = (int)GiamGia.Value;
            tongtien = tongtien - tongtien / 100 * giamgia;
            tienthua = (tienkhach - tongtien);
            txttienthua.Text = tienthua.ToString("0,00");
            txtkhach.Text = tienkhach.ToString("0,00");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

           /// Image image1 = Resources.cf;
            //e.Graphics.DrawImage(image1, 90, 0, 120, 90);

           // Image image = Resources.brand;
            //e.Graphics.DrawImage(image, 50, 0, 200, 25);

            //Image image2 = Resources.loca;
            //e.Graphics.DrawImage(image2, 40, 30, 10, 10);
           // e.Graphics.DrawString("111/11, P11, Q.Gò Vấp", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(50, 30));

            //Bàn
            e.Graphics.DrawString("Bàn: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString(thongtinhoadon1.Text.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(70, 60));


            //Thời gian
            e.Graphics.DrawString("Ngày giờ: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 75));
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(70, 75));
            e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(140, 75));


            ////Hóa đơn
            e.Graphics.DrawString("Hóa đơn: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString("#" + label5.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(70, 90));

            //Thu ngân
            e.Graphics.DrawString("Thu ngân: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 105));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(70, 105));

            //e.Graphics.DrawString("__________________________________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 275));
            //e.Graphics.DrawString("Tên món", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(10, 290));
            //e.Graphics.DrawString("SL", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(100, 290));
            //e.Graphics.DrawString("Đơn giá", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(130, 290));
            //e.Graphics.DrawString("Thành tiền", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(190, 290));
            e.Graphics.DrawString("____________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 120));

            int offset = 135;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1.Items[i].SubItems[1].Text + " (" + listView1.Items[i].SubItems[5].Text + ")", new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset);
                //e.Graphics.DrawString(listView1.Items[i].SubItems[1].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset+30);
                //e.Graphics.DrawString(listView1.Items[i].SubItems[2].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 155, offset);
                e.Graphics.DrawString(listView1.Items[i].SubItems[4].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 230, offset);
                offset = offset + 32;
            }
            int offset1 = 150;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1.Items[i].SubItems[2].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset1);
                e.Graphics.DrawString("x", new Font("Arial", 8), new SolidBrush(Color.Black), 20, offset1);
                e.Graphics.DrawString(listView1.Items[i].SubItems[3].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 30, offset1);
                //e.Graphics.DrawString(listView1.Items[i].SubItems[1].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 10, offset+30);
                //e.Graphics.DrawString(listView1.Items[i].SubItems[2].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 155, offset);
                //e.Graphics.DrawString(listView1.Items[i].SubItems[3].Text, new Font("Arial", 8), new SolidBrush(Color.Black), 220, offset);
                offset1 = offset1 + 32;
            }
            e.Graphics.DrawString("____________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, offset - 5));
            decimal tongtien = 0;
            Table table = listView1.Tag as Table;
            List<Menu> listbill = getlistmenu(table.ID);
            foreach (Menu item in listbill)
            {

                ListViewItem lv = new ListViewItem(item.Ma.ToString());
                lv.SubItems.Add(item.Tenmon.ToString());
                lv.SubItems.Add(item.Count.ToString());
                lv.SubItems.Add(item.Dongia.ToString());
                lv.SubItems.Add(item.Totalprice.ToString("0,00"));
                tongtien += item.Totalprice;
            }
            e.Graphics.DrawString("Giảm giá:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(10, offset + 13));
            e.Graphics.DrawString(GiamGia.Value.ToString() + "%", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(250, offset + 13));
            //e.Graphics.DrawString("- "+(tongtien * GiamGia.Value / 100).ToString("0,00"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(245, offset + 13));

            e.Graphics.DrawString("____________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, offset + 20));

            e.Graphics.DrawString("TỔNG CỘNG:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, offset + 35));
            e.Graphics.DrawString(txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(220, offset + 35));

            //e.Graphics.DrawString("Tổng cộng:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(140, offset+15));
            //e.Graphics.DrawString(tongtien.ToString("0,00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(220, offset+15));

            //e.Graphics.DrawString("Chiết khấu:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(140, offset+30));
            //e.Graphics.DrawString(GiamGia.Value.ToString()+"%", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(220, offset+30));



            //e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, offset+60));

            //e.Graphics.DrawString("THANH TOÁN:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(30, offset + 75));
            //e.Graphics.DrawString(txttotal.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(220, offset + 75));

            //e.Graphics.DrawString("KHÁCH TRẢ TỔNG CỘNG (VNĐ):", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(30, offset + 90));
            //e.Graphics.DrawString(txtkhach.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(220, offset + 90));

            //e.Graphics.DrawString("TIỀN TRẢ LẠI (VNĐ):", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(30, offset + 105));
            //e.Graphics.DrawString(txttienthua.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(220, offset + 105));

            //Image image3 = Resources.money;
            //e.Graphics.DrawImage(image3, 10, offset + 65, 15, 15);
            //e.Graphics.DrawString("∙ ACB:", new Font("Arial", 7), Brushes.Black, new Point(30, offset + 60));
            //e.Graphics.DrawString("1111 (1111)", new Font("Arial", 7), Brushes.Black, new Point(75, offset + 60));

            //e.Graphics.DrawString("∙ Momo:", new Font("Arial", 7), Brushes.Black, new Point(30, offset + 75));
            //e.Graphics.DrawString("1111 (111)", new Font("Arial", 7), Brushes.Black, new Point(75, offset + 75));
            ////e.Graphics.DrawString("1111 (1111)", new Font("Arial", 7), Brushes.Black, new Point(75, offset + 90));

            e.Graphics.DrawString("Chân thành cảm ơn quý khách!!!", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(55, offset + 110));
            e.Graphics.DrawString("WIFI: COFFEE", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(90, offset + 125));
            e.Graphics.DrawString("Password: 1111", new Font("Arial", 8), Brushes.Black, new Point(90, offset + 140));
        }
        private void PrintPreview_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = printDocument1;
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pz", 302,600);
            //PaperSize pageSize = new PaperSize();
            //pageSize.Width = 302;
            //printDocument1.DefaultPageSettings.PaperSize = pageSize;
            //printPreviewDialog1.ShowDialog();
        }

        private void TruBill_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            showbill(table.ID);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Table table = listView1.Tag as Table;
            int idbill = getbilltable(table.ID);
            var billinfo = getlistbillinfo(idbill);

            foreach (int i in listView1.SelectedIndices)
            {
                string test = listView1.Items[i].Text;
                listView1.Items.Remove(listView1.Items[i]);
                DataProvider.Instance.ExecuteQuery("DELETE ThongTinBill where id=" + test);
                if (billinfo.Count <= 1)
                {
                    DataProvider.Instance.ExecuteQuery("DELETE Bill where id=" + idbill);
                    DataProvider.Instance.ExecuteQuery("UPDATE dbo.Bill SET trangthai = 1 where idBan=" + table.ID);
                    btn_xoa.Enabled = false;
                }


            }


            showbill(table.ID);
        }

        private void btn_note_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            int idbill = getbilltable(table.ID);
            var billinfo = getlistbillinfo(idbill);

            foreach (int i in listView1.SelectedIndices)
            {
                string test = listView1.Items[i].Text;
                listView1.Items.Remove(listView1.Items[i]);
                DataProvider.Instance.ExecuteQuery("UPDATE ThongTinBill SET ghichu=N'" + textnote.Text.ToString() + "' where id=" + test);
            }
            textnote.Text = "";
            showbill(table.ID);
    }
}
}
