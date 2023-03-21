using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;
using DoAn.Model;

namespace DoAn
{

    public partial class QLHocPhi : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        string flag;
        public QLHocPhi()
        {
            InitializeComponent();
        }

        private void QLHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLDiem1.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.dataSetQLDiem1.SinhVien);
            // TODO: This line of code loads data into the 'dataSetQLDiem1.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.dataSetQLDiem1.Lop);
            this.khoaTableAdapter.Fill(this.dataSetQLDiem1.Khoa);
            ketnoi = new SqlConnection(chuoiketnoi);

            List<SinhVien> listSinhVien = dbContent.SinhVien.ToList();
            List<Lop> listLop = dbContent.Lop.ToList();
            List<Khoa> listKhoa = dbContent.Khoa.ToList();

            cbbMaKhoa.SelectedIndex = -1;

        }

        private void FillDataDGV_HocPhi(List<HocPhi> listHocPhi)
        {
            var newlistSV = (from x in dbContent.SinhVien
                             from z in dbContent.Lop
                             from y in dbContent.Khoa
                             from t in dbContent.HocPhi
                             where
                             t.MSSV.CompareTo(cbbMSSV.Text.ToString()) == 0
                            && (cbbHocKi.Text.ToString() == "" || t.HocKy.TenHocKy.Contains(cbbHocKi.Text.ToString()) )    // lớp

                             && x.MaLop == z.MaLop && z.MaKhoa == y.MaKhoa && x.MSSV == t.MSSV
                             select new
                             {
                                 Mã_Sinh_Viên = x.MSSV,
                                 MaHocPhiSV = t.MaHocPhi,
                                 SoTienHp = t.SoTien,
                                 Tên_lớp = x.MaLop,
                                 Khoa = y.TenKhoa,
                                 TrangThai = t.TrangThai,
                                 HocKy = t.HocKy.TenHocKy

                             }
            ).Distinct().ToList();
            dgvHocPhi.Rows.Clear();
            foreach (var item in newlistSV)
            {
                int newRow = dgvHocPhi.Rows.Add();
                dgvHocPhi.Rows[newRow].Cells[0].Value = item.Mã_Sinh_Viên;
                dgvHocPhi.Rows[newRow].Cells[3].Value = item.MaHocPhiSV;
                if (item.SoTienHp == 0)
                {
                    dgvHocPhi.Rows[newRow].Cells[4].Value = "0 VND";
                }

                if (item.SoTienHp.ToString().Length == 6)
                {
                    dgvHocPhi.Rows[newRow].Cells[4].Value = $"{item.SoTienHp.ToString().Substring(0, 3)},{item.SoTienHp.ToString().Substring(3, 3)},VND";
                }

                if (item.SoTienHp.ToString().Length == 7)
                {
                    dgvHocPhi.Rows[newRow].Cells[4].Value = $"{item.SoTienHp.ToString().Substring(0, 1)},{item.SoTienHp.ToString().Substring(1, 3)},{item.SoTienHp.ToString().Substring(3, 3)},VND";
                }
                if (item.SoTienHp.ToString().Length == 8)
                {
                    dgvHocPhi.Rows[newRow].Cells[4].Value = $"{item.SoTienHp.ToString().Substring(0, 2)},{item.SoTienHp.ToString().Substring(2, 3)},{item.SoTienHp.ToString().Substring(5, 3)},VND";
                }

                dgvHocPhi.Rows[newRow].Cells[1].Value = item.Tên_lớp;
                dgvHocPhi.Rows[newRow].Cells[2].Value = item.Khoa;
                dgvHocPhi.Rows[newRow].Cells[5].Value = item.HocKy;
                dgvHocPhi.Rows[newRow].Cells[6].Value = item.TrangThai;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbMSSV.SelectedIndex == -1 || cbbMSSV.Text == "")
            {
                MessageBox.Show($"Hay chon MSSV", "Thong bao");
            }
            else
            {
                List<HocPhi> listHocPhi = dbContent.HocPhi.ToList();
                FillDataDGV_HocPhi(listHocPhi);
            }
        }
        string chuoiketnoi = @"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        int j = 0;
        string sql;
        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMaLop.Items.Clear();
            ketnoi.Open();
            sql = @"Select Khoa.MaKhoa,Lop.MaLop
                    From    Khoa Join Lop
                    On Khoa.MaKhoa = Lop.MaKhoa
                    Where (Khoa.MaKhoa = N'" + cbbMaKhoa.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                cbbMaLop.Items.Add(docdulieu[1].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMSSV.Items.Clear();
            ketnoi.Open();
            sql = @"Select Lop.MaLop,SinhVien.MSSV
                    From    Lop Join SinhVien
                    On Lop.MaLop = SinhVien.MaLop
                    Where (Lop.MaLop = N'" + cbbMaLop.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            j = 0;
            while (docdulieu.Read())
            {
                cbbMSSV.Items.Add(docdulieu[1].ToString());
                j++;
            }
            ketnoi.Close();
        }

        private void dgvHocPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
