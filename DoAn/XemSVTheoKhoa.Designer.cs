
namespace DoAn
{
    partial class ReportSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSV));
            this.SinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnXem = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SinhVienBindingSource
            // 
            this.SinhVienBindingSource.DataSource = typeof(DoAn.Model.SinhVien);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(432, 55);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(293, 41);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "Xem thông tin sinh viên theo khoa";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DatasetSVKhoa";
            reportDataSource1.Value = this.SinhVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn.Report.ReportSVKhoa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(128, 116);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(879, 476);
            this.reportViewer1.TabIndex = 1;
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(432, 15);
            this.cbbMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(195, 24);
            this.cbbMaLop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khoa";
            // 
            // ReportSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1133, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnXem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportSV";
            this.Text = "Xem Thông Tin Sinh Viên Theo Khoa";
            this.Load += new System.EventHandler(this.ReportSV_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource SinhVienBindingSource;
    }
}