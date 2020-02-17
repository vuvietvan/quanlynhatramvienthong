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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
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

        private void btnExit_Click(object sender, EventArgs e)
        {

            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtUser.Text;
                String password = txtPass.Text;
                String password_re = txtRePass.Text;
                String fullname = txtName.Text;

                if (username == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtUser.Focus();
                }
                else if (password == "" || password_re == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtPass.Focus();
                }
                else
                {
                    if (password == password_re)
                    {
                        String admin = "SELECT Username FROM User_Password WHERE Username='" + username + "'";
                        SqlCommand cmd1 = new SqlCommand(admin, conn.Connect());
                        SqlDataAdapter da = new SqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        String user_c = "";
                        foreach (DataRow User_Password in dt.Rows)
                        {
                            user_c = User_Password["Username"].ToString();
                        }
                        if (username == user_c)
                        {
                            MessageBox.Show("Tài khoản đã được đăng ký! Mời nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUser.Clear();
                            txtPass.Clear();
                            txtRePass.Clear();
                            txtName.Clear();
                            txtUser.Focus();

                        }
                        else
                        {
                            if (password.Length >= 8 && password_re.Length >= 8)
                            {
                                String passMd5 = ChangeMD5(txtPass.Text);
                                Random getRand = new Random();
                                int num = getRand.Next(1, 99999);
                                conn.Open();
                                string sql = "insert into User_Password (ID,Username,Password,Fullname)"
                                    + "values('" + num + "',N'" + username + "','" + passMd5 + "',N'" + fullname + "')";
                                conn.Excute(sql);
                                DialogResult f = MessageBox.Show("Đăng ký thành công !!! ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                                if (f == DialogResult.OK)
                                {
                                    this.Hide();
                                    frmLogin login = new frmLogin();
                                    login.Show();
                                }
                                else
                                {

                                    txtUser.Clear();
                                    txtPass.Clear();
                                    txtRePass.Clear();
                                    txtName.Clear();
                                    txtUser.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu bạn nhập phải lớn hơn hoặc bằng 8 ký tự !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPass.Clear();
                                txtRePass.Clear();
                                txtName.Clear();
                                txtPass.Focus();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu bạn nhập không khớp !!! Mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        txtPass.Clear();
                        txtRePass.Clear();
                        txtRePass.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi sảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {

    
        }

        private void frmRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
           
          
        }
    }
}
