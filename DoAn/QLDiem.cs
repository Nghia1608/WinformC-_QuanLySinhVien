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
    public partial class QLDiem : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        // khoi tao các biến temp
        string flag;

        public QLDiem()
        {
            InitializeComponent();
        }

        public void LockTxt(bool val)   //khóa text , cbb
        {
            cbbMaMon.Enabled = !val;
            txtDiemQuaTrinh.Enabled = !val;
            txtDiemThi.Enabled = !val;
        }
        public void SetButton(bool val)     // khóa nút
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnQuayVe.Enabled = val;
        }
        public void SetButton_ForLocBtn(bool val)     // khóa nút
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = val;
            btnHuy.Enabled = val;
            btnQuayVe.Enabled = !val;
        }
        private void QLDiem_Load(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.dataSetQLDiem.SinhVien);
            this.lopTableAdapter.Fill(this.dataSetQLDiem.Lop);
            this.khoaTableAdapter.Fill(this.dataSetQLDiem.Khoa);
            ketnoi = new SqlConnection(chuoiketnoi);

            List<MonHoc> listMonHoc = dbContent.MonHoc.ToList();
            List<HocKy> listHocKy = dbContent.HocKy.ToList();

            labelShow.Text = "";

            SetButton(true);
            LockTxt(true);

            FillDataCBB_MonHoc(listMonHoc);
            FillDataCBB_HocKi(listHocKy);

            cbbMaKhoa.SelectedIndex = -1;

            this.dgvQLDiem.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            this.dgvQLDiem.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);

        }

        private void FillDataCBB_HocKi(List<HocKy> listHocKy)
        {
            cbbHocKi.DataSource = listHocKy;         // cbb hoc ky
            cbbHocKi.DisplayMember = "TenHocKy";
            cbbHocKi.ValueMember = "TenHocKy";
        }       //load mã các học kì từ ds môn vào cbb
        private void FillDataCBB_MonHoc(List<MonHoc> listMonHoc)           //load mã và tên các môn học từ ds môn vào cbb
        {
            cbbMaMon.DataSource = listMonHoc;         // cbb ma mon
            cbbMaMon.DisplayMember = "MaMon";
            cbbMaMon.ValueMember = "MaMon";
        }

        private void FillDataDGV_Diem(List<Diem> listDiem)           //load data vao dgv
        {
            dgvQLDiem.Rows.Clear();
            var newlistSV = (from x in dbContent.Diem
                             where
                             (x.MSSV == cbbMSSV.SelectedItem.ToString()
                             && (x.HocKy.TenHocKy == cbbHocKi.SelectedValue.ToString())
                            )       // kiem theo ma   // khoa
                             select new
                             {
                                 MSSV1 = x.MSSV,
                                 MaMon1 = x.MaMon,
                                 LanThi1 = x.LanThi,
                                 DiemQuaTrinh1 = x.DiemQuaTrinh,
                                 DiemThi1 = x.DiemThi,
                                 DiemTongKet1 = x.DiemTongKet,
                                 DiemChu1 = x.DiemChu,
                                 KetQua1 = x.KetQua,
                                 TinhTrang1 = x.TinhTrang,
                                 MaHocKy1 = x.HocKy.TenHocKy
                             }
                         ).ToList();
            foreach (var item in newlistSV)
            {
                int newRow = dgvQLDiem.Rows.Add();        //them 1 dong moi
                dgvQLDiem.Rows[newRow].Cells[0].Value = item.MSSV1;
                dgvQLDiem.Rows[newRow].Cells[1].Value = item.MaMon1;
                dgvQLDiem.Rows[newRow].Cells[2].Value = item.LanThi1;
                dgvQLDiem.Rows[newRow].Cells[3].Value = item.DiemQuaTrinh1;
                dgvQLDiem.Rows[newRow].Cells[4].Value = item.DiemThi1;
                dgvQLDiem.Rows[newRow].Cells[5].Value = item.DiemTongKet1;
                dgvQLDiem.Rows[newRow].Cells[6].Value = item.DiemChu1;
                dgvQLDiem.Rows[newRow].Cells[7].Value = item.KetQua1;
                dgvQLDiem.Rows[newRow].Cells[8].Value = item.TinhTrang1;
                dgvQLDiem.Rows[newRow].Cells[9].Value = item.MaHocKy1;
                txtTong.Text = (dgvQLDiem.Rows.Count - 1).ToString();
            }
        }
        private Boolean CheckMSSV()        // kt ma so sv , bang True la co sv
        {
            string temp = "";
            var newlistSV = (from t in dbContent.Diem
                             where (t.MSSV == cbbMSSV.SelectedItem.ToString())
                             select new
                             {
                                 MaSV = t.MSSV
                             }).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = item.MaSV;
            }
            if (temp == "" || temp == null)
            {
                return false;
            }
            else
            {
                return true;    // co sv
            }
        }
        private Boolean CheckMaMon()        // lấy mã môn học CBB đang chọn từ CSDL  ,table Điểm
        {
            string temp = "";
            var newlistSV = (
                 from t in dbContent.Diem
                 where (
                    t.MSSV == cbbMSSV.SelectedItem.ToString()
                    && t.MaMon == cbbMaMon.SelectedValue.ToString()
                 )
                 select new
                 {
                     MaMonHoc = t.MaMon
                 }
                 ).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = item.MaMonHoc;
            }
            if (temp == "" || temp == null)
            {
                return false;
            }
            else
            {
                return true;    // co mon hoc
            }
        }
        private int CheckLanThi()        // lấy số lần thi gần nhất của môn học và mã sv đang chọn
        {
            int temp = 0;
            var newlistSV = (from t in dbContent.Diem
                             where (t.MSSV == cbbMSSV.SelectedItem.ToString()
                     && t.MaMon == cbbMaMon.SelectedValue.ToString())  // ket thuc where
                             group t by new { t.LanThi } into g
                             orderby g.Max(p => p.LanThi) descending
                             select new
                             {
                                 LanThi = g.Max(p => p.LanThi),
                             }
                 ).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = item.LanThi;
            }
            return temp;
        }

        private void TinhTotNghiep()
        {
            double tempDiem = 0;
            int tempTinChi = 0;
            var tongTinChi = (from x in dbContent.Diem
                              from y in dbContent.MonHoc
                              where (x.MSSV == cbbMSSV.SelectedItem.ToString()
                              && x.KetQua == "Đạt"
                              && x.LanThi == (
                                      from x1 in dbContent.Diem
                                      where x1.MSSV == x.MSSV
                                      && x1.MaMon == x.MaMon
                                      && x1.MaMon == y.MaMon
                                      group x1 by new { x1.LanThi } into g1
                                      orderby g1.Max(p => p.LanThi) descending
                                      select new
                                      {
                                          LanThiMax = g1.Max(p => p.LanThi)
                                      }
                                  ).Max(p => p.LanThiMax))
                              group y by new { y.SoTinChi } into g

                              select new
                              {
                                  TongTinChi = g.Sum(p => p.SoTinChi)

                              });
            foreach (var item in tongTinChi)
            {
                tempTinChi = item.TongTinChi;
            }
            var tongDiemTB = (from x in dbContent.Diem
                              from y in dbContent.MonHoc
                              where (x.MSSV == cbbMSSV.SelectedItem.ToString()
                              && x.KetQua == "Đạt"
                              && x.LanThi == (
                                      from x1 in dbContent.Diem
                                      where x1.MSSV == x.MSSV
                                      && x1.MaMon == x.MaMon
                                      && x1.MaMon == y.MaMon
                                      group x1 by new { x1.LanThi } into g1
                                      orderby g1.Key.LanThi descending
                                      select new
                                      {
                                          LanThiMax = g1.Key.LanThi
                                      }
                                  ).Max(p => p.LanThiMax))
                              group x by new { x.MSSV } into g

                              select new
                              {
                                  TongDiem = g.Average(p => p.DiemTongKet)

                              });
            foreach (var item in tongDiemTB)
            {
                tempDiem = item.TongDiem;
            }
            //cập nhật table Tốt nghiệp mỗi lần thao tác với điểm sv
            TotNghiep SVTotNghiep1 = dbContent.TotNghiep.Where(p => p.MSSV == cbbMSSV.SelectedItem.ToString()).FirstOrDefault();
            SVTotNghiep1.TongDiem = tempDiem;
            SVTotNghiep1.SoTinChi = tempTinChi;
            if (tempDiem < 10.0)
            {
                SVTotNghiep1.XepLoai = "Xuất sắc";
            }
            if (tempDiem < 9.0)
            {
                SVTotNghiep1.XepLoai = "Giỏi";
            }
            if (tempDiem < 8.0)
            {
                SVTotNghiep1.XepLoai = "Khá";
            }
            if (tempDiem < 6.25)
            {
                SVTotNghiep1.XepLoai = "Trung bình";
            }
            if (tempDiem < 5.0)
            {
                SVTotNghiep1.XepLoai = "Chưa đạt";
            }
            dbContent.TotNghiep.AddOrUpdate(SVTotNghiep1);
            dbContent.SaveChanges();
            if (tempTinChi >= 15)
            {
                SinhVien SVTotNghiep = dbContent.SinhVien.Where(p => p.MSSV == cbbMSSV.SelectedItem.ToString()).FirstOrDefault();
                SVTotNghiep.TrangThai = "Đã tốt nghiệp";
                dbContent.SinhVien.AddOrUpdate(SVTotNghiep);
                dbContent.SaveChanges();
                MessageBox.Show($"SV" + cbbMSSV.SelectedItem.ToString() + "đã tốt nghiệp với số điểm" + tempDiem);

            }
        }
        int tempHocKy = 0;
        private Boolean CheckHocKy()        //true là học kỳ môn học lần trước nhỏ hơn hoặc bằng kỳ hiện tại
        {
            int temp = 0;
            int tempLanThi = CheckLanThi();
            var newlistSV = (from t in dbContent.Diem
                             where (t.MSSV == cbbMSSV.SelectedItem.ToString()
                             && t.MaMon == cbbMaMon.SelectedValue.ToString()
                             && t.LanThi == tempLanThi)  // ket thuc where
                             select new
                             {
                                 HocKyTruoc = t.MaHocKy,
                             }
                 ).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = Convert.ToInt32(item.HocKyTruoc);
            }
            tempHocKy = Convert.ToInt32((cbbHocKi.SelectedIndex + 1).ToString());   // lấy index của học kì lần trước
            if (temp < Convert.ToInt32((cbbHocKi.SelectedIndex + 1).ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean CheckTinhTrang()        //true là lần trước kết quả đạt
        {
            string temp = "";
            int tempLanThi = CheckLanThi();
            var newlistSV = (from t in dbContent.Diem
                             where (t.MSSV == cbbMSSV.SelectedItem.ToString()
                             && t.MaMon == cbbMaMon.SelectedValue.ToString()
                             && t.LanThi == tempLanThi)  // ket thuc where
                             select new
                             {
                                 KetQuaTruoc = t.KetQua,
                             }
                 ).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = item.KetQuaTruoc;
            }
            if (temp == "Đạt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean CheckGioiHanHoc()        //true là đã học cải thiện
        {
            string temp = "";
            int tempLanThi = CheckLanThi();
            var newlistSV = (from t in dbContent.Diem
                             where (t.MSSV == cbbMSSV.SelectedItem.ToString()
                             && t.MaMon == cbbMaMon.SelectedValue.ToString()
                             && t.LanThi == tempLanThi)  // ket thuc where
                             select new
                             {
                                 KetQuaTruoc = t.TinhTrang,
                             }
                 ).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = item.KetQuaTruoc;
            }
            if (temp == "Học cải thiện")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckDataInput()           // kiem tra du lieu dau vao
        {
            if (cbbMSSV.SelectedIndex == -1 || cbbMSSV.Text == "")
            {
                MessageBox.Show("Hãy chọn sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDiemQuaTrinh.Text == "" || txtDiemThi.Text == "")
            {
                MessageBox.Show("Dữ liệu điểm phải là số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((string)cbbMSSV.SelectedValue == "" || (string)cbbMaMon.SelectedValue == "" || (string)cbbHocKi.SelectedValue == "")
            {
                MessageBox.Show("Dữ liệu không có MSSV hoặc Mã môn học hoặc Mã Học Kỳ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToDouble(txtDiemQuaTrinh.Text) < 0 || Convert.ToDouble(txtDiemQuaTrinh.Text) > 10
                || Convert.ToDouble(txtDiemThi.Text) < 0 || Convert.ToDouble(txtDiemThi.Text) > 10)
            {
                MessageBox.Show("Giá trị điểm không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        //C
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            labelShow.Text = "Hiện đang chọn chức năng thêm";
            cbbMSSV.Focus();
            cbbMaMon.Focus();
            flag = "them";
            LockTxt(false);
            SetButton(false);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            labelShow.Text = "Hiện đang chọn chức năng sửa";
            cbbMSSV.Focus();
            cbbMaMon.Focus();
            flag = "sua";
            LockTxt(false);
            SetButton(false);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            labelShow.Text = "Hiện đang chọn chức năng xóa";
            cbbMSSV.Focus();
            cbbMaMon.Focus();
            flag = "xoa";
            LockTxt(false);
            SetButton(false);

        }

        private void dgvQLDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowi = e.RowIndex;
            if (rowi < 0 || rowi >= dgvQLDiem.Rows.Count)
            {
                return;
            }
            else
            {
                dgvQLDiem.CurrentRow.Selected = true;
                cbbMSSV.SelectedItem = dgvQLDiem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cbbMaMon.SelectedValue = dgvQLDiem.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtDiemQuaTrinh.Text = dgvQLDiem.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtDiemThi.Text = dgvQLDiem.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                cbbHocKi.SelectedIndex = cbbHocKi.FindString(dgvQLDiem.Rows[e.RowIndex].Cells[9].FormattedValue.ToString());
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
            cbbMaLop.Text = null;
            cbbMaLop.SelectedIndex = -1;
            cbbMSSV.Items.Clear();
            cbbMSSV.SelectedIndex = -1;
            //    cbbMSSV.Text = null;
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
            cbbMSSV.SelectedIndex = -1;
            //    cbbMSSV.Text = null;
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
        private void cbbMSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButton_ForLocBtn(false);     // mỗi khi đổi học kì..sẽ khóa hết nút tránh sai sót
                                            // su dung nút lọc kết quả rồi mở
        }
        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDiemQuaTrinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "them")
            {
                if (CheckDataInput() == true)       // check đúng kiểu dữ liệu
                {
                    if (CheckMSSV() == false)        // sv chưa có trong danh s
                    {
                        Diem newDiem = new Diem();
                        newDiem.MSSV = cbbMSSV.SelectedItem.ToString();
                        newDiem.MaMon = cbbMaMon.SelectedValue.ToString();
                        newDiem.DiemQuaTrinh = Convert.ToDouble(txtDiemQuaTrinh.Text);
                        newDiem.DiemThi = Convert.ToDouble(txtDiemThi.Text);
                        newDiem.DiemTongKet = (Convert.ToDouble(txtDiemThi.Text) + Convert.ToDouble(txtDiemQuaTrinh.Text)) / 2;
                        newDiem.MaHocKy = (cbbHocKi.SelectedIndex + 1).ToString();
                        if (newDiem.DiemTongKet < 10)
                        {
                            newDiem.DiemChu = "A";
                        }
                        if (newDiem.DiemTongKet <= 8.4)
                        {
                            newDiem.DiemChu = "B+";
                        }
                        if (newDiem.DiemTongKet <= 7.7)
                        {
                            newDiem.DiemChu = "B";
                        }
                        if (newDiem.DiemTongKet <= 6.9)
                        {
                            newDiem.DiemChu = "C+";
                        }
                        if (newDiem.DiemTongKet <= 6.2)
                        {
                            newDiem.DiemChu = "C";
                        }
                        if (newDiem.DiemTongKet <= 5.4)
                        {
                            newDiem.DiemChu = "D+";
                        }
                        if (newDiem.DiemTongKet <= 4.7)
                        {
                            newDiem.DiemChu = "D";
                        }
                        if (newDiem.DiemTongKet <= 3.9)
                        {
                            newDiem.DiemChu = "F+";
                        }
                        if (newDiem.DiemTongKet <= 2.9)
                        {
                            newDiem.DiemChu = "F";
                        }
                        //tinh kết quả
                        if (newDiem.DiemTongKet >= 4.0)
                        {
                            newDiem.KetQua = "Đạt";
                        }
                        if (newDiem.DiemTongKet < 4.0)
                        {
                            newDiem.KetQua = "Chưa đạt";
                        }
                        newDiem.TinhTrang = "Học mới";
                        newDiem.LanThi = 1;
                        //dua data xuong db va luu
                        dbContent.Diem.AddOrUpdate(newDiem);
                        dbContent.SaveChanges();
                        MessageBox.Show($"Thêm điểm thành công - check mssv!", "Thông báo");
                    }
                    else                        // sv đã có trong ds...giờ check mã môn để k trùng môn học
                    {
                        if (CheckMaMon() == false)     // chưa có môn này
                        {
                            Diem newDiem = new Diem();
                            newDiem.MSSV = cbbMSSV.SelectedItem.ToString();
                            newDiem.MaMon = cbbMaMon.SelectedValue.ToString();
                            newDiem.DiemQuaTrinh = Convert.ToDouble(txtDiemQuaTrinh.Text);
                            newDiem.DiemThi = Convert.ToDouble(txtDiemThi.Text);
                            newDiem.DiemTongKet = (Convert.ToDouble(txtDiemThi.Text) + Convert.ToDouble(txtDiemQuaTrinh.Text)) / 2;
                            newDiem.MaHocKy = (cbbHocKi.SelectedIndex + 1).ToString();
                            if (newDiem.DiemTongKet < 10)
                            {
                                newDiem.DiemChu = "A";
                            }
                            if (newDiem.DiemTongKet <= 8.4)
                            {
                                newDiem.DiemChu = "B+";
                            }
                            if (newDiem.DiemTongKet <= 7.7)
                            {
                                newDiem.DiemChu = "B";
                            }
                            if (newDiem.DiemTongKet <= 6.9)
                            {
                                newDiem.DiemChu = "C+";
                            }
                            if (newDiem.DiemTongKet <= 6.2)
                            {
                                newDiem.DiemChu = "C";
                            }
                            if (newDiem.DiemTongKet <= 5.4)
                            {
                                newDiem.DiemChu = "D+";
                            }
                            if (newDiem.DiemTongKet <= 4.7)
                            {
                                newDiem.DiemChu = "D";
                            }
                            if (newDiem.DiemTongKet <= 3.9)
                            {
                                newDiem.DiemChu = "F+";
                            }
                            if (newDiem.DiemTongKet <= 2.9)
                            {
                                newDiem.DiemChu = "F";
                            }
                            //tinh kết quả
                            if (newDiem.DiemTongKet >= 4.0)
                            {
                                newDiem.KetQua = "Đạt";
                            }
                            if (newDiem.DiemTongKet < 4.0)
                            {
                                newDiem.KetQua = "Chưa đạt";
                            }
                            newDiem.TinhTrang = "Học mới";
                            newDiem.LanThi = 1;
                            // tinh tình trạng (lần đầu , cải thiện , rớt,học lại)
                            //dua data xuong db va luu
                            dbContent.Diem.AddOrUpdate(newDiem);
                            dbContent.SaveChanges();
                            MessageBox.Show($"Thêm điểm thành công -check lan thi bang 1!", "Thông báo");
                        }
                        else        // môn học đã có...giờ thêm số lần thi tiếp theo cho môn học
                        {
                            if (CheckGioiHanHoc() == true)
                            {
                                MessageBox.Show($"Sinh viên đã học cải thiện.Không thể học thêm môn này!", "Thất bại");
                            }
                            else
                            {
                                if (CheckHocKy() == true)
                                {
                                    Diem newDiem = new Diem();
                                    newDiem.MSSV = cbbMSSV.SelectedItem.ToString();
                                    newDiem.MaMon = cbbMaMon.SelectedValue.ToString();
                                    newDiem.DiemQuaTrinh = Convert.ToDouble(txtDiemQuaTrinh.Text);
                                    newDiem.DiemThi = Convert.ToDouble(txtDiemThi.Text);
                                    newDiem.DiemTongKet = (Convert.ToDouble(txtDiemThi.Text) + Convert.ToDouble(txtDiemQuaTrinh.Text)) / 2;
                                    newDiem.MaHocKy = (cbbHocKi.SelectedIndex + 1).ToString();
                                    newDiem.LanThi = CheckLanThi() + 1;  //cộng 1 lần so với lần thi trước
                                    if (newDiem.DiemTongKet < 10)
                                    {
                                        newDiem.DiemChu = "A";
                                    }
                                    if (newDiem.DiemTongKet <= 8.4)
                                    {
                                        newDiem.DiemChu = "B+";
                                    }
                                    if (newDiem.DiemTongKet <= 7.7)
                                    {
                                        newDiem.DiemChu = "B";
                                    }
                                    if (newDiem.DiemTongKet <= 6.9)
                                    {
                                        newDiem.DiemChu = "C+";
                                    }
                                    if (newDiem.DiemTongKet <= 6.2)
                                    {
                                        newDiem.DiemChu = "C";
                                    }
                                    if (newDiem.DiemTongKet <= 5.4)
                                    {
                                        newDiem.DiemChu = "D+";
                                    }
                                    if (newDiem.DiemTongKet <= 4.7)
                                    {
                                        newDiem.DiemChu = "D";
                                    }
                                    if (newDiem.DiemTongKet <= 3.9)
                                    {
                                        newDiem.DiemChu = "F+";
                                    }
                                    if (newDiem.DiemTongKet <= 2.9)
                                    {
                                        newDiem.DiemChu = "F";
                                    }
                                    //tinh kết quả
                                    if (newDiem.DiemTongKet >= 4.0)
                                    {
                                        newDiem.KetQua = "Đạt";
                                    }
                                    if (newDiem.DiemTongKet < 4.0)
                                    {
                                        newDiem.KetQua = "Chưa đạt";
                                    }
                                    if (CheckTinhTrang() == true)
                                    {
                                        newDiem.TinhTrang = "Học cải thiện";
                                    }
                                    else
                                    {
                                        newDiem.TinhTrang = "Học lại";
                                    }
                                    // tinh tình trạng (lần đầu , cải thiện , rớt,học lại)
                                    //dua data xuong db va luu
                                    dbContent.Diem.AddOrUpdate(newDiem);
                                    dbContent.SaveChanges();
                                    MessageBox.Show($"Thêm điểm thành công !", "Thông báo");
                                }
                                else
                                {
                                    MessageBox.Show($"Không thể chọn học kỳ cũ hoặc giống học kỳ lần trước !", "Thất bại");
                                }
                            }
                        }
                    }
                }
            }
            if (flag == "sua")
            {
                if (CheckDataInput() == true)
                {
                    // lay sv dua vao ma so sv
                    Diem updateDiem = dbContent.Diem.Where(p => p.MaMon == cbbMaMon.SelectedValue.ToString()
                        && p.MSSV == cbbMSSV.SelectedItem.ToString()
                        && p.MaHocKy == cbbHocKi.SelectedItem.ToString()).FirstOrDefault();
                    updateDiem.MSSV = cbbMSSV.SelectedItem.ToString();
                    updateDiem.MaMon = cbbMaMon.SelectedValue.ToString();
                    updateDiem.DiemQuaTrinh = Convert.ToDouble(txtDiemQuaTrinh.Text.ToString());
                    updateDiem.DiemThi = Convert.ToDouble(txtDiemThi.Text.ToString());
                    updateDiem.DiemTongKet = (Convert.ToDouble(txtDiemThi.Text) + Convert.ToDouble(txtDiemQuaTrinh.Text)) / 2;
                    updateDiem.MaHocKy = cbbHocKi.Text;
                    if (updateDiem.DiemTongKet < 10)
                    {
                        updateDiem.DiemChu = "A";
                    }
                    if (updateDiem.DiemTongKet <= 8.4)
                    {
                        updateDiem.DiemChu = "B+";
                    }
                    if (updateDiem.DiemTongKet <= 7.7)
                    {
                        updateDiem.DiemChu = "B";
                    }
                    if (updateDiem.DiemTongKet <= 6.9)
                    {
                        updateDiem.DiemChu = "C+";
                    }
                    if (updateDiem.DiemTongKet <= 6.2)
                    {
                        updateDiem.DiemChu = "C";
                    }
                    if (updateDiem.DiemTongKet <= 5.4)
                    {
                        updateDiem.DiemChu = "D+";
                    }
                    if (updateDiem.DiemTongKet <= 4.7)
                    {
                        updateDiem.DiemChu = "D";
                    }
                    if (updateDiem.DiemTongKet <= 3.9)
                    {
                        updateDiem.DiemChu = "F+";
                    }
                    if (updateDiem.DiemTongKet <= 2.9)
                    {
                        updateDiem.DiemChu = "F";
                    }
                    //
                    if (updateDiem.DiemTongKet >= 4.0)
                    {
                        updateDiem.KetQua = "Đạt";
                    }
                    if (updateDiem.DiemTongKet < 4.0)
                    {
                        updateDiem.KetQua = "Rớt";
                    }
                    //
                    dbContent.Diem.AddOrUpdate(updateDiem);

                    dbContent.SaveChanges();
                    MessageBox.Show($"Sửa điểm {updateDiem.MSSV} thành công!", "Thông báo");
                }
            }
            if (flag == "xoa")
            {
                int tempLanThi = CheckLanThi();
                Diem XoaDiem = dbContent.Diem.Where(p => p.MSSV == cbbMSSV.SelectedItem.ToString()
                                        && p.MaMon == cbbMaMon.SelectedValue.ToString()
                                        && p.LanThi == tempLanThi   //sử dụng temp vì linQ k gọi được hàm CheckLanThi
                                        ).FirstOrDefault();
                if (XoaDiem != null)        // kiểm tra điểm cần xóa đúng data input
                {
                    DialogResult XD = MessageBox.Show("Bạn có chắc muốn xóa điểm ? ", "Yes/No", MessageBoxButtons.YesNo);
                    if (XD == DialogResult.Yes)
                    {
                        dbContent.Diem.Remove(XoaDiem);
                        dbContent.SaveChanges();
                        MessageBox.Show($"Xóa điểm sinh viên {cbbMSSV.Text} thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show($"Xóa điểm sinh viên {cbbMSSV.Text} thất bại", "Canceled By User !");
                    }
                }
                else //không có điểm cần xóa theo data input
                    MessageBox.Show($"SV {cbbMSSV.Text} chưa có điểm môn này", "Thông báo");
            }
            SetButton(true);
            LockTxt(true);
            labelShow.Text = "";
            //refresh dgv diem sau khi luu
            List<Diem> listDiem = dbContent.Diem.ToList();
            FillDataDGV_Diem(listDiem);

            TinhTotNghiep();    // gọi hàm mỗi lần thao tác với điểm
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButton(true);
            LockTxt(true);
            labelShow.Text = "";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SetButton(true);
            labelShow.Text = "";
            if (cbbMSSV.SelectedIndex == -1 || cbbMSSV.Text == "")
            {
                MessageBox.Show($"Hay chon MSSV", "Thong bao");
            }
            else
            {
                List<Diem> listDiem = dbContent.Diem.ToList();
                FillDataDGV_Diem(listDiem);
            }
        }
    }
}