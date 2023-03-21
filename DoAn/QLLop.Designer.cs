namespace DoAn
{
    partial class QLLop
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
            this.components = new System.ComponentModel.Container();
            this.dgvQLLop = new System.Windows.Forms.DataGridView();
            this.dgvMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMaKhoaHoc = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLLop
            // 
            this.dgvQLLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKhoa,
            this.dgvMaLop,
            this.dgvTenLop,
            this.dgvSiSo,
            this.dgvConLai,
            this.dgvMaKhoaHoc});
            this.dgvQLLop.Location = new System.Drawing.Point(11, 274);
            this.dgvQLLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLLop.Name = "dgvQLLop";
            this.dgvQLLop.RowHeadersWidth = 51;
            this.dgvQLLop.RowTemplate.Height = 24;
            this.dgvQLLop.Size = new System.Drawing.Size(1026, 256);
            this.dgvQLLop.TabIndex = 12;
            this.dgvQLLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLLop_CellClick);
            // 
            // dgvMaKhoa
            // 
            this.dgvMaKhoa.HeaderText = "Mã Khoa";
            this.dgvMaKhoa.MinimumWidth = 6;
            this.dgvMaKhoa.Name = "dgvMaKhoa";
            // 
            // dgvMaLop
            // 
            this.dgvMaLop.HeaderText = "Mã lớp";
            this.dgvMaLop.MinimumWidth = 6;
            this.dgvMaLop.Name = "dgvMaLop";
            // 
            // dgvTenLop
            // 
            this.dgvTenLop.HeaderText = "Tên lớp";
            this.dgvTenLop.MinimumWidth = 6;
            this.dgvTenLop.Name = "dgvTenLop";
            // 
            // dgvSiSo
            // 
            this.dgvSiSo.HeaderText = "Sỉ số";
            this.dgvSiSo.MinimumWidth = 6;
            this.dgvSiSo.Name = "dgvSiSo";
            // 
            // dgvConLai
            // 
            this.dgvConLai.HeaderText = "Còn lại";
            this.dgvConLai.MinimumWidth = 6;
            this.dgvConLai.Name = "dgvConLai";
            // 
            // dgvMaKhoaHoc
            // 
            this.dgvMaKhoaHoc.HeaderText = "Mã khóa học";
            this.dgvMaKhoaHoc.MinimumWidth = 6;
            this.dgvMaKhoaHoc.Name = "dgvMaKhoaHoc";
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuayVe.FlatAppearance.BorderSize = 0;
            this.btnQuayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuayVe.Location = new System.Drawing.Point(852, 550);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(96, 30);
            this.btnQuayVe.TabIndex = 15;
            this.btnQuayVe.Text = "Quay Về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(510, 550);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 30);
            this.btnSua.TabIndex = 16;
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
            this.btnXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(398, 550);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 30);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Transparent;
            this.btnThem.Location = new System.Drawing.Point(285, 550);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(271, 96);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(204, 33);
            this.txtMaLop.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Lớp";
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(271, 42);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(204, 33);
            this.cbbMaKhoa.TabIndex = 19;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(271, 150);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(204, 33);
            this.txtTenLop.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sỉ số";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSo.Location = new System.Drawing.Point(744, 43);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(204, 33);
            this.txtSiSo.TabIndex = 11;
            this.txtSiSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiSo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Khoá Học";
            // 
            // cbbMaKhoaHoc
            // 
            this.cbbMaKhoaHoc.DisplayMember = "MaKhoa";
            this.cbbMaKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoaHoc.FormattingEnabled = true;
            this.cbbMaKhoaHoc.Location = new System.Drawing.Point(744, 97);
            this.cbbMaKhoaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKhoaHoc.Name = "cbbMaKhoaHoc";
            this.cbbMaKhoaHoc.Size = new System.Drawing.Size(204, 33);
            this.cbbMaKhoaHoc.TabIndex = 19;
            this.cbbMaKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoaHoc_SelectedIndexChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkRed;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(741, 550);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 30);
            this.btnHuy.TabIndex = 29;
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
            this.btnLuu.Location = new System.Drawing.Point(628, 550);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 30);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(475, 227);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 25);
            this.labelShow.TabIndex = 31;
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(142, 550);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 29);
            this.txtTong.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tổng";
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources._249675490_1285046221948820_2844251225914574091_n;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbMaKhoaHoc);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.dgvQLLop);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLLop";
            this.Text = "QLLop";
            this.Load += new System.EventHandler(this.QLLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLLop;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaKhoaHoc;
        private DataSetQLDiem dataSetQLDiem;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DataSetQLDiemTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhoaHoc;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label8;
    }
}