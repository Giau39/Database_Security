using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_person
{
	class NhanVienBLL
	{
		NhanVienAccess accessNv;
		public NhanVienBLL()
		{
			accessNv = new NhanVienAccess();
		}
		public DataTable getAllNhanVien()
		{
			return accessNv.getAllNhanVien();
		}
		public bool InsertNhanVien( tblNhanVien nv)
		{
			return accessNv.InsertNhanVien(nv);
		}
		public bool UpdateNhanVien(tblNhanVien nv)
		{
			return accessNv.UpdateNhanVien(nv);
		}
		public bool DeleteNhanVien(string nv)
		{
			return accessNv.DeleteNhanVien(nv);
		}
	}
}
