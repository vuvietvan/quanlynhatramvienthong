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

namespace QuanLyNhaTramVienThong
{
    public partial class frmUnit : Form
    {
        public frmUnit()
        {
            InitializeComponent();
        }
        ConnectionSQL conn = new ConnectionSQL();
        public void hienthi()
        {
            String sql = "SELECT * FROM Unit ";
            SqlCommand cmd = new SqlCommand(sql, conn.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        private void frmUnit_Load(object sender, EventArgs e)
        {

            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtMaDonVi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã đơn vị  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaDonVi.Focus();
                }
                else if (txtTenDonVi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đơn vị !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenDonVi.Focus();
                } 
                else
                {
                    conn.Open();
                    String out_put = "select * from Unit where Unitcode='" + txtMaDonVi.Text + "'";
                    SqlCommand cmd = new SqlCommand(out_put, conn.Connect());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    conn.Close();

                    String Unitcode = "";
                    foreach (DataRow d in dt.Rows)
                    {
                        Unitcode = d["Unitcode"].ToString();
                    }
                    if (Unitcode == txtMaDonVi.Text)
                    {
                        MessageBox.Show("Mã đơn vị của bạn nhập đã tồn tại. Mời nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaDonVi.Clear();
                        txtMaDonVi.Focus();
                    }
                    else
                    {
                        conn.Open();
                        String sql = "insert into Unit (Unitcode,Unit)" +
                            "values('" + txtMaDonVi.Text + "',N'" + txtTenDonVi.Text + "')";
                        conn.Excute(sql);
                        MessageBox.Show("Thêm 1 nhà trạm thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaDonVi.Clear(); txtTenDonVi.Clear(); txtMaDonVi.Focus(); 
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

                if (txtMaDonVi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã đơn vị  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaDonVi.Focus();
                }
                else if (txtTenDonVi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đơn vị !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenDonVi.Focus();
                }
                else
                {
                   
                        conn.Open();
                        String sql = "Update Unit set Unit=N'"+txtTenDonVi.Text + "' where Unitcode = N'" + txtMaDonVi.Text + "'";
                        conn.Excute(sql);
                        MessageBox.Show("Sửa 1 nhà trạm thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaDonVi.Clear(); txtTenDonVi.Clear(); txtMaDonVi.Focus();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int number;
                number = e.RowIndex;
                txtMaDonVi.Text = dgv.Rows[number].Cells[0].Value.ToString();
                txtTenDonVi.Text = dgv.Rows[number].Cells[1].Value.ToString();
               
            }
            catch
            {
                MessageBox.Show("Mời bạn click vào danh sách để show form !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaDonVi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã đơn vị  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaDonVi.Focus();
                }
                else if (txtTenDonVi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đơn vị !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenDonVi.Focus();
                }
                else
                {
                    conn.Open();
                    String out_put = "select * from Unit where Unitcode='" + txtMaDonVi.Text + "'";
                    SqlCommand cmd = new SqlCommand(out_put, conn.Connect());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    conn.Close();

                    String Unitcode = "";
                    foreach (DataRow d in dt.Rows)
                    {
                        Unitcode = d["Unitcode"].ToString();
                    }
                    if (Unitcode != txtMaDonVi.Text)
                    {
                        MessageBox.Show("Mã đơn vị của bạn nhập không có. Mời nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaDonVi.Clear();
                        txtMaDonVi.Focus();
                    }
                    else
                    {
                        conn.Open();
                        String sql = "delete from Unit where Unitcode='" + txtMaDonVi.Text + "' ";
                        conn.Excute(sql);
                        MessageBox.Show("Xóa 1 nhà trạm thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaDonVi.Clear(); txtTenDonVi.Clear(); txtMaDonVi.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
