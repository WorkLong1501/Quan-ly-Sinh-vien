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

namespace CNQuanLySV
{
    public partial class frmQLSV : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQLSV1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter1.Fill(this.dataQLSV1.SINHVIEN);

            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            //Add du lieu vao cboKhoa
            string select = "Select MaKhoa from KHOA ";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                cboKhoahoc.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();

            //Add du lieu vao MaLop
            string selects = "Select MaLop from LOPQL";
            SqlCommand cmd1 = new SqlCommand(selects, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {

                cboMalop.Items.Add(reader1.GetString(0));
            }
            reader1.Dispose();
            cmd1.Dispose();
            //Load lai du lieu
            FillDataGridView_SV();
        }
        public void FillDataGridView_SV()
        {
            // Thực hiện truy vấn
            string select = "Select * From SINHVIEN  ";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrDSSV.DataSource = ds;
            dgrDSSV.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void dgrDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgrDSSV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDSSV.CurrentRow.Cells[1].Value.ToString();
            mskNgaySinh.Text = dgrDSSV.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinh.Text = dgrDSSV.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgrDSSV.CurrentRow.Cells[4].Value.ToString();
            cboMalop.Text = dgrDSSV.CurrentRow.Cells[5].Value.ToString();
        }

        private void cboKhoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLop.Items.Clear();
            string select = "Select MaLop from LOPQL where MaKhoa=N'" + cboKhoahoc.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            //Add vao cboLop
            while (reader.Read())
            {
                cboLop.Items.Add(reader.GetString(0));
            }
            //Tra tai nguyen             
            reader.Dispose();
            cmd.Dispose();            
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            string select = "Select * From SINHVIEN  where MaLop='" + cboLop.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrDSSV.DataSource = ds;
            dgrDSSV.DataMember = "SINHVIEN";

            cmd.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMaSV.Text == "")
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            else if (cboMalop.Text == "")
                errorProvider1.SetError(cboMalop, "Mã lớp không để trống!");

            else
            {
                // Thực hiện truy vấn
                string update = "Update SINHVIEN Set HoTen=N'" + txtHoTen.Text + "',NgaySinh='" +
                                mskNgaySinh.Text + "',GioiTinh=N'" + cboGioiTinh.Text + "',DiaChi=N'" +
                                txtDiaChi.Text + "',MaLop='" + cboMalop.Text + "'where MaSV='" + txtMaSV.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //Load lai du lieu
                FillDataGridView_SV();
                // Trả tài nguyên
                cmd.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kiem tra 
                        
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {               

                SqlCommand cmd = new SqlCommand("delete from SINHVIEN where MaSV='" + txtMaSV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Load lai du lieu
                FillDataGridView_SV();
            }
            
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            //Kiem tra trung ten MaSV
            string select2 = "Select * From SINHVIEN where MaSV='" + txtMaSV.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtMaSV.Text == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            }
            else if (cboMalop.Text == "")
            {
                errorProvider1.SetError(cboMalop, "Mã lớp không để trống!");
            }
            else if (reader2.Read())
            {
                MessageBox.Show("Bạn đã nhập trùng mã sinh viên ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into SINHVIEN(MaSV,HoTen,Ngaysinh,Gioitinh,DiaChi,Malop)" +
                                "Values('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "','" +
                                DateTime.Parse(mskNgaySinh.Text) + "',N'" + cboGioiTinh.Text + "',N'" + txtDiaChi.Text + "','" +
                                cboMalop.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");

                // Trả tài nguyên

                cmd.Dispose();
            }
            // Trả tài nguyên
            cmd2.Dispose();
            reader2.Dispose();
            //Load lai du lieu
            FillDataGridView_SV();
        }

    }
}
