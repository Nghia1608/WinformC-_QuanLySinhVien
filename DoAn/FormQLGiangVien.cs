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
using DoAn.Model;
namespace DoAn
{
    public partial class FormQLGiangVien : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();      //Gọi d
        string tendangnhap = "", matkhau = "", quyen = "";
        string flag;
        public FormQLGiangVien()
        {
            InitializeComponent();
        }
        public FormQLGiangVien(string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
        public void LockTxt(bool val)       // Khóa hết Textbox và ComboBox trước khi chọn nút chức năng
        {
            //txtMaGV.ReadOnly = val;
            txtHo.ReadOnly = val;
            txtTen.ReadOnly = val;
            txtHocVi.ReadOnly = val;        
            txtSDT.ReadOnly = val;
            cbbMaKhoa.Enabled = !val;

        }
        public void SetNull()
        {
            txtMaGV.Text = "";
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
        private void loadDGV()              //load data
        {
            List<GiangVien> newGiangVien = dbContent.GiangVien.ToList();
            FillDataDGV(newGiangVien);
        }
        private void loadForm()
        {

            txtMaGV.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtHocVi.Clear();
            txtSDT.Clear();

        }
        private void FillDataDGV(List<GiangVien> listGiangVien)           //load data vao dgv
        {
            dgvQLGV.Rows.Clear();
            foreach (var item in listGiangVien)
            {
                int newRow = dgvQLGV.Rows.Add();        //them 1 dong moi
                dgvQLGV.Rows[newRow].Cells[0].Value = item.MaGiangVien;
                dgvQLGV.Rows[newRow].Cells[1].Value = item.Ho;
                dgvQLGV.Rows[newRow].Cells[2].Value = item.Ten;
                dgvQLGV.Rows[newRow].Cells[3].Value = item.HocVi;
                dgvQLGV.Rows[newRow].Cells[4].Value = item.SDT;
                dgvQLGV.Rows[newRow].Cells[5].Value = item.MaKhoa;
                txtTong.Text = (dgvQLGV.Rows.Count - 1).ToString();

            }
        }
        private void FormQLGiangVien_Load(object sender, EventArgs e)
        {
            List<GiangVien> listGiangVien = dbContent.GiangVien.ToList();
            List<Khoa> listKhoa = dbContent.Khoa.ToList(); ;
            FillDataDGV(listGiangVien);
            SetNull();
            SetButton(true);
            LockTxt(true);
            FillDataCBB_Khoa(listKhoa);
            labelShow.Text = "";
            this.dgvQLGV.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            this.dgvQLGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
        }
        private int CheckMSGV(string idGiangVien)        // kt ma so sv , bang True la co sv
        {
            for (int i = 0; i < dgvQLGV.Rows.Count; i++)
            {
                if (dgvQLGV.Rows[i].Cells[0].Value != null)
                {
                    if (dgvQLGV.Rows[i].Cells[0].Value.ToString() == idGiangVien)
                    {
                        return i;
                    }
                }
            }
            return -1;  //-1 khi khong tim thay sinh vien co ma so moi
        }
        private void FillDataCBB_Khoa(List<Khoa> listKhoa)           //load mã và tên các môn học từ ds môn vào cbb
        {

            cbbMaKhoa.DataSource = listKhoa;         // cbb ma mon
            cbbMaKhoa.DisplayMember = "MaKhoa";
            cbbMaKhoa.ValueMember = "MaKhoa";

        }
        private bool CheckDataInput()           // kiem tra du lieu dau vao
        {
            if (txtMaGV.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtHocVi.Text == ""
                || txtSDT.Text == "" || cbbMaKhoa.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu ! Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMaGV.TextLength > 10)
            {
                MessageBox.Show("Mã giảng viên tối đa 10 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbbMaKhoa.SelectedItem == null)
            {
                MessageBox.Show("Mã khoa bị trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;        // neu khong co IF nao dung (k co loi)
        }
        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvQLGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGV.Focus();
            flag = "Them";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng thêm";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaGV.Focus();
            flag = "Xoa";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng xóa";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaGV.Focus();
            flag = "Sua";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng sửa";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            string ms = txtMaGV.Text;
            string ht = txtTen.Text;
            if (flag == "Them")
            {
                if (CheckDataInput() == true)
                {
                    if (CheckMSGV(txtMaGV.Text) == -1)        // neu tra ve -1 thi sv chua co trong ds
                    {
                        GiangVien newGiangVien = new GiangVien();        // khoi tao sv moi
                        newGiangVien.MaGiangVien = txtMaGV.Text;
                        newGiangVien.Ho = txtHo.Text;
                        newGiangVien.Ten = txtTen.Text;
                        newGiangVien.HocVi = txtHocVi.Text;
                        newGiangVien.SDT = txtSDT.Text;
                        newGiangVien.MaKhoa = cbbMaKhoa.Text;

                        //dua data xuong db va luu
                        dbContent.GiangVien.AddOrUpdate(newGiangVien);
                        dbContent.SaveChanges();
                        loadForm();
                        loadDGV();

                        MessageBox.Show($"Thêm giảng viên {txtMaGV.Text} thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show($"Thêm giảng viên {txtMaGV.Text} thất bại! Trùng MSSV", "Thông báo");
                    }
                }
            }
            if (flag == "Sua")
            {
                if (CheckDataInput() == true)
                {
                    // lay sv dua vao ma so sv
                    GiangVien updateGV = dbContent.GiangVien.Where(p => p.MaGiangVien == txtMaGV.Text).FirstOrDefault();

                    if (updateGV != null)        // neu tra ve -1 thi sv chua co trong ds
                    {
                        updateGV.Ho = txtHo.Text;
                        updateGV.Ten = txtTen.Text;
                        updateGV.HocVi = txtHocVi.Text;
                        updateGV.SDT = txtSDT.Text;
                        updateGV.MaKhoa = cbbMaKhoa.Text;
                        dbContent.GiangVien.AddOrUpdate(updateGV);
                        dbContent.SaveChanges();

                        //reset data gird view
                        loadForm();
                        loadDGV();

                        MessageBox.Show($"Sửa giảng viên {updateGV.MaGiangVien} thành công!", "Thông báo");
                    }

                }
                MessageBox.Show($"Sửa giảng viên thất bại", "Thông báo");
            }
            if (flag == "Xoa")
            {
                GiangVien XoaGV = dbContent.GiangVien.Where(p => p.MaGiangVien == txtMaGV.Text).FirstOrDefault();
                DialogResult XD = MessageBox.Show("Bạn có chắc muốn xóa giảng viên ? ", "Yes/No", MessageBoxButtons.YesNo);
                if (XD == DialogResult.Yes)
                {
                    if (XoaGV != null)
                    {
                        dbContent.GiangVien.Remove(XoaGV);
                    }
                    dbContent.SaveChanges();
                    loadForm();
                    loadDGV();

                    MessageBox.Show($"Xóa giảng viên {XoaGV.MaGiangVien} thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show($"Xóa giảng viên {txtMaGV.Text} thất bại", "Thông báo");
                }


            }
            SetButton(true);
            SetNull();
            labelShow.Text = "";
        }

        private void dgvQLGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowi = e.RowIndex;
            if (rowi < 0 || rowi >= dgvQLGV.Rows.Count)
            {
                return;
            }
            else
            {
                txtMaGV.Text = dgvQLGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtHo.Text = dgvQLGV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtTen.Text = dgvQLGV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtHocVi.Text = dgvQLGV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtSDT.Text = dgvQLGV.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                cbbMaKhoa.Text = dgvQLGV.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            /*var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template Word\\Mau_Bao_Cao.doc");

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "Ho" }, new[] { txtHo.Text });
            baoCao.MailMerge.Execute(new[] { "MSGV" }, new[] { txtMaGV.Text });
            baoCao.MailMerge.Execute(new[] { "Ten" }, new[] { txtTen.Text });
            baoCao.MailMerge.Execute(new[] { "HocVi" }, new[] { txtHocVi.Text });
            baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { txtSDT.Text });
            baoCao.MailMerge.Execute(new[] { "Ma_Khoa" }, new[] { cbbMaKhoa.Text });

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("BaoCaoGV" + txtMaGV.Text + ".doc");*/
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SetButton(true);
            labelShow.Text = "";
            if (txtMaGV.Text == "")
            {
                MessageBox.Show($"Hãy điền mã giảng viên cần lọc", "Thong bao");
            }
            else
            {
                List<GiangVien> listGV = dbContent.GiangVien.ToList();
                FillDataDGV(listGV);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            SetButton(true);
            labelShow.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
                    }
    }
}
