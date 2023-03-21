
namespace DoAn
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelXemThongTin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHocPhi = new System.Windows.Forms.Button();
            this.btnSinhVienTheoLop = new System.Windows.Forms.Button();
            this.btnSinhVienTheoKhoa = new System.Windows.Forms.Button();
            this.btnDiemTheoMon = new System.Windows.Forms.Button();
            this.btnDiemTheoMSSV = new System.Windows.Forms.Button();
            this.btnBXH = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.panelQuanLySinhVien = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDiemRenLuyen = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.panelHethong = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelXemThongTin.SuspendLayout();
            this.panelQuanLySinhVien.SuspendLayout();
            this.panelQuanLy.SuspendLayout();
            this.panelHethong.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.panelXemThongTin);
            this.panel1.Controls.Add(this.btnXemThongTin);
            this.panel1.Controls.Add(this.panelQuanLySinhVien);
            this.panel1.Controls.Add(this.btnQuanLySinhVien);
            this.panel1.Controls.Add(this.panelQuanLy);
            this.panel1.Controls.Add(this.btnQuanLy);
            this.panel1.Controls.Add(this.panelHethong);
            this.panel1.Controls.Add(this.btnHeThong);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 681);
            this.panel1.TabIndex = 0;
            // 
            // panelXemThongTin
            // 
            this.panelXemThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelXemThongTin.Controls.Add(this.button1);
            this.panelXemThongTin.Controls.Add(this.btnHocPhi);
            this.panelXemThongTin.Controls.Add(this.btnSinhVienTheoLop);
            this.panelXemThongTin.Controls.Add(this.btnSinhVienTheoKhoa);
            this.panelXemThongTin.Controls.Add(this.btnDiemTheoMon);
            this.panelXemThongTin.Controls.Add(this.btnDiemTheoMSSV);
            this.panelXemThongTin.Controls.Add(this.btnBXH);
            this.panelXemThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelXemThongTin.Location = new System.Drawing.Point(0, 584);
            this.panelXemThongTin.Name = "panelXemThongTin";
            this.panelXemThongTin.Size = new System.Drawing.Size(183, 219);
            this.panelXemThongTin.TabIndex = 8;
            this.panelXemThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelXemThongTin_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nhóm môn học";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocPhi.FlatAppearance.BorderSize = 0;
            this.btnHocPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocPhi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHocPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.Image")));
            this.btnHocPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhi.Location = new System.Drawing.Point(0, 150);
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.Size = new System.Drawing.Size(183, 32);
            this.btnHocPhi.TabIndex = 7;
            this.btnHocPhi.Text = "Học phí sinh viên";
            this.btnHocPhi.UseVisualStyleBackColor = true;
            this.btnHocPhi.Click += new System.EventHandler(this.btnHocPhi_Click);
            // 
            // btnSinhVienTheoLop
            // 
            this.btnSinhVienTheoLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhVienTheoLop.FlatAppearance.BorderSize = 0;
            this.btnSinhVienTheoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVienTheoLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVienTheoLop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSinhVienTheoLop.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVienTheoLop.Image")));
            this.btnSinhVienTheoLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVienTheoLop.Location = new System.Drawing.Point(0, 120);
            this.btnSinhVienTheoLop.Name = "btnSinhVienTheoLop";
            this.btnSinhVienTheoLop.Size = new System.Drawing.Size(183, 30);
            this.btnSinhVienTheoLop.TabIndex = 6;
            this.btnSinhVienTheoLop.Text = "Sinh viên theo lớp";
            this.btnSinhVienTheoLop.UseVisualStyleBackColor = true;
            this.btnSinhVienTheoLop.Click += new System.EventHandler(this.btnSinhVienTheoLop_Click);
            // 
            // btnSinhVienTheoKhoa
            // 
            this.btnSinhVienTheoKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhVienTheoKhoa.FlatAppearance.BorderSize = 0;
            this.btnSinhVienTheoKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVienTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVienTheoKhoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSinhVienTheoKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVienTheoKhoa.Image")));
            this.btnSinhVienTheoKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVienTheoKhoa.Location = new System.Drawing.Point(0, 90);
            this.btnSinhVienTheoKhoa.Name = "btnSinhVienTheoKhoa";
            this.btnSinhVienTheoKhoa.Size = new System.Drawing.Size(183, 30);
            this.btnSinhVienTheoKhoa.TabIndex = 5;
            this.btnSinhVienTheoKhoa.Text = "Sinh viên theo khoa";
            this.btnSinhVienTheoKhoa.UseVisualStyleBackColor = true;
            this.btnSinhVienTheoKhoa.Click += new System.EventHandler(this.btnSinhVienTheoKhoa_Click);
            // 
            // btnDiemTheoMon
            // 
            this.btnDiemTheoMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemTheoMon.FlatAppearance.BorderSize = 0;
            this.btnDiemTheoMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemTheoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemTheoMon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiemTheoMon.Image = ((System.Drawing.Image)(resources.GetObject("btnDiemTheoMon.Image")));
            this.btnDiemTheoMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemTheoMon.Location = new System.Drawing.Point(0, 60);
            this.btnDiemTheoMon.Name = "btnDiemTheoMon";
            this.btnDiemTheoMon.Size = new System.Drawing.Size(183, 30);
            this.btnDiemTheoMon.TabIndex = 4;
            this.btnDiemTheoMon.Text = "Điểm theo môn";
            this.btnDiemTheoMon.UseVisualStyleBackColor = true;
            this.btnDiemTheoMon.Click += new System.EventHandler(this.btnDiemTheoMon_Click);
            // 
            // btnDiemTheoMSSV
            // 
            this.btnDiemTheoMSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemTheoMSSV.FlatAppearance.BorderSize = 0;
            this.btnDiemTheoMSSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemTheoMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemTheoMSSV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiemTheoMSSV.Image = ((System.Drawing.Image)(resources.GetObject("btnDiemTheoMSSV.Image")));
            this.btnDiemTheoMSSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemTheoMSSV.Location = new System.Drawing.Point(0, 30);
            this.btnDiemTheoMSSV.Name = "btnDiemTheoMSSV";
            this.btnDiemTheoMSSV.Size = new System.Drawing.Size(183, 30);
            this.btnDiemTheoMSSV.TabIndex = 3;
            this.btnDiemTheoMSSV.Text = "Điểm theo MSSV";
            this.btnDiemTheoMSSV.UseVisualStyleBackColor = true;
            this.btnDiemTheoMSSV.Click += new System.EventHandler(this.btnDiemTheoMSSV_Click);
            // 
            // btnBXH
            // 
            this.btnBXH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBXH.FlatAppearance.BorderSize = 0;
            this.btnBXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBXH.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBXH.Image = ((System.Drawing.Image)(resources.GetObject("btnBXH.Image")));
            this.btnBXH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBXH.Location = new System.Drawing.Point(0, 0);
            this.btnBXH.Name = "btnBXH";
            this.btnBXH.Size = new System.Drawing.Size(183, 30);
            this.btnBXH.TabIndex = 2;
            this.btnBXH.Text = "Bảng xếp hạng";
            this.btnBXH.UseVisualStyleBackColor = true;
            this.btnBXH.Click += new System.EventHandler(this.btnBXH_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemThongTin.FlatAppearance.BorderSize = 0;
            this.btnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongTin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXemThongTin.Location = new System.Drawing.Point(0, 547);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXemThongTin.Size = new System.Drawing.Size(183, 37);
            this.btnXemThongTin.TabIndex = 7;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.button20_Click);
            // 
            // panelQuanLySinhVien
            // 
            this.panelQuanLySinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelQuanLySinhVien.Controls.Add(this.btnTimKiem);
            this.panelQuanLySinhVien.Controls.Add(this.btnDiemRenLuyen);
            this.panelQuanLySinhVien.Controls.Add(this.btnDiem);
            this.panelQuanLySinhVien.Controls.Add(this.btnSinhVien);
            this.panelQuanLySinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuanLySinhVien.Location = new System.Drawing.Point(0, 427);
            this.panelQuanLySinhVien.Name = "panelQuanLySinhVien";
            this.panelQuanLySinhVien.Size = new System.Drawing.Size(183, 120);
            this.panelQuanLySinhVien.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 90);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(183, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnDiemRenLuyen
            // 
            this.btnDiemRenLuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemRenLuyen.FlatAppearance.BorderSize = 0;
            this.btnDiemRenLuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemRenLuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemRenLuyen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiemRenLuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnDiemRenLuyen.Image")));
            this.btnDiemRenLuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemRenLuyen.Location = new System.Drawing.Point(0, 60);
            this.btnDiemRenLuyen.Name = "btnDiemRenLuyen";
            this.btnDiemRenLuyen.Size = new System.Drawing.Size(183, 30);
            this.btnDiemRenLuyen.TabIndex = 4;
            this.btnDiemRenLuyen.Text = "Điểm rèn luyện";
            this.btnDiemRenLuyen.UseVisualStyleBackColor = true;
            this.btnDiemRenLuyen.Click += new System.EventHandler(this.btnDiemRenLuyen_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiem.FlatAppearance.BorderSize = 0;
            this.btnDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnDiem.Image")));
            this.btnDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiem.Location = new System.Drawing.Point(0, 30);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(183, 30);
            this.btnDiem.TabIndex = 3;
            this.btnDiem.Text = "Điểm môn học";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhVien.FlatAppearance.BorderSize = 0;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.Image")));
            this.btnSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 0);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(183, 30);
            this.btnSinhVien.TabIndex = 2;
            this.btnSinhVien.Text = "Thông tin cá nhân";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLySinhVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLySinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySinhVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(0, 387);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(183, 40);
            this.btnQuanLySinhVien.TabIndex = 5;
            this.btnQuanLySinhVien.Text = "Quản lý sinh viên";
            this.btnQuanLySinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySinhVien.UseVisualStyleBackColor = true;
            this.btnQuanLySinhVien.Click += new System.EventHandler(this.button15_Click);
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelQuanLy.Controls.Add(this.btnGiangVien);
            this.panelQuanLy.Controls.Add(this.btnLop);
            this.panelQuanLy.Controls.Add(this.btnMonHoc);
            this.panelQuanLy.Controls.Add(this.btnKhoa);
            this.panelQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuanLy.Location = new System.Drawing.Point(0, 263);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(183, 124);
            this.panelQuanLy.TabIndex = 4;
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiangVien.FlatAppearance.BorderSize = 0;
            this.btnGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiangVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGiangVien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiangVien.Image")));
            this.btnGiangVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiangVien.Location = new System.Drawing.Point(0, 91);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(183, 31);
            this.btnGiangVien.TabIndex = 6;
            this.btnGiangVien.Text = "Giảng viên";
            this.btnGiangVien.UseVisualStyleBackColor = true;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // btnLop
            // 
            this.btnLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLop.FlatAppearance.BorderSize = 0;
            this.btnLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLop.Image = ((System.Drawing.Image)(resources.GetObject("btnLop.Image")));
            this.btnLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.Location = new System.Drawing.Point(0, 60);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(183, 31);
            this.btnLop.TabIndex = 5;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonHoc.FlatAppearance.BorderSize = 0;
            this.btnMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonHoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.Image")));
            this.btnMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonHoc.Location = new System.Drawing.Point(0, 30);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(183, 30);
            this.btnMonHoc.TabIndex = 4;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoa.FlatAppearance.BorderSize = 0;
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Image")));
            this.btnKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.Location = new System.Drawing.Point(0, 0);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(183, 30);
            this.btnKhoa.TabIndex = 3;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 223);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(183, 40);
            this.btnQuanLy.TabIndex = 3;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // panelHethong
            // 
            this.panelHethong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelHethong.Controls.Add(this.btnThoat);
            this.panelHethong.Controls.Add(this.btnDangKi);
            this.panelHethong.Controls.Add(this.btnDoiMatKhau);
            this.panelHethong.Controls.Add(this.btnDangXuat);
            this.panelHethong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHethong.Location = new System.Drawing.Point(0, 99);
            this.panelHethong.Name = "panelHethong";
            this.panelHethong.Size = new System.Drawing.Size(183, 124);
            this.panelHethong.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(0, 90);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(183, 30);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangKi.FlatAppearance.BorderSize = 0;
            this.btnDangKi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangKi.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKi.Image")));
            this.btnDangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKi.Location = new System.Drawing.Point(0, 60);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(183, 30);
            this.btnDangKi.TabIndex = 4;
            this.btnDangKi.Text = "Thêm tài khoản";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 30);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(183, 30);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(183, 30);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHeThong.Location = new System.Drawing.Point(0, 59);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHeThong.Size = new System.Drawing.Size(183, 40);
            this.btnHeThong.TabIndex = 1;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 59);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(200, 76);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1064, 605);
            this.panelChildForm.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1064, 80);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeader.Location = new System.Drawing.Point(474, 27);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(90, 31);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Home";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panelXemThongTin.ResumeLayout(false);
            this.panelQuanLySinhVien.ResumeLayout(false);
            this.panelQuanLy.ResumeLayout(false);
            this.panelHethong.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHethong;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelQuanLySinhVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDiemRenLuyen;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnQuanLySinhVien;
        private System.Windows.Forms.Panel panelQuanLy;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Panel panelXemThongTin;
        private System.Windows.Forms.Button btnDiemTheoMon;
        private System.Windows.Forms.Button btnDiemTheoMSSV;
        private System.Windows.Forms.Button btnBXH;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnSinhVienTheoLop;
        private System.Windows.Forms.Button btnSinhVienTheoKhoa;
        private System.Windows.Forms.Button btnHocPhi;
        private System.Windows.Forms.Button btnGiangVien;
        private System.Windows.Forms.Button button1;
    }
}