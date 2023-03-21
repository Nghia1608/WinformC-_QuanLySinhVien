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

namespace DoAn
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            conn.Open();
            string id = txtTenDangNhap.Text;
            string email = txtEmail.Text;
            string sql = "select ID,Password,Quyen from TaiKhoan where ID='" + id + "'and Gmail='" + email + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter("select ID,Password,Quyen,Gmail from TaiKhoan where ID='" + id + "'and Gmail='" + email + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dtsv = cmd.ExecuteReader();
            if (txtEmail.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu ! Hãy nhập đầy đủ thông tin để lấy lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMatKhauMoi.Text != txtXacNhan.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp");
                    return;
                }
                if (txtMatKhauMoi.Text == "" && txtXacNhan.Text == "")
                {
                    MessageBox.Show("Phải nhập mật khẩu mới");
                    return;
                }
                if (dtsv.Read() == true)
                    {
                        if (txtMatKhauMoi.Text == txtXacNhan.Text)
                        {
                            SqlDataAdapter da1 = new SqlDataAdapter("UPDATE TaiKhoan SET Password =N'" + txtMatKhauMoi.Text + "' WHERE ID=N'" + txtTenDangNhap.Text + "'", conn);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            MessageBox.Show("Lấy lại mật khẩu thành công !", "Thông báo !", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhập vào không chính xác để lấy lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }
        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
