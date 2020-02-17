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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        ConnectionSQL conn = new ConnectionSQL();

        private String ChangeMD5(String strSource)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();//khởi tạo md5
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(strSource);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (Byte b in bs)
            {
                s.Append(b.ToString("X2").ToUpper());
            }
            return s.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtUser.Text;
                String password = txtPass.Text;
                if (username == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtUser.Focus();
                }
                else if (password == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtPass.Focus();
                }
                else
                {
                    string pass = ChangeMD5(password);
                    String sql = "SELECT * FROM User_Password WHERE Username='" + username + "' AND Password='" + pass+ "'";
                    SqlCommand cmd = new SqlCommand(sql, conn.Connect());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    String tkuser = "";
                    String tkpass = ""; 

                    foreach (DataRow User_Password in dt.Rows)
                    {
                       
                        tkuser = User_Password["Username"].ToString(); 
                          
                        tkpass = User_Password["Password"].ToString();
                     
                    }

                        if (tkuser == username && tkpass == pass )
                        {

                            frmHome frm = new frmHome();
                            frm.Show();
                            this.Hide();
                        }
                    else
                    {
                        MessageBox.Show("Nhập sai User và Password ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi sảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.Show();
            this.Hide();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            thoat();
        }
        private void thoat()
        {
            DialogResult ret = MessageBox.Show("Bạn muốn có muốn thoát không ?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
