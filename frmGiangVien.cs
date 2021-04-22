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
    public partial class frmGiangVien : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //chua co code
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQLSV.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.dataQLSV.GIANGVIEN);           
            
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sql = "select * from [Quanlydiem_SV].[dbo].[GIANGVIEN]";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrDSGV.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select2 = "Select * From GIANGVIEN where MaGV='" + txtMaGV.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaGV.Text == "")
            {
                errorProvider1.SetError(txtMaGV, "Mã giảng viên không để trống!");
            }
            else if (reader2.Read())
            {
                MessageBox.Show("Bạn đã nhập trùng mã giảng viên", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                cmd2.Dispose();
                reader2.Dispose();
                string insert = "Insert Into GIANGVIEN(MaGV,TenGV,Gioitinh,Phone,Email,PhanloaiGV)" +
                                "Values(N'" + txtMaGV.Text + "',N'" + txtHoTen.Text + "',N'" + cboGioiTinh.Text + "',N'" +
                                txtPhone.Text + "',N'" + txtEmail.Text + "',N'" + cboPhanloai.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");
                cmd.Dispose();

            }
            cmd2.Dispose();
            reader2.Dispose();
            FillDataGridView_SV();
        }
        public void FillDataGridView_SV()
        {

            string select = "Select * From GIANGVIEN  ";
            SqlCommand cmd = new SqlCommand(select, conn);


            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(ds, "SINHVIEN");


            dgrDSGV.DataSource = ds;
            dgrDSGV.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from GIANGVIEN where MaGV=N'" + txtMaGV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                cmd.Dispose();
                FillDataGridView_SV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMaGV.Text == "")
                errorProvider1.SetError(txtMaGV, "Mã giảng viên không để trống!");
            else
            {
                string update = "Update GIANGVIEN Set TenGV=N'" + txtHoTen.Text + "',GioiTinh=N'" +
                                cboGioiTinh.Text + "',Phone=N'" + txtPhone.Text + "',Email=N'" +
                                txtEmail.Text + "',PhanLoaiGV=N'" + cboPhanloai.Text + "' where MaGV=N'" + txtMaGV.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                FillDataGridView_SV();
                cmd.Dispose();
            }
        }

        private void dgrDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgrDSGV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDSGV.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgrDSGV.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgrDSGV.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgrDSGV.CurrentRow.Cells[4].Value.ToString();
            cboPhanloai.Text = dgrDSGV.CurrentRow.Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
