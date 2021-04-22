namespace CNQuanLySV
{
    partial class frmQLDiem
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
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbDTH = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.cboTenKhoa = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            this.cboLopMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDTK = new System.Windows.Forms.TextBox();
            this.txtDTH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDKTGK = new System.Windows.Forms.TextBox();
            this.txtDQT = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrDiem = new System.Windows.Forms.DataGridView();
            this.dIEMSVTHEOLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataQLSV1 = new CNQuanLySV.dataQLSV();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.dIEMSV_THEOLOPTableAdapter1 = new CNQuanLySV.dataQLSVTableAdapters.DIEMSV_THEOLOPTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMSVTHEOLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLSV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Điểm KT giữa kì";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(652, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "Điểm thi";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1164, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "Sửa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbDTH
            // 
            this.lbDTH.AutoSize = true;
            this.lbDTH.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDTH.Location = new System.Drawing.Point(834, 36);
            this.lbDTH.Name = "lbDTH";
            this.lbDTH.Size = new System.Drawing.Size(133, 22);
            this.lbDTH.TabIndex = 20;
            this.lbDTH.Text = "Điểm thực hành";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1164, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "Xóa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điểm quá trình";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã Sinh Viên";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1164, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 39);
            this.button4.TabIndex = 24;
            this.button4.Text = "Thoát ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã lớp môn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenMon);
            this.groupBox1.Controls.Add(this.cboTenKhoa);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbTenMon);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboMaMon);
            this.groupBox1.Controls.Add(this.cboLopMon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 164);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cboTenMon
            // 
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Location = new System.Drawing.Point(630, 78);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(404, 30);
            this.cboTenMon.TabIndex = 28;
            this.cboTenMon.SelectedIndexChanged += new System.EventHandler(this.cboTenMon_SelectedIndexChanged);
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.FormattingEnabled = true;
            this.cboTenKhoa.Location = new System.Drawing.Point(339, 26);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Size = new System.Drawing.Size(404, 30);
            this.cboTenKhoa.TabIndex = 27;
            this.cboTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cboTenKhoa_SelectedIndexChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(630, 120);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(404, 30);
            this.txtGhiChu.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(539, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 22);
            this.label15.TabIndex = 25;
            this.label15.Text = "Ghi Chú";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 22);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tên Khoa";
            // 
            // lbTenMon
            // 
            this.lbTenMon.AutoSize = true;
            this.lbTenMon.Location = new System.Drawing.Point(537, 78);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(78, 22);
            this.lbTenMon.TabIndex = 21;
            this.lbTenMon.Text = "Tên môn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 22);
            this.label11.TabIndex = 19;
            // 
            // cboMaMon
            // 
            this.cboMaMon.FormattingEnabled = true;
            this.cboMaMon.Location = new System.Drawing.Point(132, 75);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(361, 30);
            this.cboMaMon.TabIndex = 16;
            this.cboMaMon.SelectedIndexChanged += new System.EventHandler(this.cboMaMon_SelectedIndexChanged);
            // 
            // cboLopMon
            // 
            this.cboLopMon.FormattingEnabled = true;
            this.cboLopMon.Location = new System.Drawing.Point(132, 119);
            this.cboLopMon.Name = "cboLopMon";
            this.cboLopMon.Size = new System.Drawing.Size(361, 30);
            this.cboLopMon.TabIndex = 15;
            this.cboLopMon.SelectedIndexChanged += new System.EventHandler(this.cboLopMon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Môn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điểm Điểm Danh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(848, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điểm tổng kết";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1342, 56);
            this.label1.TabIndex = 16;
            this.label1.Text = "THÔNG TIN ĐIỂM SINH VIÊN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDTK);
            this.groupBox2.Controls.Add(this.txtDTH);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtDT);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.txtDKTGK);
            this.groupBox2.Controls.Add(this.txtDQT);
            this.groupBox2.Controls.Add(this.txtDDD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbDTH);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(64, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 123);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtDTK
            // 
            this.txtDTK.Location = new System.Drawing.Point(973, 73);
            this.txtDTK.Name = "txtDTK";
            this.txtDTK.ReadOnly = true;
            this.txtDTK.Size = new System.Drawing.Size(61, 30);
            this.txtDTK.TabIndex = 31;
            // 
            // txtDTH
            // 
            this.txtDTH.Location = new System.Drawing.Point(973, 33);
            this.txtDTH.Name = "txtDTH";
            this.txtDTH.Size = new System.Drawing.Size(61, 30);
            this.txtDTH.TabIndex = 30;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(91, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(233, 30);
            this.txtHoTen.TabIndex = 18;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(754, 69);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(61, 30);
            this.txtDT.TabIndex = 29;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(158, 33);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(166, 30);
            this.txtMaSV.TabIndex = 17;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtDKTGK
            // 
            this.txtDKTGK.Location = new System.Drawing.Point(754, 30);
            this.txtDKTGK.Name = "txtDKTGK";
            this.txtDKTGK.Size = new System.Drawing.Size(61, 30);
            this.txtDKTGK.TabIndex = 28;
            // 
            // txtDQT
            // 
            this.txtDQT.Location = new System.Drawing.Point(504, 76);
            this.txtDQT.Name = "txtDQT";
            this.txtDQT.ReadOnly = true;
            this.txtDQT.Size = new System.Drawing.Size(61, 30);
            this.txtDQT.TabIndex = 27;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(504, 33);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(61, 30);
            this.txtDDD.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Họ tên";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgrDiem);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(64, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1063, 288);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dgrDiem
            // 
            this.dgrDiem.AutoGenerateColumns = false;
            this.dgrDiem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.hoTenDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.tenMonDataGridViewTextBoxColumn,
            this.tenKhoaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgrDiem.DataSource = this.dIEMSVTHEOLOPBindingSource;
            this.dgrDiem.Location = new System.Drawing.Point(0, 21);
            this.dgrDiem.Name = "dgrDiem";
            this.dgrDiem.Size = new System.Drawing.Size(1043, 252);
            this.dgrDiem.TabIndex = 0;
            this.dgrDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDiem_CellContentClick);
            // 
            // dIEMSVTHEOLOPBindingSource
            // 
            this.dIEMSVTHEOLOPBindingSource.DataMember = "DIEMSV_THEOLOP";
            this.dIEMSVTHEOLOPBindingSource.DataSource = this.dataQLSV1;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNQuanLySV.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(48, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1164, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Nhập";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(1164, 373);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(105, 37);
            this.btnXuat.TabIndex = 25;
            this.btnXuat.Text = "In Bảng Điểm";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // dIEMSV_THEOLOPTableAdapter1
            // 
            this.dIEMSV_THEOLOPTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLopM";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaLopM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaSV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaMon";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaMon";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            // 
            // tenKhoaDataGridViewTextBoxColumn
            // 
            this.tenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn.Name = "tenKhoaDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DiemDiemDanh";
            this.dataGridViewTextBoxColumn4.HeaderText = "DiemDiemDanh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DiemKiemTraGiuaKi";
            this.dataGridViewTextBoxColumn5.HeaderText = "DiemKiemTraGiuaKi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DiemThucHanh";
            this.dataGridViewTextBoxColumn6.HeaderText = "DiemThucHanh";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DiemQuaTrinh";
            this.dataGridViewTextBoxColumn7.HeaderText = "DiemQuaTrinh";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DiemThi";
            this.dataGridViewTextBoxColumn8.HeaderText = "DiemThi";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DiemTongKet";
            this.dataGridViewTextBoxColumn9.HeaderText = "DiemTongKet";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1164, 449);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 37);
            this.button5.TabIndex = 27;
            this.button5.Text = "ReFresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 680);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmQLDiem";
            this.Text = "Nhập điểm sinh viên";
            this.Load += new System.EventHandler(this.frmQLDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMSVTHEOLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLSV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDTH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private dataQLSV dataQLSV;
        private dataQLSVTableAdapters.DIEMSV_THEOLOPTableAdapter dIEMSV_THEOLOPTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private dataQLSVTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.DataGridView dgrDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDiemDanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemKiemTraGiuaKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThucHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemQuaTrinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTongKetDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cboMaMon;
        private System.Windows.Forms.ComboBox cboLopMon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDTK;
        private System.Windows.Forms.TextBox txtDTH;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDKTGK;
        private System.Windows.Forms.TextBox txtDQT;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.ComboBox cboTenKhoa;
        private dataQLSV dataQLSV1;
        private System.Windows.Forms.BindingSource dIEMSVTHEOLOPBindingSource;
        private dataQLSVTableAdapters.DIEMSV_THEOLOPTableAdapter dIEMSV_THEOLOPTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button5;
    }
}