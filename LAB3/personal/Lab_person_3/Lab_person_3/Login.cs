using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_person_3
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

	
		private void Login_btn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	
	}
}
