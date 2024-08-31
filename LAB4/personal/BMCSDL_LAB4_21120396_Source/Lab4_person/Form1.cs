using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_person
{
	public partial class Form1 : Form
	{
		SHA1CryptoServiceProvider sh;
		MD5CryptoServiceProvider md5;
		public Form1()
		{
			InitializeComponent();
			sh = new SHA1CryptoServiceProvider();
			md5 = new MD5CryptoServiceProvider();
		}



		private void BtnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void eyelash_Click(object sender, EventArgs e)
		{
			if (txtPass.PasswordChar == '\0')
			{
				eye.BringToFront();
				txtPass.UseSystemPasswordChar = true;
			}
		}

		private void eye_Click(object sender, EventArgs e)
		{

			if (txtPass.UseSystemPasswordChar)
			{
				eyelash.BringToFront();
				txtPass.PasswordChar = '\0';
				txtPass.UseSystemPasswordChar = false;
			}

		}
		
		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			ConnectSQL dc = new ConnectSQL();
			
			try
			{
				SqlConnection con = dc.getConnect();
				string tk = txtUser.Text;
				string mk = txtPass.Text;
				byte[] sh_mk = sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(mk));
				string sh_mk_string = "0x" + BitConverter.ToString(sh_mk).Replace("-", "");

				byte[] md_mk = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(mk));
				string md_mk_string = "0x" + BitConverter.ToString(md_mk).Replace("-", "");
				
				string sql_nv = "select * from NHANVIEN where TENDN= N'" + tk + "' and MATKHAU = " + sh_mk_string + ";";
				string sql_sv = "select * from SINHVIEN where TENDN=N'" + tk + "' and MATKHAU=" + md_mk_string + ";";
				con.Open();
				Console.WriteLine($"tk: {tk}");
				Console.WriteLine($"md_mk_string: {md_mk_string}");

				SqlCommand cmd = new SqlCommand(sql_nv,con);
				SqlDataReader data = cmd.ExecuteReader();
				if (data.Read() == true)
				{
					con.Close();
					this.Hide();
					DSNhanVien dsnv = new DSNhanVien();
					dsnv.ShowDialog();
				}
				else
				{
				
					cmd = new SqlCommand(sql_sv, con);
					SqlDataReader dta = cmd.ExecuteReader();
					if (dta.Read() == true)
					{
						con.Close();

						DSNhanVien dsnv = new DSNhanVien();
						dsnv.ShowDialog();
					}
					else
					{
						
						MessageBox.Show("Ten dang nhap va mat khau khong hop le!");
					}

				}

			} 
			catch (Exception ) {
				MessageBox.Show("Lỗi kết nối ahihi");

			}
		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{

		}
	}	
}

