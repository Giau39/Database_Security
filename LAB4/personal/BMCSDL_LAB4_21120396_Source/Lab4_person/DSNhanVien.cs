using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_person
{
	public partial class DSNhanVien : Form
	{
		NhanVienBLL NVBLL;
		public DSNhanVien()
		{
			InitializeComponent();
			NVBLL = new NhanVienBLL();
		}

		public void ShowAllNhanVien()
		{
			DataTable dt =NVBLL.getAllNhanVien();
			dt_GridView_tbl_nv.DataSource = dt;
			
		}
	
		

	
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
			ShowAllNhanVien();
		}

		

		private void button6_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public bool CheckData()
		{
			if(string.IsNullOrEmpty(txtMaNV.Text))
			{
				MessageBox.Show("Bạn chưa nhập mã nhân viên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				txtMaNV.Focus();
				return false;
			}
			if (string.IsNullOrEmpty(txtHoTen.Text))
			{
				MessageBox.Show("Bạn chưa nhập mã nhân viên","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
				txtHoTen.Focus();
				return false;
			}
			if (string.IsNullOrEmpty(txtEmail.Text))
			{
				MessageBox.Show("Bạn chưa nhập email","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtEmail.Focus();
				return false;
			}
			if(string.IsNullOrEmpty(txtLuong.Text))
			{
				MessageBox.Show("Bạn chưa nhập lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtLuong.Focus();
				return false;
			}	
			if(string.IsNullOrEmpty(txtTenDN.Text))
			{
				MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			if(string.IsNullOrEmpty (txtMatKhau.Text))
			{
				MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtMatKhau.Focus();
				return false;
			}	
			return true;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			
			if(CheckData())
			{
				tblNhanVien nv = new tblNhanVien();
				nv.MaNV =   txtMaNV.Text;
				nv.HoTen =  txtHoTen.Text;
				nv.Email = txtEmail.Text;
				nv.Luong = txtLuong.Text;
				nv.TenDN = txtTenDN.Text;
				nv.MatKhau = txtMatKhau.Text;
				if (MessageBox.Show("Bạn có muốn thêm nhân viên hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					if (NVBLL.InsertNhanVien(nv))
					{
						ShowAllNhanVien();
					}
					else
					{ 
						MessageBox.Show("Xảy ra lỗi khi thêm nhân viên");
					}
				}
				
			}	

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNV.Text))
			{
				MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaNV.Focus();
			}
			else if (MessageBox.Show("Bạn có muốn xoá hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{

				if (NVBLL.DeleteNhanVien(txtMaNV.Text))
				{
					ShowAllNhanVien();
				}	
				else
					MessageBox.Show("Đã xảy ra lỗi trog quá trình xoá dữ liệu.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (CheckData())
			{
				tblNhanVien nv= new tblNhanVien();
				nv.MaNV= txtMaNV.Text;
				nv.HoTen = txtHoTen.Text;
				nv.Email = txtEmail.Text;
				nv.Luong = txtLuong.Text;
				nv.TenDN	= txtTenDN.Text;
				nv.MatKhau	= txtMatKhau.Text;
				if (MessageBox.Show("Bạn có muốn cập nhật hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					if (NVBLL.UpdateNhanVien(nv))
					{
						ShowAllNhanVien();
					}	
						
				}
				else
				{
					MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

				}

			}

		}

		private void dt_GridView_tbl_nv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0 && index < dt_GridView_tbl_nv.Rows.Count - 1)
			{
				txtMaNV.Text = dt_GridView_tbl_nv.Rows[index].Cells["MANV"].Value.ToString();
				txtHoTen.Text = dt_GridView_tbl_nv.Rows[index].Cells["HOTEN"].Value.ToString();
				txtEmail.Text = dt_GridView_tbl_nv.Rows[index].Cells["EMAIL"].Value.ToString();
				txtEmail.Text = string.Empty;
				txtLuong.Text = string.Empty;
				txtMatKhau.Text = string.Empty;

			}
			else
			{
				txtMaNV.Text = String.Empty;
				txtHoTen.Text = String.Empty;
				txtEmail.Text = String.Empty;
				txtTenDN.Text = String.Empty;
				txtLuong.Text = String.Empty;
				txtMatKhau.Text = String.Empty;
			}

		}

		private void dt_GridView_tbl_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
