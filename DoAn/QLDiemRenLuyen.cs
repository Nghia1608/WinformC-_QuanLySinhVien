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
    public partial class QLDiemRenLuyen : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();      //Gọi d
        string flag;
        public QLDiemRenLuyen()
        {
            InitializeComponent();
        }
        public void LockTxt(bool val)       // Khóa hết Textbox và ComboBox trước khi chọn nút chức năng
        {
          //  txtMa.ReadOnly = val;
        }
        public void SetNull()
        {
            txtMa.Text = "";

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
        private void QLDiemRenLuyen_Load(object sender, EventArgs e)
        {
            List<DiemRenLuyen> listDRL = dbContent.DiemRenLuyen.ToList();
            List<HocKy> listHocKy = dbContent.HocKy.ToList();
            List<SinhVien> listSV = dbContent.SinhVien.ToList();
            FillDataCBB_HocKi(listHocKy);

            SetNull();
            SetButton(true);
            LockTxt(true);
        }
        private void FillDataCBB_HocKi(List<HocKy> listHocKy)
        {
            cbbHocKi.DataSource = listHocKy;         // cbb hoc ky
            cbbHocKi.DisplayMember = "TenHocKy";
            cbbHocKi.ValueMember = "TenHocKy";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel13.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel12.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel3.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel6.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel7.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel8.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel9.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel4.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel10.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel5.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
            foreach (Control c in panel11.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    if (rd.Checked == true)
                        rd.Checked = false;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Focus();
            flag = "them";
            labelShow.Text = "Hiện đang chọn chức năng thêm";
            LockTxt(false);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            labelShow.Text = "Hiện đang chọn chức năng sửa";
            LockTxt(false);
            flag = "sua";
            SetButton(false);
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int TinhDiemRenLuyen()
        {
            int Tong = 0;
            // 1.1
            if (rdo111.Checked == true)
                Tong = Tong + 0;
            if (rdo112.Checked == true)
                Tong = Tong + 5;
            if (rdo113.Checked == true)
                Tong = Tong + 6;
            if (rdo114.Checked == true)
                Tong = Tong + 7;
            if (rdo115.Checked == true)
                Tong = Tong + 8;
            if (rdo116.Checked == true)
                Tong = Tong + 9;
            if (rdo117.Checked == true)
                Tong = Tong + 10;
            //1.2.1
            if (rdo1211.Checked == true)
                Tong = Tong + 3;
            if (rdo1212.Checked == true)
                Tong = Tong + 2;
            if (rdo1213.Checked == true)
                Tong = Tong + 0;
            //1.2.2
            if (rdo122.Checked == true)
                Tong = Tong + 3;
            //1.3
            if (rdo13.Checked == true)
                Tong = Tong + 2;
            //1.4
            if (rdo14.Checked == true)
                Tong = Tong + 2;
            //1.5
            if (rdo15.Checked == true)
                Tong = Tong + 4;
            //1.6
            if (rdo16.Checked == true)
                Tong = Tong + 4;
            //1.7
            if (rdo17.Checked == true)
                Tong = Tong + 4;
            //2
            //2.1
            if (rdo211.Checked == true)
                Tong = Tong + 3;
            if (rdo212.Checked == true)
                Tong = Tong + 1;
            if (rdo213.Checked == true)
                Tong = Tong + 0;
            //2.2
            if (rdo22.Checked == true)
                Tong = Tong + 3;
            //2.3
            if (rdo231.Checked == true)
                Tong = Tong + 3;
            if (rdo232.Checked == true)
                Tong = Tong + 1;
            if (rdo233.Checked == true)
                Tong = Tong + 0;
            //2.4
            if (rdo24.Checked == true)
                Tong = Tong + 3;
            return Tong;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DiemRenLuyen diemRenLuyen = dbContent.DiemRenLuyen.Where(p => p.HocKy.TenHocKy == cbbHocKi.Text && p.MSSV==txtMa.Text).FirstOrDefault();
            SinhVien diemRenLuyenSV = dbContent.SinhVien.Where(p => p.MSSV == txtMa.Text).FirstOrDefault();

            LockTxt(true);
            if (flag == "them")
            {
                if (txtMa.Text == "")
                {
                    MessageBox.Show($" Hãy nhập MSSV !");
                    return;
                }
                if (diemRenLuyen == null)        // kiểm tra SV có điểm rèn luyện chưa..Khác null là đã có điểm
                {
                    if(diemRenLuyenSV != null) // kiểm tra SV có tên trong DS sinh viên...Null là chưa có SV
                    {
                            DiemRenLuyen newDRL = new DiemRenLuyen();        // khoi tao sv moi
                            newDRL.MSSV = txtMa.Text;
                            newDRL.DiemRenLuyen1 = TinhDiemRenLuyen();
                            newDRL.MaHocKy = (cbbHocKi.SelectedIndex + 1).ToString();
                        //dua data xuong db va luu
                        dbContent.DiemRenLuyen.AddOrUpdate(newDRL);
                            dbContent.SaveChanges();

                            MessageBox.Show($"Thêm điểm rèn luyện sinh viên {txtMa.Text} thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show($"SV không tồn tại", "Thất bại");
                    }
                }
                else
                {
                    MessageBox.Show($"Sinh viên {txtMa.Text} đã có điểm rèn luyện học kì này", "Thất bại");
                }
            }
            if (flag == "sua")
            {
                if (txtMa.Text == "")
                {
                    MessageBox.Show($" Hãy nhập MSSV !");
                    return;
                }
                // lay sv dua vao ma so sv
                DiemRenLuyen updateSV = dbContent.DiemRenLuyen.Where(p => p.HocKy.TenHocKy == cbbHocKi.Text && p.MSSV == txtMa.Text).FirstOrDefault();
                if (updateSV != null)        // neu tra ve -1 thi sv chua co trong ds
                {
                    updateSV.MSSV = txtMa.Text;
                    updateSV.DiemRenLuyen1 = TinhDiemRenLuyen();
                    updateSV.MaHocKy = (cbbHocKi.SelectedIndex + 1).ToString();
                    dbContent.DiemRenLuyen.AddOrUpdate(updateSV);
                    dbContent.SaveChanges();
                    MessageBox.Show($"Sửa điểm rèn luyện sinh viên {txtMa.Text} thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show($"Sinh viên {txtMa.Text} ở học kì {cbbHocKi.Text} không có điểm rèn luyện", "Thất bại");
                }

            }
            if (flag == "xoa")
            {
                DiemRenLuyen XoaSV = dbContent.DiemRenLuyen.Where(p => p.HocKy.TenHocKy == cbbHocKi.Text && p.MSSV == txtMa.Text).FirstOrDefault();
                DialogResult XD = MessageBox.Show("Bạn có chắc muốn xóa điểm sinh viên ? ", "Yes/No", MessageBoxButtons.YesNo);
                if (XD == DialogResult.Yes)
                {
                    if (XoaSV != null)
                    {
                        dbContent.DiemRenLuyen.Remove(XoaSV);
                        dbContent.SaveChanges();
                        MessageBox.Show($"Xóa điểm rèn luyện sinh viên {txtMa.Text} thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show($"Sinh viên {txtMa.Text} ở học kì {cbbHocKi.Text} không có điểm", "Thất bại");

                    }
                }
                else
                {
                    MessageBox.Show($"Xóa điểm rèn luyện sinh viên {txtMa.Text} thất bại", "Canceled By User");
                }
            }
            SetButton(true);
            SetNull();
            labelShow.Text = "";
            txtTong.Text = TinhDiemRenLuyen().ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockTxt(true);
            SetButton(true);
            labelShow.Text = "";
        }

        private void rdo111_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            SinhVien diemRenLuyenSV = dbContent.SinhVien.Where(p => p.MSSV == txtMa.Text).FirstOrDefault();
            if (diemRenLuyenSV == null)
            {
                txtTong.Text = "Chưa có sinh viên";
                return;
            }
            DiemRenLuyen diemRenLuyen = dbContent.DiemRenLuyen.Where(p => p.HocKy.TenHocKy == cbbHocKi.Text && p.MSSV == txtMa.Text).FirstOrDefault();
            if (diemRenLuyen != null)
                txtTong.Text = diemRenLuyen.DiemRenLuyen1.ToString();
            else
                txtTong.Text = "Chưa có điểm kì này";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
