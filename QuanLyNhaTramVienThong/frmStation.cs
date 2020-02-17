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
    public partial class frmStation : Form
    {
        public frmStation()
        {
            InitializeComponent();
        }
        ConnectionSQL conn = new ConnectionSQL();
        public void hienthi()
        {
            String sql = "SELECT * FROM Type ";
            SqlCommand cmd = new SqlCommand(sql, conn.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmStation_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhà trạm   !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNhaTram.Focus();
                }
                else if (txtTenNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenNhaTram.Focus();
                }
                else
                {
                    conn.Open();
                    String out_put = "select * from Type where Typecode='" + txtMaNhaTram.Text + "'";
                    SqlCommand cmd = new SqlCommand(out_put, conn.Connect());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    conn.Close();

                    String Typecode = "";
                    foreach (DataRow d in dt.Rows)
                    {
                        Typecode = d["Typecode"].ToString();
                    }
                    if (Typecode == txtMaNhaTram.Text)
                    {
                        MessageBox.Show("Mã loại nhà trạm của bạn nhập đã tồn tại. Mời nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaNhaTram.Clear();
                        txtMaNhaTram.Focus();
                    }
                    else
                    {
                        conn.Open();
                        String sql = "insert into Type (Typecode,Type)" +
                            "values('" + txtMaNhaTram.Text + "',N'" + txtTenNhaTram.Text + "')";
                        conn.Excute(sql);
                        MessageBox.Show("Thêm 1 loại nhà trạm thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaNhaTram.Clear(); txtTenNhaTram.Clear(); txtMaNhaTram.Focus();
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
                    MessageBox.Show("Bạn chưa nhập mã nhà trạm   !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNhaTram.Focus();
                }
                else if (txtTenNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenNhaTram.Focus();
                }
                else
                {
                        conn.Open();
                        String sql = "Update Type set Type=N'" + txtTenNhaTram.Text + "' where Typecode = N'" + txtMaNhaTram.Text + "'";
                        conn.Excute(sql);
                        MessageBox.Show("Sửa 1 loại nhà trạm thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaNhaTram.Clear(); txtTenNhaTram.Clear(); txtMaNhaTram.Focus();
                    
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
                    MessageBox.Show("Bạn chưa nhập mã nhà trạm   !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNhaTram.Focus();
                }
                else if (txtTenNhaTram.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà trạm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenNhaTram.Focus();
                }
                else
                {
                    conn.Open();
                    String out_put = "select * from Type where Typecode='" + txtMaNhaTram.Text + "'";
                    SqlCommand cmd = new SqlCommand(out_put, conn.Connect());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    conn.Close();

                    String Typecode = "";
                    foreach (DataRow d in dt.Rows)
                    {
                        Typecode = d["Typecode"].ToString();
                    }
                    if (Typecode != txtMaNhaTram.Text)
                    {
                        MessageBox.Show("Mã loại nhà trạm của bạn nhập không tồn tại. Mời nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaNhaTram.Clear();
                        txtMaNhaTram.Focus();
                    }
                    else
                    {
                        conn.Open();
                        String sql = "delete from Type where Typecode='" + txtMaNhaTram.Text + "' ";
                        conn.Excute(sql);
                        MessageBox.Show("Xóa 1 loại nhà trạm thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        hienthi();
                        txtMaNhaTram.Clear(); txtTenNhaTram.Clear(); txtMaNhaTram.Focus();
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int number;
                number = e.RowIndex;
                txtMaNhaTram.Text = dgv.Rows[number].Cells[0].Value.ToString();
                txtTenNhaTram.Text = dgv.Rows[number].Cells[1].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Mời bạn click vào danh sách để show form !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
