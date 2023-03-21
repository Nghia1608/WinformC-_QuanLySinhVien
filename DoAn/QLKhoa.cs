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
    public partial class QLKhoa : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        string flag;
        public QLKhoa()
        {
            InitializeComponent();
        }
        public void LockTxt(bool val)
        {
            txtMa.ReadOnly = val;
            txtTen.ReadOnly = val;
        }
        public void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            List<Khoa> listKhoa = dbContent.Khoa.ToList();
            FillDataDGV(listKhoa);
            txtMa.Focus();
            SetNull();
            SetButton(true);
            LockTxt(true);
            this.dgvQLKhoa.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            this.dgvQLKhoa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
        }
        private void loadDGV()              //load data
        {
            List<Khoa> newKhoa = dbContent.Khoa.ToList();
            FillDataDGV(newKhoa);
        }
        private void FillDataDGV(List<Khoa> listKhoa)           //load data vao dgv
        {
            dgvQLKhoa.Rows.Clear();
            foreach (var item in listKhoa)
            {
                int newRow = dgvQLKhoa.Rows.Add();        //them 1 dong moi
                dgvQLKhoa.Rows[newRow].Cells[0].Value = item.MaKhoa;
                dgvQLKhoa.Rows[newRow].Cells[1].Value = item.TenKhoa;
                txtTong.Text = (dgvQLKhoa.Rows.Count - 1).ToString();

            }
        }
        private void loadForm()
        {

            txtMa.Clear();
            txtTen.Clear();
            SetButton(true);
        }

        private int CheckIDKhoa(string idKhoa)        // kt ma so sv
        {
            for (int i = 0; i < dgvQLKhoa.Rows.Count; i++)
            {
                if (dgvQLKhoa.Rows[i].Cells[0].Value != null)
                {
                    if (dgvQLKhoa.Rows[i].Cells[0].Value.ToString() == idKhoa)
                    {
                        return i;
                    }
                }
            }
            return -1;  //-1 khi khong tim thay sinh vien co ma so moi
        }
        private bool CheckDataInput()           // kiem tra du lieu dau vao
        {
            if (txtMa.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;        // neu khong co IF nao dung (k co loi)
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "Them";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng thêm";
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "Xoa";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng xóa";
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "Sua";
            LockTxt(false);
            SetButton(false);
            labelShow.Text = "Đang chọn chức năng sửa";
        }

        private void dgvQLKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowi = e.RowIndex;
            if (rowi < 0 || rowi >= dgvQLKhoa.Rows.Count)
            {
                return;
            }
            else
            {
                txtMa.Text = dgvQLKhoa.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTen.Text = dgvQLKhoa.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            string ms = txtMa.Text;
            string ht = txtTen.Text;
            if (flag == "Them")
            {
                if (CheckDataInput() == true)
                {
                    if (CheckIDKhoa(txtMa.Text) == -1)        // neu tra ve -1 thi sv chua co trong ds
                    {
                        Khoa newKhoa = new Khoa();        // khoi tao sv moi
                        newKhoa.MaKhoa = txtMa.Text;
                        newKhoa.TenKhoa = txtTen.Text;
                        //dua data xuong db va luu
                        dbContent.Khoa.AddOrUpdate(newKhoa);
                        dbContent.SaveChanges();
                        //reset data gird view
                        loadForm();
                        loadDGV();

                        MessageBox.Show($"Thêm khoa {txtMa.Text}-{txtTen.Text} thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show($"Thêm khoa {txtMa.Text}-{txtTen.Text} thất bại , Trùng mã khoa", "Thông báo");
                    }

                }
            }
            if (flag == "Sua")
            {
                if (CheckDataInput() == true)
                {
                    // lay sv dua vao ma so sv
                    Khoa updateKhoa = dbContent.Khoa.Where(p => p.MaKhoa == txtMa.Text).FirstOrDefault();

                    if (updateKhoa != null)        // neu tra ve -1 thi sv chua co trong ds
                    {
                        updateKhoa.TenKhoa = txtTen.Text;

                        dbContent.Khoa.AddOrUpdate(updateKhoa);

                        dbContent.SaveChanges();
                        //reset data gird view
                        loadForm();
                        loadDGV();

                        MessageBox.Show($"Sửa khoa {updateKhoa.MaKhoa} thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show($"Sửa khoa {txtMa} thất bại", "Thông báo");
                    }
                }
            }
            if (flag == "Xoa")
            {
                if (CheckDataInput() == true)
                {
                    Khoa XoaKhoa = dbContent.Khoa.Where(p => p.MaKhoa == txtMa.Text).FirstOrDefault();
                    if (XoaKhoa != null)        // neu tra ve -1 thi sv chua co trong ds
                    {
                        DialogResult XD = MessageBox.Show("Bạn có chắc muốn xóa ? ", "Yes/No", MessageBoxButtons.YesNo);
                        if (XD == DialogResult.Yes)
                        {

                            dbContent.Khoa.Remove(XoaKhoa);
                            dbContent.SaveChanges();

                            loadForm();
                            loadDGV();

                            MessageBox.Show($"Xóa khoa {XoaKhoa.MaKhoa} thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show($"Xóa khoa {txtMa} thất bại", "Thông báo");
                        }
                    }
                }
            }
            SetButton(true);
            SetNull();
            labelShow.Text = "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            SetButton(true);
            labelShow.Text = "";
        }

        private void dgvQLKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
