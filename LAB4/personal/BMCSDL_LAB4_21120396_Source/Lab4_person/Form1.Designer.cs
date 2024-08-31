namespace Lab4_person
{
	partial class Form1
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
			this.Login = new System.Windows.Forms.Panel();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.eye = new System.Windows.Forms.Button();
			this.eyelash = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Login.SuspendLayout();
			this.SuspendLayout();
			// 
			// Login
			// 
			this.Login.BackColor = System.Drawing.SystemColors.Info;
			this.Login.Controls.Add(this.txtUser);
			this.Login.Controls.Add(this.eye);
			this.Login.Controls.Add(this.eyelash);
			this.Login.Controls.Add(this.BtnExit);
			this.Login.Controls.Add(this.btnLogin);
			this.Login.Controls.Add(this.txtPass);
			this.Login.Controls.Add(this.label3);
			this.Login.Controls.Add(this.label2);
			this.Login.Controls.Add(this.label1);
			this.Login.Location = new System.Drawing.Point(0, 0);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(802, 449);
			this.Login.TabIndex = 0;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(251, 131);
			this.txtUser.Multiline = true;
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(340, 40);
			this.txtUser.TabIndex = 9;
			this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
			// 
			// eye
			// 
			this.eye.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.eye.Location = new System.Drawing.Point(537, 205);
			this.eye.Name = "eye";
			this.eye.Size = new System.Drawing.Size(54, 40);
			this.eye.TabIndex = 8;
			this.eye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.eye.UseVisualStyleBackColor = false;
			this.eye.Click += new System.EventHandler(this.eye_Click);
			// 
			// eyelash
			// 
			this.eyelash.Location = new System.Drawing.Point(537, 205);
			this.eyelash.Name = "eyelash";
			this.eyelash.Size = new System.Drawing.Size(54, 40);
			this.eyelash.TabIndex = 7;
			this.eyelash.UseVisualStyleBackColor = true;
			this.eyelash.Click += new System.EventHandler(this.eyelash_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Location = new System.Drawing.Point(483, 313);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(108, 55);
			this.BtnExit.TabIndex = 6;
			this.BtnExit.Text = "Thoát";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(251, 313);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(114, 55);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Đăng Nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(251, 205);
			this.txtPass.Multiline = true;
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(340, 40);
			this.txtPass.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(86, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật Khẩu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(71, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên đăng nhập";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(264, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đăng Nhập Tài Khoản";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Login);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Login.ResumeLayout(false);
			this.Login.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Login;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button eyelash;
		private System.Windows.Forms.Button eye;
		private System.Windows.Forms.TextBox txtUser;
	}
}

