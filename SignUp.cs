using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANEPROJE_DENEMELER
{
	public partial class SignUp : Form
	{

		public SignUp()
		{
			InitializeComponent();
		}

		KUTUPHANEEntities1 db=new KUTUPHANEEntities1();
		public bool UserLogin(string username, string password)
		{
			var user = (from item in db.TBLUSER
						where item.IsActive == true &&
						item.UserName == username &&
						item.UserPassword == password&&
						item.YetkiID==3
						select item).FirstOrDefault();
			if (user != null)
			{
				return true;
			}
			return false;
		}
		public bool AdminLogin(string username, string password)
		{

			var user = (from item in db.TBLUSER
						where item.IsActive == true &&
						item.UserName == username &&
						item.UserPassword == password &&
						item.YetkiID == 1
						select item).FirstOrDefault();
			if (user != null)
			{
				return true;
			}
			return false;
		}
		public bool ManagerLogin(string username, string password)
		{

			var user = (from item in db.TBLUSER
						where item.IsActive == true &&
						item.UserName == username &&
						item.UserPassword == password &&
						item.YetkiID == 2
						select item).FirstOrDefault();
			if (user != null)
			{
				return true;
			}
			return false;
		}

		private void btnLogin_Click_1(object sender, EventArgs e)
		{
			var username = txtBoxUser.Text.Trim();
			TumFormlar.Username = txtBoxUser.Text;
			var password = txtBoxPassword.Text.Trim();
			TumFormlar.Password = txtBoxPassword.Text;
			var errorMessage = "";
			var isError = false;
			if (string.IsNullOrEmpty(username))
			{
				errorMessage += "Kullanıcı Adını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(password))
			{
				errorMessage += "Şifreyi Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (isError)
			{
				MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (isError==false)
			{
				var UserloginState = UserLogin(username, password);
				var ManagerloginState = ManagerLogin(username, password);
				var AdminloginState = AdminLogin(username, password);
				try
				{
					if (UserloginState)
					{
						this.Hide();
						TumFormlar.FormCalis(3);

					}
					else if (ManagerloginState)
					{
						this.Hide();
						TumFormlar.FormCalis(4);
					}
					else if (AdminloginState)
					{
						this.Hide();
						TumFormlar.FormCalis(5);
					}
					else
					{
					}
				}
				catch (Exception hata)
				{
					TBLHATA ht = new TBLHATA();
					ht.Message = hata.ToString();
					ht.LastDate = Convert.ToDateTime(DateTime.Now.ToString());
					MessageBox.Show("Böyle bir Kullanıcı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}

		private void btnRegister_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			TumFormlar.FormCalis(2);
		}

		private void txtBoxUser_MouseClick(object sender, MouseEventArgs e)
		{
			txtBoxUser.Text = "";
		}

		private void txtBoxPassword_MouseClick(object sender, MouseEventArgs e)
		{
			txtBoxPassword.Text = "";
		}

		private void SignUp_Load(object sender, EventArgs e)
		{
			var Duyuru = (from item in db.TBLDUYURU
								  orderby item.LastDate descending
								  select item.Duyuru).FirstOrDefault();
			if (Duyuru!=null)
			{
				lblDuyuru.Text = Duyuru.ToString();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Dispose();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}


	}
}
