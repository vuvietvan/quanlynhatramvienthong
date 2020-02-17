namespace QuanLyNhaTramVienThong
{
    partial class frmManagerNT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerNT));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNhaTram = new System.Windows.Forms.TextBox();
            this.txtTenNhaTram = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbbLoaiNhaTram = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDonViQuanLy = new System.Windows.Forms.ComboBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtVido = new System.Windows.Forms.TextBox();
            this.txtKinhdo = new System.Windows.Forms.TextBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Stationcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stationname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dayactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stationtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Managementunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acreage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÀ TRẠM VIỄN THÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhà Trạm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhà Trạm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = " Ngày hoạt động";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại nhà trạm";
            // 
            // txtMaNhaTram
            // 
            this.txtMaNhaTram.Location = new System.Drawing.Point(175, 58);
            this.txtMaNhaTram.Name = "txtMaNhaTram";
            this.txtMaNhaTram.Size = new System.Drawing.Size(182, 29);
            this.txtMaNhaTram.TabIndex = 1;
            // 
            // txtTenNhaTram
            // 
            this.txtTenNhaTram.Location = new System.Drawing.Point(175, 100);
            this.txtTenNhaTram.Name = "txtTenNhaTram";
            this.txtTenNhaTram.Size = new System.Drawing.Size(182, 29);
            this.txtTenNhaTram.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(175, 146);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(182, 29);
            this.dtpDate.TabIndex = 2;
            // 
            // cbbLoaiNhaTram
            // 
            this.cbbLoaiNhaTram.FormattingEnabled = true;
            this.cbbLoaiNhaTram.Location = new System.Drawing.Point(175, 195);
            this.cbbLoaiNhaTram.Name = "cbbLoaiNhaTram";
            this.cbbLoaiNhaTram.Size = new System.Drawing.Size(182, 29);
            this.cbbLoaiNhaTram.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn vị quản lý";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Diện tích";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vị  trí";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Địa chỉ";
            // 
            // cbbDonViQuanLy
            // 
            this.cbbDonViQuanLy.FormattingEnabled = true;
            this.cbbDonViQuanLy.Location = new System.Drawing.Point(555, 58);
            this.cbbDonViQuanLy.Name = "cbbDonViQuanLy";
            this.cbbDonViQuanLy.Size = new System.Drawing.Size(200, 29);
            this.cbbDonViQuanLy.TabIndex = 3;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(555, 95);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(200, 29);
            this.txtDienTich.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(943, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtVido);
            this.groupBox1.Controls.Add(this.txtKinhdo);
            this.groupBox1.Controls.Add(this.rtbDiaChi);
            this.groupBox1.Controls.Add(this.txtDienTich);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbDonViQuanLy);
            this.groupBox1.Controls.Add(this.txtMaNhaTram);
            this.groupBox1.Controls.Add(this.cbbLoaiNhaTram);
            this.groupBox1.Controls.Add(this.txtTenNhaTram);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 554);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stationcode,
            this.Stationname,
            this.Dayactive,
            this.Stationtype,
            this.Managementunit,
            this.Acreage,
            this.Longitude,
            this.Latitude,
            this.Address});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(3, 465);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(941, 86);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txtVido
            // 
            this.txtVido.Location = new System.Drawing.Point(619, 167);
            this.txtVido.Name = "txtVido";
            this.txtVido.Size = new System.Drawing.Size(136, 29);
            this.txtVido.TabIndex = 6;
            // 
            // txtKinhdo
            // 
            this.txtKinhdo.Location = new System.Drawing.Point(619, 132);
            this.txtKinhdo.Name = "txtKinhdo";
            this.txtKinhdo.Size = new System.Drawing.Size(136, 29);
            this.txtKinhdo.TabIndex = 6;
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Location = new System.Drawing.Point(541, 200);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(214, 57);
            this.rtbDiaChi.TabIndex = 5;
            this.rtbDiaChi.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Kinh độ ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Vĩ độ";
            // 
            // Stationcode
            // 
            this.Stationcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stationcode.DataPropertyName = "Stationcode";
            this.Stationcode.HeaderText = "Mã nhà trạm";
            this.Stationcode.Name = "Stationcode";
            this.Stationcode.Width = 128;
            // 
            // Stationname
            // 
            this.Stationname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stationname.DataPropertyName = "Stationname";
            this.Stationname.HeaderText = "Tên nhà trạm";
            this.Stationname.Name = "Stationname";
            this.Stationname.Width = 133;
            // 
            // Dayactive
            // 
            this.Dayactive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dayactive.DataPropertyName = "Dayactive";
            this.Dayactive.HeaderText = "Ngày hđ";
            this.Dayactive.Name = "Dayactive";
            this.Dayactive.Width = 90;
            // 
            // Stationtype
            // 
            this.Stationtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stationtype.DataPropertyName = "Stationtype";
            this.Stationtype.HeaderText = "Loại nhà trạm";
            this.Stationtype.Name = "Stationtype";
            this.Stationtype.Width = 125;
            // 
            // Managementunit
            // 
            this.Managementunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Managementunit.DataPropertyName = "Managementunit";
            this.Managementunit.HeaderText = "Đơn vị quản lý";
            this.Managementunit.Name = "Managementunit";
            this.Managementunit.Width = 121;
            // 
            // Acreage
            // 
            this.Acreage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Acreage.DataPropertyName = "Acreage";
            this.Acreage.HeaderText = "Diện tích";
            this.Acreage.Name = "Acreage";
            this.Acreage.Width = 69;
            // 
            // Longitude
            // 
            this.Longitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Longitude.DataPropertyName = "Longitude";
            this.Longitude.HeaderText = "Kinh độ";
            this.Longitude.Name = "Longitude";
            this.Longitude.Width = 87;
            // 
            // Latitude
            // 
            this.Latitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Latitude.DataPropertyName = "Latitude";
            this.Latitude.HeaderText = "Vĩ độ";
            this.Latitude.Name = "Latitude";
            this.Latitude.Width = 55;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QuanLyNhaTramVienThong.Properties.Resources.back_401;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(698, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyNhaTramVienThong.Properties.Resources.excel_41;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(555, 263);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(128, 28);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "Xuất excel\r\n";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::QuanLyNhaTramVienThong.Properties.Resources.reset_40;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(365, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 28);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Xóa dữ liệu nhập lại ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyNhaTramVienThong.Properties.Resources.delete_40;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(248, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 28);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyNhaTramVienThong.Properties.Resources.edit_40;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(131, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyNhaTramVienThong.Properties.Resources.plus_40;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(6, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmManagerNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagerNT";
            this.Text = "Quản lý Nhà Trạm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagerNT_FormClosing);
            this.Load += new System.EventHandler(this.frmManagerNT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNhaTram;
        private System.Windows.Forms.TextBox txtTenNhaTram;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbbLoaiNhaTram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbDonViQuanLy;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtVido;
        private System.Windows.Forms.TextBox txtKinhdo;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stationcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stationname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dayactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stationtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Managementunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acreage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}