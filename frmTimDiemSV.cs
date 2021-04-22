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
    public partial class frmTimDiemSV : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmTimDiemSV()
        {
            InitializeComponent();
        }

        private void frmTimDiemSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQLSV1.DIEMSV_THEOLOP' table. You can move, or remove it, as needed.
            this.dIEMSV_THEOLOPTableAdapter1.Fill(this.dataQLSV1.DIEMSV_THEOLOP);
            
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sql = "select * from [Quanlydiem_SV].[dbo].[DIEMSV_THEOLOP]";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrDIEMSV.DataSource = table;

            //Add du lieu vao cboKhoaHoc
            string select = "Select TenKhoa from KHOA ";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                cboKhoa.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Thaotac.Export2Excel(dgrDIEMSV);
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonHoc.Items.Clear();
            cboMonHoc.Text = "";
            txtMaSV.Text = "";
            string select = "select TenMon from MON where MaKhoa = (SELECT [MaKhoa] FROM [Quanlydiem_SV].[dbo].[KHOA]where TenKhoa = N'" + cboKhoa.Text + "')";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //Add vao cboLop
            while (reader.Read())
            {
                cboMonHoc.Items.Add(reader.GetString(0));
            }
            //Tra tai nguyen 
            reader.Dispose();
            cmd.Dispose();
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            String select = "Select * From DIEMSV_THEOLOP Where TenMon=N'" + cboMonHoc.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrDIEMSV.DataSource = ds;
            dgrDIEMSV.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void dgrDIEMSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaSV.Text = dgrDIEMSV.CurrentRow.Cells[2].Value.ToString();
            //txtMaGV.Text = dgrMON.CurrentRow.Cells[3].Value.ToString();            
            cboMonHoc.Text = dgrDIEMSV.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String select;
            if(cboMonHoc.Text == "")
            {
                 select = "Select * from DIEMSV_THEOLOP where Tenkhoa=N'" + cboKhoa.Text + "'";
            }
            else
            {
                 select = "Select * From DIEMSV_THEOLOP Where TenMon=N'" + cboMonHoc.Text + "'";
            }
            if (txtMaSV.Text != "")
                select = "Select * From DIEMSV_THEOLOP Where MaSV=N'" + txtMaSV.Text + "'";

            // Thực hiện truy vấn

            SqlCommand cmd = new SqlCommand(select, conn);
            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrDIEMSV.DataSource = ds;
            dgrDIEMSV.DataMember = "SINHVIEN";
            cmd.Dispose();
        }
    }
}
