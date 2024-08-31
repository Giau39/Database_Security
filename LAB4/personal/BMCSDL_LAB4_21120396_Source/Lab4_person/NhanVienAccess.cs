using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;


namespace Lab4_person
{
	
	class NhanVienAccess
	{
		ConnectSQL dc;
		SqlDataAdapter da;
		SqlCommand cmd;

		AES aes_obj;
		SHA1CryptoServiceProvider sh;
		public NhanVienAccess()
		{
			dc = new ConnectSQL();
			//32 bytes
			aes_obj = new AES("21120396211203962112039621120396");
			sh = new SHA1CryptoServiceProvider();
		}
		public DataTable getAllNhanVien()
		{
			string sql = "EXEC SP_SEL_ENCRYPT_NHANVIEN";
			SqlConnection con = dc.getConnect();
			da = new SqlDataAdapter(sql,con);
			con.Open();
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			//return dt;

			////decrypt luong
			DataTable dtClone = dt.Clone();
			dtClone.Columns["LUONG"].DataType = typeof(string);
			foreach (DataRow row in dt.Rows)
			{
				dtClone.ImportRow(row);
			}
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				DataRow row = dt.Rows[i];
				DataRow row2 = dtClone.Rows[i];

				byte[] luong = (byte[])row["LUONG"];
				row2["LUONG"] = aes_obj.Decrypt(luong);
			}

			return dtClone;
		}
		
		public bool InsertNhanVien (tblNhanVien nv)
		{
			string sql = "EXEC SP_INS_ENCRYPT_NHANVIEN @MANV ,@HOTEN , @EMAIL, @LUONG, @TENDN, @MATKHAU";
			SqlConnection con = dc.getConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value    = nv.MaNV;
				cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value  = nv.HoTen;
				cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value  = nv.Email;
				cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary).Value = aes_obj.Encrypt(nv.Luong)  ;
				cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value   = nv.TenDN;
				cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary).Value =sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(nv.MatKhau));
				cmd.ExecuteNonQuery();
				con.Close();

			}catch(Exception)
			{
				return false;
			}
			return true;
		}
		
		public bool DeleteNhanVien (string Manv)
		{
			string sql = "delete NHANVIEN where MANV= @manv";
			SqlConnection con = dc.getConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = Manv;
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		public bool UpdateNhanVien(tblNhanVien nv)
		{
			string sql = "update NHANVIEN set hoten=@hoten,email=@email,luong=@luong,tendn=@tendn, matkhau=@matkhau where manv = @manv";
			SqlConnection con = dc.getConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value    = nv.MaNV;
				cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value  = nv.HoTen;
				cmd.Parameters.Add("@email",SqlDbType.VarChar).Value    = nv.Email;
				cmd.Parameters.Add("@luong", SqlDbType.VarBinary).Value = aes_obj.Encrypt(nv.Luong);
				cmd.Parameters.Add("@tendn", SqlDbType.VarChar).Value   = nv.TenDN;
				cmd.Parameters.Add("@matkhau", SqlDbType.VarBinary).Value = sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(nv.MatKhau));
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		
	}
	
}
