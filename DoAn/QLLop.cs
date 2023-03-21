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
    public partial class QLLop : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        string flag="";

        public QLLop()
        {
            InitializeComponent();
        }
        public void LockTxt(bool val)
        {
            cbbMaKhoa.Enabled = !val;
            cbbMaKhoaHoc.Enabled = !val;
            txtMaLop.ReadOnly = val;
            txtTenLop.ReadOnly = val;
            txtSiSo.ReadOnly = val;
        }
        public void SetNull()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtSiSo.Text = "";
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

        private void QLLop_Load(object sender, EventArgs e)
        {
            cbbMaKhoa.SelectedIndex = -1;
            List<Lop> listLop = dbContent.Lop.ToList();
            List<Khoa> listKhoa = dbContent.Khoa.ToList();
            List<KhoaHoc> listKhoaHoc = dbContent.KhoaHoc.ToList();
            FillDataDGV_Lop(listLop);
            FillDataCBB_KhoaHoc(listKhoaHoc);
            FillDataCBB_Khoa(listKhoa);
            txtMaLop.Focus();
            SetNull();
            SetButton(true);
            LockTxt(true);

            this.dgvQLLop.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            this.dgvQLLop.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
        }
        private void loadDGV()              //load data
        {
            List<Lop> newLop = dbContent.Lop.ToList();
            FillDataDGV_Lop(newLop);
        }
        private void loadForm()
        {

            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
        }
        private void FillDataCBB_Khoa(List<Khoa> listKhoa)
        {
            cbbMaKhoa.DataSource = listKhoa;         // cbb ma mon
            cbbMaKhoa.DisplayMember = "MaKhoa";
            cbbMaKhoa.ValueMember = "MaKhoa";
        }


        private void FillDataDGV_Lop(List<Lop> listLop)           //load data vao dgv
        {
            dgvQLLop.Rows.Clear();
            foreach (var item in listLop)
            {
                int newRow = dgvQLLop.Rows.Add();        //them 1 dong moi
                dgvQLLop.Rows[newRow].Cells[0].Value = item.MaKhoa;
                dgvQLLop.Rows[newRow].Cells[1].Value = item.MaLop;
                dgvQLLop.Rows[newRow].Cells[2].Value = item.TenLop;
                dgvQLLop.Rows[newRow].Cells[3].Value = item.SiSo;
                dgvQLLop.Rows[newRow].Cells[4].Value = item.ConLai;
                dgvQLLop.Rows[newRow].Cells[5].Value = item.MaKhoaHoc;

            }
            txtTong.Text = (dgvQLLop.Rows.Count-1).ToString();
        }

        private void FillDataCBB_KhoaHoc(List<KhoaHoc> listKhoaHoc)           //load mã và tên các môn học từ ds môn vào cbb
        {

            cbbMaKhoaHoc.DataSource = listKhoaHoc;         // cbb ma mon
            cbbMaKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbbMaKhoaHoc.ValueMember = "MaKhoaHoc";

        }
        private int CheckMaLop(string idMaLop)        // kt ma lop
        {
            for (int i = 0; i < dgvQLLop.Rows.Count; i++)
            {
                if (dgvQLLop.Rows[i].Cells[1].Value != null)
                {
                    if (dgvQLLop.Rows[i].Cells[1].Value.ToString() == idMaLop)
                    {
                        return i;

                    }
                }
            }
            return -1;  //-1 khi khong tim thay lop co ma so moi
        }
        private bool CheckDataInput()           // kiem tra du lieu dau vao
        {
            if (txtMaLop.Text == "" || txtTenLop.Text == "" || txtSiSo.Text == "")
            {
                MessageBox.Show("Dữ liệu điểm phải là số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((string)cbbMaKhoa.SelectedValue == "" || (string)cbbMaKhoaHoc.SelectedValue == "")
            {
                MessageBox.Show("Thiếu dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToInt32(txtSiSo.Text) < 0 || Convert.ToInt32(txtSiSo.Text) > 10)
            {
                MessageBox.Show("Giá trị sỉ số không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.Focus();
            flag = "Them";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng thêm";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaLop.Focus();
            flag = "Xoa";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng xóa";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaLop.Focus();
            flag = "Sua";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng sửa";
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvQLLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowi = e.RowIndex;
            if (rowi < 0 || rowi >= dgvQLLop.Rows.Count)
            {
                return;
            }
            else
            {
                cbbMaKhoa.SelectedIndex = cbbMaKhoa.FindString(dgvQLLop.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtMaLop.Text = dgvQLLop.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtTenLop.Text = dgvQLLop.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtSiSo.Text = dgvQLLop.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cbbMaKhoaHoc.SelectedIndex = cbbMaKhoaHoc.FindString(dgvQLLop.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            }
        }
        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
            cbbMaKhoaHoc.SelectedIndex = -1;
        }

        private void txtSiSo_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        private int SoLuongSVTaiLop()        // kt ma so sv , bang True la co sv
        {
            int temp = 0;
            var newlistSV = (from y in dbContent.Lop
                             where (y.MaLop == txtMaLop.Text
                             )
                             select new
                             {
                                 SoLuongSVTaiLop = y.SiSo - y.ConLai     //tính số lượng sv tại lớp này
                             }).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                temp = item.SoLuongSVTaiLop;
            }
            return temp;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            SetButton(true);
            labelShow.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            string ms = txtMaLop.Text;
            string ht = txtTenLop.Text;
            if (flag == "Them")
            {
                if (CheckDataInput() == true)
                {
                    if (CheckMaLop(txtMaLop.Text) == -1)
                    {
                        Lop newLop = new Lop();
                        newLop.MaKhoa = cbbMaKhoa.SelectedValue.ToString();
                        newLop.MaLop = txtMaLop.Text;
                        newLop.TenLop = txtTenLop.Text;
                        newLop.SiSo = Convert.ToInt32(txtSiSo.Text);
                        newLop.ConLai = Convert.ToInt32(txtSiSo.Text);
                        newLop.MaKhoaHoc = cbbMaKhoaHoc.SelectedValue.ToString();

                        dbContent.Lop.AddOrUpdate(newLop);
                        dbContent.SaveChanges();

                        loadForm();
                        loadDGV();
                        MessageBox.Show($"Thêm lớp {newLop.MaLop} thành công", "Thông báo !");

                    }
                    else
                    {
                        MessageBox.Show($"Thêm lớp {txtMaLop.Text} thất bại ", "Thông báo !");
                    }

                }
            }
            if (flag == "Sua")
            {
                if (CheckDataInput() == true)
                {
                    Lop SuaLop = dbContent.Lop.Where(p => p.MaLop == txtMaLop.Text).FirstOrDefault();
                    if (SuaLop != null)
                    {
                        SuaLop.MaKhoa = cbbMaKhoa.SelectedValue.ToString();
                        SuaLop.TenLop = txtTenLop.Text;
                        // trường hợp sỉ số sửa nhỏ hơn hiện tại
                        if(Convert.ToInt32(txtSiSo.Text) < SoLuongSVTaiLop())
                        {
                            MessageBox.Show($"Sỉ số không thể nhỏ hơn số lượng sinh viên của lớp", "Thất bại!");
                            return;
                        }
                        else                        // trường hợp sỉ số sửa lớn hơn hiện tại
                        {
                            SuaLop.SiSo = Convert.ToInt32(txtSiSo.Text);
                            SuaLop.ConLai = Convert.ToInt32(txtSiSo.Text) - SoLuongSVTaiLop();  //lấy sỉ số mới trừ số sv đang học
                        }
                        SuaLop.MaKhoaHoc = cbbMaKhoaHoc.SelectedValue.ToString();

                        dbContent.Lop.AddOrUpdate(SuaLop);
                        dbContent.SaveChanges();

                        loadForm();
                        loadDGV();
                        MessageBox.Show($"Sửa Lớp {SuaLop.MaLop} thành công", "Thông báo !");

                    }
                    else
                    {
                        MessageBox.Show($"Sửa lớp {txtMaLop.Text} thất bại ", "Thông báo !");
                    }

                }
            }
            if (flag == "Xoa")
            {
                if (CheckDataInput() == true)
                {
                    Lop XoaLop = dbContent.Lop.Where(p => p.MaLop == txtMaLop.Text).FirstOrDefault();
                    if (XoaLop != null)        // neu tra ve -1 thi sv chua co trong ds
                    {
                        DialogResult XD = MessageBox.Show("Bạn có chắc muốn xóa ? ", "Yes/No", MessageBoxButtons.YesNo);
                        if (XD == DialogResult.Yes)
                        {
                            dbContent.Lop.Remove(XoaLop);
                            dbContent.SaveChanges();
                            loadForm();
                            loadDGV();
                            MessageBox.Show($"Xóa lop {XoaLop.MaLop} thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show($"Xóa lop {txtMaLop } thất bại", "Thông báo");
                        }
                    }
                }
            }
            SetButton(true);
            SetNull();
            labelShow.Text = "";
        }

        private void cbbMaKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
