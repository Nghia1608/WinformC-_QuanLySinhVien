
namespace DoAn
{
    partial class XemDiemTheoMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDiemTheoMon));
            this.cbbTenMon = new System.Windows.Forms.ComboBox();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.dgvXemDiem = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbMaHocKy = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLDiem = new DoAn.DataSetQLDiem();
            this.khoaTableAdapter = new DoAn.DataSetQLDiemTableAdapters.KhoaTableAdapter();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new DoAn.DataSetQLDiemTableAdapters.LopTableAdapter();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new DoAn.DataSetQLDiemTableAdapters.SinhVienTableAdapter();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTenMon
            // 
            this.cbbTenMon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenMon.FormattingEnabled = true;
            this.cbbTenMon.Location = new System.Drawing.Point(323, 135);
            this.cbbTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenMon.Name = "cbbTenMon";
            this.cbbTenMon.Size = new System.Drawing.Size(192, 33);
            this.cbbTenMon.TabIndex = 2;
            this.cbbTenMon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuayVe.FlatAppearance.BorderSize = 0;
            this.btnQuayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.White;
            this.btnQuayVe.Location = new System.Drawing.Point(674, 512);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(101, 28);
            this.btnQuayVe.TabIndex = 5;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // dgvXemDiem
            // 
            this.dgvXemDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXemDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvMSSV,
            this.dgvHo,
            this.dgvTen,
            this.dgvDiem,
            this.dgvMaKhoa,
            this.dgvMaLop});
            this.dgvXemDiem.GridColor = System.Drawing.Color.DarkGray;
            this.dgvXemDiem.Location = new System.Drawing.Point(11, 241);
            this.dgvXemDiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvXemDiem.Name = "dgvXemDiem";
            this.dgvXemDiem.RowHeadersWidth = 51;
            this.dgvXemDiem.RowTemplate.Height = 24;
            this.dgvXemDiem.Size = new System.Drawing.Size(1026, 250);
            this.dgvXemDiem.TabIndex = 4;
            this.dgvXemDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXemDiem_CellClick);
            // 
            // dgvSTT
            // 
            this.dgvSTT.HeaderText = "STT";
            this.dgvSTT.Name = "dgvSTT";
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.HeaderText = "MSSV";
            this.dgvMSSV.MinimumWidth = 6;
            this.dgvMSSV.Name = "dgvMSSV";
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
            this.dgvTen.Name = "dgvTen";
            // 
            // dgvDiem
            // 
            this.dgvDiem.HeaderText = "Điểm";
            this.dgvDiem.MinimumWidth = 6;
            this.dgvDiem.Name = "dgvDiem";
            // 
            // dgvMaKhoa
            // 
            this.dgvMaKhoa.HeaderText = "Mã khoa";
            this.dgvMaKhoa.MinimumWidth = 6;
            this.dgvMaKhoa.Name = "dgvMaKhoa";
            // 
            // dgvMaLop
            // 
            this.dgvMaLop.HeaderText = "Mã lớp";
            this.dgvMaLop.Name = "dgvMaLop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng";
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(536, 513);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 29);
            this.txtTong.TabIndex = 7;
            this.txtTong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã học kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên môn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(674, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Xem điểm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbMaHocKy
            // 
            this.cbbMaHocKy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHocKy.FormattingEnabled = true;
            this.cbbMaHocKy.Location = new System.Drawing.Point(323, 180);
            this.cbbMaHocKy.Name = "cbbMaHocKy";
            this.cbbMaHocKy.Size = new System.Drawing.Size(192, 33);
            this.cbbMaHocKy.TabIndex = 19;
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
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
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
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.dataSetQLDiem;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.DataSource = this.khoaBindingSource;
            this.cbbMaKhoa.DisplayMember = "MaKhoa";
            this.cbbMaKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(323, 46);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(192, 33);
            this.cbbMaKhoa.TabIndex = 27;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged_1);
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(323, 88);
            this.cbbMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(192, 33);
            this.cbbMaLop.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã Lớp";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(858, 180);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 37);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // XemDiemTheoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbMaHocKy);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvXemDiem);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.cbbTenMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "XemDiemTheoMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Điểm Theo Môn";
            this.Load += new System.EventHandler(this.XemDiemTheoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbTenMon;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.DataGridView dgvXemDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbMaHocKy;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DataSetQLDiem dataSetQLDiem;
        private DataSetQLDiemTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private DataSetQLDiemTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DataSetQLDiemTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}