using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace QuanLyNhaTramVienThong
{
    public partial class frmManagerNT : Form
    {
        public frmManagerNT()
        {
            InitializeComponent();
        }
        ConnectionSQL conn = new ConnectionSQL();
        public void hienthi()
        {
            String sql = "SELECT * FROM Station ";
            SqlCommand cmd = new SqlCommand(sql, conn.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        private void frmManagerNT_Load(object sender, EventArgs e)
        {
            hienthi();
            loadcombobox_LoaiNhaTram();
            loadcombobox_DonViQuanLy();
        }
        public void loadcombobox_LoaiNhaTram()
        {
            conn.Open();
            string sql = "select Type from Type";
            SqlCommand cmd = new SqlCommand(sql, conn.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            da.Fill(set, "Chọn loại nhà trạm ");
            cbbLoaiNhaTram.DataSource = set.Tables[0];
            cbbLoaiNhaTram.DisplayMember = "Type";
            cbbLoaiNhaTram.ValueMember = "Type";
            conn.Close();

        }
        public void loadcombobox_DonViQuanLy()
        {
            conn.Open();
            string sql = "select Unit from Unit";
            SqlCommand cmd = new SqlCommand(sql, conn.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            da.Fill(set, "Chọn loại nhà trạm ");
            cbbDonViQuanLy.DataSource = set.Tables[0];
            cbbDonViQuanLy.DisplayMember = "Unit";
            cbbDonViQuanLy.ValueMember = "Unit";
            conn.Close();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int number;
                number = e.RowIndex;
                txtMaNhaTram.Text = dgv.Rows[number].Cells[0].Value.ToString();
                txtTenNhaTram.Text = dgv.Rows[number].Cells[1].Value.ToString();
                dtpDate.Text = dgv.Rows[number].Cells[2].Value.ToString();
                cbbLoaiNhaTram.Text = dgv.Rows[number].Cells[3].Value.ToString();
                cbbDonViQuanLy.Text = dgv.Rows[number].Cells[4].Value.ToString();
                txtDienTich.Text = dgv.Rows[number].Cells[5].Value.ToString();
                txtKinhdo.Text = dgv.Rows[number].Cells[6].Value.ToString();
                txtVido.Text = dgv.Rows[number].Cells[7].Value.ToString();
                rtbDiaChi.Text = dgv.Rows[number].Cells[8].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Mời bạn click vào danh sách để show form !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập nhà trạm  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNhaTram.Focus();
                }
                else if (txtTenNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenNhaTram.Focus();
                }
                else if (cbbLoaiNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chọn loại nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbbLoaiNhaTram.Focus();
                }
                else if (cbbDonViQuanLy.Text == "")
                {
                    MessageBox.Show("Bạn chưa đơn vị quản lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbbDonViQuanLy.Focus();
                }
                else if (txtDienTich.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập diện tích !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDienTich.Focus();
                }
                else if (txtKinhdo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập kinh độ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtKinhdo.Focus();
                }
                else if (txtVido.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập vĩ độ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtVido.Focus();
                }
                else
                {
                    conn.Open();
                    String out_put = "select * from Station where Stationcode='" + txtMaNhaTram.Text + "'";        
                    SqlCommand cmd = new SqlCommand(out_put, conn.Connect()); 
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    conn.Close();

                    String stationcode = "";
                    foreach (DataRow d in dt.Rows)
                    {
                        stationcode = d["Stationcode"].ToString();
                    } 
                    if (stationcode == txtMaNhaTram.Text)
                    {
                        MessageBox.Show("Mã nhà trạm của bạn nhập đã tồn tại. Mời nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         txtMaNhaTram.Clear();
                          txtMaNhaTram.Focus();
                    }
                    else
                    {
                        conn.Open();
                        String sql = "insert into Station (Stationcode,Stationname,Dayactive,Stationtype,Managementunit,Acreage,Longitude,Latitude,Address)" +
                            "values('" + txtMaNhaTram.Text + "',N'" + txtTenNhaTram.Text + "',N'" + dtpDate.Text + "',N'" + cbbLoaiNhaTram.Text + "',N'" + cbbDonViQuanLy.Text + "',N'" + txtDienTich.Text + "','" + txtKinhdo.Text + "','" + txtVido.Text + "'," +
                            "N'" + rtbDiaChi.Text + "')";
                        conn.Excute(sql);
                        MessageBox.Show("Thêm 1 nhà trạm thành công !!! Mời", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaNhaTram.Clear();txtTenNhaTram.Clear();txtDienTich.Clear();txtKinhdo.Clear();txtVido.Clear();rtbDiaChi.Clear();
                
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           try
            {

                if (txtMaNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập nhà trạm  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNhaTram.Focus();
                }
                else if (txtTenNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenNhaTram.Focus();
                }
                else if (cbbLoaiNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chọn loại nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbbLoaiNhaTram.Focus();
                }
                else if (cbbDonViQuanLy.Text == "")
                {
                    MessageBox.Show("Bạn chưa đơn vị quản lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbbDonViQuanLy.Focus();
                }
                else if (txtDienTich.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập diện tích !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDienTich.Focus();
                }
                else if (txtKinhdo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập kinh độ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtKinhdo.Focus();
                }
                else if (txtVido.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập vĩ độ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtVido.Focus();
                }
                else
                { 
                        conn.Open();
                        String sql = "update Station set Stationname=N'" + txtTenNhaTram.Text + "'," +
                        "Dayactive=N'" + dtpDate.Text + "',Stationtype =N'" + cbbLoaiNhaTram.Text + "'," +
                        "Managementunit=N'" + cbbDonViQuanLy.Text + "',Acreage=N'" + txtDienTich.Text + "'," +
                        "Longitude=N'" + txtKinhdo.Text + "',Latitude=N'" + txtVido.Text + "',Address =N'"+ rtbDiaChi.Text + "' Where Stationcode =N'"+txtMaNhaTram.Text+"'";
                        conn.Excute(sql);
                        MessageBox.Show("Sửa 1 nhà trạm thành công !!! Mời", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaNhaTram.Clear(); txtTenNhaTram.Clear(); txtDienTich.Clear(); txtKinhdo.Clear(); txtVido.Clear(); rtbDiaChi.Clear();   
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập nhà trạm  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNhaTram.Focus();
                }
                else if (txtTenNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenNhaTram.Focus();
                }
                else if (cbbLoaiNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chọn loại nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbbLoaiNhaTram.Focus();
                }
                else if (cbbDonViQuanLy.Text == "")
                {
                    MessageBox.Show("Bạn chưa đơn vị quản lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbbDonViQuanLy.Focus();
                }
                else if (txtDienTich.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập diện tích !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDienTich.Focus();
                }
                else if (txtKinhdo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập kinh độ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtKinhdo.Focus();
                }
                else if (txtVido.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập vĩ độ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtVido.Focus();
                }
                else
                {
                    conn.Open();
                    String out_put = "select * from Station where Stationcode='" + txtMaNhaTram.Text + "'";
                    SqlCommand cmd = new SqlCommand(out_put, conn.Connect());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    conn.Close();

                    String stationcode = "";
                    foreach (DataRow d in dt.Rows)
                    {
                        stationcode = d["Stationcode"].ToString();
                    }
                    if (stationcode != txtMaNhaTram.Text)
                    {
                        MessageBox.Show("Mã nhà trạm không tồn tại. Mời nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaNhaTram.Clear();
                        txtMaNhaTram.Focus();
                    }
                    else
                    {
                        conn.Open();
                        String sql = "delete from Station where Stationcode='" + txtMaNhaTram.Text + "'";
                        conn.Excute(sql);
                        MessageBox.Show("xóa 1 nhà trạm thành công !!! Mời", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaNhaTram.Clear(); txtTenNhaTram.Clear(); txtDienTich.Clear(); txtKinhdo.Clear(); txtVido.Clear(); rtbDiaChi.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNhaTram.Clear();
            txtTenNhaTram.Clear();
            txtDienTich.Clear();
            txtKinhdo.Clear();
            txtVido.Clear();
            rtbDiaChi.Clear();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //khởi tạo WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            //đổ dữ liệu vào shee  
            worksheet.Cells[2, 1] = "Danh sách toàn bộ các nhà trạm viễn thông ";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã nhà trạm ";
            worksheet.Cells[3, 3] = "Tên nhà trạm ";
            worksheet.Cells[3, 4] = "Ngày hoạt động ";
            worksheet.Cells[3, 5] = "Loại nhà trạm ";
            worksheet.Cells[3, 6] = "Đơn vị quản lý";
            worksheet.Cells[3, 7] = "Diện tích";
            worksheet.Cells[3, 8] = "Kinh độ ";
            worksheet.Cells[3, 9] = "Vĩ độ ";
            worksheet.Cells[3, 10] = "Địa chỉ";
            for (int i = 0; i < dgv.RowCount - 1 ; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = dgv.Rows[i].Cells[j].Value;
                } 
            }
            worksheet.Cells[40, 9] = " ....., Ngày ... tháng ... năm 2020 ";
            worksheet.Cells[41, 9] = "              Người lập danh sách   ";
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            worksheet.PageSetup.CenterHorizontally = true;
            //định dạng cột
            worksheet.Range["A1"].ColumnWidth = 5;
            worksheet.Range["B1"].ColumnWidth = 15.3;
            worksheet.Range["C1"].ColumnWidth = 26.78;
            worksheet.Range["D1"].ColumnWidth = 15.89;
            worksheet.Range["E1"].ColumnWidth = 16.78;
            worksheet.Range["F1"].ColumnWidth = 20.11;
            worksheet.Range["G1"].ColumnWidth = 10.78;
            worksheet.Range["H1"].ColumnWidth = 10.78;
            worksheet.Range["I1"].ColumnWidth = 10.78;
            worksheet.Range["J1"].ColumnWidth = 44.78;
            worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "J100"].Font.Size = 13;
            worksheet.Range["A1", "J1"].MergeCells = true;
            worksheet.Range["A2", "J2"].MergeCells = true;
            worksheet.Range["A2", "J2"].Font.Bold = true;
            worksheet.Range["A2", "J2"].Font.Size = 26;
            worksheet.Range["A3", "J3"].Font.Bold = true;
            worksheet.Range["A3", "J3"].Interior.ColorIndex = 15;
            worksheet.Range["A3", "J3"].HorizontalAlignment = 2;
            worksheet.Range["A3", "J" + (dgv.RowCount + 2)].Borders.LineStyle = 1;
            worksheet.Range["A1", "J1"].HorizontalAlignment = 4;
            worksheet.Range["A2", "J2"].HorizontalAlignment = 3;
            worksheet.Range["A3", "A" + (dgv.RowCount + 2)].HorizontalAlignment = 3;
            worksheet.Range["A3", "J3"].HorizontalAlignment = 3;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            thoat();
        }
        private void thoat()
        {
            this.Hide();
        }
        private void frmManagerNT_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
