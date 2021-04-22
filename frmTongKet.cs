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
    public partial class frmTongKet : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmTongKet()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmTongKet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQLSV1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dataQLSV1.SINHVIEN);
            // TODO: This line of code loads data into the 'dataQLSV1.HOCLUC' table. You can move, or remove it, as needed.
            this.hOCLUCTableAdapter.Fill(this.dataQLSV1.HOCLUC);
            // TODO: This line of code loads data into the 'dataQLSV1.DIEMTONGKET1' table. You can move, or remove it, as needed.
            this.dIEMTONGKET1TableAdapter.Fill(this.dataQLSV1.DIEMTONGKET1);
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sql = " select * from [Quanlydiem_SV].[dbo].[DIEMTONGKET1]";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrDiem.DataSource = table;

            //Add du lieu vao cboMSV
            string select = "Select MaSV from SINHVIEN ";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboMSV.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();

            //Add du lieu vao cboMaLop
            string select1 = "Select MaLop from LOPQL ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                cboMaLop.Items.Add(reader1.GetString(0));
            }
            reader1.Dispose();
            cmd1.Dispose();
            
            //Load lai du lieu
            FillDataGridView_Diem();
        }

        private void FillDataGridView_Diem()
        {
            // Thực hiện truy vấn
            string select = "Select * From DIEMTONGKET1  ";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboMaLop.Items.Clear();
            //cboMaLop.Text = "";
            //txtHoTen.Items.Clear();
            //txtHoTen.Text = "";
            //txtTenLop.Items.Clear();
            //txtTenLop.Text = "";
            //cboHK.Items.Clear();
            //cboHK.Text = "";
             
            // Thực hiện truy vấn
            string select0 = "Select * From DIEMTONGKET1 Where MaSV=N'" + cboMSV.Text + "'";
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

        private void dgrDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMSV.Text = dgrDiem.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDiem.CurrentRow.Cells[1].Value.ToString();
            cboMaLop.Text = dgrDiem.CurrentRow.Cells[2].Value.ToString();
            txtTenLop.Text = dgrDiem.CurrentRow.Cells[3].Value.ToString();
            txtDCK.Text = dgrDiem.CurrentRow.Cells[4].Value.ToString();
            //txtHocLuc.Text = dgrDiem.CurrentRow.Cells[6].Value.ToString();
            //txtHocLuc.Text = dgrDiem.CurrentRow.Cells[5].Value.ToString();            
        }

        private void txtHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String select = "Select * from DIEMTONGKET1 ";
            if (cboMaLop.Text != "")
            {
                select = "Select * from DIEMTONGKET1 where MaLop=N'" + cboMaLop.Text + "'";
            }            
            if (cboMSV.Text != "")
                select = "Select * From DIEMTONGKET1 Where MaSV=N'" + cboMSV.Text + "'";
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
            dgrDiem.DataSource = ds;
            dgrDiem.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMSV.Items.Clear();
            cboMSV.Text = "";

            //Add du lieu vao cboMaLop
            string select1 = "Select MaSV from SINHVIEN where MaLop = N'" + cboMaLop.Text + "'";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                cboMSV.Items.Add(reader1.GetString(0));
            }
            reader1.Dispose();
            cmd1.Dispose();


            // Thực hiện truy vấn
            string select0 = "Select * From DIEMTONGKET1 Where MaLop=N'" + cboMaLop.Text + "'";
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
    }
}
