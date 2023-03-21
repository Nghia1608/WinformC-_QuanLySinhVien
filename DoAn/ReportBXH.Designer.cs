
namespace DoAn
{
    partial class ReportBXH
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLDiem = new DoAn.DataSetQLDiem();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MonHoc1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new DoAn.DataSetQLDiemTableAdapters.KhoaTableAdapter();
            this.lopTableAdapter = new DoAn.DataSetQLDiemTableAdapters.LopTableAdapter();
            this.sinhVienTableAdapter = new DoAn.DataSetQLDiemTableAdapters.SinhVienTableAdapter();
            this.DiemTableAdapter = new DoAn.DataSetQLDiemTableAdapters.DiemTableAdapter();
            this.MonHoc1TableAdapter = new DoAn.DataSetQLDiemTableAdapters.MonHoc1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHoc1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.dataSetQLDiem;
            // 
            // dataSetQLDiem
            // 
            this.dataSetQLDiem.DataSetName = "DataSetQLDiem";
            this.dataSetQLDiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.dataSetQLDiem;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.dataSetQLDiem;
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.DataSource = this.khoaBindingSource;
            this.cbbMaKhoa.DisplayMember = "MaKhoa";
            this.cbbMaKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(506, 36);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(173, 33);
            this.cbbMaKhoa.TabIndex = 21;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged);
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(506, 90);
            this.cbbMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(173, 33);
            this.cbbMaLop.TabIndex = 22;
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(506, 144);
            this.cbbHocKi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(173, 33);
            this.cbbHocKi.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã học kì";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã Lớp";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(718, 181);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(129, 30);
            this.btnLoc.TabIndex = 31;
            this.btnLoc.Text = "Lọc kết quả";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetDiemSV";
            reportDataSource1.Value = this.diemBindingSource;
            reportDataSource2.Name = "DataSetSV";
            reportDataSource2.Value = this.sinhVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn.ReportBXH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 232);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1040, 356);
            this.reportViewer1.TabIndex = 32;
            // 
            // MonHoc1BindingSource
            // 
            this.MonHoc1BindingSource.DataMember = "MonHoc1";
            this.MonHoc1BindingSource.DataSource = this.dataSetQLDiem;
            // 
            // StudentReportBindingSource
            // 
            this.StudentReportBindingSource.DataSource = typeof(DoAn.StudentReport);
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // DiemTableAdapter
            // 
            this.DiemTableAdapter.ClearBeforeFill = true;
            // 
            // MonHoc1TableAdapter
            // 
            this.MonHoc1TableAdapter.ClearBeforeFill = true;
            // 
            // ReportBXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources._249675490_1285046221948820_2844251225914574091_n;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportBXH";
            this.Text = "ReportBXH";
            this.Load += new System.EventHandler(this.ReportBXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHoc1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoc;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private System.Windows.Forms.BindingSource MonHoc1BindingSource;
        private DataSetQLDiem dataSetQLDiem;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private System.Windows.Forms.BindingSource StudentReportBindingSource;
        private DataSetQLDiemTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private DataSetQLDiemTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DataSetQLDiemTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private DataSetQLDiemTableAdapters.DiemTableAdapter DiemTableAdapter;
        private DataSetQLDiemTableAdapters.MonHoc1TableAdapter MonHoc1TableAdapter;
    }
}