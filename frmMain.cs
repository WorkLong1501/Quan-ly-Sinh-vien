using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNQuanLySV
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        public frmMain()
        {
            InitializeComponent();
        }
        public static bool kt1, kt2;

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

        private void mnuDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void mnuQuanlinguoidung_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQuanLyNguoiDung")
                {
                    f.Activate();
                    return;
                }
            }
            frmQuanLyNguoiDung frmGV = new frmQuanLyNguoiDung();
            frmGV.MdiParent = this;
            //Closeform("frmQLDiem");
            frmGV.Show();
            frmGV.Top = 0;
            frmGV.Left = 0;
        }

        private void mnuDX_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
            mnuDN.Enabled = true;
            //editMenu.Enabled = false;
            mnuDoiMK.Enabled = false;
            MnuItemDanhMuc.Enabled = false;
            mnuItemQuanli.Enabled = false;
            mnuWindows.Enabled = false;

            menuBarToolStripMenuItem.Checked = false;

            btl1.Hide();
            btl2.Hide();
            btl3.Hide();
            btl4.Hide();
            btl5.Hide();
            btl6.Hide();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMon_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmMonHoc")
                {
                    f.Activate();
                    return;
                }
            }
            frmMonHoc frm1 = new frmMonHoc();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmQLK = new frmKhoa();
            frmQLK.MdiParent = this;
            //Closeform("frmQLDiem");
            frmQLK.Show();
            frmQLK.Top = 0;
            frmQLK.Left = 0;
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmLop")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmLop = new frmLop();
            frmLop.MdiParent = this;
            //Closeform("frmQLDiem");
            frmLop.Show();
            frmLop.Top = 0;
            frmLop.Left = 0;
        }

        private void mnuSV_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLSV")
                {
                    f.Activate();
                    return;
                }
            }

            frmQLSV frm1 = new frmQLSV();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void mnuGV_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmGiangvien")
                {
                    f.Activate();
                    return;
                }
            }


            frmGiangVien frm1 = new frmGiangVien();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void mnuDiem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLDiem")
                {
                    f.Activate();
                    return;
                }
            }


            frmQLDiem frm1 = new frmQLDiem();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void mnuThongtinSV_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmTimDiemSV ")
                {
                    f.Activate();
                    return;
                }
            }


            frmTimDiemSV frm1 = new frmTimDiemSV();
            frm1.MdiParent = this;

            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void mnuDTK_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmTongKet")
                {
                    f.Activate();
                    return;
                }
            }
            Form frm1 = new frmTongKet();
            frm1.MdiParent = this;

            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void btl1_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLSV")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLSV = new frmQLSV();
            frmQLSV.MdiParent = this;
            //Closeform("frmQLSV");
            frmQLSV.Show();
            frmQLSV.Top = 0;
            frmQLSV.Left = 0;
        }

        private void btl2_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmGiangVien")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmGV = new frmGiangVien();
            frmGV.MdiParent = this;
            //Closeform("frmGiangVien");
            frmGV.Show();
            frmGV.Top = 0;
            frmGV.Left = 0;
        }

        private void btl3_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLDiem")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmQLD = new frmQLDiem();
            frmQLD.MdiParent = this;
            //Closeform("frmQLDiem");
            frmQLD.Show();
            frmQLD.Top = 0;
            frmQLD.Left = 0;
        }

        private void btl4_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmQLK = new frmKhoa();
            frmQLK.MdiParent = this;
            //Closeform("frmQLDiem");
            frmQLK.Show();
            frmQLK.Top = 0;
            frmQLK.Left = 0;
        }

        private void btl5_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmLop")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmLop = new frmLop();
            frmLop.MdiParent = this;
            //Closeform("frmQLDiem");
            frmLop.Show();
            frmLop.Top = 0;
            frmLop.Left = 0;
        }

        private void btl6_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmMonHoc")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmMon = new frmMonHoc();
            frmMon.MdiParent = this;
            //Closeform("frmQLDiem");
            frmMon.Show();
            frmMon.Top = 0;
            frmMon.Left = 0;
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void mnuItemHethong_Click(object sender, EventArgs e)
        {

        }

        private void menuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btl1.Visible = menuBarToolStripMenuItem.Checked;
            btl2.Visible = menuBarToolStripMenuItem.Checked;
            btl3.Visible = menuBarToolStripMenuItem.Checked;
            btl4.Visible = menuBarToolStripMenuItem.Checked;
            btl5.Visible = menuBarToolStripMenuItem.Checked;
            btl6.Visible = menuBarToolStripMenuItem.Checked;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
