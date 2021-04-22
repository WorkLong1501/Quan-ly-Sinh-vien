namespace CNQuanLySV
{
    partial class frmTongKet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongKet));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtHocLuc = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDCK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrDiem = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMTONGKET1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataQLSV1 = new CNQuanLySV.dataQLSV();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMSV = new System.Windows.Forms.ComboBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dIEMTONGKET1TableAdapter = new CNQuanLySV.dataQLSVTableAdapters.DIEMTONGKET1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.hOCLUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCLUCTableAdapter = new CNQuanLySV.dataQLSVTableAdapters.HOCLUCTableAdapter();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new CNQuanLySV.dataQLSVTableAdapters.SINHVIENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMTONGKET1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLSV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCLUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenLop);
            this.groupBox2.Controls.Add(this.txtHocLuc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDCK);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(91, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1053, 153);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(627, 45);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(372, 30);
            this.txtTenLop.TabIndex = 5;
            // 
            // txtHocLuc
            // 
            this.txtHocLuc.Location = new System.Drawing.Point(633, 105);
            this.txtHocLuc.Name = "txtHocLuc";
            this.txtHocLuc.Size = new System.Drawing.Size(175, 30);
            this.txtHocLuc.TabIndex = 31;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(389, 30);
            this.txtHoTen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Học Lực";
            // 
            // txtDCK
            // 
            this.txtDCK.Location = new System.Drawing.Point(256, 105);
            this.txtDCK.Name = "txtDCK";
            this.txtDCK.ReadOnly = true;
            this.txtDCK.Size = new System.Drawing.Size(175, 30);
            this.txtDCK.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Điểm Cuối Kì";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgrDiem);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(91, 418);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1063, 265);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dgrDiem
            // 
            this.dgrDiem.AutoGenerateColumns = false;
            this.dgrDiem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.HoTen,
            this.MaLop,
            this.TenLop,
            this.DiemCuoiKi,
            this.HocLuc});
            this.dgrDiem.DataSource = this.dIEMTONGKET1BindingSource;
            this.dgrDiem.Location = new System.Drawing.Point(4, 21);
            this.dgrDiem.Name = "dgrDiem";
            this.dgrDiem.Size = new System.Drawing.Size(1053, 234);
            this.dgrDiem.TabIndex = 0;
            this.dgrDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDiem_CellContentClick);
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.Name = "HoTen";
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "MaLop";
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "TenLop";
            this.TenLop.Name = "TenLop";
            // 
            // DiemCuoiKi
            // 
            this.DiemCuoiKi.DataPropertyName = "DiemCuoiKi";
            this.DiemCuoiKi.HeaderText = "DiemCuoiKi";
            this.DiemCuoiKi.Name = "DiemCuoiKi";
            // 
            // HocLuc
            // 
            this.HocLuc.DataPropertyName = "HocLuc";
            this.HocLuc.HeaderText = "HocLuc";
            this.HocLuc.Name = "HocLuc";
            // 
            // dIEMTONGKET1BindingSource
            // 
            this.dIEMTONGKET1BindingSource.DataMember = "DIEMTONGKET1";
            this.dIEMTONGKET1BindingSource.DataSource = this.dataQLSV1;
            // 
            // dataQLSV1
            // 
            this.dataQLSV1.DataSetName = "dataQLSV";
            this.dataQLSV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboMSV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 136);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(158, 36);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(258, 30);
            this.cboMaLop.TabIndex = 3;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // cboMSV
            // 
            this.cboMSV.FormattingEnabled = true;
            this.cboMSV.Location = new System.Drawing.Point(159, 96);
            this.cboMSV.Name = "cboMSV";
            this.cboMSV.Size = new System.Drawing.Size(258, 30);
            this.cboMSV.TabIndex = 0;
            this.cboMSV.SelectedIndexChanged += new System.EventHandler(this.cboMSV_SelectedIndexChanged);
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(1191, 366);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(72, 37);
            this.btnXuat.TabIndex = 36;
            this.btnXuat.Text = "In Bảng Điểm";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1191, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 39);
            this.button4.TabIndex = 35;
            this.button4.Text = "Thoát ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dIEMTONGKET1TableAdapter
            // 
            this.dIEMTONGKET1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1191, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hOCLUCBindingSource
            // 
            this.hOCLUCBindingSource.DataMember = "HOCLUC";
            this.hOCLUCBindingSource.DataSource = this.dataQLSV1;
            // 
            // hOCLUCTableAdapter
            // 
            this.hOCLUCTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dataQLSV1;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1311, 56);
            this.label1.TabIndex = 39;
            this.label1.Text = "THÔNG TIN ĐIỂM SINH VIÊN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNQuanLySV.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(130, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTongKet";
            this.Text = "TỔNG KẾT ĐIỂM SINH VIÊN ";
            this.Load += new System.EventHandler(this.frmTongKet_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMTONGKET1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLSV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCLUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgrDiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private dataQLSV dataQLSV1;
        private System.Windows.Forms.BindingSource dIEMTONGKET1BindingSource;
        private dataQLSVTableAdapters.DIEMTONGKET1TableAdapter dIEMTONGKET1TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDCK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource hOCLUCBindingSource;
        private dataQLSVTableAdapters.HOCLUCTableAdapter hOCLUCTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private dataQLSVTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.TextBox txtHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocLuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}