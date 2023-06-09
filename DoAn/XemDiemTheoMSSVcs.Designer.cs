﻿
namespace DoAn
{
    partial class XemDiemTheoMSSVcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDiemTheoMSSVcs));
            this.cbbMSSV = new System.Windows.Forms.ComboBox();
            this.dgvXemDiem = new System.Windows.Forms.DataGridView();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLDiem = new DoAn.DataSetQLDiem();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khoaTableAdapter = new DoAn.DataSetQLDiemTableAdapters.KhoaTableAdapter();
            this.dataSetQLDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new DoAn.DataSetQLDiemTableAdapters.LopTableAdapter();
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new DoAn.DataSetQLDiemTableAdapters.SinhVienTableAdapter();
            this.cbbMaHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMSSV
            // 
            this.cbbMSSV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMSSV.FormattingEnabled = true;
            this.cbbMSSV.Location = new System.Drawing.Point(309, 107);
            this.cbbMSSV.Name = "cbbMSSV";
            this.cbbMSSV.Size = new System.Drawing.Size(226, 33);
            this.cbbMSSV.TabIndex = 1;
            // 
            // dgvXemDiem
            // 
            this.dgvXemDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXemDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMSSV,
            this.dgvTenMon,
            this.dgvDiem,
            this.dgvDiemChu,
            this.dgvHocKy});
            this.dgvXemDiem.Location = new System.Drawing.Point(12, 255);
            this.dgvXemDiem.Name = "dgvXemDiem";
            this.dgvXemDiem.RowHeadersWidth = 51;
            this.dgvXemDiem.RowTemplate.Height = 24;
            this.dgvXemDiem.Size = new System.Drawing.Size(1024, 242);
            this.dgvXemDiem.TabIndex = 4;
            this.dgvXemDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXemDiem_CellClick);
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.HeaderText = "MSSV";
            this.dgvMSSV.Name = "dgvMSSV";
            // 
            // dgvTenMon
            // 
            this.dgvTenMon.HeaderText = "Tên môn học";
            this.dgvTenMon.MinimumWidth = 6;
            this.dgvTenMon.Name = "dgvTenMon";
            // 
            // dgvDiem
            // 
            this.dgvDiem.HeaderText = "Điểm";
            this.dgvDiem.MinimumWidth = 6;
            this.dgvDiem.Name = "dgvDiem";
            // 
            // dgvDiemChu
            // 
            this.dgvDiemChu.HeaderText = "Điểm chữ";
            this.dgvDiemChu.MinimumWidth = 6;
            this.dgvDiemChu.Name = "dgvDiemChu";
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.HeaderText = "Mã học kỳ";
            this.dgvHocKy.Name = "dgvHocKy";
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXemDiem.FlatAppearance.BorderSize = 0;
            this.btnXemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.ForeColor = System.Drawing.Color.White;
            this.btnXemDiem.Location = new System.Drawing.Point(475, 203);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(132, 44);
            this.btnXemDiem.TabIndex = 5;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = false;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuayVe.FlatAppearance.BorderSize = 0;
            this.btnQuayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.White;
            this.btnQuayVe.Location = new System.Drawing.Point(882, 107);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(132, 44);
            this.btnQuayVe.TabIndex = 5;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // txtDTB
            // 
            this.txtDTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTB.Location = new System.Drawing.Point(703, 117);
            this.txtDTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(148, 33);
            this.txtDTB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Điểm trung bình";
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.DataSource = this.khoaBindingSource;
            this.cbbMaKhoa.DisplayMember = "MaKhoa";
            this.cbbMaKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(309, 18);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(226, 33);
            this.cbbMaKhoa.TabIndex = 17;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged);
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
            // cbbMaLop
            // 
            this.cbbMaLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(309, 63);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(226, 33);
            this.cbbMaLop.TabIndex = 18;
            this.cbbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbbMaLop_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "MSSV";
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetQLDiemBindingSource
            // 
            this.dataSetQLDiemBindingSource.DataSource = this.dataSetQLDiem;
            this.dataSetQLDiemBindingSource.Position = 0;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.dataSetQLDiemBindingSource;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "Lop";
            this.lopBindingSource1.DataSource = this.dataSetQLDiem;
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
            // cbbMaHocKy
            // 
            this.cbbMaHocKy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHocKy.FormattingEnabled = true;
            this.cbbMaHocKy.Location = new System.Drawing.Point(309, 154);
            this.cbbMaHocKy.Name = "cbbMaHocKy";
            this.cbbMaHocKy.Size = new System.Drawing.Size(226, 33);
            this.cbbMaHocKy.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã học kỳ";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(643, 210);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 37);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // XemDiemTheoMSSVcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.dgvXemDiem);
            this.Controls.Add(this.cbbMaHocKy);
            this.Controls.Add(this.cbbMSSV);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XemDiemTheoMSSVcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm theo MSSV";
            this.Load += new System.EventHandler(this.XemDiemTheoMSSVcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbMSSV;
        private System.Windows.Forms.DataGridView dgvXemDiem;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DataSetQLDiem dataSetQLDiem;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DataSetQLDiemTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource dataSetQLDiemBindingSource;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private DataSetQLDiemTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DataSetQLDiemTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.ComboBox cbbMaHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiemChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHocKy;
        private System.Windows.Forms.Button btnReset;
    }
}