using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUTUPHANEPROJE_DENEMELER
{
	class TumFormlar
	{
		public static string NesneUsername, NesnePassword;
		public static string Username { get => NesneUsername; set => NesneUsername = value; }
		public static string Password { get => NesnePassword; set => NesnePassword = value; }
		public static void FormCalis(int x)
		{
			if (x==1)
			{
				SignUp frm = new SignUp();
				frm.ShowDialog();

			}
			if (x==2)
			{
				Register frm2 = new Register();
				frm2.ShowDialog();
			}
			if (x==3)
			{
				User frm3 = new User();
				frm3.ShowDialog();
			}
			if (x==4)
			{
				Manager frm4 = new Manager();
				frm4.ShowDialog();
			}
			if (x==5)
			{
				Admin frm5 = new Admin();
				frm5.ShowDialog();

			}
			if (x==6)
			{
				UserRepair frm6 = new UserRepair();
				frm6.ShowDialog();
			}
		}
	}
}
