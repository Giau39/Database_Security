namespace Lab4_person
{
	partial class DSNhanVien
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
			this.dt_GridView_tbl_nv = new System.Windows.Forms.DataGridView();
			this.FormThaoTac = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnNoSave = new System.Windows.Forms.Button();
			this.btnExits = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtLuong = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtTenDN = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TENDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dt_GridView_tbl_nv)).BeginInit();
			this.FormThaoTac.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dt_GridView_tbl_nv
			// 
			this.dt_GridView_tbl_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dt_GridView_tbl_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.EMAIL,
            this.TENDN,
            this.LUONG,
            this.MATKHAU});
			this.dt_GridView_tbl_nv.Location = new System.Drawing.Point(29, 27);
			this.dt_GridView_tbl_nv.Name = "dt_GridView_tbl_nv";
			this.dt_GridView_tbl_nv.RowHeadersWidth = 62;
			this.dt_GridView_tbl_nv.RowTemplate.Height = 28;
			this.dt_GridView_tbl_nv.Size = new System.Drawing.Size(1190, 251);
			this.dt_GridView_tbl_nv.TabIndex = 4;
			this.dt_GridView_tbl_nv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_GridView_tbl_nv_CellClick);
			this.dt_GridView_tbl_nv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_GridView_tbl_nv_CellContentClick);
			// 
			// FormThaoTac
			// 
			this.FormThaoTac.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.FormThaoTac.Controls.Add(this.panel4);
			this.FormThaoTac.Controls.Add(this.flowLayoutPanel1);
			this.FormThaoTac.Controls.Add(this.panel2);
			this.FormThaoTac.Controls.Add(this.label1);
			this.FormThaoTac.Location = new System.Drawing.Point(0, -1);
			this.FormThaoTac.Name = "FormThaoTac";
			this.FormThaoTac.Size = new System.Drawing.Size(1371, 726);
			this.FormThaoTac.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.dt_GridView_tbl_nv);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Location = new System.Drawing.Point(61, 329);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1251, 372);
			this.panel4.TabIndex = 3;
			this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel6.Controls.Add(this.btnUpdate);
			this.panel6.Controls.Add(this.btnDelete);
			this.panel6.Controls.Add(this.btnAdd);
			this.panel6.Controls.Add(this.btnNoSave);
			this.panel6.Controls.Add(this.btnExits);
			this.panel6.Controls.Add(this.btnSave);
			this.panel6.Location = new System.Drawing.Point(29, 302);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1190, 54);
			this.panel6.TabIndex = 0;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(475, 10);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(91, 35);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(283, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(91, 35);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(109, 10);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(91, 35);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnNoSave
			// 
			this.btnNoSave.Location = new System.Drawing.Point(869, 10);
			this.btnNoSave.Name = "btnNoSave";
			this.btnNoSave.Size = new System.Drawing.Size(91, 35);
			this.btnNoSave.TabIndex = 4;
			this.btnNoSave.Text = "Không";
			this.btnNoSave.UseVisualStyleBackColor = true;
			// 
			// btnExits
			// 
			this.btnExits.Location = new System.Drawing.Point(1023, 10);
			this.btnExits.Name = "btnExits";
			this.btnExits.Size = new System.Drawing.Size(91, 35);
			this.btnExits.TabIndex = 5;
			this.btnExits.Text = "Thoát";
			this.btnExits.UseVisualStyleBackColor = true;
			this.btnExits.Click += new System.EventHandler(this.button6_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(699, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(91, 35);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Ghi/Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 310);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1299, 403);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Bisque;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(38, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1299, 220);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.txtMatKhau);
			this.panel3.Controls.Add(this.txtLuong);
			this.panel3.Controls.Add(this.txtHoTen);
			this.panel3.Controls.Add(this.txtTenDN);
			this.panel3.Controls.Add(this.txtEmail);
			this.panel3.Controls.Add(this.txtMaNV);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(23, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1246, 163);
			this.panel3.TabIndex = 0;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(789, 116);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(311, 26);
			this.txtMatKhau.TabIndex = 12;
			this.txtMatKhau.UseSystemPasswordChar = true;
			// 
			// txtLuong
			// 
			this.txtLuong.Location = new System.Drawing.Point(789, 78);
			this.txtLuong.Multiline = true;
			this.txtLuong.Name = "txtLuong";
			this.txtLuong.Size = new System.Drawing.Size(311, 26);
			this.txtLuong.TabIndex = 11;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(789, 36);
			this.txtHoTen.Multiline = true;
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(311, 26);
			this.txtHoTen.TabIndex = 10;
			// 
			// txtTenDN
			// 
			this.txtTenDN.Location = new System.Drawing.Point(253, 119);
			this.txtTenDN.Multiline = true;
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.Size = new System.Drawing.Size(311, 26);
			this.txtTenDN.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(253, 79);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(311, 26);
			this.txtEmail.TabIndex = 8;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(253, 38);
			this.txtMaNV.Multiline = true;
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(311, 26);
			this.txtMaNV.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(666, 119);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 23);
			this.label8.TabIndex = 6;
			this.label8.Text = "Mật khẩu";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(666, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 23);
			this.label7.TabIndex = 5;
			this.label7.Text = "Lương";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(666, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Họ Tên";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(79, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Tên đăng nhập";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(79, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "EMAIL";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label3.Location = new System.Drawing.Point(79, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "MÃ NV";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(49, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Thông tin nhân viên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(511, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(333, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH MỤC NHÂN VIÊN";
			// 
			// MANV
			// 
			this.MANV.DataPropertyName = "MANV";
			this.MANV.HeaderText = "Mã NV";
			this.MANV.MinimumWidth = 8;
			this.MANV.Name = "MANV";
			this.MANV.Width = 150;
			// 
			// HOTEN
			// 
			this.HOTEN.DataPropertyName = "HOTEN";
			this.HOTEN.HeaderText = "Họ Tên";
			this.HOTEN.MinimumWidth = 8;
			this.HOTEN.Name = "HOTEN";
			this.HOTEN.Width = 150;
			// 
			// EMAIL
			// 
			this.EMAIL.DataPropertyName = "EMAIL";
			this.EMAIL.HeaderText = "Email";
			this.EMAIL.MinimumWidth = 8;
			this.EMAIL.Name = "EMAIL";
			this.EMAIL.Width = 150;
			// 
			// TENDN
			// 
			this.TENDN.DataPropertyName = "TENDN";
			this.TENDN.HeaderText = "Tên ĐN";
			this.TENDN.MinimumWidth = 8;
			this.TENDN.Name = "TENDN";
			this.TENDN.Width = 150;
			// 
			// LUONG
			// 
			this.LUONG.DataPropertyName = "LUONG";
			this.LUONG.HeaderText = "LUONG";
			this.LUONG.MinimumWidth = 8;
			this.LUONG.Name = "LUONG";
			this.LUONG.Width = 150;
			// 
			// MATKHAU
			// 
			this.MATKHAU.DataPropertyName = "MATKHAU";
			this.MATKHAU.HeaderText = "Mật Khẩu";
			this.MATKHAU.MinimumWidth = 8;
			this.MATKHAU.Name = "MATKHAU";
			this.MATKHAU.Width = 150;
			// 
			// DSNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1371, 724);
			this.Controls.Add(this.FormThaoTac);
			this.Name = "DSNhanVien";
			this.Text = "DSNhanVien";
			((System.ComponentModel.ISupportInitialize)(this.dt_GridView_tbl_nv)).EndInit();
			this.FormThaoTac.ResumeLayout(false);
			this.FormThaoTac.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel FormThaoTac;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.TextBox txtLuong;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtTenDN;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnNoSave;
		private System.Windows.Forms.Button btnExits;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView dt_GridView_tbl_nv;
		private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
		private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
		private System.Windows.Forms.DataGridViewTextBoxColumn TENDN;
		private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
		private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
	}
}