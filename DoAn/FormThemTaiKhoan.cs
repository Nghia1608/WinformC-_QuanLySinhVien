using DoAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormThemTaiKhoan : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillDataCBB(List<TaiKhoan> listQuyen)
        {
            cbbQuyen.DataSource = listQuyen;
            cbbQuyen.DisplayMember = "Quyen";
            cbbQuyen.ValueMember = "Quyen";
        }
        private void FormThemTaiKhoan_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> listQuyen = dbContent.TaiKhoan.ToList();
            FillDataCBB(listQuyen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtXacNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtQuyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (txtTenDangNhap.Text.Length > 20)
            {
                MessageBox.Show("ID chỉ được nhập tối đa 20 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhauMoi.Text.Length <= 3)
            {
                MessageBox.Show("Mật khẩu phải có nhiều 3 ký tự hơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhật mật khẩu không trùng khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!CheckEmail(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            SqlConnection conn = new SqlConnection(@"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            conn.Open();
            string tk = txtTenDangNhap.Text;
            string mk = txtEmail.Text;
            string sql = "select Gmail from TaiKhoan where Gmail='" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
                            SqlCommand cmd1 = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter("select Gmail from TaiKhoan where Gmail='" + mk + "'", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dtsv = cmd.ExecuteReader(); 
            {
                if (dtsv.Read() == true  )

                    {
                        MessageBox.Show($"Trung Gmail", "Thông báo");
                }
                else
                {
                    try
                    {
                        string query = "INSERT INTO TaiKhoan VALUES ('" + txtTenDangNhap.Text + "','" + txtEmail.Text + "','" + txtMatKhauMoi.Text + "','" + cbbQuyen.Text + "','" + "" + "')";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Thêm tài khoản mới thành công !", "Thông báo");
                    }
                    catch (Exception e1)
                    {
                        string temp = e.ToString();
                        if(e1.ToString().Contains("Cannot insert duplicate key"))
                        {
                            MessageBox.Show("Trung ID !", "Thông báo");
                        } 
                    }

                }
            }
        }
    }
}
