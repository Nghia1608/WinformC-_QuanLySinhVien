
namespace DoAn
{
    partial class FormQLSinhViencs
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
            this.dgvTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelShow = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLDiem = new DoAn.DataSetQLDiem();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new DoAn.DataSetQLDiemTableAdapters.LopTableAdapter();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.khoaTableAdapter = new DoAn.DataSetQLDiemTableAdapters.KhoaTableAdapter();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.HeaderText = "Trạng thái";
            this.dgvTrangThai.MinimumWidth = 6;
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.Width = 125;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(283, 410);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 25);
            this.labelShow.TabIndex = 60;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkRed;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(686, 510);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 30);
            this.btnHuy.TabIndex = 58;
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
            this.btnLuu.Location = new System.Drawing.Point(568, 510);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 30);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click1);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.BlueViolet;
            this.btnQuayVe.FlatAppearance.BorderSize = 0;
            this.btnQuayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.White;
            this.btnQuayVe.Location = new System.Drawing.Point(806, 510);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(96, 30);
            this.btnQuayVe.TabIndex = 57;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.dataSetQLDiem;
            // 
            // dataSetQLDiem
            // 
            this.dataSetQLDiem.DataSetName = "DataSetQLDiem";
            this.dataSetQLDiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTrangThai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đang học",
            "Bảo lưu",
            "Đã tốt nghiệp",
            "Nghỉ học"});
            this.cbbTrangThai.Location = new System.Drawing.Point(793, 320);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(171, 33);
            this.cbbTrangThai.TabIndex = 61;
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbMaKhoa.DataSource = this.khoaBindingSource;
            this.cbbMaKhoa.DisplayMember = "MaKhoa";
            this.cbbMaKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(793, 218);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(171, 33);
            this.cbbMaKhoa.TabIndex = 55;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged_1);
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.dataSetQLDiem;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDanToc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanToc.Location = new System.Drawing.Point(419, 269);
            this.txtDanToc.MaxLength = 12;
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(171, 33);
            this.txtDanToc.TabIndex = 54;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(419, 218);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(171, 33);
            this.txtCCCD.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(793, 169);
            this.txtEmail.MaxLength = 254;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 33);
            this.txtEmail.TabIndex = 52;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(793, 121);
            this.txtSDT.MaxLength = 12;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(171, 33);
            this.txtSDT.TabIndex = 51;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(419, 169);
            this.txtTen.MaxLength = 30;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(171, 33);
            this.txtTen.TabIndex = 50;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbMaLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(793, 271);
            this.cbbMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(171, 33);
            this.cbbMaLop.TabIndex = 56;
            // 
            // rdoNu
            // 
            this.rdoNu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoNu.AutoSize = true;
            this.rdoNu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdoNu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(519, 322);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(55, 29);
            this.rdoNu.TabIndex = 47;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = false;
            // 
            // rdoNam
            // 
            this.rdoNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoNam.AutoSize = true;
            this.rdoNam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdoNam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(422, 321);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(70, 29);
            this.rdoNam.TabIndex = 46;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(308, 510);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 30);
            this.btnSua.TabIndex = 45;
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
            this.btnXoa.Location = new System.Drawing.Point(429, 510);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 30);
            this.btnXoa.TabIndex = 44;
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
            this.btnThem.Location = new System.Drawing.Point(177, 510);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHo
            // 
            this.dgvHo.HeaderText = "Họ";
            this.dgvHo.MinimumWidth = 6;
            this.dgvHo.Name = "dgvHo";
            this.dgvHo.Width = 125;
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.HeaderText = "MSSV";
            this.dgvMSSV.MinimumWidth = 6;
            this.dgvMSSV.Name = "dgvMSSV";
            this.dgvMSSV.Width = 125;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(781, 76);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2049, 11, 26, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(237, 33);
            this.dtpNgaySinh.TabIndex = 31;
            this.dtpNgaySinh.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // txtHo
            // 
            this.txtHo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(419, 121);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHo.MaxLength = 6;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(171, 33);
            this.txtHo.TabIndex = 28;
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(419, 76);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMa.MaxLength = 10;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(171, 33);
            this.txtMa.TabIndex = 27;
            this.txtMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMa_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(665, 321);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Trạng thái";
            // 
            // dgvTen
            // 
            this.dgvTen.HeaderText = "Tên";
            this.dgvTen.MinimumWidth = 6;
            this.dgvTen.Name = "dgvTen";
            this.dgvTen.Width = 125;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Dân tộc";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Giới Tính";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(665, 272);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 25);
            this.label14.TabIndex = 42;
            this.label14.Text = "Mã Lớp";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(665, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = "Mã Khoa";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(664, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "Email";
            // 
            // dgvMaLop
            // 
            this.dgvMaLop.HeaderText = "Mã lớp";
            this.dgvMaLop.MinimumWidth = 6;
            this.dgvMaLop.Name = "dgvMaLop";
            this.dgvMaLop.Width = 125;
            // 
            // dgvDanToc
            // 
            this.dgvDanToc.HeaderText = "Dân tộc";
            this.dgvDanToc.MinimumWidth = 6;
            this.dgvDanToc.Name = "dgvDanToc";
            this.dgvDanToc.Width = 125;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(664, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "SDT";
            // 
            // dgvGioiTinh
            // 
            this.dgvGioiTinh.HeaderText = "Giới Tính";
            this.dgvGioiTinh.MinimumWidth = 6;
            this.dgvGioiTinh.Name = "dgvGioiTinh";
            this.dgvGioiTinh.Width = 125;
            // 
            // dgvNgaySinh
            // 
            this.dgvNgaySinh.HeaderText = "Ngày Sinh";
            this.dgvNgaySinh.MinimumWidth = 6;
            this.dgvNgaySinh.Name = "dgvNgaySinh";
            this.dgvNgaySinh.Width = 125;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "CCCD";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tên";
            // 
            // dgvSDT
            // 
            this.dgvSDT.HeaderText = "SDT";
            this.dgvSDT.MinimumWidth = 6;
            this.dgvSDT.Name = "dgvSDT";
            this.dgvSDT.Width = 125;
            // 
            // dgvEmail
            // 
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Width = 125;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(665, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "MSSV";
            // 
            // dgvCCCD
            // 
            this.dgvCCCD.HeaderText = "CCCD";
            this.dgvCCCD.MinimumWidth = 6;
            this.dgvCCCD.Name = "dgvCCCD";
            this.dgvCCCD.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1296, -148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(35, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 285);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonAnh.Location = new System.Drawing.Point(89, 390);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(96, 30);
            this.btnChonAnh.TabIndex = 63;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(685, 405);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(129, 30);
            this.btnLoc.TabIndex = 64;
            this.btnLoc.Text = "Lọc kết quả";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXuatFile.FlatAppearance.BorderSize = 0;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(889, 405);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(129, 30);
            this.btnXuatFile.TabIndex = 65;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // FormQLSinhViencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources._249675490_1285046221948820_2844251225914574091_n;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.txtDanToc);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLSinhViencs";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.FormQLSinhViencs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrangThai;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DataSetQLDiem dataSetQLDiem;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private DataSetQLDiemTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private DataSetQLDiemTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDanToc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCCCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXuatFile;
    }
}