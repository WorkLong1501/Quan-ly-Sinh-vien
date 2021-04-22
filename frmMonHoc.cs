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
    public partial class frmMonHoc : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataQLSV.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Fill(this.dataQLSV.MON);

            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sqlkhoa = "select * from  [Quanlydiem_SV].[dbo].[MON]";
            SqlCommand comand = new SqlCommand(sqlkhoa, conn);
            SqlDataAdapter sqlcom = new SqlDataAdapter(comand);
            DataTable table = new DataTable();
            sqlcom.Fill(table);
            dgrMON.DataSource = table;

            string select = "Select MaKhoa from KHOA ";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboKhoa.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select1 = "Select MaMon from MON where MaMon=N'" + txtMaMon.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaMon.Text == "")
            {
                errorProvider1.SetError(txtMaMon, "Mã môn không để trống!");
            }
            else if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn đã nhập thông tin cho môn: " + txtTenMon.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMon.Focus();
                }
                //Tra tai nguyen 
                reader1.Dispose();
                cmd1.Dispose();
            }
            else
            {
                reader1.Dispose();
                cmd1.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into MON(MaMon,TenMon,SoDVHT,MaKhoa,MaHK)" +
                "Values(N'" + txtMaMon.Text + "',N'" + txtTenMon.Text + "',N'" + txtSDVHT.Text + "',N'"
                + cboKhoa.Text + "',N'" + txtHocKy.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");
                // Trả tài nguyên
                cmd.Dispose();
                //Fill du lieu vao Database
                FillDataGridView_MON();
            }
            reader1.Dispose();
            cmd1.Dispose();
        }
        public void FillDataGridView_MON()
        {
            // Thực hiện truy vấn
            string select = "Select * From MON  ";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrMON.DataSource = ds;
            dgrMON.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            string update = "Update MON Set TenMon=N'" + txtTenMon.Text + "',SoDVHT=N'" +
                            txtSDVHT.Text +  "',MaHK=N'" +
                            txtHocKy.Text + "',MaKhoa=N'" + cboKhoa.Text + "' where MaMon=N'" + txtMaMon.Text + "' ";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Load lai du lieu
            FillDataGridView_MON();
            // Trả tài nguyên
            cmd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete = "delete from MON where MaMon=N'" + txtMaMon.Text + "' ";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");


            cmd.Dispose();

            FillDataGridView_MON();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrMON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dgrMON.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dgrMON.CurrentRow.Cells[1].Value.ToString();
            txtSDVHT.Text = dgrMON.CurrentRow.Cells[2].Value.ToString();
            //txtMaGV.Text = dgrMON.CurrentRow.Cells[3].Value.ToString();            
            txtHocKy.Text = dgrMON.CurrentRow.Cells[4].Value.ToString();
            cboKhoa.Text = dgrMON.CurrentRow.Cells[3].Value.ToString();

        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHocKy.Text = "";
            txtMaMon.Text = "";
            txtSDVHT.Text = "";
            txtTenMon.Text = "";
            // Thực hiện truy vấn
            string select = "Select * From MON Where MaKhoa='" + cboKhoa.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrMON.DataSource = ds;
            dgrMON.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            string select = "select * from  [Quanlydiem_SV].[dbo].[MON]";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrMON.DataSource = ds;
            dgrMON.DataMember = "SINHVIEN";
            cmd.Dispose();
        }
    }
}
