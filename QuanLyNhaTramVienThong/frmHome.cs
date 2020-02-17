using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTramVienThong
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void đơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnit frm = new frmUnit();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void loạiNhàTrạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStation frm = new frmStation();
            frm.MdiParent = this;  
            frm.Show();
            

        }

        private void quảnLýNhàTrạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerNT frm = new frmManagerNT();
            frm.MdiParent = this;
            frm.Show();


        }

        private void traCứutìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeach frm = new frmSeach();
            frm.MdiParent = this;
            frm.Show();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn muốn có muốn đăng xuất không ?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void xemTrênBảnĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewMap frm = new frmViewMap();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
