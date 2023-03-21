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
using DoAn.Model;
using System.Security.Cryptography;
namespace DoAn
{
    public partial class FormDangNhap : Form
    {
        string tendangnhap = "", matkhau = "", quyen = "";
        DbContentSinhVien dbContent = new DbContentSinhVien();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        public FormDangNhap(string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.taikhoan;
            txtMatKhau.Text = Properties.Settings.Default.matkhau;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void cbSave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtTenDangNhap.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtMatKhau.BackColor = SystemColors.Control;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            conn.Open();
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                string sql = "select ID,Password,Quyen from TaiKhoan where ID='" + tk + "'and Password='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter("select ID,Password,Quyen from TaiKhoan where ID='" + tk + "'and Password='" + mk + "'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataReader dtsv = cmd.ExecuteReader();
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                    {
                        MessageBox.Show("Phải nhập đủ thông tin", "Thông báo");
                    }
                else
                {
                    if (dtsv.Read() == true)
                    {
                        MessageBox.Show($"Đăng nhập thành công", "Thông báo");
                        FormMenu formMenu = new FormMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                        formMenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                }
                }

            if (cbLuu.Checked == true)
            {
                Properties.Settings.Default.taikhoan = txtTenDangNhap.Text;
                Properties.Settings.Default.matkhau = txtMatKhau.Text;
                Properties.Settings.Default.Save();
            }
            else if (cbLuu.Checked == false )
            {
                Properties.Settings.Default.taikhoan = "";
                Properties.Settings.Default.matkhau = "";
                Properties.Settings.Default.Save();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            QuenMatKhau quenmk = new QuenMatKhau();
            quenmk.ShowDialog();
        }

    }
}