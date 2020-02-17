namespace QuanLyNhaTramVienThong
{
    partial class frmSeach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Stationcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stationname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dayactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stationtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Managementunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acreage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.cbbDonViQuanLy = new System.Windows.Forms.ComboBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbTenNhaTram = new System.Windows.Forms.RadioButton();
            this.rbMaNhaTram = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.txtSeach);
            this.groupBox1.Controls.Add(this.cbbDonViQuanLy);
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.btnSeach);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbTenNhaTram);
            this.groupBox1.Controls.Add(this.rbMaNhaTram);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 470);
            this.groupBox1.TabIndex = 0;
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
            this.dgv.Location = new System.Drawing.Point(3, 339);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(872, 128);
            this.dgv.TabIndex = 5;
            // 
            // Stationcode
            // 
            this.Stationcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stationcode.DataPropertyName = "Stationcode";
            this.Stationcode.HeaderText = "Mã nhà trạm";
            this.Stationcode.Name = "Stationcode";
            this.Stationcode.ReadOnly = true;
            this.Stationcode.Width = 128;
            // 
            // Stationname
            // 
            this.Stationname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stationname.DataPropertyName = "Stationname";
            this.Stationname.HeaderText = "Tên nhà trạm";
            this.Stationname.Name = "Stationname";
            this.Stationname.ReadOnly = true;
            this.Stationname.Width = 122;
            // 
            // Dayactive
            // 
            this.Dayactive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dayactive.DataPropertyName = "Dayactive";
            this.Dayactive.HeaderText = "Ngày hđ";
            this.Dayactive.Name = "Dayactive";
            this.Dayactive.ReadOnly = true;
            this.Dayactive.Width = 90;
            // 
            // Stationtype
            // 
            this.Stationtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stationtype.DataPropertyName = "Stationtype";
            this.Stationtype.HeaderText = "Loại nhà trạm";
            this.Stationtype.Name = "Stationtype";
            this.Stationtype.ReadOnly = true;
            this.Stationtype.Width = 125;
            // 
            // Managementunit
            // 
            this.Managementunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Managementunit.DataPropertyName = "Managementunit";
            this.Managementunit.HeaderText = "Đơn vị quản lý";
            this.Managementunit.Name = "Managementunit";
            this.Managementunit.ReadOnly = true;
            this.Managementunit.Width = 121;
            // 
            // Acreage
            // 
            this.Acreage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Acreage.DataPropertyName = "Acreage";
            this.Acreage.HeaderText = "Diện tích";
            this.Acreage.Name = "Acreage";
            this.Acreage.ReadOnly = true;
            this.Acreage.Width = 69;
            // 
            // Longitude
            // 
            this.Longitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Longitude.DataPropertyName = "Longitude";
            this.Longitude.HeaderText = "Kinh độ";
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Width = 87;
            // 
            // Latitude
            // 
            this.Latitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Latitude.DataPropertyName = "Latitude";
            this.Latitude.HeaderText = "Vĩ độ";
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Width = 55;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(216, 83);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(219, 29);
            this.txtSeach.TabIndex = 4;
            // 
            // cbbDonViQuanLy
            // 
            this.cbbDonViQuanLy.Location = new System.Drawing.Point(591, 83);
            this.cbbDonViQuanLy.Name = "cbbDonViQuanLy";
            this.cbbDonViQuanLy.Size = new System.Drawing.Size(183, 29);
            this.cbbDonViQuanLy.TabIndex = 3;
            this.cbbDonViQuanLy.SelectedIndexChanged += new System.EventHandler(this.cbbDonViQuanLy_SelectedIndexChanged);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Image = global::QuanLyNhaTramVienThong.Properties.Resources.excel_411;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(466, 208);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(127, 39);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.Image = global::QuanLyNhaTramVienThong.Properties.Resources.search_40;
            this.btnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeach.Location = new System.Drawing.Point(286, 208);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(127, 39);
            this.btnSeach.TabIndex = 2;
            this.btnSeach.Text = "Tìm kiếm ";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(537, 161);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(80, 25);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả ";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbTenNhaTram
            // 
            this.rbTenNhaTram.AutoSize = true;
            this.rbTenNhaTram.Location = new System.Drawing.Point(377, 160);
            this.rbTenNhaTram.Name = "rbTenNhaTram";
            this.rbTenNhaTram.Size = new System.Drawing.Size(126, 25);
            this.rbTenNhaTram.TabIndex = 1;
            this.rbTenNhaTram.TabStop = true;
            this.rbTenNhaTram.Text = "Tên nhà trạm";
            this.rbTenNhaTram.UseVisualStyleBackColor = true;
            // 
            // rbMaNhaTram
            // 
            this.rbMaNhaTram.AutoSize = true;
            this.rbMaNhaTram.Location = new System.Drawing.Point(242, 160);
            this.rbMaNhaTram.Name = "rbMaNhaTram";
            this.rbMaNhaTram.Size = new System.Drawing.Size(121, 25);
            this.rbMaNhaTram.TabIndex = 1;
            this.rbMaNhaTram.TabStop = true;
            this.rbMaNhaTram.Text = "Mã nhà trạm";
            this.rbMaNhaTram.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị quản lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm theo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin tìm kiếm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU, TÌM KIẾM NHÀ TRẠM VIỄN THÔNG";
            // 
            // frmSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 470);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeach";
            this.Text = "Tìm kiếm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSeach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.ComboBox cbbDonViQuanLy;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbTenNhaTram;
        private System.Windows.Forms.RadioButton rbMaNhaTram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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