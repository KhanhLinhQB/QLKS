namespace QuanLyKhachSan.GUI
{
    partial class AddNV_GUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvnv = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtgioitinh = new DevExpress.XtraEditors.TextEdit();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtdc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtsdt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtcmnd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txthoten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtmanv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgioitinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvnv);
            this.groupControl3.Location = new System.Drawing.Point(21, 336);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1156, 370);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Bảng danh sách";
            // 
            // dgvnv
            // 
            this.dgvnv.AllowUserToAddRows = false;
            this.dgvnv.AllowUserToDeleteRows = false;
            this.dgvnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.cmnd,
            this.email,
            this.diachi});
            this.dgvnv.Location = new System.Drawing.Point(18, 34);
            this.dgvnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvnv.Name = "dgvnv";
            this.dgvnv.ReadOnly = true;
            this.dgvnv.RowHeadersWidth = 62;
            this.dgvnv.Size = new System.Drawing.Size(1118, 314);
            this.dgvnv.TabIndex = 0;
            this.dgvnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnxoa);
            this.groupControl2.Controls.Add(this.btnluu);
            this.groupControl2.Controls.Add(this.btnsua);
            this.groupControl2.Controls.Add(this.btnthem);
            this.groupControl2.Location = new System.Drawing.Point(963, 9);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(214, 319);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tác vụ";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(39, 243);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(136, 44);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(39, 175);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(136, 44);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(39, 111);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(136, 44);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(39, 45);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(136, 44);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtgioitinh);
            this.groupControl1.Controls.Add(this.dtpngaysinh);
            this.groupControl1.Controls.Add(this.cbChucvu);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtdc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtemail);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtsdt);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtcmnd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txthoten);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtmanv);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(21, 9);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(933, 319);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin nhân viên";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(507, 134);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 21);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Giới tính:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(42, 136);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 21);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Ngày sinh:";
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Enabled = false;
            this.txtgioitinh.Location = new System.Drawing.Point(596, 129);
            this.txtgioitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgioitinh.Properties.Appearance.Options.UseFont = true;
            this.txtgioitinh.Size = new System.Drawing.Size(288, 28);
            this.txtgioitinh.TabIndex = 4;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Enabled = false;
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(132, 129);
            this.dtpngaysinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(322, 27);
            this.dtpngaysinh.TabIndex = 3;
            this.dtpngaysinh.Value = new System.DateTime(2014, 12, 17, 17, 39, 22, 0);
            // 
            // cbChucvu
            // 
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Location = new System.Drawing.Point(596, 45);
            this.cbChucvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(286, 27);
            this.cbChucvu.TabIndex = 0;
            this.cbChucvu.SelectedIndexChanged += new System.EventHandler(this.cbChucvu_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(507, 53);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 21);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Chức vụ:";
            // 
            // txtdc
            // 
            this.txtdc.Enabled = false;
            this.txtdc.Location = new System.Drawing.Point(132, 257);
            this.txtdc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdc.Name = "txtdc";
            this.txtdc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdc.Properties.Appearance.Options.UseFont = true;
            this.txtdc.Size = new System.Drawing.Size(752, 28);
            this.txtdc.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(42, 265);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 21);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Địa chỉ:";
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(132, 215);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Properties.Appearance.Options.UseFont = true;
            this.txtemail.Size = new System.Drawing.Size(752, 28);
            this.txtemail.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(42, 222);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 21);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Email:";
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(132, 172);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Properties.Appearance.Options.UseFont = true;
            this.txtsdt.Size = new System.Drawing.Size(324, 28);
            this.txtsdt.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(42, 180);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 21);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "SDT:";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Enabled = false;
            this.txtcmnd.Location = new System.Drawing.Point(596, 172);
            this.txtcmnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmnd.Properties.Appearance.Options.UseFont = true;
            this.txtcmnd.Size = new System.Drawing.Size(288, 28);
            this.txtcmnd.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(507, 180);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "CMND:";
            // 
            // txthoten
            // 
            this.txthoten.Enabled = false;
            this.txthoten.Location = new System.Drawing.Point(132, 88);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Properties.Appearance.Options.UseFont = true;
            this.txthoten.Size = new System.Drawing.Size(752, 28);
            this.txthoten.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 95);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Họ tên:";
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(132, 45);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Properties.Appearance.Options.UseFont = true;
            this.txtmanv.Size = new System.Drawing.Size(324, 28);
            this.txtmanv.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 53);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã NV:";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "IdEmployee";
            this.manv.HeaderText = "Mã NV";
            this.manv.MinimumWidth = 8;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 62;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "NameEmployee";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 101;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "DateOfBirth";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 8;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 79;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "GenderEmployee";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 8;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 70;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "PhoneNumber";
            this.sdt.HeaderText = "Số ĐT";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 80;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "IdCardEmployee";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.MinimumWidth = 8;
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            this.cmnd.Width = 80;
            // 
            // email
            // 
            this.email.DataPropertyName = "EmailEmployee";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "AddressEmployee";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 8;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 130;
            // 
            // AddNV_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNV_GUI";
            this.Size = new System.Drawing.Size(1196, 757);
            this.Load += new System.EventHandler(this.AddNV_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgioitinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvnv;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtdc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtsdt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtcmnd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txthoten;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtmanv;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbChucvu;
        private DevExpress.XtraEditors.TextEdit txtgioitinh;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}
