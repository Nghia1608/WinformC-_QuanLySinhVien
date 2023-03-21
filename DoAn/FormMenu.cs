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

namespace DoAn
{
    public partial class FormMenu : Form
    {
        string tendangnhap = "", matkhau = "", quyen = "";
        public FormMenu()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        public FormMenu(string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            if (quyen == "CTSV")
            {
                btnDangKi.Visible = false;
                btnQuanLy.Visible = false;
                btnDiem.Visible = false;
                btnDiemTheoMon.Visible = false;
                btnDiemTheoMSSV.Visible = false;
                btnBXH.Visible = false;
            }
            if (quyen == "DaoTao")
            {
                btnDangKi.Visible = false;
                btnKhoa.Visible = false;
                btnLop.Visible = false;
            }
            if (quyen == "TaiChinh")
            {
                btnDangKi.Visible = false;
                btnQuanLy.Visible = false;
                btnQuanLySinhVien.Visible = false;
                btnDiemTheoMon.Visible = false;
                btnDiemTheoMSSV.Visible = false;
                btnSinhVienTheoKhoa.Visible = false;
                btnSinhVienTheoLop.Visible = false;
                btnBXH.Visible = false;
            }
        }
        private void CustomizeDesing()
        {
            panelHethong.Visible = false;
            panelQuanLy.Visible = false;
            panelQuanLySinhVien.Visible = false;
            panelXemThongTin.Visible = false;

        }
        private void HideSubMenu()
        {
            if (panelHethong.Visible == true)
                panelHethong.Visible = false;
            if (panelQuanLy.Visible == true)
                panelQuanLy.Visible = false;
            if (panelQuanLySinhVien.Visible == true)
                panelQuanLySinhVien.Visible = false;
            if (panelXemThongTin.Visible == true)
                panelXemThongTin.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelHethong);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelQuanLy);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelQuanLySinhVien);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelXemThongTin);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult XD = MessageBox.Show("Bạn có chắc muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (XD == DialogResult.Yes)
            {
                Close();
            }
            HideSubMenu();
        }

        private Form ActiveForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLSinhViencs());
            HideSubMenu();
            labelHeader.Text = "Quản lý sinh viên";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Close();
            SqlConnection conn = new SqlConnection(@"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            conn.Open();
            string sql = "select ID,Password,Quyen from TaiKhoan where ID='" + tendangnhap + "'and Password='" + matkhau + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter("select ID,Password,Quyen from TaiKhoan where ID='" + tendangnhap + "'and Password='" + matkhau + "'", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dtsv = cmd.ExecuteReader();

            FormDoiMatKhau form =  new FormDoiMatKhau(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
            form.ShowDialog();

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            Close();
            FormThemTaiKhoan form = new FormThemTaiKhoan();
            form.ShowDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult XD = MessageBox.Show("Bạn có chắc muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (XD == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
                OpenChildForm(new QLKhoa());
                HideSubMenu();
                labelHeader.Text = "Quản lý khoa";
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
                OpenChildForm(new QLMonHoc());
                HideSubMenu();
                labelHeader.Text = "Quản lý môn học";
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLLop());
            HideSubMenu();
            labelHeader.Text = "Quản lý lớp";
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLSinhViencs());
            HideSubMenu();
            labelHeader.Text = "Quản lý sinh viên";
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            HideSubMenu();
        }

        private void btnDiemRenLuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDiemRenLuyen());
            HideSubMenu();
            labelHeader.Text = "Điểm rèn luyện";
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportBXH());
            HideSubMenu();
            labelHeader.Text = "Bảng xếp hạng";
        }

        private void btnDiemTheoMSSV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportDiemSV());
            HideSubMenu();
            labelHeader.Text = "Xem điểm theo mã sinh viên";
        }

        private void btnDiemTheoMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemDiemTheoMon());
            HideSubMenu();
            labelHeader.Text = "Xem điểm theo môn học";
        }

        private void btnSinhVienTheoKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportSVKhoa());
            HideSubMenu();
            labelHeader.Text = "Sinh viên theo khoa";
        }

        private void btnSinhVienTheoLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportSVLop());
            HideSubMenu();
            labelHeader.Text = "Sinh viên theo lớp";
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLHocPhi());
            HideSubMenu();
            labelHeader.Text = "Quản lý học phí";
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLGiangVien());
            HideSubMenu();
            labelHeader.Text = "Quản lý giảng viên";
        }

        private void panelXemThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportNhomMH());
            HideSubMenu();
            labelHeader.Text = "Xem thông tin nhóm môn học";
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDiem());
            HideSubMenu();
            labelHeader.Text = "Quản lý điểm môn học";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLTimKiem());
            HideSubMenu();
            labelHeader.Text = "Tìm kiếm";
        }
    }
}
