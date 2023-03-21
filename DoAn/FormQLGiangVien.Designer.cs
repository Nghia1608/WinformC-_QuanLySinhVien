
namespace DoAn
{
    partial class FormQLGiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQLGV = new System.Windows.Forms.DataGridView();
            this.dgvMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelShow = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(706, 250);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(129, 30);
            this.btnLoc.TabIndex = 92;
            this.btnLoc.Text = "Lọc kết quả";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbMaKhoa.DisplayMember = "MaKhoa";
            this.cbbMaKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(660, 178);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(168, 33);
            this.cbbMaKhoa.TabIndex = 88;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged);
            // 
            // txtHocVi
            // 
            this.txtHocVi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHocVi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocVi.Location = new System.Drawing.Point(660, 76);
            this.txtHocVi.MaxLength = 12;
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(168, 33);
            this.txtHocVi.TabIndex = 86;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(660, 126);
            this.txtSDT.MaxLength = 12;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(168, 33);
            this.txtSDT.TabIndex = 84;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(360, 178);
            this.txtTen.MaxLength = 30;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(168, 33);
            this.txtTen.TabIndex = 83;
            // 
            // txtHo
            // 
            this.txtHo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(360, 128);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHo.MaxLength = 6;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(168, 33);
            this.txtHo.TabIndex = 67;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaGV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(360, 76);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaGV.MaxLength = 10;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(168, 33);
            this.txtMaGV.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(553, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 77;
            this.label12.Text = "Mã Khoa";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(586, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 25);
            this.label10.TabIndex = 74;
            this.label10.Text = "SDT";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(568, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 70;
            this.label6.Text = "Học Vị";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Mã Giảng Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkRed;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(750, 559);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 30);
            this.btnHuy.TabIndex = 98;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Orange;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(632, 559);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 30);
            this.btnLuu.TabIndex = 99;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.BlueViolet;
            this.btnQuayVe.FlatAppearance.BorderSize = 0;
            this.btnQuayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.White;
            this.btnQuayVe.Location = new System.Drawing.Point(870, 559);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(96, 30);
            this.btnQuayVe.TabIndex = 97;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(372, 559);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 30);
            this.btnSua.TabIndex = 96;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(493, 559);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 30);
            this.btnXoa.TabIndex = 95;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(241, 559);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 94;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvQLGV
            // 
            this.dgvQLGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLGV.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaGV,
            this.dgvHo,
            this.dgvTen,
            this.dgvHocVi,
            this.dgvSDT,
            this.dgvMaKhoa});
            this.dgvQLGV.Location = new System.Drawing.Point(9, 284);
            this.dgvQLGV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLGV.Name = "dgvQLGV";
            this.dgvQLGV.RowHeadersWidth = 51;
            this.dgvQLGV.RowTemplate.Height = 24;
            this.dgvQLGV.Size = new System.Drawing.Size(1028, 255);
            this.dgvQLGV.TabIndex = 100;
            this.dgvQLGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLGV_CellClick);
            this.dgvQLGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLGV_CellContentClick);
            // 
            // dgvMaGV
            // 
            this.dgvMaGV.HeaderText = "Mã Giảng Viên";
            this.dgvMaGV.MinimumWidth = 6;
            this.dgvMaGV.Name = "dgvMaGV";
            // 
            // dgvHo
            // 
            this.dgvHo.HeaderText = "Họ";
            this.dgvHo.MinimumWidth = 6;
            this.dgvHo.Name = "dgvHo";
            // 
            // dgvTen
            // 
            this.dgvTen.HeaderText = "Tên";
            this.dgvTen.MinimumWidth = 6;
            this.dgvTen.Name = "dgvTen";
            // 
            // dgvHocVi
            // 
            this.dgvHocVi.HeaderText = "Học Vị";
            this.dgvHocVi.MinimumWidth = 6;
            this.dgvHocVi.Name = "dgvHocVi";
            // 
            // dgvSDT
            // 
            this.dgvSDT.HeaderText = "SĐT";
            this.dgvSDT.MinimumWidth = 6;
            this.dgvSDT.Name = "dgvSDT";
            // 
            // dgvMaKhoa
            // 
            this.dgvMaKhoa.HeaderText = "Mã Khoa";
            this.dgvMaKhoa.MinimumWidth = 6;
            this.dgvMaKhoa.Name = "dgvMaKhoa";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(175, 236);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 25);
            this.labelShow.TabIndex = 101;
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(119, 561);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 29);
            this.txtTong.TabIndex = 103;
            this.txtTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 102;
            this.label8.Text = "Tổng";
            // 
            // FormQLGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources._249675490_1285046221948820_2844251225914574091_n;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.dgvQLGV);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.txtHocVi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQLGiangVien";
            this.Text = "Quản Lý Giảng Viên";
            this.Load += new System.EventHandler(this.FormQLGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.TextBox txtHocVi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQLGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHocVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhoa;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label8;
    }
}