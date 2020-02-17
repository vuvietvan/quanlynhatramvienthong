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
    public partial class frmSeach : Form
    {
        public frmSeach()
        {
            InitializeComponent();
        }
        ConnectionSQL conn = new ConnectionSQL();
        SqlConnection con = new SqlConnection(@"Data Source=VIET_VAN;Initial Catalog=QLNTVT;Integrated Security=True");
       
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
        private void frmSeach_Load(object sender, EventArgs e)
        {
            loadcombobox_DonViQuanLy();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSeach.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSeach.Focus();
                }
                else
                {
                    if(rbMaNhaTram.Checked==true)
                    {
                        Boolean kt = false;
                        int count;
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Station where Stationcode like N'%" + txtSeach.Text + "%' " +
                            "AND Managementunit like N'%" + cbbDonViQuanLy.Text+ "%' ", con);
                        count = (int)cmd.ExecuteScalar();
                        con.Close();
                        if (count != 0)
                        {
                            kt = true;
                        }
                        else
                        {
                            MessageBox.Show("Không tin thấy kết quả  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtSeach.Focus();
                            dgv.DataSource = null;
                        }

                        if (kt == true)
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SELECT * FROM Station where Stationcode like N'%" + txtSeach.Text + "%' " +
                                "AND Managementunit like N'%" + cbbDonViQuanLy.Text + "%' ", con);
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            System.Data.DataTable dt = new System.Data.DataTable();
                            da.Fill(dt);
                            dgv.DataSource = dt; 
                            con.Close();
                        }
                    }
                    else if(rbTenNhaTram.Checked==true)
                    {
                        Boolean kt = false;
                        int count;
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Station where Stationname like N'%" + txtSeach.Text + "%' " +
                            "AND Managementunit like N'%" + cbbDonViQuanLy.Text + "%'", con);
                        count = (int)cmd.ExecuteScalar();
                        con.Close();
                        if (count != 0)
                        {
                            kt = true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy kết quả !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtSeach.Focus();
                            dgv.DataSource = null;
                        }

                        if (kt == true)
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SELECT * FROM Station where Stationname like N'%" + txtSeach.Text + "%'" +
                                "AND Managementunit like N'%" + cbbDonViQuanLy.Text + "%' ", con);
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            System.Data.DataTable dt = new System.Data.DataTable();
                            da.Fill(dt);
                            dgv.DataSource = dt;
                            con.Close();
                        }
                    }
                    else if(rbAll.Checked==true)
                    {
                        Boolean kt = false;
                        int count;
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Station where Stationcode like N'%" + txtSeach.Text + "%' OR " +
                            "Stationname like N'%" + txtSeach.Text + "%' OR Dayactive like N'%" + txtSeach.Text + "%' " +
                            "OR Stationtype like N'%" + txtSeach.Text + "%' OR Managementunit like N'" + txtSeach.Text + "'" +
                            " OR Acreage like N'%" + txtSeach.Text + "%' OR" +
                            " Address like N'%" + txtSeach.Text + "%'" +
                            " AND Managementunit like N'%" + cbbDonViQuanLy.Text + "%'", con);
                        count = (int)cmd.ExecuteScalar();
                        con.Close();
                        if (count != 0)
                        {
                            kt = true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy kết quả !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtSeach.Focus();
                            dgv.DataSource = null;
                        }

                        if (kt == true)
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SELECT * FROM Station where Stationcode like N'%" + txtSeach.Text + "%' OR " +
                            "Stationname like N'%" + txtSeach.Text + "%' OR Dayactive like N'%" + txtSeach.Text + "%' " +
                            "OR Stationtype like N'%" + txtSeach.Text + "%' OR Managementunit like N'" + txtSeach.Text + "'" +
                            " OR Acreage like N'%" + txtSeach.Text + "%' OR" +
                            " Address like N'%" + txtSeach.Text + "%'" +
                            " AND Managementunit like N'%" + cbbDonViQuanLy.Text + "%'", con);
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            System.Data.DataTable dt = new System.Data.DataTable();
                            da.Fill(dt);
                            dgv.DataSource = dt;
                            con.Close();
                        }

                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
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
            //đổ dữ liệu vào sheet

            worksheet.Cells[2, 1] = "Danh sách các nhà trạm viễn thông ";
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
            for (int i = 0; i < dgv.RowCount - 1; i++)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbDonViQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
