using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using app = Microsoft.Office.Interop.Excel.Application;
namespace QuanLyCaFe
{
    public partial class Admin : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string idsp;
        public Admin(string idsp)
        {
            this.idsp = idsp;
            InitializeComponent();
            loadDM();
            loadDMdoUong();
            loadDMbanan();
            LoadTable();
            loaddate();
            monmuanhieunhat();
        }
        //Danh mục đồ uống
        public void loadDM()
        {
            var rs = from h in db.FoodCategories.ToList()
                     join d in db.Foods on h.id equals d.idCategory
                     select new
                     {
                         d.id,
                         h.ten,
                         d.tenmon,
                         d.dongia,
                     };
            dataDouong.DataSource = rs.ToList();
            dataDouong.Columns["id"].HeaderText = "Mã";
            dataDouong.Columns["ten"].HeaderText = "Loại đồ uống";
            dataDouong.Columns["tenmon"].HeaderText = "Tên đồ uống";
            dataDouong.Columns["dongia"].HeaderText = "Đơn giá";
            //Căn chỉnh cột
            dataDouong.Columns["ten"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataDouong.Columns["tenmon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataDouong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //format giá bán
            dataDouong.Columns["dongia"].DefaultCellStyle.Format = "N0";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var tenmon = from h in db.FoodCategories.ToList()
                         join d in db.Foods on h.id equals d.idCategory
                         where d.tenmon.Contains(txtTim.Text.Trim().ToLower())
                         select new
                     {
                         d.id,
                         h.ten,
                         d.tenmon,
                         d.dongia,
                     };
            dataDouong.DataSource = tenmon.ToList();
        }
        //btn thêm
        private void ThemBtn_Click(object sender, EventArgs e)
        {
            new AddProduct(null).ShowDialog();
            loadDM();
        }  
        public void dataDouong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDouong.Rows[e.RowIndex].Index >= 0)
            {
                new AddProduct(dataDouong.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
                this.Dispose();
            }
        }


        //hàm xóa
        public void xoasp()
        { 
            if (MessageBox.Show("Bạn có muốn xóa món này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(idsp))
                {
                    Food mh = new Food();
                    mh = db.Foods.FirstOrDefault(x => x.id == int.Parse(idsp));
                    db.Foods.DeleteOnSubmit(mh);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                }
            }
        }


        //Danh mục bàn ăn
        public void loadDMbanan()
        {
            var rs = from h in db.TableFoods.ToList()
                     select new
                     {
                         h.id,
                         h.tenban,
                     };
            dmBanAn.DataSource = rs.ToList();
            dmBanAn.Columns["id"].HeaderText = "Mã bàn";
            dmBanAn.Columns["tenban"].HeaderText = "Tên bàn";

            //Căn chỉnh cột
            dmBanAn.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dmBanAn.Columns["tenban"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btntimban_Click(object sender, EventArgs e)
        {
            var query = from h in db.TableFoods.ToList()
                        where h.tenban.Contains(txttimban.Text.Trim().ToLower().ToUpper())
                        select new
                        {
                           h.id,
                           h.tenban,
                        };
             dmBanAn.DataSource = query.ToList();
        }

        private void btnthemban_Click(object sender, EventArgs e)
        {
            new AddTable(null).ShowDialog();
            loadDMbanan();
        }

        private void dmBanAn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dmBanAn.Rows[e.RowIndex].Index >= 0)
            {
                new AddTable(dmBanAn.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
                this.Dispose();
            }
        }

        //Danh muc đồ uống
        public void loadDMdoUong()
        {
            var rs1 = from h in db.FoodCategories.ToList()
                     select new
                     {
                         h.id,
                         h.ten,
                     };
            datadmdouong.DataSource = rs1.ToList();
            datadmdouong.Columns["id"].HeaderText = "Mã ";

            datadmdouong.Columns["ten"].HeaderText = "Tên";


            //Căn chỉnh cột
            datadmdouong.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datadmdouong.Columns["ten"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new DanhMuc(null).ShowDialog();
            loadDMdoUong();
        }
        //cập nhật danh mục
        private void CapNhatDM(object sender, DataGridViewCellEventArgs e)
        {
            if (datadmdouong.Rows[e.RowIndex].Index >= 0)
            {
                new DanhMuc(datadmdouong.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
                this.Dispose();
            }
        }

        private void bnt_SearchDM_Click(object sender, EventArgs e)
        {

            var query = from a in db.FoodCategories.ToList()
                        where a.ten.Contains(timdanhmuc.Text.Trim().ToLower())
                        select new
                        {
                            a.id,
                            a.ten,
                        };
            datadmdouong.DataSource = query.ToList();
        }
        void LoadTable()
        {
            //string cn = @"Data Source=.;Initial Catalog=QLCF;Integrated Security=True";
            //SqlConnection connect = new SqlConnection(cn);
            //string query = "SELECT *FROM dbo.TableFood";
            //connect.Open();
            //SqlCommand command = new SqlCommand(query, connect);
            System.Data.DataTable data = new System.Data.DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            data = DataProvider.Instance.ExecuteQuery("SELECT *FROM dbo.TableFood");
            //adapter.Fill(data);
            //connect.Close();
            //dmBanAn.DataSource = data;

        }
        void loaddate()
        {
            DateTime today = DateTime.Now;
            ngayvao.Value = new DateTime(today.Year, today.Month, 1);
            ngayra.Value = ngayvao.Value.AddMonths(2).AddDays(-1);

            ngayvao1.Value = new DateTime(today.Year, today.Month, 1);
            ngayra1.Value = ngayvao1.Value.AddMonths(2).AddDays(-1);

        }
        public System.Data.DataTable getBillListByDate(DateTime ngayvao, DateTime ngayra)
        {
            return DataProvider.Instance.ExecuteQuery("USP_BillListByDate @ngayvao , @ngayra", new object[] { ngayvao, ngayra });
        }
        public System.Data.DataTable getDetailListbyDate(DateTime ngayvao, DateTime ngayra)
        {
            return DataProvider.Instance.ExecuteQuery("USP_ChiTietDoanhThu @ngayvao , @ngayra", new object[] { ngayvao, ngayra });
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(ngayvao1.Value > ngayra1.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc, thử lại","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }    
            else
            {
                dataBill.DataSource = getBillListByDate(ngayvao.Value, ngayra.Value);
                dataBill.Columns["tenban"].Width = 60;
                dataBill.Columns["tenban"].HeaderText = "Bàn";

                dataBill.Columns["ngayvao"].Width = 200;
                dataBill.Columns["ngayvao"].HeaderText = "Thời gian vào";

                dataBill.Columns["ngayra"].HeaderText = "Thời gian ra";
                dataBill.Columns["ngayra"].Width = 200;

                dataBill.Columns["discount"].Width = 150;
                dataBill.Columns["discount"].HeaderText = "Giảm giá (%)";

                dataBill.Columns["tongtien"].Width = 185;
                dataBill.Columns["tongtien"].HeaderText = "Tổng tiền";

                dataBill.Columns["tenban"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataBill.Columns["ngayvao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataBill.Columns["ngayra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataBill.Columns["discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataBill.Columns["tongtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dataBill.Columns["tongtien"].DefaultCellStyle.Format = "0,00đ";
                decimal thongketong = 0;
                int sc = dataBill.Rows.Count;
                for (int i = 0; i < sc - 1; i++)
                thongketong += decimal.Parse(dataBill.Rows[i].Cells["tongtien"].Value.ToString());
                txtthongke.Text = thongketong.ToString("0,00đ");

                btn_excel_thongke.Enabled = true;
            }    

        }

        public void monmuanhieunhat()
        {
            System.Data.DataTable data = new System.Data.DataTable();
            data = DataProvider.Instance.ExecuteQuery("USP_maxlanmua");
            dataGridView2.DataSource = data;
            dataGridView2.Columns["tenmon"].Width = 150;
            dataGridView2.Columns["tenmon"].HeaderText = "Tên món";

            dataGridView2.Columns["solanmua"].Width = 150;
            dataGridView2.Columns["solanmua"].HeaderText = "Số lượng";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ngayvao.Value > ngayra.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc, thử lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                doanhthuchitiet.DataSource = getDetailListbyDate(ngayvao1.Value, ngayra.Value);
                doanhthuchitiet.Columns["tenmon"].Width = 130;
                doanhthuchitiet.Columns["tenmon"].HeaderText = "Tên món";

                doanhthuchitiet.Columns["count"].Width = 60;
                doanhthuchitiet.Columns["count"].HeaderText = "Số lượng";

                doanhthuchitiet.Columns["dongia"].HeaderText = "Đơn giá";
                doanhthuchitiet.Columns["dongia"].Width = 60;

                doanhthuchitiet.Columns["discount"].HeaderText = "Giảm giá (%)";
                doanhthuchitiet.Columns["discount"].Width = 60;

                doanhthuchitiet.Columns["ngayvao"].Width = 150;
                doanhthuchitiet.Columns["ngayvao"].HeaderText = "Ngày vào";

                doanhthuchitiet.Columns["ngayra"].Width = 150;
                doanhthuchitiet.Columns["ngayra"].HeaderText = "Ngày ra";

                doanhthuchitiet.Columns["Tongcong"].HeaderText = "Tổng (Đã trừ chiết khấu)";
                doanhthuchitiet.Columns["Tongcong"].Width = 85;

                doanhthuchitiet.Columns["Tienchietkhau"].HeaderText = "Chiết khấu";
                doanhthuchitiet.Columns["Tienchietkhau"].Width = 85;

                doanhthuchitiet.Columns["tenmon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                doanhthuchitiet.Columns["count"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                doanhthuchitiet.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                doanhthuchitiet.Columns["discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                doanhthuchitiet.Columns["Tongcong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                doanhthuchitiet.Columns["Tienchietkhau"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                doanhthuchitiet.Columns["Tongcong"].DefaultCellStyle.Format = "N0";
                doanhthuchitiet.Columns["Tienchietkhau"].DefaultCellStyle.Format = "N0";

                decimal thongketong = 0;
                int sc = doanhthuchitiet.Rows.Count;
                for (int i = 0; i < sc - 1; i++)
                    thongketong += decimal.Parse(doanhthuchitiet.Rows[i].Cells["Tongcong"].Value.ToString());
                tongchitiet.Text = thongketong.ToString("0,00đ");

                int sl = 0;
                for (int i = 0; i < sc - 1; i++)
                    sl += int.Parse(doanhthuchitiet.Rows[i].Cells["count"].Value.ToString());
                SoLuong.Text = sl.ToString();

                decimal ck = 0;
                for (int i = 0; i < sc - 1; i++)
                    ck += decimal.Parse(doanhthuchitiet.Rows[i].Cells["Tienchietkhau"].Value.ToString());
                ChietKhau.Text = ck.ToString("0,00đ");
                btn_thongkechitiet.Enabled = true;
            }    
        }
        private void btn_excel_thongke_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel|*.xlsx|Excel 2003|*.xls";
            if (dialog.ShowDialog() == DialogResult.OK) { ToExcel(dataBill, dialog.FileName); }
            {
                //filepath = dialog.FileName;
            } 
        }

        private void ToExcel(DataGridView dataBill, string filename)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;

            workbook = excel.Workbooks.Add(Type.Missing);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["sheet1"];

            worksheet.Name = "Thóng kê";
            worksheet.Cells[1, 1].Value = "BẢNG DOANH THU THỐNG KÊ";
            worksheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 1].Font.Size = 20;

            worksheet.Cells[dataBill.Rows.Count + 2, dataBill.Columns.Count].Value = txtthongke.Text;
            worksheet.Cells[dataBill.Rows.Count + 2, dataBill.Columns.Count].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[dataBill.Rows.Count + 2, dataBill.Columns.Count].Font.Bold = true;

            worksheet.Cells[dataBill.Rows.Count + 2, dataBill.Columns.Count - 1].Value = "Tổng cộng";
            worksheet.Cells[dataBill.Rows.Count + 2, dataBill.Columns.Count - 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[dataBill.Rows.Count + 2, dataBill.Columns.Count - 1].Font.Bold = true;
            worksheet.Cells[dataBill.Rows.Count + 2, dataBill.Columns.Count - 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]].Merge();
            worksheet.Columns[1].ColumnWidth = 30;
            worksheet.Columns[2].ColumnWidth = 50;
            worksheet.Columns[3].ColumnWidth = 50;
            worksheet.Columns[4].ColumnWidth = 30;
            worksheet.Columns[5].ColumnWidth = 30;
            
            
            for (int i = 0; i < dataBill.Columns.Count; i++)
            {
                worksheet.Cells[2,i+1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                worksheet.Cells[2,i+ 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Cells[2,i+1].Font.Bold = true;
                worksheet.Cells[2, i + 1] = dataBill.Columns[i].HeaderText;
                worksheet.Cells[2,i+1].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, XlBorderWeight.xlThin);
            }

            for (int i = 0; i < dataBill.RowCount -1; i++)
            {
                
                for (int j = 0; j < dataBill.ColumnCount ; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataBill.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells.Range[worksheet.Cells[i+3,j+1], worksheet.Cells[i+3, j+1]].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, XlBorderWeight.xlThin);
                }
            }
            workbook.SaveAs(filename);
            workbook.Close();
            excel.Quit();
            MessageBox.Show("Xuất excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btn_excel_thongke.Enabled = false;
            btn_thongkechitiet.Enabled = false;
        }

        private void btn_thongkechitiet_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel|*.xlxs|Excel 2003|*.xls";
            if (dialog.ShowDialog() == DialogResult.OK) { ToExcelchitiet(doanhthuchitiet, dialog.FileName); }
            {
                //filepath = dialog.FileName;
            }
        }

        private void ToExcelchitiet(DataGridView doanhthuchitiet, string fileName1)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;

            workbook = excel.Workbooks.Add(Type.Missing);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["sheet1"];

            worksheet.Name = "Thóng kê";
            worksheet.Cells[1, 1].Value = "BẢNG DOANH THU THỐNG KÊ CHI TIẾT";
            worksheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 1].Font.Size = 20;

            worksheet.Cells[doanhthuchitiet.Rows.Count + 2, doanhthuchitiet.Columns.Count].Value = tongchitiet.Text;
            worksheet.Cells[doanhthuchitiet.Rows.Count + 2, doanhthuchitiet.Columns.Count].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[doanhthuchitiet.Rows.Count + 2, doanhthuchitiet.Columns.Count].Font.Bold = true;

            worksheet.Cells[doanhthuchitiet.Rows.Count + 2, doanhthuchitiet.Columns.Count - 1].Value = "Tổng cộng";
            worksheet.Cells[doanhthuchitiet.Rows.Count + 2, doanhthuchitiet.Columns.Count - 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[doanhthuchitiet.Rows.Count + 2, doanhthuchitiet.Columns.Count - 1].Font.Bold = true;
            worksheet.Cells[doanhthuchitiet.Rows.Count + 2, doanhthuchitiet.Columns.Count - 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 8]].Merge();
            worksheet.Columns[1].ColumnWidth = 30;
            worksheet.Columns[2].ColumnWidth = 20;
            worksheet.Columns[3].ColumnWidth = 20;
            worksheet.Columns[4].ColumnWidth = 20;
            worksheet.Columns[5].ColumnWidth = 20;
            worksheet.Columns[6].ColumnWidth = 20;
            worksheet.Columns[7].ColumnWidth = 25;
            worksheet.Columns[8].ColumnWidth = 25;


            for (int i = 0; i < doanhthuchitiet.Columns.Count; i++)
            {
                worksheet.Cells[2, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                worksheet.Cells[2, i + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Cells[2, i + 1].Font.Bold = true;
                worksheet.Cells[2, i + 1] = doanhthuchitiet.Columns[i].HeaderText;
                worksheet.Cells[2, i + 1].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, XlBorderWeight.xlThin);
            }

            for (int i = 0; i < doanhthuchitiet.RowCount - 1; i++)
            {

                for (int j = 0; j < doanhthuchitiet.ColumnCount; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = doanhthuchitiet.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, XlBorderWeight.xlThin);
                }
            }
            workbook.SaveAs(fileName1);
            workbook.Close();
            excel.Quit();
            MessageBox.Show("Xuất excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
