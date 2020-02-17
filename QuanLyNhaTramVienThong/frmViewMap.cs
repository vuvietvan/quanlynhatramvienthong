using GMap.NET;
using GMap.NET.MapProviders;
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
    public partial class frmViewMap : Form
    {
        public frmViewMap()
        {
            InitializeComponent();
        }
        ConnectionSQL conn = new ConnectionSQL();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                Map.DragButton = MouseButtons.Left;
                Map.MapProvider = GMapProviders.GoogleChinaMap;
                double longintude = float.Parse(cbbKinhdo.Text);
                double latitude = float.Parse(cbbVido.Text);
                Map.Position = new PointLatLng(longintude, latitude);
                Map.MinZoom = 1;
                Map.MaxZoom = 500;
                Map.Zoom = 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void loadcombobox_NameStation()
        {
            conn.Open();
            string sql = "select Stationname,Longitude,Latitude from Station";
            SqlCommand cmd = new SqlCommand(sql, conn.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Fill(set, "Chọn tên nhà trạm ");
            cbbMap.DataSource = set.Tables[0];
            cbbMap.DisplayMember = "Stationname";
            cbbMap.ValueMember = "Stationname";
            cbbKinhdo.DataSource = set.Tables[0];
            cbbKinhdo.DisplayMember = "Longitude";
            cbbKinhdo.ValueMember = "Longitude";
            cbbVido.DataSource = set.Tables[0];
            cbbVido.DisplayMember = "Latitude";
            cbbVido.ValueMember = "Latitude";
            conn.Close();

        }
        private void frmViewMap_Load(object sender, EventArgs e)
        {
            loadcombobox_NameStation();
            Map.DragButton = MouseButtons.Left;
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.Position = new PointLatLng(16, 108);
            Map.Zoom = 20;
            Map.MaxZoom = 500;
            Map.MinZoom = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
