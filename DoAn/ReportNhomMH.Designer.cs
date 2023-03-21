
namespace DoAn
{
    partial class ReportNhomMH
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
            this.cbbMaNhom = new System.Windows.Forms.ComboBox();
            this.cbbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // cbbMaNhom
            // 
            this.cbbMaNhom.DisplayMember = "MaKhoa";
            this.cbbMaNhom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaNhom.FormattingEnabled = true;
            this.cbbMaNhom.Location = new System.Drawing.Point(489, 71);
            this.cbbMaNhom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaNhom.Name = "cbbMaNhom";
            this.cbbMaNhom.Size = new System.Drawing.Size(129, 33);
            this.cbbMaNhom.TabIndex = 22;
            // 
            // cbbMaMonHoc
            // 
            this.cbbMaMonHoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaMonHoc.FormattingEnabled = true;
            this.cbbMaMonHoc.Location = new System.Drawing.Point(489, 116);
            this.cbbMaMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaMonHoc.Name = "cbbMaMonHoc";
            this.cbbMaMonHoc.Size = new System.Drawing.Size(129, 33);
            this.cbbMaMonHoc.TabIndex = 23;
            this.cbbMaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMaMonHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã Nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Môn Học";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(669, 115);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(129, 30);
            this.btnLoc.TabIndex = 32;
            this.btnLoc.Text = "Lọc kết quả";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(2, 176);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1059, 413);
            this.reportViewer1.TabIndex = 33;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReportNhomMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbbMaNhom);
            this.Controls.Add(this.cbbMaMonHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportNhomMH";
            this.Text = "ReportNhomMH";
            this.Load += new System.EventHandler(this.ReportNhomMH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaNhom;
        private System.Windows.Forms.ComboBox cbbMaMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoc;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}