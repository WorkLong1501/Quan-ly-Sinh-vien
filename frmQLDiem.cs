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
    public partial class frmQLDiem : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmQLDiem()
        {
            InitializeComponent();
        }


        private void frmQLDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQLSV1.DIEMSV_THEOLOP' table. You can move, or remove it, as needed.
            this.dIEMSV_THEOLOPTableAdapter1.Fill(this.dataQLSV1.DIEMSV_THEOLOP);
            
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sql = " select * from [Quanlydiem_SV].[dbo].[DIEMSV_THEOLOP]";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrDiem.DataSource = table;


            //Add du lieu vao cboTenKhoa
            string select1 = "Select TenKhoa from KHOA ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                cboTenKhoa.Items.Add(reader1.GetString(0));
            }
            reader1.Dispose();
            cmd1.Dispose();

            //Add du lieu vao cboMaMon
            string select2 = "Select MaMon from MON ";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cboMaMon.Items.Add(reader2.GetString(0));
            }
            reader2.Dispose();
            cmd2.Dispose();

            //Add du lieu vao cboTenMon
            string select3 = "Select TenMon from MON ";
            SqlCommand cmd3 = new SqlCommand(select3, conn);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                cboTenMon.Items.Add(reader3.GetString(0));
            }
            reader3.Dispose();
            cmd3.Dispose();

            //Add du lieu vao cboLopMon
            string select4 = "Select MaLopM from LOPMON ";
            SqlCommand cmd4 = new SqlCommand(select4, conn);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                cboLopMon.Items.Add(reader4.GetString(0));
            }
            reader4.Dispose();
            cmd4.Dispose();

            //Load lai du lieu
            FillDataGridView_Diem();
        }
        public void FillDataGridView_Diem()
        {
            // Thực hiện truy vấn
            string select = "Select * From DIEMSV_THEOLOP  ";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrDiem.DataSource = ds;
            dgrDiem.DataMember = "SINHVIEN";
            cmd.Dispose();
        }


        private void cboLopMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            string select = "Select * From DIEMSV_THEOLOP Where MaLopM='" + cboLopMon.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrDiem.DataSource = ds;
            dgrDiem.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select1 = "Select MaSV from SINHVIEN where MaSV=N'" + txtMaSV.Text + "' and Hoten=N'" + txtHoTen.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            errorProvider1.Clear();

            if (txtMaSV.Text == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
                txtMaSV.Focus();
            }
            else if (txtMaSV.Text == dgrDiem.CurrentRow.Cells[1].Value.ToString() && cboMaMon.Text == dgrDiem.CurrentRow.Cells[3].Value.ToString())
            {
                {
                    MessageBox.Show("Sinh viên này đã được nhập điểm môn: " + cboMaMon.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                }
            }
            else if (cboLopMon.Text == "")
            {
                errorProvider1.SetError(cboLopMon, "Mã lớp không để trống!");
                cboLopMon.Focus();
            }

            else if (cboMaMon.Text == "")
            {
                errorProvider1.SetError(cboMaMon, "Mã môn không để trống!");
                cboMaMon.Focus();
            }
            else
            {
                if (reader1.Read() == false )
                {
                    //< MaLopM > ,< MaSV > ,< HoTen > ,< MaMon > ,< TenMon > ,< TenKhoa > ,< DiemDiemDanh > ,< DiemKiemTraGiuaKi > ,< DiemThucHanh > ,< DiemQuaTrinh > ,< DiemThi > ,< DiemTongKet >
                    //Tra tai nguyen 
                    reader1.Dispose();
                    cmd1.Dispose();
                    //
                    // Thực hiện truy vấn sinh vien
                    string insert2 = "Insert Into [dbo].[SINHVIEN]([MaSV],[HoTen])" +
                    "Values( N'" + txtMaSV.Text + "',N'" + txtHoTen.Text + "' )";
                    SqlCommand cmd2 = new SqlCommand(insert2, conn);
                    cmd2.ExecuteNonQuery();
                    // Trả tài nguyên
                    cmd2.Dispose();

                    // Thực hiện truy vấn
                    string insert = "Insert Into DIEMSV_THEOLOP([MaLopM],[MaSV],[HoTen],[MaMon],[TenMon],[TenKhoa],[DiemDiemDanh],[DiemKiemTraGiuaKi],[DiemThucHanh],[DiemThi])" +
                        "Values( N'" + cboLopMon.Text + "',N'" + txtMaSV.Text + "',N'" + txtHoTen.Text + "',N'" + cboMaMon.Text + "',N'" + cboTenMon.Text + "',N'" +
                                cboTenKhoa.Text + "',N'" + txtDDD.Text + "',N'" + txtDKTGK.Text + "',N'" + txtDTH.Text + "',N'" + txtDT.Text + "' )";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhập thông tin thành công", "Thông báo!");

                    // Trả tài nguyên
                    cmd.Dispose();

                }
                else
                {
                    {
                        MessageBox.Show("Nhập mã sinh viên không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSV.Focus();
                    }
                    ////Tra tai nguyen 
                    //reader1.Dispose();
                    //cmd1.Dispose();
                }
            }    
            //Tra tai nguyen 
            reader1.Dispose();
            cmd1.Dispose();
            //Load lai du lieu
            FillDataGridView_Diem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                string delete = "delete from DIEMSV_THEOLOP where MaSV='" + txtMaSV.Text + "' and MaMon='" + cboMaMon.Text + "' ";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Load lai du lieu
                FillDataGridView_Diem();
            }
        }

        private void dgrDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboLopMon.Text = dgrDiem.CurrentRow.Cells[0].Value.ToString();
            txtMaSV.Text = dgrDiem.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dgrDiem.CurrentRow.Cells[2].Value.ToString();
            cboMaMon.Text = dgrDiem.CurrentRow.Cells[3].Value.ToString();
            cboTenMon.Text = dgrDiem.CurrentRow.Cells[4].Value.ToString();
            cboTenKhoa.Text = dgrDiem.CurrentRow.Cells[5].Value.ToString();
            txtDDD.Text = dgrDiem.CurrentRow.Cells[6].Value.ToString();
            txtDKTGK.Text = dgrDiem.CurrentRow.Cells[7].Value.ToString();
            txtDTH.Text = dgrDiem.CurrentRow.Cells[8].Value.ToString();
            txtDQT.Text = dgrDiem.CurrentRow.Cells[9].Value.ToString();
            txtDT.Text = dgrDiem.CurrentRow.Cells[10].Value.ToString();
            txtDTK.Text = dgrDiem.CurrentRow.Cells[11].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtMaSV.Text == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            }            
            else
            {                
                // Thực hiện truy vấn                
                string update = "Update DIEMSV_THEOLOP Set [MaLopM]=N'" + cboLopMon.Text + "',[MaSV]=N'" + txtMaSV.Text + "',HoTen=N'" +
                                txtHoTen.Text + "',MaMon=N'" + cboMaMon.Text + "',TenMon=N'" + cboTenMon.Text + "' ,TenKhoa=N'" +
                                cboTenKhoa.Text + "',DiemDiemDanh=N'" + txtDDD.Text + "',DiemKiemTraGiuaKi=N'" + txtDKTGK.Text + "',DiemThucHanh=N'" +
                                txtDTH.Text+  "',DiemThi=N'" + txtDT.Text  + "' where MaSV=N'" + txtMaSV.Text + "' and MaMon=N'" + cboMaMon.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load lai du lieu
                FillDataGridView_Diem();
                // Trả tài nguyên
                cmd.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDQT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Thaotac.Export2Excel(dgrDiem);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dIEMSV_THEOLOPTableAdapter.Fill(this.dataQLSV.DIEMSV_THEOLOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cboLopMonMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTenMon.Items.Clear();
            cboLopMon.Items.Clear();
            cboLopMon.Text = "";
            ////----------lấy tên môn
            string selectTenMon = "Select TenMon from MON where  MaMon=N'" + cboMaMon.Text + "'";
            SqlCommand cmdTenMon = new SqlCommand(selectTenMon, conn);
            SqlDataReader readerTenMon = cmdTenMon.ExecuteReader();
            //Add vao cboLopMon
            while (readerTenMon.Read())
            {
                cboTenMon.Text = readerTenMon.GetString(0);
            }
            //Tra tai nguyen 
            readerTenMon.Dispose();
            cmdTenMon.Dispose();
            ////----------kết thúc lấy tên môn

            string select = "Select MaLopM from LOPMON where MaMon='" + cboMaMon.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboLopMon.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cboTenKhoa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTenMon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboLopMon.Items.Clear();
            cboLopMon.Text = "";

            cboMaMon.Items.Clear();
            cboMaMon.Text = "";
            cboTenMon.Items.Clear();
            cboTenMon.Text = "";
            
            string select = "select MaMon from MON where MaKhoa =(select MaKhoa from KHOA where TenKhoa = N'" + cboTenKhoa.Text + "')";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //Add vao cboLopMon
            while (reader.Read())
            {
                cboMaMon.Items.Add(reader.GetString(0));
            }
            //Tra tai nguyen 
            reader.Dispose();
            cmd.Dispose();

            string select1 = "select TenMon from MON where MaKhoa =(select MaKhoa from KHOA where TenKhoa = N'" + cboTenKhoa.Text + "')";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            //Add vao cboLopMon
            while (reader1.Read())
            {
                cboTenMon.Items.Add(reader1.GetString(0));
            }
            //Tra tai nguyen 
            reader1.Dispose();
            cmd1.Dispose();

            //hiển thị
            // Thực hiện truy vấn
            string select0 = "Select * From DIEMSV_THEOLOP Where TenKhoa=N'" + cboTenKhoa.Text + "'";
            SqlCommand cmd0 = new SqlCommand(select0, conn);

            // Tạo đối tượng DataSet
            DataSet ds0 = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter0 = new SqlDataAdapter();
            adapter0.SelectCommand = cmd0;

            // Fill dữ liệu từ adapter vào DataSet
            adapter0.Fill(ds0, "SINHVIEN");

            // Đưa ra DataGridView
            dgrDiem.DataSource = ds0;
            dgrDiem.DataMember = "SINHVIEN";
            cmd0.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaMon.Items.Clear();

            cboLopMon.Items.Clear();
            cboLopMon.Text = "";
            //----------lấy ma môn
             string selectMaMon = "Select MaMon from MON where TenMon=N'" + cboTenMon.Text + "'";
             SqlCommand cmdMaMon = new SqlCommand(selectMaMon, conn);
            SqlDataReader readerMaMon = cmdMaMon.ExecuteReader();
            //Add vao cboLopMon
            while (readerMaMon.Read())
            {
                cboMaMon.Text = readerMaMon.GetString(0);
            }
            //Tra tai nguyen
            readerMaMon.Dispose();
            cmdMaMon.Dispose();
            //----------kết thúc lấy tên môn

            string select = "Select MaLopM from LOPMON where MaMon=N'" + cboMaMon.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboLopMon.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();
        }

        //button ReFresh
        private void button5_Click(object sender, EventArgs e)
        {
            txtDQT.Text = "";
            txtDTK.Text = "";

            cboTenKhoa.Text = "";
            cboMaMon.Text = "";
            cboTenMon.Text = "";
            cboLopMon.Text = "";
            string sql = " select * from [Quanlydiem_SV].[dbo].[DIEMSV_THEOLOP]";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrDiem.DataSource = table;


            //Add du lieu vao cboTenKhoa
            string select1 = "Select TenKhoa from KHOA ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                cboTenKhoa.Items.Add(reader1.GetString(0));
            }
            reader1.Dispose();
            cmd1.Dispose();

            //Add du lieu vao cboMaMon
            string select2 = "Select MaMon from MON ";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cboMaMon.Items.Add(reader2.GetString(0));
            }
            reader2.Dispose();
            cmd2.Dispose();

            //Add du lieu vao cboTenMon
            string select3 = "Select TenMon from MON ";
            SqlCommand cmd3 = new SqlCommand(select3, conn);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                cboTenMon.Items.Add(reader3.GetString(0));
            }
            reader3.Dispose();
            cmd3.Dispose();

            //Add du lieu vao cboLopMon
            string select4 = "Select MaLopM from LOPMON ";
            SqlCommand cmd4 = new SqlCommand(select4, conn);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                cboLopMon.Items.Add(reader4.GetString(0));
            }
            reader4.Dispose();
            cmd4.Dispose();

            //Load lai du lieu
            FillDataGridView_Diem();
        }
    }
}
