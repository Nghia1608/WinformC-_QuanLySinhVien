using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Model;
using Aspose.Words;
using Aspose.Words.Tables;
using Extension.Report.AsposeWordExtension;

namespace DoAn
{
    public partial class FormQLSinhViencs : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();      //Gọi d
        string tendangnhap = "", matkhau = "", quyen = "";
        string flag;
        public FormQLSinhViencs()
        {
            InitializeComponent();

        }
        public FormQLSinhViencs(string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
        public void LockTxt(bool val)       // Khóa hết Textbox và ComboBox trước khi chọn nút chức năng
        {
        //    txtMa.ReadOnly = val;
            txtHo.ReadOnly = val;
            txtTen.ReadOnly = val;
            txtCCCD.ReadOnly = val;
            txtDanToc.ReadOnly = val;
            rdoNam.Enabled = !val;
            rdoNu.Enabled = !val;
            dtpNgaySinh.Enabled = !val;
            txtSDT.ReadOnly = val;
            txtEmail.ReadOnly = val;
            cbbTrangThai.Enabled = !val;
            cbbMaKhoa.Enabled = !val;
            cbbMaLop.Enabled = !val;

        }
        public void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
        public void SetButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnQuayVe.Enabled = val;
        }
        // Cac ham load va check data
        private void loadDGV()              //load data
        {
            List<SinhVien> newSinhVien = dbContent.SinhVien.ToList();
            FillDataDGV(newSinhVien);
        }
        private void loadForm()
        {

            txtMa.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtCCCD.Clear();
            txtDanToc.Clear();
            txtEmail.Clear();

            txtSDT.Clear();

        }
        private void FillDataDGV(List<SinhVien> listSinhVien)           //load data vao dgv
        {
            var newlistSV = (from x in dbContent.SinhVien
                             from y in dbContent.Lop
                             from z in dbContent.Khoa
                             where
                             x.MSSV == txtMa.Text
                             && x.MaLop == y.MaLop
                             && y.MaKhoa == z.MaKhoa
                             select new
                             {
                                 MSSV = x.MSSV,
                                 Ho = x.Ho,
                                 Ten = x.Ten,
                                 CCCD = x.CCCD,
                                 DanToc = x.DanToc,
                                 Email = x.Email,
                                 SDT = x.SDT,
                                 TrangThai = x.TrangThai,
                                 NamSinh = x.NamSinh,
                                 GioiTinh = x.GioiTinh,
                                 MaLop = x.MaLop,
                                 MaKhoa = z.MaKhoa,
                                 TenKhoa = z.TenKhoa,
                                 HinhAnh = x.HinhAnh
                             }
                         ).ToList();
            foreach (var item in newlistSV)
            {
                
                txtHo.Text = item.Ho;
                txtTen.Text = item.Ten;
                txtCCCD.Text = item.CCCD;
                txtDanToc.Text = item.DanToc;
                if(item.GioiTinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                DateTime dt = DateTime.Parse(item.NamSinh.ToString());
                dtpNgaySinh.Value = dt;
                txtSDT.Text = item.SDT;
                txtEmail.Text = item.Email;
                cbbMaLop.SelectedItem = item.MaLop;
                cbbMaKhoa.SelectedItem = item.MaKhoa;
                cbbTrangThai.SelectedItem = item.TrangThai;
                pictureBox1.Image = ConvertToImage((byte[])item.HinhAnh);
                tempTenKhoa = item.TenKhoa;
            }
        }
        string tempTenKhoa;
        private Boolean CheckMSSV()        // kt ma so sv , bang True la co sv
        {
            string temp = "";
            var newlistSV = (from t in dbContent.SinhVien
                             where (t.MSSV == txtMa.Text)
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
        private bool CheckDataInput()           // kiem tra du lieu dau vao
        {
            if (txtMa.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtCCCD.Text == ""
                || txtDanToc.Text == "" || txtEmail.Text == "" || cbbMaLop.Text == "" || txtSDT.Text == ""
                 || cbbTrangThai.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu ! Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMa.TextLength < 5)
            {
                MessageBox.Show("Mã số sinh viên phải có hơn 5 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (pictureBox1.Image == null )
            {
                MessageBox.Show("Phải chọn ảnh SV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(cbbMaLop.SelectedItem== null)
            {
                MessageBox.Show("Mã lớp bị trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;        // neu khong co IF nao dung (k co loi)
        }
        //Cac ham chuc nang button

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và kí tự trắng , điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và kí tự trắng , điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        private void txtDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        string chuoiketnoi = @"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        string fileName;
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter= "Image Files|*.jpg;*.jpeg;*.png",ValidateNames = true,Multiselect=false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }
        }
        byte[] ConvertToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private Image ConvertToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private Boolean CheckMaLop()        // kt ma so sv , bang True la co sv
        {
            int temp = 0;
            var newlistSV = (from y in dbContent.Lop
                             where (y.MaLop == cbbMaLop.SelectedItem.ToString()
                             )
                             select new
                             {
                                 SoLuongCon = y.ConLai
                             }).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = item.SoLuongCon;
            }
            if (temp == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void SuaLopDichDen()        // chỉnh sửa sỉ số khi sửa , xóa sv
        {
            var lopDichDen = (from x in dbContent.SinhVien
                              from y in dbContent.Lop
                              where (y.MaLop == cbbMaLop.SelectedItem.ToString()
                              && x.MaLop == y.MaLop)
                              select new
                              {
                                  MaLop1 = y.MaLop,
                                  SiSo1 = y.SiSo,
                                  SoLuongCon1 = y.ConLai
                              }).Distinct().ToList();
            foreach (var item in lopDichDen)
            {
                Lop updateLop1 = dbContent.Lop.Where(p => p.MaLop == cbbMaLop.SelectedItem.ToString()).FirstOrDefault();    //chọn mã lớp đích đến của thao tác...tức là mã lớp đang chọn bởi cbb
                updateLop1.ConLai = item.SoLuongCon1 - 1;
                dbContent.Lop.AddOrUpdate(updateLop1);
            }

            dbContent.SaveChanges();
        }
        private void SuaLopHienTai()
        {
            var lopHienTai = (from x in dbContent.SinhVien
                              from y in dbContent.Lop
                              where (x.MSSV == txtMa.Text.ToString()
                              && x.MaLop == y.MaLop)
                              select new
                              {
                                  MaLop1 = y.MaLop,
                                  SiSo1 = y.SiSo,
                                  SoLuongCon1 = y.ConLai
                              }).Distinct().ToList();
            foreach (var item in lopHienTai)
            {
                Lop updateLop = dbContent.Lop.Where(p => p.MaLop == item.MaLop1).FirstOrDefault();  //chọn mã lớp hiện tại của sv
                updateLop.ConLai = item.SoLuongCon1 + 1;    //gán số lượng còn lại sau khi sửa bằng số lượng còn lại hiện tại
                dbContent.Lop.AddOrUpdate(updateLop);                                            //cộng thêm 1
            }
            dbContent.SaveChanges();
        }
        private void btnLuu_Click1(object sender, EventArgs e)
        {
            LockTxt(true);
            string ms = txtMa.Text;
            string ht = txtTen.Text;
            if (flag == "them")
            {
                if (CheckDataInput() == true)
                {
                    if (CheckMSSV() == false)        // neu tra ve -1 thi sv chua co trong ds
                    {
                        if (CheckMaLop() == true)
                        {
                            SinhVien newSinhVien = new SinhVien();        // khoi tao sv moi
                            newSinhVien.MSSV = txtMa.Text;
                            newSinhVien.Ho = txtHo.Text;
                            newSinhVien.Ten = txtTen.Text;
                            newSinhVien.CCCD = txtCCCD.Text;
                            newSinhVien.Email = txtEmail.Text;
                            newSinhVien.SDT = txtSDT.Text;
                            newSinhVien.TrangThai = cbbTrangThai.Text;
                            newSinhVien.MaLop = cbbMaLop.Text;
                            newSinhVien.DanToc = txtDanToc.Text;
                            newSinhVien.NamSinh = dtpNgaySinh.Value;
                            if (rdoNam.Checked == true)
                                newSinhVien.GioiTinh = "Nam";
                            else
                                newSinhVien.GioiTinh = "Nữ";
                            if (pictureBox1.Image != null)
                            {
                                newSinhVien.HinhAnh = ConvertToBinary(pictureBox1.Image);
                            }
                            //dua data xuong db va luu
                            dbContent.SinhVien.AddOrUpdate(newSinhVien);
                            dbContent.SaveChanges();
                            //reset data gird view

                            //sửa sỉ số lớp
                            Lop updateLop = dbContent.Lop.Where(p => p.MaLop == cbbMaLop.SelectedItem.ToString()).FirstOrDefault();
                            updateLop.ConLai = updateLop.ConLai - 1;
                            dbContent.Lop.AddOrUpdate(updateLop);

                            dbContent.SaveChanges();
                            //
                            loadForm();
                            loadDGV();

                            MessageBox.Show($"Thêm sinh viên {txtMa.Text} thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show($"Thất bại . Lớp này đã hết chỗ", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Thêm sinh viên {txtMa.Text} thất bại! Trùng MSSV", "Thông báo");
                    }
                }
            }
            if (flag == "sua")
            {
                if (CheckDataInput() == true)
                {
                    // lay sv dua vao ma so sv
                    SinhVien updateSV = dbContent.SinhVien.Where(p => p.MSSV == txtMa.Text).FirstOrDefault();
                    if (CheckMaLop() == true)
                    {
                        if (updateSV != null)        // neu tra ve -1 thi sv chua co trong ds
                        {
                            updateSV.Ho = txtHo.Text;
                            updateSV.Ten = txtTen.Text;
                            updateSV.DanToc = txtDanToc.Text;
                            updateSV.CCCD = txtCCCD.Text;
                            updateSV.Email = txtEmail.Text;
                            updateSV.MaLop = cbbMaLop.Text;
                            updateSV.TrangThai = cbbTrangThai.SelectedItem.ToString();
                            updateSV.SDT = txtSDT.Text;
                            updateSV.NamSinh = dtpNgaySinh.Value;
                            if (rdoNam.Checked == true)
                                updateSV.GioiTinh = "Nam";
                            else
                                updateSV.GioiTinh = "Nữ";
                        //    updateSV.HinhAnh = ConvertToBinary(pictureBox1.InitialImage);
                            dbContent.SinhVien.AddOrUpdate(updateSV);
                            dbContent.SaveChanges();

                            SuaLopDichDen(); SuaLopHienTai();   //gọi hàm sửa lớp

                            //reset data gird view
                            loadForm();
                            loadDGV();

                            MessageBox.Show($"Sửa sinh viên {updateSV.MSSV} thành công!", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Thất bại . Lớp này đã hết chỗ", "Thông báo");
                        }
                }
                else
                {
                    MessageBox.Show($"Hãy nhập đủ thông tin", "Thông báo");
                }
            }
            if (flag == "xoa")
            {
                SinhVien XoaSV = dbContent.SinhVien.Where(p => p.MSSV == txtMa.Text).FirstOrDefault();
                Diem XoaDiem = dbContent.Diem.Where(p => p.MSSV == txtMa.Text).FirstOrDefault();
                HocPhi XoaHocPhi = dbContent.HocPhi.Where(p => p.MSSV == txtMa.Text).FirstOrDefault();
                DialogResult XD = MessageBox.Show("Bạn có chắc muốn xóa sinh viên ? ", "Yes/No", MessageBoxButtons.YesNo);
                if (XD == DialogResult.Yes)
                {
                    if (XoaSV != null)
                    {
                        dbContent.SinhVien.Remove(XoaSV);
                        SuaLopHienTai();
                    }
                    if (XoaDiem != null)
                    {
                        DialogResult XD1 = MessageBox.Show("Sinh viên này được sử dụng ở bảng khác. Bạn có chắc muốn xóa sinh viên ? ", "Yes/No", MessageBoxButtons.YesNo);
                        if (XD1 == DialogResult.Yes)
                        {
                            dbContent.Diem.Remove(XoaDiem);
                        }
                    }
                    if (XoaHocPhi != null)
                    {
                        dbContent.Diem.Remove(XoaDiem);
                    }
                    dbContent.SaveChanges();
                    loadForm();
                    loadDGV();

                    MessageBox.Show($"Xóa sinh viên {XoaSV.MSSV} thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show($"Xóa sinh viên {txtMa.Text} thất bại", "Thông báo");
                }


            }
            SetButton(true);
            SetNull();
            labelShow.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            labelShow.Text = "Hiện đang chọn chức năng sửa";
            LockTxt(false);
            flag = "sua";
            SetButton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = "xoa";
            labelShow.Text = "Hiện đang chọn chức năng xóa";
            txtMa.Focus();
            LockTxt(false);
            SetButton(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "them";
            labelShow.Text = "Hiện đang chọn chức năng thêm";
            LockTxt(false);
            SetButton(false);
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            SetButton(true);
            labelShow.Text = "";
        }

        private void FormQLSinhViencs_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            this.lopTableAdapter.Fill(this.dataSetQLDiem.Lop);
            this.khoaTableAdapter.Fill(this.dataSetQLDiem.Khoa);
            List<SinhVien> listSinhVien = dbContent.SinhVien.ToList();
            List<Khoa> listKhoa = dbContent.Khoa.ToList(); ;
            FillDataDGV(listSinhVien);
            SetNull();
            SetButton(true);
            LockTxt(true);
            labelShow.Text = "";
            btnXuatFile.Enabled = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SetButton(true);
            labelShow.Text = "";
            if (txtMa.Text == "")
            {
                MessageBox.Show($"Hay chon MSSV", "Thong bao");
            }
            else
            {
                List<SinhVien> listSV = dbContent.SinhVien.ToList();
                FillDataDGV(listSV);
            }
            btnXuatFile.Enabled = true;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template Word\\Mau_Bao_Cao.doc");

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "Ho" }, new[] { txtHo.Text });
            baoCao.MailMerge.Execute(new[] { "MSSV" }, new[] { txtMa.Text });
            baoCao.MailMerge.Execute(new[] { "Ten" }, new[] { txtTen.Text });

            baoCao.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { dtpNgaySinh.Value.ToString("dd/MM/yyyy") });
            baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { txtTen.Text });
            baoCao.MailMerge.Execute(new[] { "CCCD" }, new[] { txtCCCD.Text });
            baoCao.MailMerge.Execute(new[] { "Dan_Toc" }, new[] { txtDanToc.Text });
            if (rdoNam.Checked == true)
            {
                baoCao.MailMerge.Execute(new[] { "Gioi_Tinh" }, new[] { "Nam" });
            }
            else
            {
                baoCao.MailMerge.Execute(new[] { "Gioi_Tinh" }, new[] { "Nữ" });
            }
            baoCao.MailMerge.Execute(new[] { "Email" }, new[] { txtEmail.Text });
            baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { txtTen.Text });

            baoCao.MailMerge.Execute(new[] { "Ma_Lop" }, new[] { cbbMaLop.Text });
            baoCao.MailMerge.Execute(new[] { "Ten_Khoa" }, new[] { tempTenKhoa });



            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("BaoCaoSV"+txtMa.Text+".doc");
        }

        private void cbbMaKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbMaLop.SelectedIndex = -1;
            cbbMaLop.Items.Clear();
            ketnoi.Open();
            sql = @"Select Khoa.MaKhoa,Lop.MaLop
                    From    Khoa Inner Join Lop
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

        string sql;

    }
}
