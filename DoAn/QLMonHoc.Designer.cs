
namespace DoAn
{
    partial class QLMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.dgvQLMonHoc = new System.Windows.Forms.DataGridView();
            this.dgvMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên môn học";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiết";
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTiet.Location = new System.Drawing.Point(723, 60);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(204, 33);
            this.txtSoTiet.TabIndex = 2;
            // 
            // dgvQLMonHoc
            // 
            this.dgvQLMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaMon,
            this.dgvTenMon,
            this.dgvSoTiet,
            this.dgvSoTinChi,
            this.dgvTrangThai});
            this.dgvQLMonHoc.Location = new System.Drawing.Point(12, 270);
            this.dgvQLMonHoc.Name = "dgvQLMonHoc";
            this.dgvQLMonHoc.RowHeadersWidth = 51;
            this.dgvQLMonHoc.RowTemplate.Height = 24;
            this.dgvQLMonHoc.Size = new System.Drawing.Size(1024, 259);
            this.dgvQLMonHoc.TabIndex = 3;
            this.dgvQLMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLMonHoc_CellClick);
            // 
            // dgvMaMon
            // 
            this.dgvMaMon.HeaderText = "Mã môn học";
            this.dgvMaMon.MinimumWidth = 6;
            this.dgvMaMon.Name = "dgvMaMon";
            // 
            // dgvTenMon
            // 
            this.dgvTenMon.HeaderText = "Tên môn học";
            this.dgvTenMon.MinimumWidth = 6;
            this.dgvTenMon.Name = "dgvTenMon";
            // 
            // dgvSoTiet
            // 
            this.dgvSoTiet.HeaderText = "Số tiết";
            this.dgvSoTiet.MinimumWidth = 6;
            this.dgvSoTiet.Name = "dgvSoTiet";
            // 
            // dgvSoTinChi
            // 
            this.dgvSoTinChi.HeaderText = "Số tín chỉ";
            this.dgvSoTinChi.Name = "dgvSoTinChi";
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.HeaderText = "Trạng thái";
            this.dgvTrangThai.Name = "dgvTrangThai";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(291, 547);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(511, 547);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 30);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(404, 547);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 30);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuayVe.FlatAppearance.BorderSize = 0;
            this.btnQuayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.White;
            this.btnQuayVe.Location = new System.Drawing.Point(844, 547);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(96, 30);
            this.btnQuayVe.TabIndex = 6;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(291, 63);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(204, 33);
            this.txtMa.TabIndex = 7;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(291, 118);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(204, 33);
            this.txtTen.TabIndex = 9;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tin chi";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.Location = new System.Drawing.Point(723, 109);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(204, 33);
            this.txtSoTinChi.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkRed;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(734, 547);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 30);
            this.btnHuy.TabIndex = 31;
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
            this.btnLuu.Location = new System.Drawing.Point(623, 547);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 30);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(163, 547);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 29);
            this.txtTong.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tổng";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(447, 232);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 25);
            this.labelShow.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Trạng thái";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTrangThai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đang dạy",
            "Ngừng"});
            this.cbbTrangThai.Location = new System.Drawing.Point(291, 173);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(204, 33);
            this.cbbTrangThai.TabIndex = 37;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // QLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvQLMonHoc);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Môn Học";
            this.Load += new System.EventHandler(this.QLMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.DataGridView dgvQLMonHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrangThai;
        private System.Windows.Forms.ComboBox cbbTrangThai;
    }
}