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
    public partial class QLMonHoc : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        string flag = "";
        public QLMonHoc()
        {
            InitializeComponent();
        }
        public void LockTxt(bool val)
        {
            txtMa.ReadOnly = val;
            txtTen.ReadOnly = val;
            txtSoTiet.ReadOnly = val;
            txtSoTinChi.ReadOnly = val;
            cbbTrangThai.Enabled = !val;
        }
        public void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSoTiet.Text = "";
            txtSoTinChi.Text = "";
        }
        private void QLMonHoc_Load(object sender, EventArgs e)
        {
            List<MonHoc> listMonHoc = dbContent.MonHoc.ToList();
            FillDataDGV(listMonHoc);
            txtMa.Focus();
            SetNull();
            SetButton(true);
            LockTxt(true);
            this.dgvQLMonHoc.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            this.dgvQLMonHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);

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
            List<MonHoc> newMonHoc = dbContent.MonHoc.ToList();
            FillDataDGV(newMonHoc);
        }
        private void loadForm()
        {
            txtSoTiet.Clear();
            txtTen.Clear();
            txtMa.Clear();
            txtSoTinChi.Clear();
        }
        private void FillDataDGV(List<MonHoc> listMonHoc)           //load data vao dgv
        {
            dgvQLMonHoc.Rows.Clear();
            foreach (var item in listMonHoc)
            {
                int newRow = dgvQLMonHoc.Rows.Add();        //them 1 dong moi
                dgvQLMonHoc.Rows[newRow].Cells[0].Value = item.MaMon;
                dgvQLMonHoc.Rows[newRow].Cells[1].Value = item.TenMon;
                dgvQLMonHoc.Rows[newRow].Cells[2].Value = item.SoTiet;
                dgvQLMonHoc.Rows[newRow].Cells[3].Value = item.SoTinChi;
                dgvQLMonHoc.Rows[newRow].Cells[4].Value = item.TrangThai;
                txtTong.Text = (dgvQLMonHoc.Rows.Count - 1).ToString();
            }
        }

        private int CheckIDMonHoc(string idMonHoc)        // kt ma so mon hoc
        {
            for (int i = 0; i < dgvQLMonHoc.Rows.Count; i++)
            {
                if (dgvQLMonHoc.Rows[i].Cells[0].Value != null)
                {
                    if (dgvQLMonHoc.Rows[i].Cells[0].Value.ToString() == idMonHoc)
                    {
                        return i;
                    }
                }
            }
            return -1;  //-1 khi khong tim thay mon hoc co ma so moi
        }
        private bool CheckDataInput()           // kiem tra du lieu dau vao
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtSoTiet.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                float KQ = 0;
                bool KetQua = float.TryParse(txtSoTiet.Text, out KQ);
                if (KetQua != true)
                {
                    MessageBox.Show("Dữ liệu số tiết phải là số !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "Them";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Hiện đang chọn chức năng thêm";
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "Sua";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Hiện đang chọn chức năng sửa";
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "Xoa";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Hiện đang chọn chức năng xóa";
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
            if (flag == "Them")
            {
                if (CheckDataInput() == true)
                {
                    if (CheckIDMonHoc(txtMa.Text) == -1)
                    {
                        MonHoc newMonHoc = new MonHoc();
                        newMonHoc.MaMon = txtMa.Text;
                        newMonHoc.TenMon = txtTen.Text;
                        newMonHoc.SoTiet = Convert.ToInt32(txtSoTiet.Text);
                        newMonHoc.SoTinChi = Convert.ToInt32(txtSoTinChi.Text);
                        newMonHoc.TrangThai = cbbTrangThai.SelectedItem.ToString();
                        dbContent.MonHoc.AddOrUpdate(newMonHoc);
                        dbContent.SaveChanges();

                        loadForm();
                        loadDGV();
                        MessageBox.Show($"Thêm môn học {newMonHoc.MaMon} thành công", "Thông báo !");

                    }
                    else
                    {
                        MessageBox.Show($"Thêm môn học {txtMa.Text} thất bại , trùng mã môn học", "Thông báo !");
                    }

                }
            }
            if (flag == "Sua")
            {
                if (CheckDataInput() == true)
                {
                    // lay sv dua vao ma so sv
                    MonHoc updateMonHoc = dbContent.MonHoc.Where(p => p.MaMon == txtMa.Text).FirstOrDefault();

                    if (updateMonHoc != null)        // neu tra ve -1 thi mon hoc chua co trong ds
                    {
                        updateMonHoc.TenMon = txtTen.Text;
                        updateMonHoc.SoTiet = Convert.ToInt32(txtSoTiet.Text);
                        updateMonHoc.SoTinChi = Convert.ToInt32(txtSoTinChi.Text);
                        updateMonHoc.TrangThai = cbbTrangThai.SelectedItem.ToString();
                        dbContent.MonHoc.AddOrUpdate(updateMonHoc);
                        dbContent.SaveChanges();
                        //reset data gird view
                        loadForm();
                        loadDGV();

                        MessageBox.Show($"Sửa môn học {updateMonHoc.MaMon} thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show($"Sửa môn học {txtTen} thất bại", "Thông báo");
                    }
                }
            }
            if (flag == "Xoa")
            {
                MonHoc XoaMonHoc = dbContent.MonHoc.Where(p => p.MaMon == txtMa.Text).FirstOrDefault();
                if (XoaMonHoc != null)        // neu tra ve -1 thi mon hoc chua co trong ds
                {
                    DialogResult XD = MessageBox.Show("Bạn có chắc muốn xóa môn học ? ", "Yes/No", MessageBoxButtons.YesNo);
                    if (XD == DialogResult.Yes)
                    {
                        Diem XoaDiem = dbContent.Diem.Where(p => p.MaMon == txtMa.Text).FirstOrDefault();
                        if (XoaDiem != null)
                        {
                            MessageBox.Show($"Xóa môn học {XoaMonHoc.TenMon} thất bại. Môn học được sử dụng ở bảng điểm !", "Thông báo");
                            return;         // dừng hàm
                        }
                        dbContent.MonHoc.Remove(XoaMonHoc);
                        dbContent.SaveChanges();
                        loadForm();
                        loadDGV();
                        MessageBox.Show($"Xóa môn học {XoaMonHoc.MaMon} thành công!", "Thông báo");
                    }
                }
            }
            SetButton(true);
            SetNull();
            labelShow.Text = "";
        }

        private void dgvQLMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowi = e.RowIndex;
            if (rowi < 0 || rowi >= dgvQLMonHoc.Rows.Count)
            {
                return;
            }
            else
            {
                txtMa.Text = dgvQLMonHoc.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTen.Text = dgvQLMonHoc.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtSoTiet.Text = dgvQLMonHoc.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtSoTinChi.Text = dgvQLMonHoc.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cbbTrangThai.SelectedItem = dgvQLMonHoc.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
