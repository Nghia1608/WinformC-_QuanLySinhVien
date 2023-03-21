namespace DoAn
{
    partial class BXH
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLDiem1 = new DoAn.DataSetQLDiem();
            this.dgvBXH = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataSetQLDiem1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new DoAn.DataSetQLDiemTableAdapters.KhoaTableAdapter();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new DoAn.DataSetQLDiemTableAdapters.LopTableAdapter();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(251, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Lớp";
            // 
            // cbbLop
            // 
            this.cbbLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(323, 111);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(186, 33);
            this.cbbLop.TabIndex = 36;
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(251, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DataSource = this.khoaBindingSource;
            this.cbbKhoa.DisplayMember = "MaKhoa";
            this.cbbKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(323, 54);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(186, 33);
            this.cbbKhoa.TabIndex = 31;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.dataSetQLDiem1;
            // 
            // dataSetQLDiem1
            // 
            this.dataSetQLDiem1.DataSetName = "DataSetQLDiem";
            this.dataSetQLDiem1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvBXH
            // 
            this.dgvBXH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBXH.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBXH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBXH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvMSSV,
            this.dgvMaLop,
            this.dgvMaKhoa,
            this.dgvDTB,
            this.dgvMaHocKy});
            this.dgvBXH.Location = new System.Drawing.Point(12, 222);
            this.dgvBXH.Name = "dgvBXH";
            this.dgvBXH.Size = new System.Drawing.Size(1024, 327);
            this.dgvBXH.TabIndex = 38;
            this.dgvBXH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBXH_CellClick);
            // 
            // dgvSTT
            // 
            this.dgvSTT.HeaderText = "STT";
            this.dgvSTT.Name = "dgvSTT";
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.HeaderText = "MSSV";
            this.dgvMSSV.Name = "dgvMSSV";
            // 
            // dgvMaLop
            // 
            this.dgvMaLop.HeaderText = "Mã lớp";
            this.dgvMaLop.Name = "dgvMaLop";
            // 
            // dgvMaKhoa
            // 
            this.dgvMaKhoa.HeaderText = "Mã khoa";
            this.dgvMaKhoa.Name = "dgvMaKhoa";
            // 
            // dgvDTB
            // 
            this.dgvDTB.HeaderText = "Điểm trung bình";
            this.dgvDTB.Name = "dgvDTB";
            // 
            // dgvMaHocKy
            // 
            this.dgvMaHocKy.HeaderText = "Mã học kỳ";
            this.dgvMaHocKy.Name = "dgvMaHocKy";
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(323, 164);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(186, 33);
            this.cbbHocKi.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(251, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Học kì";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(547, 154);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(129, 33);
            this.btnTimKiem.TabIndex = 39;
            this.btnTimKiem.Text = "Loc ket qua";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataSetQLDiem1BindingSource
            // 
            this.dataSetQLDiem1BindingSource.DataSource = this.dataSetQLDiem1;
            this.dataSetQLDiem1BindingSource.Position = 0;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.dataSetQLDiem1;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(703, 154);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 33);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources._249675490_1285046221948820_2844251225914574091_n;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvBXH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbKhoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BXH";
            this.Text = "BXH";
            this.Load += new System.EventHandler(this.BXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLDiem1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private DataSetQLDiem dataSetQLDiem1;
        private System.Windows.Forms.DataGridView dgvBXH;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.BindingSource dataSetQLDiem1BindingSource;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DataSetQLDiemTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private DataSetQLDiemTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaHocKy;
        private System.Windows.Forms.Button btnReset;
    }
}