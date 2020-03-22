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
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
		}

		KUTUPHANEEntities1 db = new KUTUPHANEEntities1();

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnRegister_Click_1(object sender, EventArgs e)
		{
			var username = txtBoxUsername.Text;
			var password = txtBoxPassword.Text;
			var name = txtBoxName.Text;
			var surname = txtBoxSurname.Text;
			var tc = txtBoxTC.Text;
			var repassword = txtBoxRePassword.Text;
			var errorMessage = "";
			var isError = false;
			var TC_KONTROL= (from item in db.TBLUSER
							 where item.TC == txtBoxTC.Text
							 select item).FirstOrDefault();
			if (TC_KONTROL!=null)
			{
				errorMessage += "Bu TC İle Kayıtlı Kullanıcı Var Kendi TC'nizi Giriniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(username))
			{
				errorMessage += "Kullanıcı Adını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (txtBoxRePassword.Text != txtBoxPassword.Text)
			{
				errorMessage += "Parola Tekrarı Uyumsuz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(password))
			{
				errorMessage += "Şifreyi Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(repassword))
			{
				errorMessage += "Şifrenin Tekrarını Girmedin!\r\n";
				isError = true;
			}
			if (txtBoxRePassword.Text != txtBoxPassword.Text)
			{
				errorMessage += "Şifre Tekrarı Uyuşmuyor!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(name))
			{
				errorMessage += "İsim Kısmını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(surname))
			{
				errorMessage += "Soyadını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(tc))
			{
				errorMessage += "TC Kimlik Nuamrasını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			else if (tc.Count() < 11 || tc.Count() > 11)
			{
				errorMessage += "TC Kimlik Nuamrası 11 Karakter Olmalı!\r\n";
				isError = true;
			}
			if (isError)
			{
				MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (isError == false)
			{
				try
				{
					KUTUPHANEEntities1 db = new KUTUPHANEEntities1();
					TBLUSER usr = new TBLUSER();
					usr.Name = name;
					usr.Surname = surname;
					usr.UserName = username;
					usr.UserPassword = password;
					usr.TC = tc;
					usr.YetkiID = 3;
					usr.IsActive = true;
					db.TBLUSER.Add(usr);
					db.SaveChanges();
					MessageBox.Show("Kayıt Alındı");
					this.Hide();
					TumFormlar.FormCalis(1);
				}
				catch (Exception hata)
				{
					TBLHATA ht = new TBLHATA();
					ht.Message = hata.ToString();
					ht.LastDate = Convert.ToDateTime(DateTime.Now.ToString());
					MessageBox.Show("Kayıt Alınamadı !");
				}

			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Dispose();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			TumFormlar.FormCalis(1);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void txtBoxName_Click(object sender, EventArgs e)
		{
			txtBoxName.Text = "";
		}

		private void txtBoxSurname_Click(object sender, EventArgs e)
		{
			txtBoxSurname.Text = "";
		}

		private void txtBoxUsername_Click(object sender, EventArgs e)
		{
			txtBoxUsername.Text = "";
		}

		private void txtBoxPassword_Click(object sender, EventArgs e)
		{
			txtBoxPassword.Text = "";
		}

		private void txtBoxRePassword_Click(object sender, EventArgs e)
		{
			txtBoxRePassword.Text = "";
		}

		private void txtBoxTC_Click(object sender, EventArgs e)
		{
			txtBoxTC.Text = "";
		}
	}
}
